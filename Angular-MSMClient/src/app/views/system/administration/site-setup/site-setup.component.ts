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
import { msmHelper, treeHelper } from '../../../../helpers';

@Component({
  selector: 'app-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteForm: FormGroup;
  private originalSiteSource = [];
  private selectedRowIndex: number;
  private selectedSite: Site;
  private deletedSiteIds = [];
  private deletedSites = [];
  private siteIds = [];
  private siteGroups = [];
  private siteChangedIds = [];
  constructor(private siteService: SiteService, modalService: BsModalService,
    ngRedux: NgRedux<IAppState>, private fb: FormBuilder) {
    super(ngRedux, modalService);
  }

  // rebuild form if there are any changes
  ngOnChanges() {
    this.rebuildForm();
  }

  // add new site
  onAddNewSite() {
    var newSiteRef = this.modalService.show(NewSiteComponent);
    this.onAfterAddingNewSite(newSiteRef);
  }

  // add new site group
  onAddNewGroup() {
    var newSiteRef = this.modalService.show(NewSiteGroupComponent);
    this.onAfterAddingNewSite(newSiteRef);
  }

  // row click and get the appopriate index
  onRowClick(i) {
    this.selectedRowIndex = i;
  }

  // workflow when deleting a site
  onDeleteSite() {
    if (this.selectedRowIndex === undefined) {
      this.openNotificationDialog('Delete Site?', "Please select a site to delete");
      return;
    }

    // Get site object from the form array
    // then do a search to find its children and grand 
    let site = this.siteSource.controls[this.selectedRowIndex].value;
    let siteIncludeChildren = this.findSiteIncludingChildren(this.selectedSite, site);
    let foundSiteIds = [];
    this.trarveChildren(siteIncludeChildren, foundSiteIds);
    let onConfirmDialog;
    if (foundSiteIds.length > 1) {
      onConfirmDialog = this.openConfirmDialog('Delete Group?', site.description + " is a 'Group'. All sites within this group will be deleted. Delete anyway?");
    }

    if (onConfirmDialog) {
      onConfirmDialog.content.onClose.subscribe(result => {
        if (result) {
          this.removeSites(foundSiteIds);
        }

        onConfirmDialog.content.onClose.unsubscribe();
      });
    }
    else {
      this.removeSites(foundSiteIds);
    }
  }

  private removeSites(foundSiteIds) {
    // call this method to notify changes up to the form
    this.selectedRowIndex = undefined;
    foundSiteIds.forEach(element => {
      this.deletedSiteIds.push(element);
      this.deletedSites.push(this.siteSource.controls.find(s => s.value.id === element).value);
      this.siteSource.removeAt(this.siteSource.controls.findIndex(s => s.value.id === element));
    });
  }

  // rebuild form if user reject changes
  onRejectChanges() {
    this.rebuildForm();
  }

  // handle workflow when user accept changes from the gui
  onSaveChanges() {
    // delete sites if any
    this.siteService.deleteSites(this.deletedSiteIds)
      .then(res => {
        treeHelper.removeSite(this.deletedSites);
        this.deletedSiteIds.forEach(id => this.removeItemAndUnsubById(this.siteGroups, id));
        this.updateLocalVariables();
      });

    //then save changes for updated data
    let siteChangeds = [];
    this.siteSource.value.forEach(element => {
      if (this.siteChangedIds.findIndex(s => s === element.id) !== -1) {
        siteChangeds.push(element);
      }
    });

    this.siteService.updateSites(siteChangeds)
      .then(res => {
        treeHelper.updateSite(siteChangeds);
        this.originalSiteSource = this.siteSource.value;
        this.openNotificationDialog('Success', 'Sites saved successfully');
      });
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
    this.siteGroupUnsubscribe();
  }

  // event called when site is selected from the tree view
  protected onSelectedSite(selectedSite) {
    this.selectedSite = selectedSite;
    this.siteIds = [];
    this.updateLocalVariables();
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
    this.siteGroupUnsubscribe();
    const sites = this.originalSiteSource.map(site => this.fb.group(site));
    const siteFormArray = this.fb.array(sites);
    this.siteForm.setControl('siteSource', siteFormArray);
    this.onSiteControlsChanges(sites);
  }

  private onSiteControlsChanges(siteGroup) {
    siteGroup.forEach(element => {
      this.siteGroups.push(element);
      element.valueChanges.subscribe(
        val => {
          if (this.siteChangedIds.findIndex(s => s === val.id) < 0) {
            this.siteChangedIds.push(val.id);
          }
        });
    });
  }

  // unsubscribe event changed from sitegroup
  private siteGroupUnsubscribe() {
    this.siteGroups.forEach(element => element.valueChanges.unsubscribe());
    this.siteGroups = [];
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

  private onAfterAddingNewSite(newSiteRef) {
    newSiteRef.content.onClose.subscribe(result => {
      if (result) {
        this.siteSource.push(this.fb.group(result));
      }

      newSiteRef.content.onClose.unsubscribe();
    });
  }

  private updateLocalVariables() {
    this.deletedSiteIds = [];
    this.deletedSites = [];
  }

  private removeItemAndUnsubById(arr, id) {
    if (arr === undefined || arr.length === 0) {
      return;
    }

    var index = arr.findIndex(s => s.get('id').value === id);
    if (index !== -1) {
      arr[index].valueChanges.unsubscribe();
      arr.splice(index, 1);
    }
  }
}
