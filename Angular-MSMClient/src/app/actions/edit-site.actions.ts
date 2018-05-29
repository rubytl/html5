import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../store';
import { constants } from './constants';

@Injectable()
export class EditSiteActions {
    constructor(private ngRedux: NgRedux<IAppState>) { }

    addNewSite(site) {
        this.ngRedux.dispatch({
            type: constants.ADD_SITE,
            payload: { type: constants.ADD_SITE, value: site }
        });
    }
}