import { Component, OnChanges } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { BsModalService } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { UserService, RoleService, RestrictedGroupService } from '../../../../services';
import { NewUserComponent } from '../new-user/new-user.component';
import { treeHelper } from '../../../../helpers';
import { ResetPasswordComponent } from '../reset-password/reset-password.component';

@Component({
  selector: 'msm-user-setup',
  templateUrl: './user-setup.component.html',
  styleUrls: ['./user-setup.component.scss']
})
export class UserSetupComponent extends CommonComponent {
  userForm: FormGroup;
  noServiceLoaded: number;
  private originalUserSource = [];
  private roleList = [];
  private restrictedList = [];
  private selectedRowIndex: number;
  private deletedUsers = [];
  private lockedUsers = [];

  constructor(modalService: BsModalService, ngRedux: NgRedux<IAppState>, private fb: FormBuilder,
    private roleService: RoleService,
    private userService: UserService, private restrictedService: RestrictedGroupService) {
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
    this.restrictedList.push({ itemName: 'All', itemId: null });
    this.noServiceLoaded = 0;
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
            id: element.id, userName: element.userName, email: element.email,
            comment: element.comment, locked: element.locked, friendlyName: element.friendlyName,
            createdDate: element.createdDate, lastLogin: element.lastLogin
          });
        });
        this.noServiceLoaded++;
        if (this.noServiceLoaded === 2) {
          this.rebuildForm();
        }
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
    this.userService.getUserLogins(this.paging.pageIndex, this.paging.pageSize)
      .then(res => {
        let actualIds = [];
        res.forEach(element => {
          let user = this.originalUserSource.find(s => s.userName === element.userName);
          if (user) {
            user.roleName = element.roleName;
            user.restrictedGroupId = element.restrictedGroupId;
            user.userId = element.id;
            actualIds.push(user.id);
          }
        });

        this.originalUserSource = this.originalUserSource.filter(s => actualIds.includes(s.id));
        this.noServiceLoaded++;
        if (this.noServiceLoaded === 2) {
          this.rebuildForm();
        }
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
    // add new site
    let setting = {
      roleList: this.roleList, restrictedList: this.restrictedList
    };
    var newSiteRef = this.modalService.show(NewUserComponent, { initialState: { setting } });
    this.onAfterAddingNewUser(newSiteRef);
  }

  private onAfterAddingNewUser(newSiteRef) {
    newSiteRef.content.onClose.subscribe(result => {
      if (result) {
        this.userSource.push(this.fb.group(result));
      }

      newSiteRef.content.onClose.unsubscribe();
    });
  }

  private onDeleteUser() {
    if (this.selectedRowIndex === undefined) {
      this.openNotificationDialog('Delete User?', "Please select a user to delete");
      return;
    }

    let user = this.userSource.controls[this.selectedRowIndex].value;
    this.userSource.removeAt(this.selectedRowIndex);
    this.deletedUsers.push(user);
    this.userSource.markAsDirty();
  }

  // row click and get the appopriate index
  private onRowClick(i) {
    this.selectedRowIndex = i;
  }
  // rebuild form if user reject changes
  private onRejectChanges() {
    this.rebuildForm();
  }

  // handle workflow when user accept changes from the gui
  private onSaveChanges() {
    // save delete templates
    if (this.deletedUsers.length > 0) {
      this.userService.deleteUserById(this.deletedUsers.map(s => s.id))
        .then(res => {
          this.userService.deleteUserLoginById(this.deletedUsers.map(s => s.userId))
            .then(res => {
              this.updateLocalVariables();
              this.openNotificationDialog('Success', 'User(s) deleted successfully');
            })
        });
    }

    if (this.lockedUsers.length > 0) {
      this.userService.unlockUser(this.lockedUsers.map(s => s.id));
    }
  }

  private updateLocalVariables() {
    this.deletedUsers = [];
    this.originalUserSource = this.userSource.value;
  }

  private onResetPassword() {
    if (this.selectedRowIndex === undefined) {
      this.openNotificationDialog('Reset Password?', "Please select a user to reset password");
      return;
    }
    let currentUser = this.userSource.controls[this.selectedRowIndex].value;
    var newSiteRef = this.modalService.show(ResetPasswordComponent, { initialState: { setting: currentUser } });
  }

  private onUnlockUser() {
    this.lockedUsers = this.originalUserSource.filter(s => s.locked === true);
    if (this.lockedUsers.length > 0) {
      this.userForm.markAsDirty();
      this.lockedUsers.forEach(element => {
        let index = this.userSource.value.findIndex(s => s.id === element.id);
        this.userSource.controls[index].patchValue({ locked: false });
      });
    }
  }

  // after page changed
  protected onAfterPageChanged() {
    this.noServiceLoaded = 0;
    this.originalUserSource = [];
    this.getUserPaging();
    this.getUserLoginsPaging();
  }
}
