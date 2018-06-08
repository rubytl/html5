import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class TemplateService extends BaseService {

    constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
        super(http, progressAct, modelService);
    }

    getTemplates() {
        return this.get(factory.getTemplateUrl(), factory.createHeaderWithToken());
    }

    getsiteTemplates(pageIndex, pageSize) {
        return this.post(factory.getsiteTemplateUrl(),
            JSON.stringify({ pageIndex, pageSize }),
            factory.createHeaderWithToken());
    }
}
