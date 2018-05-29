import { Component } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { ListViewApiService } from '../../../services/list-view.service';
import { IAppState } from '../../../store';
import { CommonComponent } from '../../common/common.component';

@Component({
    selector: 'list-view',
    templateUrl: './list-view.component.html',
    styleUrls: ['./list-view.component.scss']
})

export class ListViewComponent extends CommonComponent {
    siteListViews: any;
    private siteIds = [];
    constructor(
        private listViewSVC: ListViewApiService,
        ngRedux: NgRedux<IAppState>
    ) {
        super(ngRedux);
    }

    ngOnInit() {
        super.ngOnInit();
        this.filterSiteView();
    }

    filterSiteView() {
        this.listViewSVC.getAllSitesView(this.siteIds, this.paging.pageIndex, this.paging.pageSize)
            .then(res => this.siteListViews = res);
    }

    onSelectedSite(selectedSite) {
        this.siteIds = [];
        this.trarveChildren(selectedSite, this.siteIds);
        this.filterSiteView();
    }

    onAfterPageChanged() {
        this.filterSiteView();
    }
}