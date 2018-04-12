import { Component, Input, Output, EventEmitter } from '@angular/core';
import { msmHelper } from '../../helpers';


@Component({
  selector: 'filter-type',
  templateUrl: './filter-type.component.html',
  styleUrls: ['./filter-type.component.scss']
})
export class FilterTypeComponent {

  filterTypes = msmHelper.createFilterTypeList();
  @Output() filterTypeChange = new EventEmitter<string>();
  selectedFilterType = this.filterTypes[0].description;

  constructor() { }

  updateFilterType() {
    this.filterTypeChange.next(this.selectedFilterType);
  }
}
