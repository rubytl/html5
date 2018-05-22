import { Component } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';

@Component({
  selector: 'msm-new-group',
  templateUrl: './new-group.component.html',
  styleUrls: ['./new-group.component.scss']
})
export class NewSiteGroupComponent extends MsmDialogComponent {
  constructor(bsModalRef: BsModalRef) {
    super(bsModalRef);
  }
}
