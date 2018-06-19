import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class RoleService extends BaseService {

  constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
    super(http, progressAct, modelService);
  }

  getRoles() {
    return this.get(factory.getRoleUrl(), factory.createHeaderWithToken());
  }
}
