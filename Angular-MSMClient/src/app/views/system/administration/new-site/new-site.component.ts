import { Component } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { SiteService } from '../../../../services';
import { Site } from '../../../../models';
import { ControllerTypeEnum } from '../../../../enums';
import { BsModalService } from 'ngx-bootstrap/modal';
import { msmHelper } from '../../../../helpers';

@Component({
  selector: 'msm-new-site',
  templateUrl: './new-site.component.html',
  styleUrls: ['./new-site.component.scss']
})
export class NewSiteComponent extends MsmDialogComponent {
  newSite: Site;
  constructor(bsModalRef: BsModalRef, private siteService: SiteService, private modelService: BsModalService) {
    super(bsModalRef);
  }

  protected onComponentInit() {
    this.newSite = new Site({ sitePriority: 3, controllerType: ControllerTypeEnum.smartpack, templateId: "0001", ssl: true, jsonUserName: 'Multisite', jsonPassword: "Ah83siO@kda%938kJdsA" });
    this.siteService.getLastSiteID().then(res => this.newSite.id = res + 1);
  }

  onAddNewSite() {
    this.siteService.addNewSite(this.newSite)
      .then(res => this.openConfirmDialog('Success', 'Site saved successfully'))
      .catch(ex => {
        var error = ex.error;
        if (error === 1) {
          this.openConfirmDialog('Error', "Site limit exceeded");
        }
        else if (error === 2) {
          this.openConfirmDialog('Error', "License invalid");
        }
        else if (error === 3) {
          this.openConfirmDialog('Error', "License expired");
        }
        else {
          this.openConfirmDialog('Error', "Site failed to check");
        }
      });

    this.onClick(null);
  }

  protected onValueChanged(event, name) {
    if (!event) {
      return;
    }
    if (name === 'parent') {
      this.newSite.parentId = event;
    }
    else if (name === 'controllerType') {
      this.newSite.controllerType = event;
    }
    else if (name === 'template') {
      this.newSite.templateId = event;
    }
    else if (name === 'snmpTemplate') {
      this.newSite.snmpTemplateId = event;
    }
    else if (name === 'snmpDataTemplate') {
      this.newSite.snmpDataTemplateId = event;
    }
  }

  // Open the confirm diaglog
  private openConfirmDialog(tittle, message) {
    let settings = { title: tittle, message: message };
    msmHelper.openConfirmDialog(this.modelService, settings);
  }
}
