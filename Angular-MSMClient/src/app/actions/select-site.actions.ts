import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../store';
import { constants } from './constants';

@Injectable()
export class SelectSiteActions {
  constructor(private ngRedux: NgRedux<IAppState>) { }

  chooseSite(site) {
    this.ngRedux.dispatch({
      type: constants.SELECT_SITE,
      payload: site
    });
  }
}