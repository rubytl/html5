import { Component } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { NewSiteComponent } from '../new-site/new-site.component';
import { BsModalService } from 'ngx-bootstrap/modal';
import { SiteService } from '../../../../services';
import { EditSiteActions } from '../../../../actions';

@Component({
  selector: 'msm-new-group',
  templateUrl: './new-group.component.html',
  styleUrls: ['./new-group.component.scss']
})
export class NewSiteGroupComponent extends NewSiteComponent {
  constructor(bsModalRef: BsModalRef, siteService: SiteService,
    modelService: BsModalService, editSiteAction: EditSiteActions) {
    super(bsModalRef, siteService, modelService, editSiteAction);
  }
}
