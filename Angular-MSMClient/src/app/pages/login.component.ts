import { Component, OnInit, OnDestroy } from '@angular/core';
import { UserService } from '../services';
import { Router } from '@angular/router';

import { Credentials } from '../models';

@Component({
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.scss']
})
export class LoginComponent {

  errors: string;
  isRequesting: boolean;
  credentials: Credentials = { username: '', password: '' };
  constructor(private userSVC: UserService, private router: Router) {
  }

  login() {
    this.isRequesting = true;
    this.errors = '';
    this.userSVC.login(this.credentials.username, this.credentials.password)
      .then(() => {
        this.isRequesting = false
        this.router.navigate(['/dashboard']);
      })
      .catch(ex => {
        var error = ex.error;
        this.isRequesting = false
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
          this.errors = "Invalid username/password.\n Or server error, or internet connection failure has occurred";
        }
      });
  }
}
