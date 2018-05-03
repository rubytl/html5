import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';
import 'rxjs/add/operator/catch';
import { BehaviorSubject } from 'rxjs/Rx';

import { ListView, Site } from '../../../models';
import { ListViewApiService } from '../../../services/list-view.service';
import { IAppState } from '../../../store';
import { Paging, Sorting } from '../../../models'

import { RestrictedSiteApiService } from '../../../services';

@Component({
    selector: 'list-view',
    templateUrl: './list-view.component.html',
    styleUrls: ['./list-view.component.scss']
})

export class ListViewComponent implements OnInit, OnDestroy {
    selectSiteSub: Subscription;
    siteListViews: any;
    paging: Paging;
    pageIndexSubject: BehaviorSubject<number> = new BehaviorSubject<number>(0);
    siteIds = [];
    constructor(
        private listViewSVC: ListViewApiService,
        private ngRedux: NgRedux<IAppState>
    ) {
    }

    ngOnInit() {
        this.paging = { pageSize: 10, pageIndex: 0, pageLength: 10 };
        this.pageIndexSubject.subscribe(value => this.paging.pageIndex = value);
        this.filterSiteView();
        this.notifySelectedSite();
    }

    ngOnDestroy() {
        // prevent memory leak when component destroyed
        this.selectSiteSub.unsubscribe();
        this.pageIndexSubject.unsubscribe();
    }

    async filterSiteView() {
        await this.listViewSVC.getAllSitesView(this.siteIds, this.paging.pageIndex, this.paging.pageSize)
            .then(res => this.siteListViews = res);
    }

    onCurrentPageChange(event) {
        this.paging.pageIndex = event;
        this.filterSiteView();
    }

    onPageSizeChange(event) {
        this.paging.pageSize = event;
        this.filterSiteView();
        this.pageIndexSubject.next(0);
    }

    private trarveChildren(site: Site) {
        if (site === null) {
            return;
        }

        this.siteIds.push(site.id);
        if (site.children != null) {
            site.children.forEach(element => {
                this.siteIds.push(element.id);
                this.trarveChildren(element);
            });
        }
    }

    notifySelectedSite() {
        this.selectSiteSub =
            this.ngRedux.select(state => state.selectedSite)
                .subscribe(
                    selectedSite => {
                        this.siteIds = [];
                        this.trarveChildren(selectedSite);
                        this.filterSiteView();
                    });
    }

}