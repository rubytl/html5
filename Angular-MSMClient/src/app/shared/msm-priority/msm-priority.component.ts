import { Component, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { treeHelper, msmHelper } from '../../helpers';

@Component({
  selector: 'msm-priority',
  templateUrl: './msm-priority.component.html',
  styleUrls: ['./msm-priority.component.scss']
})

export class MsmPriorityComponent implements OnDestroy {
  prioritySource = msmHelper.createPriorityList();
  @Output() priorityChange = new EventEmitter<number>();
  @Input() priority: number;

  ngOnDestroy() {
    this.priorityChange.unsubscribe();
  }

  onPriorityChanged() {
    this.priorityChange.next(this.priority);
  }
}
