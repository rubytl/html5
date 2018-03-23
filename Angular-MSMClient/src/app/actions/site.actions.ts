import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../store';
import { RestrictedSiteApiService } from '../services/restricted-site.service';
import { Site } from '../models/site';
import { constants } from './constants';
import { treeHelper } from '../helpers';

@Injectable()
export class SiteActions {
  constructor(private ngRedux: NgRedux<IAppState>,
    private siteApiService: RestrictedSiteApiService) { }

  loadSites(): void {
    this.siteApiService
      .getAllSites()
      .then((sites) => {
        this.ngRedux.dispatch({
          type: constants.LOAD_SITE,
          payload: [new Site({
            id: 0,
            description: "My Network",
            children: treeHelper.listToTree(sites)
          })]
        });
      });
  }


  addSite(site): void {
  }
}
