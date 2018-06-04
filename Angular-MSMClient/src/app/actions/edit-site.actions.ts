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

    updateSite(sites) {
        this.ngRedux.dispatch({
            type: constants.EDIT_SITE,
            payload: { type: constants.EDIT_SITE, value: sites }
        });
    }

    deleteSites(sites) {
        this.ngRedux.dispatch({
            type: constants.DELETE_SITE,
            payload: { type: constants.DELETE_SITE, value: sites }
        });
    }
}