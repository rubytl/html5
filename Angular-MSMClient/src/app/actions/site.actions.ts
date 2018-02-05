import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../store';
import { RestrictedSiteApiService } from '../services/restricted-site.service';
import { Site } from '../models/site';
import { constants } from './constants';

@Injectable()
export class SiteActions {
  constructor(private ngRedux: NgRedux<IAppState>,
    private siteApiService: RestrictedSiteApiService) { }

  loadSites(): void {
    this.siteApiService
      .getAllSites()
      .subscribe(
      (sites) => {
        this.ngRedux.dispatch({
          type: constants.LOAD_SITE,
          payload: [new Site({
            id: 0,
            name: "My Network",
            children: sites
          })]
        });
      }
      );
  }

   
  addSite(site): void {
  }
}
