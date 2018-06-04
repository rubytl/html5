import { ViewChild, Component, OnInit, OnDestroy, Input } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Subscription } from 'rxjs/Subscription';
import { Observable } from 'rxjs/Observable';
import { Site } from '../../models/site';
import { SiteActions } from '../../actions';
import { IAppState } from '../../store';
import { treeHelper } from '../../helpers';
import { constants } from '../../actions/constants';

@Component({
    selector: 'tree-view',
    templateUrl: './tree-view.component.html',
    styleUrls: ['./tree-view.component.scss']
})
export class TreeViewComponent implements OnInit, OnDestroy {
    @select('sites') sites$: Observable<Site>;
    siteName = '';
    private filterType = 0;
    private siteBehaviorSub: Subscription;
    constructor(private ngRedux: NgRedux<IAppState>, private siteAction: SiteActions) {
    }

    ngOnInit() {
        this.siteAction.loadSites();
        this.siteBehaviorSub = this.ngRedux.select(state => state.editSite)
            .subscribe(editSite => {
                if (editSite === null) {
                    return;
                }
                else if (editSite.type === constants.ADD_SITE) {
                    treeHelper.addNewSite(editSite.value);
                }
                else if (editSite.type === constants.EDIT_SITE) {
                    treeHelper.updateSite(editSite.value);
                }
                else if (editSite.type === constants.DELETE_SITE) {
                    treeHelper.removeSite(editSite.value);
                }
            });
    }

    ngOnDestroy() {
        this.siteBehaviorSub.unsubscribe();
    }

    onFilterTypeChange(event) {
        this.filterType = event;
        this.siteAction.getFilteredSites(event, this.siteName);
    }

    onEnter() {
        this.siteAction.getFilteredSites(this.filterType, this.siteName);
    }
}
