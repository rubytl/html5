import { Component } from '@angular/core';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-snmp-data-template',
  templateUrl: './msm-snmp-data-template.component.html',
  styleUrls: ['./msm-snmp-data-template.component.scss']
})
export class MsmSnmpDataTemplateComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
}
