// auth.guard.ts
import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';
import { UserLoginService } from './user-login.service';

@Injectable()
export class AuthGuard implements CanActivate {
    constructor(private user: UserLoginService, private router: Router) { }

    canActivate() {
        if (!this.user.isLoggedIn) {
            this.router.navigate(['/pages/login']);
            return false;
        }

        return true;
    }
}