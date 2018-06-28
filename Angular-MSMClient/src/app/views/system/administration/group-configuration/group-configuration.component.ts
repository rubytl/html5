import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { SiteService } from '../../../../services';
import { siteParentTreeHelper } from '../../../../helpers';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-group-configuration',
  templateUrl: './group-configuration.component.html',
  styleUrls: ['./group-configuration.component.scss']
})
export class GroupConfigurationComponent extends MsmDialogComponent {
  @Input() setting: any;
  parentSites: any;
  siteForm: FormGroup;
  constructor(bsModalRef: BsModalRef, private siteService: SiteService,
    modelService: BsModalService, private fb: FormBuilder) {
    super(bsModalRef, modelService);
  }

  ngOnChanges() {
    this.rebuildForm();
  }

  rebuildForm() {
    if (this.parentSites && this.parentSites.length > 0) {
      this.siteForm.setControl('siteSource', this.fb.array(siteParentTreeHelper.listToTree(this.parentSites, this.fb)));
    }
  }

  // get site source
  get siteSource(): FormArray {
    return this.siteForm.get('siteSource') as FormArray;
  }

  protected onComponentInit() {
    this.createForm();
    this.siteService.getParents()
      .then(res => {
        this.parentSites = res;
        this.rebuildForm();
      });
  }

  // create default form group
  private createForm() {
    this.siteForm = this.fb.group({
      siteSource: this.fb.array([])
    });
  }

  private onSelectGroup(event) {
    this.siteService.getSitesByGroupId(event.itemId)
      .then(res => {
        this.trarveChildren(this.siteSource, res.map(s => s.id));
      });
  }

  protected trarveChildren(siteSource, siteIds) {
    if (siteSource === null) {
      return;
    }

    siteSource.controls.forEach(element => {
      if (siteIds.includes(element.value.id)) {
        element.patchValue({ isSelected: true });
      }

      if (element.value.children !== null) {
        this.trarveChildren(element.controls.children.controls.parentSiteSource, siteIds);
      }
    });
  }
}
