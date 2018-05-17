import { Component } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { SiteApiService } from '../../../../services';
import { treeHelper } from '../../../../helpers';

@Component({
  selector: 'app-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteSource: any;
  siteGroups = treeHelper.createSiteGroups();
  
  constructor(private siteService: SiteApiService, ngRedux: NgRedux<IAppState>
  ) {
    super(ngRedux);
  }

  ngOnInit() {
    super.ngOnInit();
  }
  
  onSelectedSite(selectedSite) {
    this.siteIds = [];
    this.trarveChildren(selectedSite);
    this.getSiteByIds();
  }

  onAfterPageChanged() {
    this.getSiteByIds();
  }

  getSiteByIds() {
    this.siteService.getSiteByIds(this.siteIds, this.paging.pageIndex, this.paging.pageSize)
      .then(res => this.siteSource = res);
  }
}
