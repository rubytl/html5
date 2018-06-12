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

    deleteTemplates(templateIds) {
        let data = '?';
        templateIds.forEach(element => {
            data += "templateIds=" + element + "&";
        });
        return this.delete(factory.getTemplateUrl(), data, factory.createHeaderWithToken());
    }

    canDeleteTemplate(templateId) {
        return this.get(factory.getCanDeleteTemplateUrl() + templateId, factory.createHeaderWithToken());
    }

    getTemplates() {
        return this.get(factory.getTemplateUrl(), factory.createHeaderWithToken());
    }

    getsiteTemplates(pageIndex, pageSize) {
        return this.post(factory.getsiteTemplateUrl(),
            JSON.stringify({ pageIndex, pageSize }),
            factory.createHeaderWithToken());
    }

    addNewTemplate(newTemplate) {
        return this.post(factory.getNewTemplateUrl(),
            JSON.stringify({}),
            factory.createHeaderWithToken());
    }
}
