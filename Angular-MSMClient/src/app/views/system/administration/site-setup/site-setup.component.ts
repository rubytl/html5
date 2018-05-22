import { Component } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { BsModalService } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { SiteService } from '../../../../services';
import { NewSiteComponent } from '../new-site/new-site.component';
import { NewSiteGroupComponent } from '../new-group/new-group.component';

@Component({
  selector: 'app-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteSource: any;

  constructor(private siteService: SiteService, private modalService: BsModalService, ngRedux: NgRedux<IAppState>
  ) {
    super(ngRedux);
  }

  protected onSelectedSite(selectedSite) {
    this.siteIds = [];
    this.trarveChildren(selectedSite);
    this.getSiteByIds();
  }

  protected onAfterPageChanged() {
    this.getSiteByIds();
  }

  private getSiteByIds() {
    this.siteService.getSiteByIds(this.siteIds, this.paging.pageIndex, this.paging.pageSize)
      .then(res => this.siteSource = res);
  }

  onAddNewSite() {
    return this.modalService.show(NewSiteComponent);
  }

  onAddNewGroup() {
    return this.modalService.show(NewSiteGroupComponent);
  }
}
