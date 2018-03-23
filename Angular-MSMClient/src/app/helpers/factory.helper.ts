import { HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
const API_URL = environment.msmClientAPIUrl;

export function createHeaderWithToken(): HttpHeaders {
    var token = sessionStorage.getItem('auth_token');
    let headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + token,
    });

    return headers;
}

export function createHeader(): HttpHeaders {
    let headers = new HttpHeaders({
        'Content-Type': 'application/json',
    });

    return headers;
}

export function getSiteUrl() {
    return API_URL + "/sites";
}

export function getLoginUrl() {
    return API_URL + "/auth/login";
}

export function getRefreshTokenUrl() {
    return API_URL + "/auth/refresh";
}