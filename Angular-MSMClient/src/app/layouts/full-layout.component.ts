import { Component, OnInit } from '@angular/core';
import { UserService } from '../services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './full-layout.component.html'
})
export class FullLayoutComponent {

  public disabled = false;
  public status: { isopen: boolean } = { isopen: false };

  constructor(private userSVC: UserService) {
  }

  public toggled(open: boolean): void {
    console.log('Dropdown is now: ', open);
  }

  public toggleDropdown($event: MouseEvent): void {
    $event.preventDefault();
    $event.stopPropagation();
    this.status.isopen = !this.status.isopen;
  }

  logout() {
    this.userSVC.logout();
  }
}
