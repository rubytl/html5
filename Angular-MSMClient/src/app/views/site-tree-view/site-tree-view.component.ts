import { ViewChild, Component, OnInit } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';

import { Site } from '../../models/site';
import { SiteActions, SelectSiteActions } from '../../actions';
import { IAppState } from '../../store';

@Component({
    selector: 'site-tree-view',
    templateUrl: './site-tree-view.component.html'
})
export class SiteTreeViewComponent implements OnInit {
    @select('sites') sites$: Observable<Site>;

    constructor(private siteAction: SiteActions,
        private SelectSiteAction: SelectSiteActions) {
    }

    public ngOnInit() {
        this.siteAction.loadSites();
    }

    chooseSite(site: Site) {
        this.SelectSiteAction.chooseSite(site);
    }
}
