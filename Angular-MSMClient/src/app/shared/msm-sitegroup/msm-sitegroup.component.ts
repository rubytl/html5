import { Component, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { treeHelper } from '../../helpers';

@Component({
  selector: 'msm-sitegroup',
  templateUrl: './msm-sitegroup.component.html',
  styleUrls: ['./msm-sitegroup.component.scss']
})
export class MsmSitegroupComponent implements OnDestroy {
  siteGroups = treeHelper.createSiteGroups();
  @Output() groupChange = new EventEmitter<number>();
  @Input() groupId: number;

  ngOnDestroy() {
    this.groupChange.unsubscribe();
  }

  onGroupChanged() {
    this.groupChange.next(this.groupId);
  }
}
