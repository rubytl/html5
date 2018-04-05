import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../store';
import { constants } from './constants';

@Injectable()
export class ProgressActions {
    constructor(private ngRedux: NgRedux<IAppState>) { }

    updateProgress(status) {
        this.ngRedux.dispatch({
            type: constants.IN_PROGRESS,            
            payload: status            
        });
    }
}