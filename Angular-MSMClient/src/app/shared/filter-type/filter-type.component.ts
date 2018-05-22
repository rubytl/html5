import { Component } from '@angular/core';
import { msmHelper } from '../../helpers';
import { MsmTemplateComponent } from '../template.component';

@Component({
  selector: 'filter-type',
  templateUrl: './filter-type.component.html',
  styleUrls: ['./filter-type.component.scss']
})
export class FilterTypeComponent extends MsmTemplateComponent {
  filterTypes = msmHelper.createFilterTypeList();
  value = this.filterTypes[0].value;
}
