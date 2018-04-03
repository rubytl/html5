import { FilterType } from '../models';
import { FilterTypeEnum, AlarmStatus } from '../enums';

export function createFilterTypeList() {
    return [
        new FilterType("All", FilterTypeEnum.all),
        new FilterType("In Alarm", FilterTypeEnum.hasAlarm),
        new FilterType("Is Offline", FilterTypeEnum.isOffline),
        new FilterType("All - Generator installed", FilterTypeEnum.hasGenerator),
        new FilterType("All - PV installed", FilterTypeEnum.hasSolar),
        new FilterType("All - Wind turbine installed", FilterTypeEnum.hasWind),
        new FilterType("Hybrid", FilterTypeEnum.hybrid),
        new FilterType("Hybrid - Generator installed", FilterTypeEnum.hybridGen),
        new FilterType("Hybrid - PV installed", FilterTypeEnum.hybridPV),
        new FilterType("Hybrid - Wind turbine installed", FilterTypeEnum.hybridWind),
        new FilterType("Hybrid - AC monitoring", FilterTypeEnum.hasMainsMonitorHybrid),
        new FilterType("On grid", FilterTypeEnum.onGrid),
        new FilterType("On grid - Generator installed", FilterTypeEnum.onGridGen),
        new FilterType("On grid - PV installed", FilterTypeEnum.onGridPV),
        new FilterType("On grid - Wind turbine installed", FilterTypeEnum.onGridWind),
        new FilterType("On grid - AC monitoring", FilterTypeEnum.hasMainsMonitorGrid)
    ];
}

export function createAlarmStatusList() {
    return [
        { Description: AlarmStatus.All },
        { Description: AlarmStatus.Error },
        { Description: AlarmStatus.Normal },
        { Description: AlarmStatus.Minor },
        { Description: AlarmStatus.Major },
        { Description: AlarmStatus.Disable },
        { Description: AlarmStatus.Disconnected },
        { Description: AlarmStatus.NotPresent },
        { Description: AlarmStatus.MajorLow },
        { Description: AlarmStatus.MinorLow },
        { Description: AlarmStatus.MajorHigh },
        { Description: AlarmStatus.MinorHigh }
    ];
}