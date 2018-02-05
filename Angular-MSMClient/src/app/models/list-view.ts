export class ListView {
    id: number;
    controllerType: string = '';
    ipAddress: string = '';
    siteName: string = '';
    lastPooling: Date = null;
    noAlarm: number;
    noOffline: number;
    noWarning: number;
    offlineStatus: string = '';
    batteryVoltage: string = '';
    rectifierCurrent: string = '';
    loadCurrent: string = '';
    batteryTemperature: string = '';
    mainPhase1: string = '';
    solarCurrent: string = '';
    constructor(values: Object = {}) {
        Object.assign(this, values);
    }
}
