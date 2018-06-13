import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { SiteService } from '../../../../services';
import { Site } from '../../../../models';
import { ControllerTypeEnum } from '../../../../enums';
import { msmHelper } from '../../../../helpers';
import { EditSiteActions } from '../../../../actions';

@Component({
  selector: 'msm-new-site',
  templateUrl: './new-site.component.html',
  styleUrls: ['./new-site.component.scss']
})
export class NewSiteComponent extends MsmDialogComponent {
  newSite: Site;
  @Input() setting: any;
  constructor(bsModalRef: BsModalRef, private siteService: SiteService,
    modelService: BsModalService, private editSiteAction: EditSiteActions) {
    super(bsModalRef, modelService);
  }

  protected onComponentInit() {
    this.newSite = new Site({
      id: null, parentId: null, sitePriority: 3, controllerType: ControllerTypeEnum.smartpack,
      address: '', templateId: "0001",
      latitude: '', longitude: '', snmpTemplateId: null, snmpDataTemplateId: '',
      ssl: true, jsonUserName: 'Multisite', jsonPassword: "Ah83siO@kda%938kJdsA"
    });
    this.siteService.getLastSiteID().then(res => this.newSite.id = res + 1);
  }

  onAddNewSite() {
    this.siteService.addNewSite(this.newSite)
      .then(res => {
        if (res === 4) {
          this.editSiteAction.addNewSite(this.newSite);
          this.openNotificationDialog('Success', 'Site saved successfully');
        }
      })
      .catch(ex => {
        var error = ex.error;
        if (error === 1) {
          this.openNotificationDialog('Error', "Max number of sites reached on this version.\nPlease contacts MSM support (MSM.Support@eltek.com)");
        }
        else if (error === 2) {
          this.openNotificationDialog('Error', "No valid license for MSM was found.\nPlease contacts MSM support (MSM.Support@eltek.com)");
        }
        else if (error === 3) {
          this.openNotificationDialog('Error', "License has been expired for MSM.\nPlease contacts MSM support (MSM.Support@eltek.com)");
        }
        else {
          this.openNotificationDialog('Error', "Failed to check if Site can be added or not.\nPlease contacts MSM support (MSM.Support@eltek.com)");
        }
      });

    this.onClick(this.newSite);
  }

  protected onValueChanged(event) {
    if (!event) {
      return;
    }
    
    if (event.name === 'parentId') {
      this.newSite.parentId = event.value;
    }
    else if (event.name === 'controllerType') {
      this.newSite.controllerType = event.value;
    }
    else if (event.name === 'templateId') {
      this.newSite.templateId = event.value;
    }
    else if (event.name === 'snmpTemplateId') {
      this.newSite.snmpTemplateId = event.value;
    }
    else if (event.name === 'snmpDataTemplateId') {
      this.newSite.snmpDataTemplateId = event.value;
    }
  }
}
