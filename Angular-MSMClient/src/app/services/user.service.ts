import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Rx';
import { BehaviorSubject } from 'rxjs/Rx';
import { Router } from '@angular/router';

import { BaseService } from "./base.service";
import { factory } from '../helpers';

@Injectable()
export class UserService extends BaseService {

    // Observable navItem source
    private _authNavStatusSource = new BehaviorSubject<boolean>(false);
    isRefreshingToken: boolean = false;

    // Observable navItem stream
    authNavStatus$ = this._authNavStatusSource.asObservable();

    private loggedIn = false;
    private currentToken: any;

    constructor(private http: HttpClient, private router: Router) {
        super();
        this.loggedIn = !!sessionStorage.getItem('auth_token');
        // ?? not sure if this the best way to broadcast the status but seems to resolve issue on page refresh where auth status is lost in
        // header component resulting in authed user nav links disappearing despite the fact user is still logged in
        this._authNavStatusSource.next(this.loggedIn);
    }

    get authToken() {
        return this.currentToken.auth_token;
    }

    get isLoggedIn() {
        return this.loggedIn;
    }

    login(userName, password): Promise<any> {
        return this.http
            .post(factory.getLoginUrl(), JSON.stringify({ userName, password }), { headers: factory.createHeader() })
            .toPromise()
            .then(res => {
                return this.ExtractResponseResult(res);
            })
            .catch(this.handleError);
    }

    refreshToken() {
        console.log("Request new token begin");
        let token = this.currentToken.jti;

        return this.http
            .post(factory.getRefreshTokenUrl(), JSON.stringify({ token }), { headers: factory.createHeader() })
            .toPromise()
            .then(res => {
                console.log("New token generated sucessfully");
                this.logout();
                this.ExtractResponseResult(res);
                return this.currentToken.auth_token;
            })
            .catch((error) => {
                console.log("Request new token failed due to: " + error);
                this.logoutUser();
            });
    }


    logout() {
        sessionStorage.removeItem('auth_token');
        this.loggedIn = false;
        this._authNavStatusSource.next(false);
    }

    logoutUser() {
        // Remove the auth_token out of the session storage, then route to the login page
        this.logout();
        this.router.navigate(['/pages/login']);
    }

    ExtractResponseResult(res) {
        sessionStorage.setItem('auth_token', res.auth_token);
        this.currentToken = res;
        this.loggedIn = true;
        this._authNavStatusSource.next(true);
    }
}

