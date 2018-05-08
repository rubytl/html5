import { constants } from '../actions/constants';
import { INITIAL_STATE } from './inital-state';

export function alarmInProgressReducer(state: boolean = INITIAL_STATE.alarmInProgress, action): boolean {
    switch (action.type) {
        case constants.ALARM_IN_PROGRESS:
            return state = action.payload;
        default:
            return state;
    }
}
