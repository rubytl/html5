import { Component, OnChanges } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { SiteService } from '../../../../services';
import { NewSiteComponent } from '../new-site/new-site.component';
import { NewSiteGroupComponent } from '../new-group/new-group.component';
import { Site } from '../../../../models';
import { msmHelper } from '../../../../helpers';

@Component({
  selector: 'app-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteForm: FormGroup;
  private originalSiteSource = [];
  private newSiteRef: BsModalRef;
  private onConfirmDialog: BsModalRef;
  private selectedRowIndex: number;
  private selectedSite: Site;
  private deletedSiteIds = [];
  private siteIds = [];
  constructor(private siteService: SiteService, private modalService: BsModalService,
    ngRedux: NgRedux<IAppState>, private fb: FormBuilder) {
    super(ngRedux);
  }

  // rebuild from if there are any changes
  ngOnChanges() {
    this.rebuildForm();
  }

  // add new site
  onAddNewSite() {
    this.newSiteRef = this.modalService.show(NewSiteComponent);
    this.newSiteRef.content.onClose.subscribe(result => {
      if (result) {
        this.siteSource.push(this.fb.group(result));
      }
    });
  }

  // add new site group
  onAddNewGroup() {
    return this.modalService.show(NewSiteGroupComponent);
  }

  // row click and get the appopriate index
  onRowClick(i) {
    this.selectedRowIndex = i;
  }

  // workflow when deleting a site
  onDeleteSite() {
    if (this.selectedRowIndex === undefined) {
      this.openNotificationDialog();
      return;
    }

    // Get site object from the form array
    // then do a search to find its children and grand child
    let site = this.siteSource.controls[this.selectedRowIndex].value;
    let siteIncludeChildren = this.findSiteIncludingChildren(this.selectedSite, site);
    let foundSiteIds = [];
    this.deletedSiteIds.push(foundSiteIds);
    this.trarveChildren(siteIncludeChildren, foundSiteIds);
    if (foundSiteIds.length > 1) {
      this.onConfirmDialog = this.openConfirmDialog(site.description);
      this.onConfirmDialog.content.onClose.subscribe(result => {
        if (result) {
          foundSiteIds.forEach(element => {
            this.siteSource.removeAt(this.siteSource.controls.findIndex(s => s.value.id === element));
          });
        }
      });
    }
    else {
      this.siteSource.removeAt(this.selectedRowIndex);
    }
  }

  // rebuild form if user reject changes
  onRejectChanges() {
    this.rebuildForm();
  }

  // handle workflow when user accept changes from the gui
  onSaveChanges() {
  }

  // get site source
  get siteSource(): FormArray {
    return this.siteForm.get('siteSource') as FormArray;
  }

  // called when component is inited
  protected onComponentInit() {
    this.createForm();
  }

  // remove event to prevent memory leak
  protected onComponentDestroy() {
    if (this.newSiteRef) {
      this.newSiteRef.content.onClose.unsubscribe();
    }

    if (this.onConfirmDialog) {
      this.onConfirmDialog.content.onClose.unsubscribe();
    }
  }

  // event called when site is selected from the tree view
  protected onSelectedSite(selectedSite) {
    this.selectedSite = selectedSite;
    this.siteIds = [];
    this.trarveChildren(selectedSite, this.siteIds);
    this.getSiteByIds();
  }

  // after page changed
  protected onAfterPageChanged() {
    this.getSiteByIds();
  }

  // get sites by ids
  private getSiteByIds() {
    this.siteService.getSiteByIds(this.siteIds, this.paging.pageIndex, this.paging.pageSize)
      .then(res => {
        this.originalSiteSource = res;
        this.rebuildForm();
      });
  }

  // create default form group
  private createForm() {
    this.siteForm = this.fb.group({
      name: 'hello',
      siteSource: this.fb.array([])
    });
  }

  // rebuild form if any changed
  private rebuildForm() {
    const sites = this.originalSiteSource.map(site => this.fb.group(site));
    const siteFormArray = this.fb.array(sites);
    this.siteForm.setControl('siteSource', siteFormArray);
  }

  // Open the confirm diaglog
  private openConfirmDialog(siteName) {
    let settings = { title: 'Delete Group?', message: siteName + " is a 'Group'. All sites within this group will be deleted. Delete anyway?" };
    return msmHelper.openConfirmDialog(this.modalService, settings);
  }

  // Open the confirm diaglog
  private openNotificationDialog() {
    let settings = { title: 'Delete Group?', message: "Please select a site to delete" };
    return msmHelper.openConfirmDialog(this.modalService, settings);
  }

  // find site including its children and grand child
  private findSiteIncludingChildren(source, site) {
    var i, found;
    if (site === null) {
      return null;
    }

    if (source.id === site.id) {
      return source;
    }
    else if (source.children != null) {
      for (i = 0; i < source.children.length; i += 1) {
        found = this.findSiteIncludingChildren(source.children[i], site);
        if (found) {
          return found;
        }
      }
    }
  }
}
