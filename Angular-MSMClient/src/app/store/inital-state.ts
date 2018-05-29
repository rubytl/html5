export class IAppState {
    sites?: Array<any>;
    selectedSite?: any;
    editSite?: any;
    inProgress?: boolean;
    siteInProgress?: boolean;
    loginInProgress?: boolean;
    alarmInProgress?: boolean;
};

export const INITIAL_STATE: IAppState = {
    sites: [],
    selectedSite: null,
    editSite: null,
    inProgress: false,
    siteInProgress: false,
    loginInProgress: false,
    alarmInProgress: false
};