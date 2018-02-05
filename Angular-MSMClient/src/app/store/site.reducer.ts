import { constants } from '../actions/constants';
import { Site } from '../models/site';
import { INITIAL_STATE } from '../store';

export function siteReducer(state: Array<any> = INITIAL_STATE.sites, action): Array<Site> {
    switch (action.type) {
        case constants.LOAD_SITE:
            return state = action.payload;
        case constants.ADD_SITE:
            return state.concat(action.payload);
        case constants.EDIT_SITE:
            Object.assign({}, state, {
                state: state.map((site, index) => {
                    if (site.id === action.id) {
                        site = action.payload
                    }
                    return site;
                })
            });
            return state;
        case constants.DELETE_SITE:
            return state.filter(site => site.id !== action.id);
        default:
            return state;
    }
}
