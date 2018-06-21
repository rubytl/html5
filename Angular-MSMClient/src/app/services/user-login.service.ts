import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class UserLoginService extends BaseService {

  constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
    super(http, progressAct, modelService);
  }

  getUserLogins(pageIndex, pageSize) {
    return this.get(factory.getUserLoginUrl(pageIndex, pageSize), factory.createHeaderWithToken());
  }

  createNewUserLoginConfig(model) {
    return this.put(factory.getNewUserLoginUrl(), model, factory.createHeaderWithToken());
  }

  getUsers(pageIndex, pageSize) {
    return this.get(factory.getUserUrl(pageIndex, pageSize), factory.createHeaderWithToken());
  }

  createNewUser(model) {
    return this.put(factory.getNewUserUrl(), model, factory.createHeaderWithToken());
  }
}
