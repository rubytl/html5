import { SiteActions } from './site.actions';
import { SelectSiteActions } from './select-site.actions';
import { ProgressActions } from './progress.action';
import { SiteInProgressActions } from './site-in-progress.action';
import { LoginInProgressActions } from './login-in-progress.action';
import { AlarmInProgressActions } from './alarm-in-progress.action';

const ACTION_PROVIDERS = [SiteActions, SelectSiteActions,
    ProgressActions, SiteInProgressActions,
    LoginInProgressActions, AlarmInProgressActions];

export {
    SiteActions,
    SelectSiteActions,
    ProgressActions,
    SiteInProgressActions,
    LoginInProgressActions,
    AlarmInProgressActions,
    ACTION_PROVIDERS
}