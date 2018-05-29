import { constants } from '../actions/constants';
import { Site } from '../models/site';
import { INITIAL_STATE } from './inital-state';

export function editSiteReducer(state: any = INITIAL_STATE.editSite, action): Site {
    switch (action.type) {
        case constants.ADD_SITE:
            return state = action.payload;
        default:
            return state;
    }
}
