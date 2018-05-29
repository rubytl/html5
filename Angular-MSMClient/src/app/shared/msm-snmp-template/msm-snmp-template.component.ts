import { Component } from '@angular/core';
import { SnmpConfigService } from '../../services';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-snmp-template',
  templateUrl: './msm-snmp-template.component.html',
  styleUrls: ['./msm-snmp-template.component.scss']
})
export class MsmSnmpTemplateComponent extends MsmTemplateComponent {
  snmpConfigSource: any;
  constructor(fb: FormBuilder, private snmpConfigService: SnmpConfigService) {
    super(fb);
    this.onComponentLoaded();
  }

  private onComponentLoaded() {
    this.snmpConfigService.getSnmpConfig()
      .then(res => this.snmpConfigSource = res);
  }
}
