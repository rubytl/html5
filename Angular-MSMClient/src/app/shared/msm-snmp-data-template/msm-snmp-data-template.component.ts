import { Component } from '@angular/core';
import { SnmpDataService } from '../../services';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-snmp-data-template',
  templateUrl: './msm-snmp-data-template.component.html',
  styleUrls: ['./msm-snmp-data-template.component.scss']
})
export class MsmSnmpDataTemplateComponent extends MsmTemplateComponent {
  snmpDataConfigSource: any;
  constructor(fb: FormBuilder, private snmpDataService: SnmpDataService) {
    super(fb);
    this.onComponentLoaded();
  }

  private onComponentLoaded() {
    this.snmpDataService.getSnmpDataConfig()
      .then(res => this.snmpDataConfigSource = res);
  }
}
