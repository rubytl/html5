import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { ListView } from '../models/list-view';
import { BaseService } from "./base.service";
import { ProgressActions } from '../actions';

@Injectable()
export class ListViewApiService extends BaseService {

    constructor(http: HttpClient, progressAct: ProgressActions) {
        super(http, progressAct);
    }

    public getAllSites() {
        return this.get('', '')
            .then(response => {
                return response;
            })
            .catch(this.handleError);
    }
}
