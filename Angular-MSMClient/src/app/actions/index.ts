import { SiteActions } from './site.actions';
import { SelectSiteActions } from './select-site.actions';

const ACTION_PROVIDERS = [SiteActions, SelectSiteActions];

export {
    SiteActions,
    SelectSiteActions,
    ACTION_PROVIDERS,
};
