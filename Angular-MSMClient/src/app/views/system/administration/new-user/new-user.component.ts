import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { UserService, UserLoginService } from '../../../../services';

@Component({
  selector: 'msm-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.scss']
})
export class NewUserComponent extends MsmDialogComponent {
  newUser: any;
  @Input() setting: any;
  constructor(bsModalRef: BsModalRef, private userService: UserService,
    modelService: BsModalService, private userLoginService: UserLoginService) {
    super(bsModalRef, modelService);
  }

  protected onComponentInit() {
    this.newUser = {
      userName: '', friendlyName: '', email: '',
      password: '', confirmPassword: '', roleName: '',
      restrictedGroupId: null, comment: '', locked: false
    };
  }

  onAddNewUser() {
    this.userLoginService.createNewUser(this.newUser)
      .then(res => {
        if (res) {
          this.userLoginService.createNewUserLoginConfig(this.newUser)
            .then(res => {
              if (res) {
                this.openNotificationDialog('Success', 'User added successfully');
                this.onClick(this.newUser);
              }
              else if (!res) {
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
