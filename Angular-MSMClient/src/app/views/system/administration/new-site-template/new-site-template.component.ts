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
      return this.templateService.addNewTemplate(this.newTemplate)
        .then(res => {
          if (res) {
            this.openNotificationDialog('Success', 'Template saved successfully');
            this.onClick(this.newTemplate);
          }
          else {
            this.onClick(null)
          }
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
      this.templateService.getLastTemplateID().then(
        res => this.newTemplate.templateId = res.value);
    }

    // get monitor list
    this.dictionaryService.getMsmDictionary()
      .then(res => {
        // monitor source
        this.monitorSource.push({ itemId: null, itemName: null });
        this.monitorSource = this.monitorSource.concat(res.filter(s => s.itemId.includes("MO")));

        // peak load source
        this.peakLoad.push({ itemId: null, itemName: null });
        this.peakLoad = this.peakLoad.concat(res.filter(s => s.itemId.includes("LR")));

        // average load source
        this.averageLoad.push({ itemId: null, itemName: null });
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
      let templateId = this.newTemplate.templateId;
      this.createDefaultTemplate();
      this.newTemplate.templateId = templateId;
    }
  }

  protected onValueChanged(event) {
    if (!event) {
      return;
    }

    if (event.name === 'mainsMonitorInstalled') {
      if (event.value === "1") {
        this.newTemplate.mainsMonitor = true;
        this.newTemplate.mainsMonitorOnSystem = true;
      }
      else if (event.value === "0") {
        this.newTemplate.mainsMonitor = false;
        this.newTemplate.mainsMonitorOnSystem = false;
      } else {
        this.newTemplate.mainsMonitor = true;
        this.newTemplate.mainsMonitorOnSystem = false;
      }
    } else if (event.value) {
      if (event.name === 'monitor1') {
        this.newTemplate.monitor1 = event.value;
      }
      else if (event.name === 'monitor2') {
        this.newTemplate.monitor2 = event.value;
      }
      else if (event.name === 'monitor3') {
        this.newTemplate.monitor3 = event.value;
      }
      else if (event.name === 'monitor4') {
        this.newTemplate.monitor4 = event.value;
      }
      else if (event.name === 'monitor5') {
        this.newTemplate.monitor5 = event.value;
      }
      else if (event.name === 'monitor6') {
        this.newTemplate.monitor6 = event.value;
      }
      else if (event.name === 'peakLoadRange') {
        this.newTemplate.peakLoadRange = event.value;
      }
      else if (event.name === 'averageLoadRange') {
        this.newTemplate.averageLoadRange = event.value;
      }
    }
    else if (event.name === 'installedBatteryBackupTarget') {
      this.newTemplate.installedBatteryBackupTarget = event.value;
    }
  }

  private createDefaultTemplate() {
    if (!this.editTemplate) {
      // new template info
      this.newTemplate = {
        cloneTemplateId: '', templateId: '', templateName: '', mainsMonitorInstalled: '0',
        monitor1: null, monitor2: null, monitor3: null, monitor4: null, monitor5: null, monitor6: null,
        onGrid: false, mainsFractionTarget: null, solar: false, solarEnergyTarget: null, wind: false, windEnergyTarget: null,
        renewEnergyTarget: null, generator: false, genRunHourTarget: null, genEfficiencyTarget: null,
        peakLoadRange: null, averageLoadRange: null, battery: false, installedBatteryBackupTarget: 20,
        aveLoadResetInterval: null, batteryDischargeAh: null, overChargetTarget: null,
        mainsAvlTarget: null, connQualityTarget: null, connLossTarget: null,
        ioUnitWithEcbonSystem: false, ecbrunTimeTarget: null, airConRunTimeTarget: null
      };
    }
    else {
      // clone from existing template
      this.cloneTemplate(this.existingTemplate);
    }
  }

  private cloneTemplate(template) {
    let templateId = this.editTemplate ? this.existingTemplate.templateId : this.newTemplate.templateId;
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
      this.newTemplate.templateId = templateId;
      this.newTemplate.templateName = template.templateName;
    }
    else {
      this.newTemplate.templateId = templateId;
    }

    if (!template.mainsMonitor && !template.mainsMonitorOnSystem) {
      this.newTemplate.mainsMonitorInstalled = '0';
    }
    else if (template.mainsMonitor && template.mainsMonitorOnSystem) {
      this.newTemplate.mainsMonitorInstalled = '1';
    }
    else {
      this.newTemplate.mainsMonitorInstalled = '2';
    }
  }
}
