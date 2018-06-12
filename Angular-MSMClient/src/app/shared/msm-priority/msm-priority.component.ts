import { Component } from '@angular/core';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-priority',
  templateUrl: './msm-priority.component.html',
  styleUrls: ['./msm-priority.component.scss']
})

export class MsmPriorityComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
}
