import { ViewChild, Component, OnInit, Input } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';

import { Site } from '../../models/site';
import { SiteActions, SelectSiteActions } from '../../actions';
import { IAppState } from '../../store';
import { SiteTreeViewComponent } from './site-tree-view.component';

@Component({
    selector: 'tree-view',
    templateUrl: './tree-view.component.html',
    styleUrls: ['./tree-view.component.scss']
})
export class TreeViewComponent implements OnInit {
    @select('sites') sites$: Observable<Site>;
    siteName = '';
    constructor(private siteAction: SiteActions) {
    }

    public ngOnInit() {
        this.siteAction.loadSites();
    }

    onFilterTypeChange(event) {
    }

    onEnter() {

    }
}
