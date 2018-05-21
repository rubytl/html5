import { Component, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { treeHelper, msmHelper } from '../../helpers';

@Component({
  selector: 'msm-controller-type',
  templateUrl: './msm-controller-type.component.html',
  styleUrls: ['./msm-controller-type.component.scss']
})
export class MsmControllerTypeComponent implements OnDestroy {

  controllerSource = msmHelper.createControllerTypeList();
  @Output() controllerChange = new EventEmitter<number>();
  @Input() controller: number;

  ngOnDestroy() {
    this.controllerChange.unsubscribe();
  }

  onControllerChanged() {
    this.controllerChange.next(this.controller);
  }
}
