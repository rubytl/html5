import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { Subscription } from 'rxjs/Subscription';
import 'rxjs/add/operator/catch';
import { BehaviorSubject } from 'rxjs/Rx';
import { Paging, Sorting } from '../../models'
import { IAppState } from '../../store';

export class CommonComponent implements OnInit, OnDestroy {
    selectSiteSub: Subscription;
    siteListViews: any;
    paging: Paging;
    pageIndexSubject: BehaviorSubject<number> = new BehaviorSubject<number>(0);
    constructor(private ngRedux: NgRedux<IAppState>) {
    }

    ngOnInit() {
        this.onComponentInit();
        this.paging = { pageSize: 10, pageIndex: 0, pageLength: 10 };
        this.pageIndexSubject.subscribe(value => this.paging.pageIndex = value);
        this.notifySelectedSite();
    }

    ngOnDestroy() {
        this.onComponentDestroy();
        // prevent memory leak when component destroyed
        this.selectSiteSub.unsubscribe();
        this.pageIndexSubject.unsubscribe();
    }

    private notifySelectedSite() {
        this.selectSiteSub =
            this.ngRedux.select(state => state.selectedSite)
                .subscribe(
                    selectedSite => {
                        this.onSelectedSite(selectedSite);
                    });
    }

    private onCurrentPageChange(event) {
        this.paging.pageIndex = event;
        this.onAfterPageChanged();
    }

    private onPageSizeChange(event) {
        this.paging.pageSize = event;
        this.onAfterPageChanged();
        this.pageIndexSubject.next(0);
    }

    // base method to handle component init
    protected onComponentInit() {
    }

    // base method to handle component destroy
    protected onComponentDestroy() {
    }

    // base method to handle data after page changed
    protected onAfterPageChanged() {
    }

    // base method to handle data after selected site changed
    protected onSelectedSite(selectedSite) {
        return selectedSite;
    }

    protected trarveChildren(site, siteIds) {
        if (site === null) {
            return;
        }

        siteIds.push(site.id);
        if (site.children != null) {
            site.children.forEach(element => {
                this.trarveChildren(element, siteIds);
            });
        }
    }
}