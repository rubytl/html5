export class IAppState {
    sites?: Array<any>;
    selectedSite?: any;
};

export const INITIAL_STATE: IAppState = {
    sites: [],
    selectedSite: null
};