import { Component, Input, Output, EventEmitter } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { CommonComponent } from '../../../common/common.component';
import { NgRedux } from 'ng2-redux';
import { IAppState } from '../../../../store';
import { siteParentTreeHelper } from '../../../../helpers';

@Component({
  selector: 'restricted-site-tree-view',
  templateUrl: './restricted-site-configuration.component.html',
  styleUrls: ['./restricted-site-configuration.component.scss']
})
export class RestrictedSiteConfigurationComponent extends CommonComponent {
  @Input() sites;
  @Input() parentId;
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
    if (this.sites && this.sites.length > 0) {
      let sites = siteParentTreeHelper.listToTree(this.sites, this.fb);
      this.parentSiteForm.setControl('parentSiteSource', this.fb.array(sites));
    }
    else if (this.sites.length === undefined) {
      let mappedElement = siteParentTreeHelper.findChildrenMapping(this.parentId);
      this.parentSiteForm.setControl('parentSiteSource', mappedElement.controls.children.controls.parentSiteSource);
    }
  }

  private onValueChanged(event, site) {
    let isSelected = event.target.checked;
    this.valueChanged.next({
      isSelected: isSelected,
      id: site.value.id
    });

    if (site.value.children) {
      site.controls.children.controls.parentSiteSource.controls.forEach(element => {
        element.patchValue({ isSelected: isSelected });
        this.onValueChanged(event, element);
      });
    }
  }
}
