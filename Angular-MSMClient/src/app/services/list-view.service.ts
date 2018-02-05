import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Http, Response } from '@angular/http';
import { ListView } from '../models/list-view';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

const API_URL = environment.msmClientAPIUrl;

@Injectable()
export class ListViewApiService {

    constructor(
        private http: Http
    ) {
    }

    public getAllSites(): Observable<ListView[]> {
        return this.http
            .get(API_URL + '/getSiteListView')
            .map(response => {
                const sites = response.json();
                return sites.map((site) => new ListView(site));
            })
            .catch(this.handleError);
    }

    private handleError(error: Response | any) {
        console.error('SiteApiService::handleError', error);
        return Observable.throw(error);
    }
}
