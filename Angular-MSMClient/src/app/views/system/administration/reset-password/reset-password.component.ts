import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { UserLoginService } from '../../../../services';

@Component({
  selector: 'msm-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.scss']
})
export class ResetPasswordComponent extends MsmDialogComponent {
  @Input() setting: any;
  currentUser: any;
  constructor(bsModalRef: BsModalRef, private userLoginService: UserLoginService, modelService: BsModalService) {
    super(bsModalRef, modelService);
  }

  protected onComponentInit() {
    this.currentUser = {
      password: '', confirmPassword: '', userName: this.setting.userName, email: this.setting.email
    };
  }

  private onChangePassword() {
    this.userLoginService.resetPw(this.currentUser.userName, this.currentUser.password, null, this.currentUser.email)
      .then(res => {
        this.openNotificationDialog("Sucess", "Change password successfully");
        this.onClick(null);
      });
  }

}
