import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions } from '../actions/progress.action';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class UserService extends BaseService {

  constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService) {
    super(http, progressAct, modelService);
  }

  getUserLogins(pageIndex, pageSize) {
    return this.get(factory.getUserLoginUrl(pageIndex, pageSize), factory.createHeaderWithToken());
  }

  createNewUserLoginConfig(model) {
    return this.put(factory.getNewUserLoginUrl(), model, factory.createHeaderWithToken());
  }

  deleteUserLoginById(userId) {
    let data = '?' + "userId=" + userId;
    return this.delete(factory.getNewUserLoginUrl(), data, factory.createHeaderWithToken());
  }

  getUsers(pageIndex, pageSize) {
    return this.get(factory.getUserUrl(pageIndex, pageSize), factory.createHeaderWithToken());
  }

  createNewUser(model) {
    return this.put(factory.getNewUserUrl(), model, factory.createHeaderWithToken());
  }

  deleteUserById(userId) {
    let data = '?' + "userId=" + userId;
    return this.delete(factory.getDeleteUserByIdUrl(), data, factory.createHeaderWithToken());
  }

  unlockUser(userIds) {
    return this.put(factory.getUnlockUserUrl(), userIds, factory.createHeaderWithToken());
  }

  updateUsers(users) {
    return this.put(factory.getUpdateUserUrl(), JSON.stringify({ users }), factory.createHeaderWithToken());
  }

  updateUsersConfig(users) {
    return this.put(factory.getUpdateUserConfigUrl(), JSON.stringify({ users }), factory.createHeaderWithToken());
  }
}
