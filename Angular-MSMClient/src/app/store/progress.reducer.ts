import { constants } from '../actions/constants';
import { INITIAL_STATE } from './inital-state';

export function inProgressReducer(state: boolean = INITIAL_STATE.inProgress, action): boolean {
    switch (action.type) {
        case constants.IN_PROGRESS:
            return state = action.payload;
        default:
            return state;
    }
}
