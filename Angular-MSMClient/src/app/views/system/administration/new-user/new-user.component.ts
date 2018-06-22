import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { UserService } from '../../../../services';

@Component({
  selector: 'msm-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.scss']
})
export class NewUserComponent extends MsmDialogComponent {
  newUser: any;
  @Input() setting: any;
  constructor(bsModalRef: BsModalRef, private userService: UserService, modelService: BsModalService) {
    super(bsModalRef, modelService);
  }

  protected onComponentInit() {
    this.newUser = {
      userName: '', friendlyName: '', email: '',
      password: '', confirmPassword: '', roleName: 'Admin',
      restrictedGroupId: null, comment: '', locked: false
    };
  }

  onAddNewUser() {
    this.userService.createNewUser(this.newUser)
      .then(res => {
        if (res) {
          this.newUser.id = res.id;
          this.newUser.createdDate = res.createdDate;
          this.userService.createNewUserLoginConfig(this.newUser)
            .then(res => {
              if (res !== -1) {
                this.newUser.userId = res;
                this.newUser.lastLogin = '';
                this.openNotificationDialog('Success', 'User added successfully');
                this.onClick(this.newUser);
              }
              else {
                this.onClick(null);
              }
            });
        }
        else {
          this.onClick(null);
        }
      });
  }

  protected onValueChanged(event) {
    if (!event) {
      return;
    }

    if (event.name === 'roleName') {
      this.newUser.roleName = event.value;
    }
    else if (event.name === 'restrictedGroupId') {
      this.newUser.restrictedGroupId = event.value;
    }
  }
}
