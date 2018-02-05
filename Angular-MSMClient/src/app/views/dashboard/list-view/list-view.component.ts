import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';

import { ListView, Site } from '../../../models';
import { ListViewApiService } from '../../../services/list-view.service';
import { IAppState } from '../../../store';

@Component({
    selector: 'list-view',
    templateUrl: './list-view.component.html'
})

export class ListViewComponent implements OnInit, OnDestroy {
    selectSiteSub: Subscription;
    lvServiceSub: Subscription;
    siteListViews: ListView[] = [];
    originalSiteViews: ListView[] = [];
    constructor(
        private listViewSVC: ListViewApiService,
        private ngRedux: NgRedux<IAppState>
    ) {
    }

    ngOnInit() {
        this.getAllSiteListView();
        this.notifySelectedSite();
    }

    ngOnDestroy() {
        // prevent memory leak when component destroyed
        if (this.selectSiteSub) {
            this.selectSiteSub.unsubscribe();
        }

        if (this.lvServiceSub) {
            this.lvServiceSub.unsubscribe();
        }
    }

    getAllSiteListView() {
        this.lvServiceSub = this.listViewSVC
            .getAllSites()
            .subscribe(
            (sites) => {
                this.siteListViews = sites;
                this.originalSiteViews = sites;
            }
            );
    }

    getSiteListViewBySiteId(site: Site) {
        if (site == null) {
            return;
        }

        // Show all when the root node selected
        if (site.id === 0) {
            return this.siteListViews = this.originalSiteViews;
        }

        return this.siteListViews = this.originalSiteViews.filter(s => site.id === s.id);
    }

    notifySelectedSite() {
        this.selectSiteSub =
            this.ngRedux.select(state => state.selectedSite)
                .subscribe(
                selectedSite => {
                    this.getSiteListViewBySiteId(selectedSite);
                });
    }

}