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

// site urls
export function getSiteUrl() {
    return CLIENT_API_URL + "/sites";
}

export function getSiteByIdsUrl() {
    return CLIENT_API_URL + "/sites/siteByIds";
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

export function getSiteViewUrl() {
    return CLIENT_API_URL + "/sites/siteview";
}

// Authentication urls
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

// Alarm urls
export function getRollingAlarmUrl() {
    return CLIENT_API_URL + "/alarm/filter";
}

export function getAlarmUrl() {
    return HUB_API_URL + "/alarms";
}

// Template urls
export function getTemplateUrl() {
    return CLIENT_API_URL + "/template";
}

// Snmp urls
export function getSnmpConfigUrl() {
    return CLIENT_API_URL + "/snmpconfig";
}

export function getSnmpDataConfigUrl() {
    return CLIENT_API_URL + "/snmpdata";
}