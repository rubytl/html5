import { Component } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { SiteService, TemplateService, SnmpConfigService, SnmpDataService } from '../../../../services';
import { treeHelper, msmHelper } from '../../../../helpers';

@Component({
  selector: 'app-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteSource: any;
  siteGroups = treeHelper.createSiteGroups();
  templateSource: any;
  snmpConfigSource: any;
  snmpDataConfigSource: any;
  controllerSource = msmHelper.createControllerTypeList();
  prioritySource = msmHelper.createPriorityList();
  
  constructor(private siteService: SiteService, private templateService: TemplateService,
    private snmpConfigService: SnmpConfigService, private snmpDataService: SnmpDataService, ngRedux: NgRedux<IAppState>
  ) {
    super(ngRedux);
  }

  ngOnInit() {
    super.ngOnInit();
    this.getTemplates();
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

  private getTemplates() {
    this.templateService.getTemplates()
      .then(res => this.templateSource = res);
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
}
