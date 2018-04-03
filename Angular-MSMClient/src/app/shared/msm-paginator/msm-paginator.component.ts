import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'msm-paginator',
  templateUrl: './msm-paginator.component.html',
  styleUrls: ['./msm-paginator.component.scss']
})
export class MsmPaginatorComponent implements OnInit {

  @Input() pageSizeOptions: any;

  @Input() pageLength: number;

  @Input() pageIndex: number;
  constructor() { }

  ngOnInit() {
  }

  @Output() pageSizeChange = new EventEmitter<any>();
  @Output() currentPageChange = new EventEmitter<any>();

  onPageSizeChange(event: Event) {
    const value: string = (<HTMLSelectElement>event.srcElement).value;
    this.pageSizeChange.emit(value);
  }

  lastPage() {
    this.pageIndex = this.pageLength - 1;
    this.currentPageChange.emit(this.pageIndex);
  }

  startPage() {
    this.pageIndex = 0;
    this.currentPageChange.emit(this.pageIndex);
  }

  increment() {
    if (this.pageIndex == this.pageLength - 1) {
      return;
    }

    this.pageIndex++;
    this.currentPageChange.emit(this.pageIndex);
  }

  decrement() {
    if (this.pageIndex == 0) {
      return;
    }

    this.pageIndex--;
    this.currentPageChange.emit(this.pageIndex);
  }
}
