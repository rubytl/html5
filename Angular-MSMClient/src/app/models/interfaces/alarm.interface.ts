import { Paging } from './paging.interface';
import { Sorting } from './sorting.interface';
import { DateTime } from './datetime.interface';

export interface AlarmRolling {
    siteName: string;
    trap: string;
    selectedStatus: string;
    selectedPriority: any;
    date: DateTime,
    paging: Paging;
    maxAlarmId: number;
    selectedFilterType: any;
    sorting: Sorting;
}