import { constants } from '../actions/constants';
import { Site } from '../models/site';
import { INITIAL_STATE } from '../store';

export function selectedSiteReducer(state: any = INITIAL_STATE.selectedSite, action): Site {
    switch (action.type) {
        case constants.SELECT_SITE:
            return state = action.payload;
        default:
            return state;
    }
}
