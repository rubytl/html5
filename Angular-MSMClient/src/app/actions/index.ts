import { SiteActions } from './site.actions';
import { SelectSiteActions } from './select-site.actions';
import { ProgressActions } from './progress.action';

const ACTION_PROVIDERS = [SiteActions, SelectSiteActions, ProgressActions];

export {
    SiteActions,
    SelectSiteActions,
    ProgressActions,
    ACTION_PROVIDERS
}