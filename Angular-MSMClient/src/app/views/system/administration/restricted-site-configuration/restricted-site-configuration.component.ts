import { Component, Input, Output, EventEmitter } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
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
  @Output() valueChanged = new EventEmitter<any>();
  parentSiteForm: any;
  private siteGroups = [];

  constructor(modalService: BsModalService, ngRedux: NgRedux<IAppState>, private fb: FormBuilder) {
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
    let sites;
    if (this.sites && this.sites.length > 0) {
      sites = this.sites.map(site => this.fb.group(site));
    }
    else if (this.sites.length === undefined) {
      sites = this.sites.parentSiteSource.map(site => this.fb.group(site));
    }

    if (sites) {
      this.parentSiteForm.setControl('parentSiteSource', this.fb.array(sites));
    }
  }

  private onValueChanged(event, id) {
    this.valueChanged.next({
      isSelected: event.target.checked,
      id: id
    });
  }
}
