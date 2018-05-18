import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { SiteInProgressActions } from '../actions/site-in-progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class RestrictedSiteService extends BaseService {

  constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService, private siteProgress: SiteInProgressActions) {
    super(http, progressAct, modelService);
  }

  getAllSites() {
    return this.get(factory.getSiteUrl(), factory.createHeaderWithToken());
  }

  getFilteredSites(filter, siteName) {
    return this.get(factory.getFilteredSiteUrl(filter, siteName), factory.createHeaderWithToken());
  }

  getSiteByIds(siteids, pageIndex, pageSize) {
    return this.post(factory.getSiteByIdsUrl(), JSON.stringify({ siteids, pageIndex, pageSize }), factory.createHeaderWithToken());
  }

  startProgress() {
    this.siteProgress.updateProgress(true);
  }

  finishProgress() {
    this.siteProgress.updateProgress(false);
  }
}
