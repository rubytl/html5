export class IAppState {
    sites?: Array<any>;
    selectedSite?: any;
    inProgress?: boolean;
};

export const INITIAL_STATE: IAppState = {
    sites: [],
    selectedSite: null,
    inProgress: false
};