import { Component, OnDestroy, Output, EventEmitter } from '@angular/core';
import { msmHelper } from '../../helpers';

@Component({
  selector: 'filter-type',
  templateUrl: './filter-type.component.html',
  styleUrls: ['./filter-type.component.scss']
})
export class FilterTypeComponent implements OnDestroy{

  filterTypes = msmHelper.createFilterTypeList();
  @Output() filterTypeChange = new EventEmitter<number>();
  selectedFilterType = this.filterTypes[0].value;

  ngOnDestroy()
  {
    this.filterTypeChange.unsubscribe();
  }

  updateFilterType() {
    this.filterTypeChange.next(this.selectedFilterType);
  }
}
