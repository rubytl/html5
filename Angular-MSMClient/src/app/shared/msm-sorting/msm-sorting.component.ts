import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'msm-sorting',
  templateUrl: './msm-sorting.component.html',
  styleUrls: ['./msm-sorting.component.scss']
})
export class MsmSortingComponent implements OnInit {

  @Output() sortOption = new EventEmitter<string>();
  constructor() { }

  ngOnInit() {
  }

  ascSort() {
    this.sortOption.emit('asc');
  }

  descSort() {
    this.sortOption.emit('desc');
  }

}
