import { HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
const CLIENT_API_URL = environment.msmClientAPIUrl;
const AUTH_API_URL = environment.msmAuthUrl;
const HUB_API_URL = environment.msmHubUrl;

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

export function getFilteredSiteUrl(filterType, siteName) {
    var site;
    if (siteName === "") {
        site = "/all";
    }
    else {
        site = "/" + siteName;
    }

    return CLIENT_API_URL + "/sites/filter/" + filterType + site;
}

export function getLoginUrl() {
    return AUTH_API_URL + "/auth/login";
}

export function getResetPasswordUrl() {
    return AUTH_API_URL + "/auth/resetPw";
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

export function getAlarmUrl() {
    return HUB_API_URL + "/alarms";
}

export function getSiteViewUrl() {
    return CLIENT_API_URL + "/sites/siteview";
}