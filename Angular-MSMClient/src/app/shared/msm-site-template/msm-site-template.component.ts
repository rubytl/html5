import { Component } from '@angular/core';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-site-template',
  templateUrl: './msm-site-template.component.html',
  styleUrls: ['./msm-site-template.component.scss']
})
export class MsmSiteTemplateComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
}
