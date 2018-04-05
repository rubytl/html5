import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Sorting } from '../../models';

@Component({
  selector: 'msm-multi-sorting',
  templateUrl: './msm-multiple-sorting.component.html',
  styleUrls: ['./msm-multiple-sorting.component.scss']
})
export class MsmMultipleSortingComponent {

  @Output() sortOption = new EventEmitter<Sorting>();
  @Input() sortField: string;
  isAscSorting = false;
  isDescSorting = false;

  ascSort() {
    this.isAscSorting = true;
    this.isDescSorting = false;
    this.sortOption.emit({ sortField: this.sortField, sortDirection: 'asc' });
  }

  descSort() {
    this.isAscSorting = false;
    this.isDescSorting = true;
    this.sortOption.emit({ sortField: this.sortField, sortDirection: 'desc' });
  }
}