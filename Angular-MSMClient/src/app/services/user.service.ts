import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Rx';
import { BehaviorSubject } from 'rxjs/Rx';
import { Router } from '@angular/router';

import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions';

@Injectable()
export class UserService extends BaseService {

    // Observable navItem source
    private _authNavStatusSource = new BehaviorSubject<boolean>(false);

    // Observable navItem stream
    authNavStatus$ = this._authNavStatusSource.asObservable();

    private loggedIn = false;

    constructor(http: HttpClient, progressAct: ProgressActions, private router: Router) {
        super(http, progressAct);
        this.loggedIn = !!sessionStorage.getItem('auth_token');
        // ?? not sure if this the best way to broadcast the status but seems to resolve issue on page refresh where auth status is lost in
        // header component resulting in authed user nav links disappearing despite the fact user is still logged in
        this._authNavStatusSource.next(this.loggedIn);
    }

    get authToken() {
        return sessionStorage.getItem('auth_token');
    }

    get isLoggedIn() {
        return this.loggedIn;
    }

    login(userName, password): Promise<any> {
        return this
            .post(factory.getLoginUrl(), JSON.stringify({ userName, password }), factory.createHeader())
            .then(res => {
                return this.ExtractResponseResult(res);
            })
            .catch(this.handleError);
    }

    refreshToken() {
        console.log("Request new token begin");
        let token = sessionStorage.getItem('token_jti');

        return this
            .post(factory.getRefreshTokenUrl(), JSON.stringify({ token }), factory.createHeader())
            .then(res => {
                console.log("New token generated sucessfully");
                this.logout();
                return this.ExtractResponseResult(res);
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
        let token = sessionStorage.getItem('token_jti');
        return this
            .post(factory.getlogoutUrl(), JSON.stringify({ token }), factory.createHeader())
            .then(res => {
                console.log("Remove token sucessfully");
            })
            .catch((error) => {
                console.log("Remove token failed due to: " + error);
            });
    }

    logoutUser() {
        // Remove the auth_token out of the session storage, then route to the login page
        this.logout();
        this.router.navigate(['/pages/login']);
    }

    ExtractResponseResult(res) {
        sessionStorage.setItem('auth_token', res.auth_token);
        sessionStorage.setItem('token_jti', res.jti);
        this.loggedIn = true;
        this._authNavStatusSource.next(true);
        return res.jti;
    }
}

