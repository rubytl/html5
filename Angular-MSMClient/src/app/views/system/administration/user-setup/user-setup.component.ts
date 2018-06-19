import { Component, OnChanges } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { BsModalService } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { UserLoginService, UserService, RoleService, RestrictedGroupService } from '../../../../services';

@Component({
  selector: 'msm-user-setup',
  templateUrl: './user-setup.component.html',
  styleUrls: ['./user-setup.component.scss']
})
export class UserSetupComponent extends CommonComponent {
  userForm: FormGroup;
  private originalUserSource = [];
  private roleList = [];
  private restrictedList = [];
  private selectedRowIndex: number;
  private deletedUserIs = [];
  constructor(modalService: BsModalService, ngRedux: NgRedux<IAppState>, private fb: FormBuilder,
    private userService: UserService, private roleService: RoleService,
    private userLoginService: UserLoginService, private restrictedService: RestrictedGroupService) {
    super(ngRedux, modalService);
  }

  // get user source
  get userSource(): FormArray {
    return this.userForm.get('userSource') as FormArray;
  }

  // rebuild form if there are any changes
  ngOnChanges() {
    this.rebuildForm();
  }

  // called when component is inited
  protected onComponentInit() {
    this.createForm();
    this.getUserPaging();
    this.getUserLoginsPaging();
    this.getRolePaging();
    this.getRestrictedGroup();
  }

  // create default form group
  private createForm() {
    this.userForm = this.fb.group({
      userSource: this.fb.array([])
    });
  }

  // get users paging
  private getUserPaging() {
    this.userService.getUsers(this.paging.pageIndex, this.paging.pageSize)
      .then(res => {
        res.forEach(element => {
          this.originalUserSource.push({
            userName: element.userName, email: element.email,
            comment: element.comment, locked: element.locked, friendlyName: element.friendlyName,
            createdDate: element.createdDate, lastLogin: element.lastLogin
          });
        });
      });
  }

  // get roles paging
  private getRolePaging() {
    this.roleService.getRoles()
      .then(res => {
        res.forEach(element => {
          this.roleList.push({ itemName: element.name, itemId: element.name });
        });
      });
  }

  // get roles paging
  private getRestrictedGroup() {
    this.restrictedService.getAllGroups()
      .then(res => {
        res.forEach(element => {
          this.restrictedList.push({ itemName: element.restrictedGroupName, itemId: element.restrictedGroupId });
        });
      });
  }

  // get roles paging
  private getUserLoginsPaging() {
    this.userLoginService.getUserLogins(this.paging.pageIndex, this.paging.pageSize)
      .then(res => {
        res.forEach(element => {
          let user = this.originalUserSource.find(s => s.userName === element.userName);
          if (user) {
            user.roleName = element.roleName;
            user.restrictedGroupId = element.restrictedGroupId;
          }
        });
        this.rebuildForm();
      });
  }

  // rebuild form if any changed
  private rebuildForm() {
    const sites = this.originalUserSource.map(site => this.fb.group(site));
    const siteFormArray = this.fb.array(sites);
    this.userForm.setControl('userSource', siteFormArray);
  }

  private onValueChanged(event) {
    this.userForm.markAsDirty();
  }

  private onAddNewUser() {
  }

  private onDeleteUser() {
  }
}
