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

// site urls
export function getSitePagingUrl() {
    return CLIENT_API_URL + "/sites/sitePaging";
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

export function getLastSiteID() {
    return CLIENT_API_URL + "/sites/lastId";
}

export function getNewSiteUrl() {
    return CLIENT_API_URL + "/sites/add";
}

export function getSiteByGroupIdUrl(groupId) {
    return CLIENT_API_URL + "/sites/sitebyGroupId/" + groupId;
}

export function getParentUrl() {
    return CLIENT_API_URL + "/sites/parent";
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

export function getRoleUrl() {
    return AUTH_API_URL + "/auth/roles";
}

export function getUserUrl(pageIndex, pageSize) {
    return AUTH_API_URL + "/auth/users/" + pageIndex + "/" + pageSize;
}

export function getNewUserUrl() {
    return AUTH_API_URL + "/auth/register";
}

export function getDeleteUserByIdUrl() {
    return AUTH_API_URL + "/auth";
}

export function getUnlockUserUrl() {
    return AUTH_API_URL + "/auth/unlock";
}

export function getUpdateLastLoginUrl() {
    return AUTH_API_URL + "/auth/lastlogin";
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

export function getsiteTemplateUrl() {
    return CLIENT_API_URL + "/template/all";
}

export function getCanDeleteTemplateUrl() {
    return CLIENT_API_URL + "/template/canDelete/?templateId=";
}

export function getLastTemplateID() {
    return CLIENT_API_URL + "/template/lastId";
}

export function getUpdateTemplateUrl() {
    return CLIENT_API_URL + "/template/update";
}


// Snmp urls
export function getSnmpConfigUrl() {
    return CLIENT_API_URL + "/snmpconfig";
}

export function getSnmpDataConfigUrl() {
    return CLIENT_API_URL + "/snmpdata";
}

// msm dictionary urls
export function getMsmDictionary() {
    return CLIENT_API_URL + "/msmdictionary";
}

export function getMsmDictionaryById(itemId) {
    return CLIENT_API_URL + "/msmdictionary/byid/" + itemId;
}

// restricted group urls
export function getRestrictedGroupUrl() {
    return CLIENT_API_URL + "/restrictedgroup";
}

// restricted group config urls
export function getUpdateGroupConfigUrl() {
    return CLIENT_API_URL + "/restrictedgroupconfiguration";
}

// user login urls
export function getUserLoginUrl(pageIndex, pageSize) {
    return CLIENT_API_URL + "/userlogin/users/" + pageIndex + "/" + pageSize;
}

export function getNewUserLoginUrl() {
    return CLIENT_API_URL + "/userlogin";
}