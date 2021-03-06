import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
// put this next to the other RxJs operator imports
// With the shareReplay operator in place, we would no longer
// fall into the situation where we have accidental multiple HTTP requests.
import 'rxjs/add/operator/shareReplay';

import { BaseService } from "./base.service";
import { factory } from '../helpers';
import { ProgressActions, AlarmInProgressActions } from '../actions';
import { BsModalService } from 'ngx-bootstrap/modal';

@Injectable()
export class AlarmService extends BaseService {

    constructor(http: HttpClient, progressAct: ProgressActions, modelService: BsModalService, private alarmProgress: AlarmInProgressActions) {
        super(http, progressAct, modelService);
    }

    getFilterAlarm(filter: string, siteName: string, priority: string,
        statusCode: string, trap: string,
        fromDate: Date, toDate: Date, pageIndex: number, pageSize: number,
        sortField: string, sortDirection: string, maxAlarmId: number) {
        return this.post(factory.getRollingAlarmUrl(),
            JSON.stringify({ filter, siteName, priority, statusCode, trap, fromDate, toDate, pageIndex, pageSize, sortField, sortDirection, maxAlarmId }),
            factory.createHeaderWithToken());
    }

    startProgress() {
        this.alarmProgress.updateProgress(true);
    }

    finishProgress() {
        this.alarmProgress.updateProgress(false);
    }
}
