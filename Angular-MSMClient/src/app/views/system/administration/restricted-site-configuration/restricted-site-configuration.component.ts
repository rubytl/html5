import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { SiteService } from '../../../../services';
import { siteParentTreeHelper } from '../../../../helpers';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { CommonComponent } from '../../../common/common.component';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../../../../store';

@Component({
  selector: 'restricted-site-tree-view',
  templateUrl: './restricted-site-configuration.component.html',
  styleUrls: ['./restricted-site-configuration.component.scss']
})
export class RestrictedSiteConfigurationComponent extends CommonComponent {
  @Input() sites;
  parentSiteForm: any;

  constructor(private siteService: SiteService, modalService: BsModalService,
    ngRedux: NgRedux<IAppState>, private fb: FormBuilder) {
    super(ngRedux, modalService);
    this.createForm();
  }

  // get site source
  get parentSiteSource(): FormArray {
    return this.parentSiteForm.get('parentSiteSource') as FormArray;
  }

  // rebuild form if there are any changes
  ngOnChanges() {
    this.rebuildForm();
  }

  // create default form group
  private createForm() {
    this.parentSiteForm = this.fb.group({
      parentSiteSource: this.fb.array([])
    });
  }

  // rebuild form if any changed
  private rebuildForm() {
    if (this.sites && this.sites.length > 0) {
      const sites = this.sites.map(site => this.fb.group(site));
      this.parentSiteForm.setControl('parentSiteSource', this.fb.array(sites));
    }
    else if (this.sites.length === undefined) {
      const sites = this.sites.parentSiteSource.map(site=>this.fb.group(site));
      this.parentSiteForm.setControl('parentSiteSource', this.fb.array(sites));
    }
  }
}
