import { Component } from '@angular/core';
import { msmHelper } from '../../helpers';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'filter-type',
  templateUrl: './filter-type.component.html',
  styleUrls: ['./filter-type.component.scss']
})
export class FilterTypeComponent extends MsmTemplateComponent {
  filterTypes = msmHelper.createFilterTypeList();
  constructor(fb: FormBuilder) {
    super(fb);
    this.templateForm = fb.group({ value: this.filterTypes[0].value });
  }
}
