
import { Component } from '@angular/core';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-monitor',
  templateUrl: './msm-monitor.component.html',
  styleUrls: ['./msm-monitor.component.scss']
})
export class MsmMonitorComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
}
