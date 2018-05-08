import { constants } from '../actions/constants';
import { INITIAL_STATE } from './inital-state';

export function siteInProgressReducer(state: boolean = INITIAL_STATE.siteInProgress, action): boolean {
    switch (action.type) {
        case constants.SITE_IN_PROGRESS:
            return state = action.payload;
        default:
            return state;
    }
}
