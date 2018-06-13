import { Component, OnInit, Input } from '@angular/core';
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
  batteryBackupTimeList = [];
  @Input() setting;
  templateSource;
  editTemplate;
  existingTemplate;
  constructor(bsModalRef: BsModalRef, private templateService: TemplateService,
    modelService: BsModalService, private dictionaryService: MsmDictionaryService) {
    super(bsModalRef, modelService);
  }

  onAddNewSite() {
    if (!this.editTemplate) {
      this.templateService.addNewTemplate(this.newTemplate)
        .then(res => {
          this.openNotificationDialog('Success', 'Template saved successfully');
        });
    }
    else {
      this.templateService.updateTemplate(this.newTemplate)
        .then(res => {
          this.openNotificationDialog('Success', 'Template saved successfully');
        });
    }
    this.onClick(this.newTemplate);
  }

  protected onComponentInit() {
    this.templateSource = this.setting.templateSource;
    this.editTemplate = this.setting.editTemplate;
    this.existingTemplate = this.setting.existingTemplate;
    this.createDefaultTemplate();
    if (!this.editTemplate) {
      this.templateService.getLastTemplateID().then(res => this.newTemplate.templateId = res);
    }

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

    // battery backup time list
    this.batteryBackupTimeList.push({ itemId: 20, itemName: '00:20' });
    this.batteryBackupTimeList.push({ itemId: 60, itemName: '01:00' });
    this.batteryBackupTimeList.push({ itemId: 120, itemName: '02:00' });
    this.batteryBackupTimeList.push({ itemId: 240, itemName: '04:00' });
    this.batteryBackupTimeList.push({ itemId: 480, itemName: '08:00' });
  }

  protected onParentTemplateChanged(event) {
    if (!event) {
      return;
    }

    let templateId = event.value;
    let existingTemplate = this.templateSource.find(s => s.itemId === templateId);
    if (existingTemplate && existingTemplate.data) {
      this.cloneTemplate(existingTemplate.data);
    }
    else {
      this.createDefaultTemplate();
    }
  }

  protected onValueChanged(event) {
    if (!event) {
      return;
    }
    if (event.name === 'mainsMonitorInstalled') {
      if (event.value === "0") {
        this.newTemplate.mainsMonitor = true;
        this.newTemplate.mainsMonitorOnSystem = true;
      }
      else if (event.value === "1") {
        this.newTemplate.mainsMonitor = false;
        this.newTemplate.mainsMonitorOnSystem = false;
      } else {
        this.newTemplate.mainsMonitor = true;
        this.newTemplate.mainsMonitorOnSystem = false;
      }
    }
  }

  private createDefaultTemplate() {
    if (!this.editTemplate) {
      // new template info
      this.newTemplate = {
        cloneTemplateId: '', templateName: '', mainsMonitorInstalled: 0, monitor1: '', monitor2: '', monitor3: '', monitor4: '', monitor5: '', monitor6: '',
        onGrid: false, mainsFractionTarget: null, solar: false, solarEnergyTarget: null, wind: false, windEnergyTarget: null,
        renewEnergyTarget: null, generator: false, genRunHourTarget: null, genEfficiencyTarget: null,
        peakLoadRange: '', averageLoadRange: '', battery: false, installedBatteryBackupTarget: 20,
        aveLoadResetInterval: null, batteryDischargeAh: null, overChargetTarget: null,
        mainsAvlTarget: null, connQualityTarget: null, connLossTarget: null,
        ioUnitWithEcbonSystem: false, ecbrunTimeTarget: null, airConRunTimeTarget: null
      };
    }
    else {
      // clone from existing template
      this.cloneTemplate(this.existingTemplate);
      this.newTemplate.templateId = this.existingTemplate.templateId;
    }
  }

  private cloneTemplate(template) {
    // new template info
    this.newTemplate = {
      cloneTemplateId: template.templateId, templateName: '', mainsMonitor: template.mainsMonitor, mainsMonitorOnSystem: template.mainsMonitorOnSystem,
      monitor1: template.monitor1, monitor2: template.monitor2, monitor3: template.monitor3,
      monitor4: template.monitor4, monitor5: template.monitor5, monitor6: template.monitor6,
      onGrid: template.onGrid, mainsFractionTarget: template.mainsFractionTarget, solar: template.solar,
      solarEnergyTarget: template.solarEnergyTarget, wind: template.wind, windEnergyTarget: template.windEnergyTarget,
      renewEnergyTarget: template.renewEnergyTarget, generator: template.generator,
      genRunHourTarget: template.genRunHourTarget, genEfficiencyTarget: template.genEfficiencyTarget,
      peakLoadRange: template.peakLoadRange, averageLoadRange: template.averageLoadRange,
      battery: template.battery, installedBatteryBackupTarget: template.installedBatteryBackupTarget,
      aveLoadResetInterval: template.aveLoadResetInterval, batteryDischargeAh: template.batteryDischargeAh, overChargetTarget: template.overChargetTarget,
      mainsAvlTarget: template.mainsAvlTarget, connQualityTarget: template.connQualityTarget, connLossTarget: template.connLossTarget,
      ioUnitWithEcbonSystem: template.ioUnitWithEcbonSystem, ecbrunTimeTarget: template.ecbrunTimeTarget, airConRunTimeTarget: template.airConRunTimeTarget
    };

    if (this.editTemplate) {
      this.newTemplate.templateName = template.templateName;
    }
    
    if (!template.mainsMonitor && !template.mainsMonitorOnSystem) {
      this.newTemplate.mainMonitorInstalled = "0";
    }
    else if (template.mainsMonitor && template.mainsMonitorOnSystem) {
      this.newTemplate.mainMonitorInstalled = "1";
    }
    else {
      this.newTemplate.mainMonitorInstalled = "2";
    }
  }
}
