import { Component } from '@angular/core';
import { SnmpDataService } from '../../services';
import { MsmTemplateComponent } from '../template.component';

@Component({
  selector: 'msm-snmp-data-template',
  templateUrl: './msm-snmp-data-template.component.html',
  styleUrls: ['./msm-snmp-data-template.component.scss']
})
export class MsmSnmpDataTemplateComponent extends MsmTemplateComponent {
  snmpDataConfigSource: any;
  constructor(private snmpDataService: SnmpDataService) {
    super();
  }

  protected onComponentInit() {
    this.snmpDataService.getSnmpDataConfig()
      .then(res => this.snmpDataConfigSource = res);
  }
}
