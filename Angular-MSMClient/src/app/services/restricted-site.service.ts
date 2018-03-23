import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import 'rxjs/Rx';
import 'rxjs/add/operator/catch';
// put this next to the other RxJs operator imports
// With the shareReplay operator in place, we would no longer
// fall into the situation where we have accidental multiple HTTP requests.
import 'rxjs/add/operator/shareReplay';

import { Site } from '../models';
import { BaseService } from "./base.service";
import { factory } from '../helpers';

@Injectable()
export class RestrictedSiteApiService extends BaseService {

  constructor(
    private httpClient: HttpClient
  ) {
    super();
  }

  getAllSites() {
    return this.httpClient
      .get(factory.getSiteUrl(), { headers: factory.createHeaderWithToken() })
      .toPromise();
  }
}
