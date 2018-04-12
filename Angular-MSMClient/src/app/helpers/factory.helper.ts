import { HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
const CLIENT_API_URL = environment.msmClientAPIUrl;
const AUTH_API_URL = environment.msmAuthUrl;

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
    return CLIENT_API_URL + "/sites";
}

export function getLoginUrl() {
    return AUTH_API_URL + "/auth/login";
}

export function getRefreshTokenUrl() {
    return AUTH_API_URL + "/auth/refresh";
}

export function getlogoutUrl() {
    return AUTH_API_URL + "/auth/logout";
}

export function getRollingAlarmUrl() {
    return CLIENT_API_URL + "/alarm/filter";
}