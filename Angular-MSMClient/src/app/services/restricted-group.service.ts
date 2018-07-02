import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class RestrictedGroupService extends BaseService {

  constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
    super(http, progressAct, modelService);
  }

  getAllGroups() {
    return this.get(factory.getRestrictedGroupUrl(), factory.createHeaderWithToken());
  }

  updateGroupConfig(groupConfig) {
    return this.put(factory.getRestrictedGroupConfigUrl(), JSON.stringify({ groupConfig }), factory.createHeaderWithToken());
  }

  canDeleteGroupConfig(groupId) {
    return this.get(factory.getCanDeleteGroupConfigUrl() + groupId, factory.createHeaderWithToken());
  }

  deleteGroupConfigs(groupIds) {
    let data = '?';
    groupIds.forEach(element => {
      data += "groupIds=" + element + "&";
    });
    return this.delete(factory.getRestrictedGroupConfigUrl(), data, factory.createHeaderWithToken());
  }
}
