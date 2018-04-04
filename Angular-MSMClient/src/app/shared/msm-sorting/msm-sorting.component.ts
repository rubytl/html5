import { Component, OnInit, Input, Output, EventEmitter, Directive, HostListener, ElementRef } from '@angular/core';
import { Sorting } from '../../models';

@Component({
  selector: 'msm-sorting',
  templateUrl: './msm-sorting.component.html',
  styleUrls: ['./msm-sorting.component.scss']
})
export class MsmSortingComponent implements OnInit {

  @Output() sortOption = new EventEmitter<Sorting>();
  @Input() sortField: string;

  ngOnInit() {
  }

  ascSort() {
    this.sortOption.emit({ sortField: this.sortField, sortDirection: 'asc' });
  }

  descSort() {
    this.sortOption.emit({ sortField: this.sortField, sortDirection: 'desc' });
  }
}

@Directive({
  selector: '[sortingToggle]'
})
export class SortingToggleDirective {

  constructor(private el: ElementRef) { }

  @HostListener('click', ['$event'])
  toggleOpen($event: any) {
    $event.preventDefault();
    var hElement: HTMLElement = this.el.nativeElement;
    var x = document.getElementsByName("asc");
    var y = document.getElementsByName("desc");
    var i;
    for (i = 0; i < x.length; i++) {
      x[i].classList.remove('open');
      y[i].classList.remove('open');      
    }

    hElement.classList.toggle('open');
  }
}