import { Injectable } from "@angular/core";
import { HttpInterceptor, HttpRequest, HttpHandler, HttpSentEvent, HttpHeaderResponse, HttpProgressEvent, HttpResponse, HttpUserEvent, HttpErrorResponse, HttpEvent } from "@angular/common/http";
import { Observable } from "rxjs/Observable";
import { BehaviorSubject } from "rxjs/BehaviorSubject";
import { Router } from '@angular/router';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/switchMap';
import 'rxjs/add/operator/finally';
import 'rxjs/add/operator/filter';
import 'rxjs/add/operator/take';
import { fromPromise } from 'rxjs/observable/fromPromise';

import { UserService } from './user.service';

@Injectable()
export class RequestInterceptorService implements HttpInterceptor {
    isRefreshingToken: boolean = false;
    tokenSubject: BehaviorSubject<string> = new BehaviorSubject<string>(null);

    constructor(private userService: UserService) { }

    addToken(req: HttpRequest<any>, token: string): HttpRequest<any> {
        return req.clone({ setHeaders: { Authorization: 'Bearer ' + token } });
    }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return Observable.fromPromise(this.handleAccess(req, next));
    }

    async handleAccess(req: HttpRequest<any>, next: HttpHandler): Promise<HttpEvent<any>> {
        return next.handle(req)
            .toPromise()
            .catch(error => {
                if (error instanceof HttpErrorResponse) {
                    switch ((<HttpErrorResponse>error).status) {
                        case 401:
                            return this.handle401Error(req, next);
                        default:
                            return Promise.reject(error);
                    }
                } else {
                    return Promise.reject(error);
                }
            });
    }

    async handle401Error(req: HttpRequest<any>, next: HttpHandler): Promise<any> {
        if (!this.isRefreshingToken) {
            this.isRefreshingToken = true;

            // Reset here so that the following requests wait until the token
            // comes back from the refreshToken call.
            this.tokenSubject.next(null);

            try {
                this.userService.refreshToken()
                    .then((newToken: string) => {
                        if (newToken) {
                            this.tokenSubject.next(newToken);
                            return next.handle(this.addToken(req, newToken));
                        }
                        else {
                            // If we don't get a new token, we are in trouble so logout.
                            this.userService.logout();
                        }
                    });
            }
            catch (error) {
                // Error happened, we are in trouble so logout
                console.log("Request new token failed due to: " + error);
                this.userService.logout();
            }
            finally {
                this.isRefreshingToken = false;
            };
        } else {
            return this.tokenSubject
                .filter(token => token != null)
                .take(1)
                .switchMap(token => {
                    return next.handle(this.addToken(req, token));
                });
        }
    }
}