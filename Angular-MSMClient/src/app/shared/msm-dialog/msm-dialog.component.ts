import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { Subject } from 'rxjs/Subject';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { DialogOption } from '../../models';

@Component({
  selector: 'msm-dialog',
  templateUrl: './msm-dialog.component.html',
  styleUrls: ['./msm-dialog.component.scss']
})
export class MsmDialogComponent implements OnInit, OnDestroy {

  @Input() settings: DialogOption;
  public onClose: Subject<boolean>;

  constructor(public bsModalRef: BsModalRef) {
  }

  public ngOnInit() {
    this.onClose = new Subject();
  }

  ngOnDestroy() {
    this.onClose.unsubscribe();
  }

  public onClick(content) {
    this.onClose.next(content.value);
    this.bsModalRef.hide();
  }
}
