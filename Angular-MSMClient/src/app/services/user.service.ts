import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Rx';
import { BehaviorSubject } from 'rxjs/Rx';
import { Router } from '@angular/router';

import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions, LoginInProgressActions } from '../actions';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class UserService extends BaseService {

    // Observable navItem source
    private _authNavStatusSource = new BehaviorSubject<boolean>(false);

    // Observable navItem stream
    authNavStatus$ = this._authNavStatusSource.asObservable();

    private loggedIn = false;

    constructor(http: HttpClient, progressAct: ProgressActions, private router: Router,
        modelService: BsModalService, private loginProgress: LoginInProgressActions) {
        super(http, progressAct, modelService);
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
                sessionStorage.setItem('username', userName);
                return this.ExtractResponseResult(res);
            })
            .catch(this.handleError);
    }

    resetPw(userName, newPassword, oldPassword, email): Promise<any> {
        return this
            .post(factory.getResetPasswordUrl(), JSON.stringify({ userName, newPassword, oldPassword, email }), factory.createHeader())
            .then(res => {
                return res;
            })
            .catch(this.handleError);
    }

    handleError(error) {
        this.finishProgress();
        Promise.reject(error);
    }

    refreshToken() {
        console.log("Request new token begin");
        let token = sessionStorage.getItem('token_jti');

        return this
            .post(factory.getRefreshTokenUrl(), JSON.stringify({ token }), factory.createHeader())
            .then(res => {
                console.log("New token generated sucessfully");
                this.removeStorage();
                return this.ExtractResponseResult(res);
            })
            .catch((error) => {
                console.log("Request new token failed due to: " + error);
                this.logout();
            });
    }


    logout() {
        this.loggedIn = false;
        this._authNavStatusSource.next(false);
        let token = sessionStorage.getItem('token_jti');
        sessionStorage.removeItem('username');
        return this
            .post(factory.getlogoutUrl(), JSON.stringify({ token }), factory.createHeader())
            .then(res => {
                console.log("Remove token sucessfully");
                this.redirectLoginPage();
            })
            .catch((error) => {
                console.log("Remove token failed due to: " + error);
                this.redirectLoginPage();
            })
    }

    private redirectLoginPage() {
        this.finishProgress();                        
        this.removeStorage();
        this.router.navigate(['/pages/login']);
    }

    private removeStorage() {
        sessionStorage.removeItem('auth_token');
        sessionStorage.removeItem('auth_token');
    }

    private ExtractResponseResult(res) {
        sessionStorage.setItem('auth_token', res.auth_token);
        sessionStorage.setItem('token_jti', res.jti);
        this.loggedIn = true;
        this._authNavStatusSource.next(true);
        return res.jti;
    }

    startProgress() {
        this.loginProgress.updateProgress(true);
    }

    finishProgress() {
        this.loginProgress.updateProgress(false);
    }
}

