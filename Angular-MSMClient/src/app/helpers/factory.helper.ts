import { Http, Response, Headers } from '@angular/http';
import { environment } from '../../environments/environment';
const API_URL = environment.msmClientAPIUrl;

export function createHttpHeader(): Headers {
    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let authToken = sessionStorage.getItem('auth_token');
    headers.append('Authorization', `Bearer ${authToken}`);
    return headers;
}

export function getSiteUrl() {
    return API_URL + "/sites";
}