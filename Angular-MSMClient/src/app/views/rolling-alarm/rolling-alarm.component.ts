import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { msmHelper, treeHelper } from '../../helpers';
import { AlarmService } from '../../services';
import { BehaviorSubject } from 'rxjs/Rx';
import { AlarmRolling, Paging, Sorting } from '../../models'
import { factory } from '../../helpers';
import { HubConnection } from '@aspnet/signalr-client';
import * as signalR from '@aspnet/signalr-client';

@Component({
  selector: 'rolling-alarm',
  templateUrl: './rolling-alarm.component.html',
  styleUrls: ['./rolling-alarm.component.scss']
})

export class RollingAlarmComponent implements OnInit, OnDestroy {
  statuses = msmHelper.createAlarmStatusList();
  priorities = treeHelper.createPriorityList();
  filterTypes = msmHelper.createFilterTypeList();
  pageIndexSubject: BehaviorSubject<number> = new BehaviorSubject<number>(0);
  alarm: AlarmRolling;
  alarmSource: any;
  defaultColumns = ['Time', 'Trap', 'Value', 'Status', 'Site', 'ParentSiteName', 'SitePriority', 'OnOffStatus', 'RepeatCount'];
  private hubConnection: HubConnection;
  private stopHubConnection = false;
  constructor(private alarmService: AlarmService) {
  }

  ngOnDestroy() {
    this.pageIndexSubject.unsubscribe();
  }

  ngOnInit() {
    this.createDefaultFilter();
    this.pageIndexSubject.subscribe(value => this.alarm.paging.pageIndex = value);
    this.getFilterAlarm();

    // Register the signalR
    this.hubConnection = new HubConnection(factory.getAlarmUrl(), { transport: signalR.TransportType.LongPolling });
    this.startHubConnection();
  }

  async getFilterAlarm() {
    await this.alarmService.getFilterAlarm(this.alarm.selectedFilterType, this.alarm.siteName,
      this.alarm.selectedPriority, this.alarm.selectedStatus, this.alarm.trap,
      this.alarm.date.fromDate, this.alarm.date.toDate, this.alarm.paging.pageIndex, this.alarm.paging.pageSize,
      this.alarm.sorting.sortField, this.alarm.sorting.sortDirection, this.alarm.maxAlarmId)
      .then(result => {
        this.alarmSource = result;
      })
      .catch(ex => console.log(ex.message))
  }

  createDefaultFilter() {
    var currentDate = new Date();
    currentDate.setDate(currentDate.getDate() + 1);
    this.alarm = {
      siteName: '', trap: '',
      selectedStatus: this.statuses[0].Description.toString(),
      selectedPriority: "All", date: { fromDate: new Date(), toDate: currentDate, settings: { bigBanner: false, timePicker: false, format: 'dd-MM-yyyy' } },
      paging: { pageSize: 10, pageIndex: 0, pageLength: 10 }, maxAlarmId: 10,
      selectedFilterType: "0", sorting: { sortField: '', sortDirection: 'desc' }
    };

  }

  onFromDateSelect(event) {
    this.alarm.date.fromDate = new Date(event);
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  onToDateSelect(event) {
    this.alarm.date.toDate = new Date(event);
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  onEnter() {
    this.getFilterAlarm();
    this.pageIndexSubject.next(0);
  }

  onFilterTypeChange(event) {
    this.alarm.selectedFilterType = event.value;
    this.getFilterAlarm();
  }

  onSortChange(event) {
    this.alarm.sorting = event;
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
    if (this.stopHubConnection) {
      this.startHubConnection();
      this.stopHubConnection = false;
    }
  }

  startHubConnection() {
    // start the connection
    this.hubConnection
      .start()
      .then(() => console.log('Hub connection started!'))
      .catch(err => console.log('Error while establishing connection due to ' + err));

    // listen if there is any alarm changed from server
    this.hubConnection.on('AlarmChanged', (changed: boolean) => {
      this.getFilterAlarm();
    });
  }

  stopConnection() {
    // stop the connection
    this.hubConnection.stop();

    // stop listenning the alarms changed from server
    this.hubConnection.off('GetAlarms', null);

    this.stopHubConnection = true;
  }
}