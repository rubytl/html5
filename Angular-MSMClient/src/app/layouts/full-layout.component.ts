import { Component, OnInit, OnDestroy } from '@angular/core';
import { UserLoginService } from '../services';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs/Subscription';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../store/index';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'full-layout.component.html',
  styleUrls: ['full-layout.component.scss']
})
export class FullLayoutComponent implements OnInit, OnDestroy {

  public disabled = false;
  public status: { isopen: boolean } = { isopen: false };
  username = sessionStorage.getItem('username');
  isSiteLoading = false;
  isAlarmLoading = false;
  isMainLoading = false;
  private siteInProgressSub: Subscription;
  private alarmInProgressSub: Subscription;
  private mainInProgressSub: Subscription;
  constructor(private userSVC: UserLoginService, private ngRedux: NgRedux<IAppState>) {
  }

  ngOnInit() {
    this.siteInProgressSub = this.ngRedux.select(state => state.siteInProgress)
      .subscribe(value => this.isSiteLoading = value);
    this.alarmInProgressSub = this.ngRedux.select(state => state.alarmInProgress)
      .subscribe(value => this.isAlarmLoading = value);
    this.mainInProgressSub = this.ngRedux.select(state => state.inProgress)
      .subscribe(value => this.isMainLoading = value);
  }

  ngOnDestroy() {
    if (this.siteInProgressSub) {
      this.siteInProgressSub.unsubscribe();
    }
    if (this.alarmInProgressSub) {
      this.alarmInProgressSub.unsubscribe();
    }
    if (this.mainInProgressSub) {
      this.mainInProgressSub.unsubscribe();
    }
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
