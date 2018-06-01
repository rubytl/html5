import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import 'rxjs/Rx';
import 'rxjs/add/operator/catch';
// put this next to the other RxJs operator imports
// With the shareReplay operator in place, we would no longer
// fall into the situation where we have accidental multiple HTTP requests.
import 'rxjs/add/operator/shareReplay';

import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';
import { Site } from '../models';

@Injectable()
export class SiteService extends BaseService {

    constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
        super(http, progressAct, modelService);
    }

    getSiteByIds(siteids, pageIndex, pageSize) {
        return this.post(factory.getSiteByIdsUrl(), JSON.stringify({ siteids, pageIndex, pageSize }), factory.createHeaderWithToken());
    }

    getLastSiteID() {
        return this.get(factory.getLastSiteID(), factory.createHeaderWithToken());
    }

    addNewSite(newSite: Site) {
        let id = newSite.id;
        let description = newSite.description;
        let sitePriority = newSite.sitePriority;
        let address = newSite.address;
        let parentId = newSite.parentId;
        let controllerType = newSite.controllerType;
        let templateId = newSite.templateId;
        let snmpTemplateId = newSite.snmpTemplateId;
        let snmpDataTemplateId = newSite.snmpDataTemplateId;
        let ssl = newSite.ssl;
        let jsonUserName = newSite.jsonUserName;
        let jsonPassword = newSite.jsonPassword;
        let jsonService = 1;
        let notificationEnabled = false;
        return this.post(factory.getNewSiteUrl(),
            JSON.stringify({ id, description, address, sitePriority, parentId, controllerType, templateId, snmpTemplateId, snmpDataTemplateId, ssl, jsonUserName, jsonPassword, jsonService, notificationEnabled }),
            factory.createHeaderWithToken());
    }

    deleteSites(siteIds) {
        let data = '?';
        siteIds.forEach(element => {
            data += "siteIds=" + element + "&";
        });
        return this.delete(factory.getDeleteSitesUrl(), data, factory.createHeaderWithToken());
    }

    updateSites(sites) {
        return this.put(factory.getUpdateSitesUrl(),
            JSON.stringify({ sites }),
            factory.createHeaderWithToken());
    }
}
