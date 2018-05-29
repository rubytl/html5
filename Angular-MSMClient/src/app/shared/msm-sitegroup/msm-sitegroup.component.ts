import { Component } from '@angular/core';
import { treeHelper } from '../../helpers';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'msm-sitegroup',
  templateUrl: './msm-sitegroup.component.html',
  styleUrls: ['./msm-sitegroup.component.scss']
})
export class MsmSitegroupComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
  
  siteGroups = treeHelper.createSiteGroups();
}
