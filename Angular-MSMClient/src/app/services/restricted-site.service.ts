import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import 'rxjs/Rx';
import 'rxjs/add/operator/catch';
// put this next to the other RxJs operator imports
// With the shareReplay operator in place, we would no longer
// fall into the situation where we have accidental multiple HTTP requests.
import 'rxjs/add/operator/shareReplay';

import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { SiteInProgressActions } from '../actions/site-in-progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class RestrictedSiteApiService extends BaseService {

  constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService, private siteProgress: SiteInProgressActions) {
    super(http, progressAct, modelService);
  }

  getAllSites() {
    return this.get(factory.getSiteUrl(), factory.createHeaderWithToken());
  }

  getFilteredSites(filter, siteName) {
    return this.get(factory.getFilteredSiteUrl(filter, siteName), factory.createHeaderWithToken());
  }

  startProgress() {
    this.siteProgress.updateProgress(true);
  }

  finishProgress() {
    this.siteProgress.updateProgress(false);
  }
}
