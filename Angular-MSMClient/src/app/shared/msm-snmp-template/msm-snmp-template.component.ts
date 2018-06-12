import { Component } from '@angular/core';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-snmp-template',
  templateUrl: './msm-snmp-template.component.html',
  styleUrls: ['./msm-snmp-template.component.scss']
})
export class MsmSnmpTemplateComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
}
