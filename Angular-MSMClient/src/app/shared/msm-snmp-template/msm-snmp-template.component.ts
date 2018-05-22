import { Component } from '@angular/core';
import { SnmpConfigService } from '../../services';
import { MsmTemplateComponent } from '../template.component';

@Component({
  selector: 'msm-snmp-template',
  templateUrl: './msm-snmp-template.component.html',
  styleUrls: ['./msm-snmp-template.component.scss']
})
export class MsmSnmpTemplateComponent extends MsmTemplateComponent {
  snmpConfigSource: any;
  constructor(private snmpConfigService: SnmpConfigService) {
    super();
  }

  protected onComponentInit() {
    this.snmpConfigService.getSnmpConfig()
      .then(res => this.snmpConfigSource = res);
  }
}
