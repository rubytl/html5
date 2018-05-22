import { Component } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';

@Component({
  selector: 'msm-new-site',
  templateUrl: './new-site.component.html',
  styleUrls: ['./new-site.component.scss']
})
export class NewSiteComponent extends MsmDialogComponent {
  constructor(bsModalRef: BsModalRef) {
    super(bsModalRef);
  }
}
