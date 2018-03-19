import { ViewChild, Component, OnInit, Input } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';

import { Site } from '../../models/site';
import { SiteActions, SelectSiteActions } from '../../actions';
import { IAppState } from '../../store';
import { SiteTreeViewComponent } from './site-tree-view.component';

@Component({
    selector: 'tree-view',
    template: '<site-tree-view [sites]="sites$ | async"></site-tree-view>'
})
export class TreeViewComponent implements OnInit {
    @select('sites') sites$: Observable<Site>;

    constructor(private siteAction: SiteActions) {
    }

    public ngOnInit() {
        this.siteAction.loadSites();
    }
}
