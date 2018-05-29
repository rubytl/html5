import { SiteActions } from './site.actions';
import { SelectSiteActions } from './select-site.actions';
import { ProgressActions } from './progress.action';
import { SiteInProgressActions } from './site-in-progress.action';
import { LoginInProgressActions } from './login-in-progress.action';
import { AlarmInProgressActions } from './alarm-in-progress.action';
import { EditSiteActions } from './edit-site.actions';

const ACTION_PROVIDERS = [SiteActions, SelectSiteActions,
    EditSiteActions,
    ProgressActions, SiteInProgressActions,
    LoginInProgressActions, AlarmInProgressActions];

export {
    SiteActions,
    SelectSiteActions,
    EditSiteActions,
    ProgressActions,
    SiteInProgressActions,
    LoginInProgressActions,
    AlarmInProgressActions,
    ACTION_PROVIDERS
}