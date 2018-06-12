import { Component, OnChanges } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { BsModalService } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { SiteService, SnmpConfigService, SnmpDataService, TemplateService } from '../../../../services';
import { NewSiteComponent } from '../new-site/new-site.component';
import { NewSiteGroupComponent } from '../new-group/new-group.component';
import { Site } from '../../../../models';
import { msmHelper, treeHelper } from '../../../../helpers';
import { EditSiteActions } from '../../../../actions';

@Component({
  selector: 'msm-site-setup',
  templateUrl: './site-setup.component.html',
  styleUrls: ['./site-setup.component.scss']
})
export class SiteSetupComponent extends CommonComponent {
  siteForm: FormGroup;
  snmpConfigSource;
  snmpDataConfigSource;
  templateSource;
  parentSites = treeHelper.createSiteGroups();
  controllerSource = msmHelper.createControllerTypeList();
  prioritySource = msmHelper.createPriorityList();
  private originalSiteSource = [];
  private selectedRowIndex: number;
  private selectedSite = null;
  private deletedSiteIds = [];
  private deletedSites = [];
  private siteIds = [];
  private siteGroups = [];
  private siteChangedIds = [];
  constructor(private siteService: SiteService, modalService: BsModalService,
    ngRedux: NgRedux<IAppState>, private fb: FormBuilder, private editSiteAction: EditSiteActions,
    private snmpConfigService: SnmpConfigService, private snmpDataService: SnmpDataService,
    private templateService: TemplateService) {
    super(ngRedux, modalService);
  }

  // rebuild form if there are any changes
  ngOnChanges() {
    this.rebuildForm();
  }

  // add new site
  onAddNewSite() {
    let setting = {
      snmpConfigSource: this.snmpConfigSource, snmpDataConfigSource: this.snmpDataConfigSource,
      templateSource: this.templateSource, parentSites: this.parentSites, controllerSource: this.controllerSource
    };
    var newSiteRef = this.modalService.show(NewSiteComponent, { initialState: { setting } });
    this.onAfterAddingNewSite(newSiteRef);
  }

  // add new site group
  onAddNewGroup() {
    let setting = { parentSites: this.parentSites };
    var newSiteRef = this.modalService.show(NewSiteGroupComponent, { initialState: { setting } });
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
    if (siteIncludeChildren) {
      this.trarveChildren(siteIncludeChildren, foundSiteIds);
    }
    else {
      foundSiteIds.push(site.id);
    }

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
    this.siteForm.markAsDirty();
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
        this.editSiteAction.deleteSites(this.deletedSites);
        this.deletedSiteIds.forEach(id => this.removeItemAndUnsubById(this.siteGroups, id));
        this.updateLocalVariables();
      });

    //then save changes for updated data
    let siteChangeds = [];
    let siteNameUnSaveds = '';
    this.siteSource.value.forEach(element => {
      if (this.siteChangedIds.findIndex(s => s === element.id) !== -1) {
        if (this.checkIfParentIdInUse(element)) {
          siteChangeds.push(element);
        }
        else {
          siteNameUnSaveds += element.description + ", ";
        }
      }
    });

    this.siteService.updateSites(siteChangeds)
      .then(res => {
        this.editSiteAction.updateSite(siteChangeds);
        this.originalSiteSource = this.siteSource.value;
        if (siteNameUnSaveds.length > 0) {
          this.rebuildForm();
          this.openNotificationDialog('Notification', "These sites:' " + siteNameUnSaveds + "' are not be saved because they are in use as site group in other places");
        }
        else {
          this.openNotificationDialog('Success', 'Sites saved successfully');
        }
      });
  }

  // get site source
  get siteSource(): FormArray {
    return this.siteForm.get('siteSource') as FormArray;
  }

  // called when component is inited
  protected onComponentInit() {
    this.createForm();
    this.getSites();
    this.getdataTemplates();
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
    this.getSites();
  }

  // after page changed
  protected onAfterPageChanged() {
    this.getSites();
  }

  private getSites() {
    if (this.siteIds.length === 0) {
      this.getSitePaging();
    }
    else {
      this.getSiteByIds();
    }
  }

  // get sites by ids
  private getSitePaging() {
    this.siteService.getSitePaging(this.paging.pageIndex, this.paging.pageSize)
      .then(res => {
        this.originalSiteSource = res;
        this.rebuildForm();
      });
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

  private onValueChanged(event) {
    this.siteForm.markAsDirty();
    this.updateItemById(this.siteSource.value, event);
    if (this.siteChangedIds.findIndex(s => s === event.id) < 0) {
      this.siteChangedIds.push(event.id);
    }
  }

  // unsubscribe event changed from sitegroup
  private siteGroupUnsubscribe() {
    this.siteGroups.forEach(element => element.valueChanges.unsubscribe());
    this.siteGroups = [];
  }

  // find site including its children and grand child
  private findSiteIncludingChildren(source, site) {
    var i, found;
    if (site === null || source === null) {
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

  private updateItemById(arr, event) {
    if (arr === undefined || arr.length === 0) {
      return;
    }

    var index = arr.findIndex(s => s.id === event.id);
    if (index !== -1) {
      var site = arr[index];
      if (event.name === 'sitePriority') {
        site.sitePriority = event.value;
      }
      else if (event.name === 'controllerType') {
        site.controllerType = event.value;
      }
      else if (event.name === 'parentId') {
        site.oldParentId = site.parentId;
        site.parentId = event.value;
      }
      else if (event.name === 'templateId') {
        site.templateId = event.value;
      }
      else if (event.name === 'snmpTemplateId') {
        site.snmpTemplateId = event.value;
      }
      else if (event.name === 'snmpDataTemplateId') {
        site.snmpDataTemplateId = event.value;
      }
    }
  }

  private checkIfParentIdInUse(site) {
    let existingSite = this.originalSiteSource.find(s => s.id === site.id);
    if (existingSite !== undefined) {
      if (existingSite.address !== site.address &&
        this.originalSiteSource.findIndex(s => s.parentId === site.id) !== -1) {
        site.address = existingSite.address;
        return false;
      }
    }

    return true;
  }

  private getdataTemplates() {
    this.snmpConfigService.getSnmpConfig()
      .then(res => this.snmpConfigSource = res);
    this.snmpDataService.getSnmpDataConfig()
      .then(res => this.snmpDataConfigSource = res);
    this.templateService.getTemplates()
      .then(res => this.templateSource = res);

  }
}
