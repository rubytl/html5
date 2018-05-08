import { combineReducers } from 'redux';
import persistState from 'redux-localstorage';
import { siteReducer } from './site.reducer';
import { selectedSiteReducer } from './select-site.reducer';
import { inProgressReducer } from './progress.reducer';
import { IAppState } from './inital-state';
import { siteInProgressReducer } from './site-in-progress.reducer';
import { loginInProgressReducer } from './login-in-progress.reducer';
import { alarmInProgressReducer } from './alarm-in-progress.reducer';

export {
    IAppState
}

export const rootReducer = combineReducers<IAppState>({
    sites: siteReducer,
    selectedSite: selectedSiteReducer,
    inProgress: inProgressReducer,
    siteInProgress: siteInProgressReducer,
    loginInProgress: loginInProgressReducer,
    alarmInProgress: alarmInProgressReducer
});

export const enhancers = [
    persistState('sites', { key: 'ng2-redux' }),
    persistState('selectedSite', { key: 'ng2-redux' }),
    persistState('inProgress', { key: 'ng2-redux' }),
    persistState('siteInProgress', { key: 'ng2-redux' }),
    persistState('loginInProgress', { key: 'ng2-redux' }),
    persistState('alarmInProgress', { key: 'ng2-redux' }),
];
