import { constants } from '../actions/constants';
import { INITIAL_STATE } from './inital-state';

export function loginInProgressReducer(state: boolean = INITIAL_STATE.loginInProgress, action): boolean {
    switch (action.type) {
        case constants.LOGIN_IN_PROGRESS:
            return state = action.payload;
        default:
            return state;
    }
}
