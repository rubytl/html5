import { Component, OnInit } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { Subject } from 'rxjs/Subject';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';

@Component({
  selector: 'app-new-site',
  templateUrl: './new-site.component.html',
  styleUrls: ['./new-site.component.scss']
})
export class NewSiteComponent extends CommonComponent {
  siteGroups: any;
  public onClose: Subject<boolean>;
  constructor(ngRedux: NgRedux<IAppState>, public bsModalRef: BsModalRef
  ) {
    super(ngRedux);
  }

  onComponentInit() {
    this.onClose = new Subject();
  }

  onComponentDestroy() {
    this.onClose.unsubscribe();
  }

  onClick(content) {
    this.onClose.next(content);
    this.bsModalRef.hide();
  }
}
