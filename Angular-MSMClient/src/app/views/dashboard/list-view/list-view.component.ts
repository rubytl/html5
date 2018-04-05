import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';
import 'rxjs/add/operator/catch';

import { ListView, Site } from '../../../models';
import { ListViewApiService } from '../../../services/list-view.service';
import { IAppState } from '../../../store';

import { RestrictedSiteApiService } from '../../../services';

@Component({
    selector: 'list-view',
    templateUrl: './list-view.component.html'
})

export class ListViewComponent implements OnInit, OnDestroy {
    selectSiteSub: Subscription;
    siteListViews: ListView[] = [];
    originalSiteViews: ListView[] = [];
    constructor(
        private listViewSVC: ListViewApiService,
        private ngRedux: NgRedux<IAppState>,
        private siteApiService: RestrictedSiteApiService
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
    }

    getAllSiteListView() {
        this.listViewSVC
            .getAllSites()
            .then(
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
                        this.siteApiService.getAllSites();
                    });
    }

}