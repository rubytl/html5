import { combineReducers } from 'redux';
import persistState from 'redux-localstorage';
import { siteReducer } from './site.reducer';
import { selectedSiteReducer } from './select-site.reducer';
import { IAppState } from './inital-state';

export {
    IAppState
}

export const rootReducer = combineReducers<IAppState>({
    sites: siteReducer,
    selectedSite: selectedSiteReducer
});

export const enhancers = [
    persistState('sites', { key: 'ng2-redux' }),
    persistState('selectedSite', { key: 'ng2-redux' })
];
