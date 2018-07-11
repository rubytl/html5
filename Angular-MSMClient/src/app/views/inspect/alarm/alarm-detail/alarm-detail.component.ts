import { Component, OnInit } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../../../../store';
import { BsModalService } from 'ngx-bootstrap/modal';
import { CommonComponent } from '../../../common/common.component';
import { msmHelper } from '../../../../helpers';

@Component({
  selector: 'app-alarm-detail',
  templateUrl: './alarm-detail.component.html',
  styleUrls: ['./alarm-detail.component.scss']
})
export class AlarmDetailComponent extends CommonComponent {
  statuses = msmHelper.createAlarmStatusList();
  alarm: any;
  constructor(modalService: BsModalService, ngRedux: NgRedux<IAppState>) {
    super(ngRedux, modalService);
  }

  protected onComponentInit() {
    var currentDate = new Date();
    currentDate.setDate(currentDate.getDate() + 1);
    this.alarm = { fromDate: currentDate, toDate: currentDate, settings: { bigBanner: false, timePicker: false, format: 'dd-MM-yyyy' } };
  }

  onFromDateSelect(event) {
    this.alarm.fromDate = new Date(event);
    this.pageIndexSubject.next(0);
  }

  onToDateSelect(event) {
    this.alarm.toDate = new Date(event);
    this.pageIndexSubject.next(0);
  }
}
