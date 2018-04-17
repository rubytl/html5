import { ViewChild, Component, OnInit, Input } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { Site } from '../../models/site';
import { SiteActions, SelectSiteActions } from '../../actions';
import { IAppState } from '../../store';

@Component({
    selector: 'site-tree-view',
    templateUrl: './site-tree-view.component.html',
    styleUrls: ['./site-tree-view.component.scss']
})
export class SiteTreeViewComponent {
    @Input() sites: Observable<Site>;

    constructor(private siteAction: SiteActions,
        private SelectSiteAction: SelectSiteActions) {
    }

    chooseSite(site: Site) {
        this.SelectSiteAction.chooseSite(site);
    }
}
