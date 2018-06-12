import { Component, OnInit } from '@angular/core';
import { MsmDialogComponent } from '../../dialog.component';
import { TemplateService, MsmDictionaryService } from '../../../../services';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'msm-new-site-template',
  templateUrl: './new-site-template.component.html',
  styleUrls: ['./new-site-template.component.scss']
})
export class NewSiteTemplateComponent extends MsmDialogComponent {
  newTemplate: any;
  monitorSource = [];
  mainMonitorInstalled = [];
  peakLoad = [];
  averageLoad = [];
  constructor(bsModalRef: BsModalRef, private templateService: TemplateService,
    modelService: BsModalService, private dictionaryService: MsmDictionaryService) {
    super(bsModalRef, modelService);
  }

  onAddNewSite() {
    this.templateService.addNewTemplate(this.newTemplate)
      .then(res => {
        if (res === 4) {
          this.openNotificationDialog('Success', 'Template saved successfully');
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

    this.onClick(this.newTemplate);
  }

  protected onComponentInit() {
    // get monitor list
    this.dictionaryService.getMsmDictionary()
      .then(res => {
        // monitor source
        this.monitorSource.push({ itemId: '', itemName: '' });
        this.monitorSource = this.monitorSource.concat(res.filter(s => s.itemId.includes("MO")));

        // peak load source
        this.peakLoad.push({ itemId: '', itemName: '' });
        this.peakLoad = this.peakLoad.concat(res.filter(s => s.itemId.includes("LR")));

        // average load source
        this.averageLoad.push({ itemId: '', itemName: '' });
        this.averageLoad = this.averageLoad.concat(res.filter(s => s.itemId.includes("LA")));
      });

    // get main monitor installed

    this.mainMonitorInstalled.push({ itemId: '0', itemName: 'No' });
    this.mainMonitorInstalled.push({ itemId: '1', itemName: 'Yes' });
    this.mainMonitorInstalled.push({ itemId: '2', itemName: 'Yes - excludes Grid, Power system' });
  }
}
