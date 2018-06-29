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
    return this.put(factory.getUpdateGroupConfigUrl(), JSON.stringify({ groupConfig }), factory.createHeaderWithToken());
  }
}
