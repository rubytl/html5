import { Component, OnInit, OnDestroy } from '@angular/core';
import { UserLoginService } from '../services';
import { Router } from '@angular/router';

import { Credentials, ResetCredentials } from '../models';

@Component({
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.scss']
})
export class LoginComponent {
  errors: string;
  changePwResult: string;
  credentials: Credentials = { username: '', password: '' };
  resetCredential: ResetCredentials = { username: '', password: '', newPassword: '', confirmNewPassword: '', email: '' };
  isChangingPw = false;
  isLogin = false;
  constructor(private userLoginSVC: UserLoginService, private router: Router) {
  }

  login() {
    this.errors = '';
    this.userLoginSVC.login(this.credentials.username, this.credentials.password)
      .then(() => {
        this.router.navigate(['/dashboard']);
        this.userLoginSVC.updateLastLogin(this.credentials.username);
      })
      .catch(ex => {
        var error = ex.error;
        if (error == "1") {
          this.errors = "You are already logged in from '{0}' computer,\ndo you want to close your other session to prevent data loss?";
          // if user agrees, then logout and login again
          this.router.navigate(['/dashboard']);
        }
        else if (error == "2") {
          this.errors = "No valid license for MSM was found.\nPlease provide valid serial number or\ncontact MSM support (MSM.Support@eltek.com)";
          this.router.navigate(['/dashboard']);
        }
        else if (error == "3") {
          this.errors = "The maximum user limit for this application is reached.\nPlease try again later or contact your administrator to expand the number of licenses.";
        }
        else {
          this.errors = "Invalid username/password.\n Or this account has ben locked, or server error, or internet connection failure has occurred";
        }
      });
  }

  resetPw() {
    this.changePwResult = '';
    this.userLoginSVC.resetPw(this.resetCredential.username, this.resetCredential.newPassword, this.resetCredential.password, this.resetCredential.email)
      .then(res => {
        if (res) {
          this.changePwResult = 'Change password sucessfully';
        }
        else {
          this.changePwResult = 'Change password unsucessfully';
        }
      })
      .catch(ex => {
        this.changePwResult = ex.error;
      });
  }

  toChangePw() {
    this.changePwResult = '';
    this.isChangingPw = true;
    this.isLogin = false;
  }

  backToLogin() {
    this.errors = '';
    this.isLogin = true;
    this.isChangingPw = false;
  }
}
