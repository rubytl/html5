import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Http, Response } from '@angular/http';
import { Site } from '../models/site';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

const API_URL = environment.restrictedSiteUrl;

@Injectable()
export class RestrictedSiteApiService {

  constructor(
    private http: Http
  ) {
  }

  public getAllSites(): Observable<Site[]> {
    return this.http
      .get(API_URL + '/admin')
      .map(response => {
        const sites = response.json().List;
        return sites.map((site) => new Site({
          id: site.SiteId, name: site.SiteName,
          lat: this.random(-50, 200),
          long: this.random(-20, 300)
        }));
      })
      .catch(this.handleError);
  }

  public random(min: number, max: number) {
    return Math.floor(Math.random() * (max - min + 1) + min);
  }

  private handleError(error: Response | any) {
    console.error('SiteApiService::handleError', error);
    return Observable.throw(error);
  }
}
