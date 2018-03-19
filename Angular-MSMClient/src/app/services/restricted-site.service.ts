import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Site } from '../models';
import { BaseService } from "./base.service";
import { factory } from '../helpers';

const API_URL = environment.restrictedSiteUrl;

@Injectable()
export class RestrictedSiteApiService extends BaseService {

  constructor(
    private http: Http
  ) {
    super();
  }

  public getAllSites(): Observable<any> {
    let headers = factory.createHttpHeader();
    return this.http
      .get(factory.getSiteUrl(), { headers })
      .map(response => response.json())
      .catch(this.handleError);
  }
}
