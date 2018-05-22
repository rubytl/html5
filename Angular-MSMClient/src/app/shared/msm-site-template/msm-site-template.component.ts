import { Component } from '@angular/core';
import { TemplateService } from '../../services';
import { MsmTemplateComponent } from '../template.component';

@Component({
  selector: 'msm-site-template',
  templateUrl: './msm-site-template.component.html',
  styleUrls: ['./msm-site-template.component.scss']
})
export class MsmSiteTemplateComponent extends MsmTemplateComponent {
  templateSource: any;
  constructor(private templateService: TemplateService) {
    super();
  }

  protected onComponentInit() {
    this.templateService.getTemplates()
      .then(res => this.templateSource = res);
  }
}
