import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { ProgressActions } from '../actions';
import { BsModalService } from 'ngx-bootstrap/modal';
import { factory } from '../helpers';

@Injectable()
export class ListViewApiService extends BaseService {

    constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
        super(http, progressAct, modelService);
    }

    async getAllSitesView(siteids, pageIndex, pageSize) {
        return await this
            .post(factory.getSiteViewUrl(), JSON.stringify({ siteids, pageIndex, pageSize }), factory.createHeaderWithToken())
            .then(res => { return res; })
            .catch(this.handleError);
    }
}
