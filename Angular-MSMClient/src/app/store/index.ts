import { combineReducers } from 'redux';
import persistState from 'redux-localstorage';
import { siteReducer } from './site.reducer';
import { selectedSiteReducer } from './select-site.reducer';
import { Site } from '../models';

export class IAppState {
    sites?: Array<any>;
    selectedSite?: any;
};

export const INITIAL_STATE: IAppState = {
    sites: [],
    selectedSite: null
};

export const rootReducer = combineReducers<IAppState>({
    sites: siteReducer,
    selectedSite: selectedSiteReducer
});

export const enhancers = [
    persistState('sites', { key: 'ng2-redux' }),
    persistState('selectedSite', { key: 'ng2-redux' })
];
