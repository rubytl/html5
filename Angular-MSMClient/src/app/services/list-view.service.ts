import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { ListView } from '../models/list-view';
import { BaseService } from "./base.service";
import { ProgressActions } from '../actions';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class ListViewApiService extends BaseService {

    constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
        super(http, progressAct, modelService);
    }

    public getAllSites() {
        return this.get('', '');
    }
}
