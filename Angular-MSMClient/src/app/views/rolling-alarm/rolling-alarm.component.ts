import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { msmHelper, treeHelper } from '../../helpers';
import { AlarmService } from '../../services';
import { BehaviorSubject } from 'rxjs/Rx';
import { AlarmRolling, Paging, Sorting } from '../../models'

@Component({
  selector: 'rolling-alarm',
  templateUrl: './rolling-alarm.component.html',
  styleUrls: ['./rolling-alarm.component.scss']
})

export class RollingAlarmComponent implements OnInit, OnDestroy {
  statuses = msmHelper.createAlarmStatusList();
  priorities = treeHelper.createPriorityList();
  alarmSource: any;
  pageIndexSubject: BehaviorSubject<number> = new BehaviorSubject<number>(0);
  alarm: AlarmRolling;

  constructor(private alarmService: AlarmService) {
  }

  ngOnDestroy() {
    this.pageIndexSubject.unsubscribe();
  }

  ngOnInit() {
    this.createDefaultFilter();
    this.pageIndexSubject.subscribe(value => this.alarm.paging.pageIndex = value);
    this.getFilterAlarm();
  }

  async getFilterAlarm() {
    await this.alarmService.getFilterAlarm(this.alarm.selectedFilterType, this.alarm.siteName,
      this.alarm.selectedPriority, this.alarm.selectedStatus, this.alarm.trap,
      this.alarm.date.fromDate, this.alarm.date.toDate, this.alarm.paging.pageIndex, this.alarm.paging.pageSize,
      this.alarm.sorting.sortField, this.alarm.sorting.sortDirection, this.alarm.maxAlarmId)
      .then(result => {
        this.alarmSource = result;
      })
      .catch(ex => console.log(ex))
  }

  createDefaultFilter() {
    this.alarm = {
      siteName: '', trap: '',
      selectedStatus: this.statuses[0].Description.toString(),
      selectedPriority: "All", date: { fromDate: new Date(), toDate: new Date(), settings: { format: 'dd-MM-yyyy' } },
      paging: { pageSize: 10, pageIndex: 0, pageLength: 10 }, maxAlarmId: 10,
      selectedFilterType: "0", sorting: { sortField: '', sortDirection: 'desc' }
    };

  }

  onDateSelect(event) {
    this.alarm.date.fromDate = new Date(event);
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  onEnter() {
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  onFilterTypeChange(event) {
    this.alarm.selectedFilterType = event;
    this.getFilterAlarm();
  }

  onSortChange(event) {
    this.alarm.sorting.sortDirection = event;
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  onCurrentPageChange(event) {
    this.alarm.paging.pageIndex = event;
    this.getFilterAlarm();
  }

  onPageSizeChange(event) {
    this.alarm.paging.pageSize = event;
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  searchAlarm() {
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  stopSearching() {
  }
}