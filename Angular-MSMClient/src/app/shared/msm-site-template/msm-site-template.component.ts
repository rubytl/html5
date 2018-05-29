import { Component } from '@angular/core';
import { TemplateService } from '../../services';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-site-template',
  templateUrl: './msm-site-template.component.html',
  styleUrls: ['./msm-site-template.component.scss']
})
export class MsmSiteTemplateComponent extends MsmTemplateComponent {
  templateSource: any;
  constructor(fb: FormBuilder, private templateService: TemplateService) {
    super(fb);
    this.onComponentLoaded();
  }

  private onComponentLoaded() {
    this.templateService.getTemplates()
      .then(res => this.templateSource = res);
  }
}
