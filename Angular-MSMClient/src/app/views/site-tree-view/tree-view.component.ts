import { ViewChild, Component, OnInit, Input } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';
import { Site } from '../../models/site';
import { SiteActions } from '../../actions';

@Component({
    selector: 'tree-view',
    templateUrl: './tree-view.component.html',
    styleUrls: ['./tree-view.component.scss']
})
export class TreeViewComponent implements OnInit {
    @select('sites') sites$: Observable<Site>;
    siteName = '';
    private filterType = 0;
    constructor(private siteAction: SiteActions) {
    }

    ngOnInit() {
        this.siteAction.loadSites();
    }

    onFilterTypeChange(event) {
        this.filterType = event;
        this.siteAction.getFilteredSites(event, this.siteName);
    }

    onEnter() {
        this.siteAction.getFilteredSites(this.filterType, this.siteName);
    }
}
