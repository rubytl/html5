import { Component } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { BsModalService } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { SiteService, SnmpConfigService, SnmpDataService } from '../../../../services';
import { NewSiteComponent } from '../new-site/new-site.component';

@Component({
  selector: 'app-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteSource: any;
  snmpConfigSource: any;
  snmpDataConfigSource: any;

  constructor(private siteService: SiteService,
    private snmpConfigService: SnmpConfigService, private snmpDataService: SnmpDataService,
    private modalService: BsModalService, ngRedux: NgRedux<IAppState>
  ) {
    super(ngRedux);
  }

  ngOnInit() {
    super.ngOnInit();
    this.getSnmpConfigs();
    this.getSnmpDataConfigs();
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

  private getSnmpConfigs() {
    this.snmpConfigService.getSnmpConfig()
      .then(res => this.snmpConfigSource = res);
  }

  private getSnmpDataConfigs() {
    this.snmpDataService.getSnmpDataConfig()
      .then(res => this.snmpDataConfigSource = res);
  }

  onAddNewSite() {
    return this.modalService.show(NewSiteComponent);
  }
}
