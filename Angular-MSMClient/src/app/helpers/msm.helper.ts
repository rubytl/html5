import { FilterType } from '../models';
import { FilterTypeEnum, AlarmStatus, ControllerTypeEnum } from '../enums';
import { BsModalService } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal/bs-modal-ref.service';
import { MsmDialogComponent } from '../shared/msm-dialog/msm-dialog.component';

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
        new FilterType("Hybrid - Wind installed", FilterTypeEnum.hybridWind),
        new FilterType("Hybrid - AC monitoring", FilterTypeEnum.hasMainsMonitorHybrid),
        new FilterType("On grid", FilterTypeEnum.onGrid),
        new FilterType("On grid - Generator installed", FilterTypeEnum.onGridGen),
        new FilterType("On grid - PV installed", FilterTypeEnum.onGridPV),
        new FilterType("On grid - Wind installed", FilterTypeEnum.onGridWind),
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

export function createControllerTypeList() {
    return [
        { description: "Others", value: ControllerTypeEnum.others },
        { description: "Compack", value: ControllerTypeEnum.compack },
        { description: "Orion", value: ControllerTypeEnum.orion },
        { description: "SmartPack 2", value: ControllerTypeEnum.smartpack2 },
        { description: "SmartPack S", value: ControllerTypeEnum.smartpacks },
        { description: "SmartPack", value: ControllerTypeEnum.smartpack },
        { description: "SmartPack (MCF5235)", value: ControllerTypeEnum.mcf5235 },
        { description: "SmartPack (MCF5208)", value: ControllerTypeEnum.mcf5208 }

    ];
}
export function createPriorityList() {
    return [
        1,
        2,
        3,
        4,
        5
    ]
}

export function openNotificationDialog(modalService: BsModalService, settings): BsModalRef {
    settings.contents = [{ description: 'OK', value: true }];
    const initialState = { settings };
    return modalService.show(MsmDialogComponent, { initialState: initialState });
}

export function openConfirmDialog(modalService: BsModalService, settings): BsModalRef {
    settings.contents = [{ description: 'OK', value: true }, { description: 'Cancel', value: false }];
    const initialState = { settings };
    return modalService.show(MsmDialogComponent, { initialState: initialState });
}