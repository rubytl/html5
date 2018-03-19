import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

import { Observable } from 'rxjs/Rx';
import { BehaviorSubject } from 'rxjs/Rx';

// Add the RxJS Observable operators we need in this app.
// import 'rxjs-operators';

import { environment } from '../../environments/environment';
import { BaseService } from "./base.service";
import { UserRegistration } from '../models';

const API_URL = environment.msmClientAPIUrl;

@Injectable()

export class UserService extends BaseService {

    // Observable navItem source
    private _authNavStatusSource = new BehaviorSubject<boolean>(false);

    // Observable navItem stream
    authNavStatus$ = this._authNavStatusSource.asObservable();

    private loggedIn = false;

    constructor(private http: Http) {
        super();
        this.loggedIn = !!sessionStorage.getItem('auth_token');
        // ?? not sure if this the best way to broadcast the status but seems to resolve issue on page refresh where auth status is lost in
        // header component resulting in authed user nav links disappearing despite the fact user is still logged in
        this._authNavStatusSource.next(this.loggedIn);
    }

    register(email: string, password: string, firstName: string, lastName: string, location: string): Observable<UserRegistration> {
        let body = JSON.stringify({ email, password, firstName, lastName, location });
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });

        return this.http.post(API_URL + "/accounts", body, options)
            .map(res => true)
            .catch(this.handleError);
    }

    login(userName, password) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        return this.http
            .post(API_URL + '/auth',
            JSON.stringify({ userName, password }), { headers }
            )
            .map(res => res.json())
            .map(res => {
                sessionStorage.setItem('auth_token', res.auth_token);
                this.loggedIn = true;
                this._authNavStatusSource.next(true);
                return true;
            })
            .catch(this.handleError);
    }

    logout() {
        
        sessionStorage.removeItem('auth_token');
        this.loggedIn = false;
        this._authNavStatusSource.next(false);
    }

    isLoggedIn() {
        return this.loggedIn;
    }
}

