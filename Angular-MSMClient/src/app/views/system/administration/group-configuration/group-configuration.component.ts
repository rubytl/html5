import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { SiteService, RestrictedGroupService } from '../../../../services';
import { siteParentTreeHelper, guidHelper } from '../../../../helpers';
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
  mappedGroupArr = {};
  currentRestrictedGroupId;
  selectedRowIndex;
  deletedGroupIds = [];
  isSelectGroup = false;
  constructor(bsModalRef: BsModalRef, private siteService: SiteService,
    modelService: BsModalService, private fb: FormBuilder, private groupService: RestrictedGroupService) {
    super(bsModalRef, modelService);
  }

  ngOnChanges() {
    this.rebuildRestrictedListForm();
  }

  private rebuildRestrictedListForm() {
    let list = this.setting.restrictedList;
    if (list && list.length > 0) {
      list.forEach(element => {
        element.isActive = false;
      });
      let restrictedGroup = list.map(element => this.fb.group(element));
      this.siteForm.setControl('restrictedList', this.fb.array(restrictedGroup));
    }
  }

  private rebuildFormFromSelectionGroup() {
    let mappedElement = this.mappedGroupArr[this.currentRestrictedGroupId];
    if (mappedElement && mappedElement.length > 0) {
      let restrictedGroup = mappedElement.map(element => this.fb.group(element));
      this.siteForm.setControl('siteSource', this.fb.array(restrictedGroup));//this.fb.array(siteParentTreeHelper.listToTree(mappedElement, this.fb)));
    }
  }

  // get site source
  get restrictedListSource(): FormArray {
    return this.siteForm.get('restrictedList') as FormArray;
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
        let restrictedElement = this.restrictedListSource.controls[0];
        if (restrictedElement) {
          this.currentRestrictedGroupId = restrictedElement.value.itemId;
          this.onSelectGroup(restrictedElement, 0);
        }
      });
  }

  // create default form group
  private createForm() {
    this.siteForm = this.fb.group({
      restrictedList: this.fb.array([]),
      siteSource: this.fb.array([]),
    });
    this.rebuildRestrictedListForm();
  }

  private onSelectGroup($event, index) {
    this.isSelectGroup = true;
    if (!$event || $event === null) {
      return;
    }

    this.selectedRowIndex = index;
    let event = $event.value;
    $event.patchValue({ isActive: true });
    this.updateActiveRestrictedItem(event.itemId);
    this.currentRestrictedGroupId = event.itemId;
    let mappedElement = this.mappedGroupArr[event.itemId];
    if (mappedElement) {
      this.rebuildFormFromSelectionGroup();
    }
    else {
      this.siteService.getSitesByGroupId(event.itemId)
        .then(res => {
          // store original value to the dictionary
          let curentGroupsSites = this.cloneParentSite();
          this.updateSiteGroupSelection(curentGroupsSites, res.map(s => s.id));
          this.mappedGroupArr[event.itemId] = curentGroupsSites;
          this.rebuildFormFromSelectionGroup();
        });
    }
  }

  // patch value to the restricted item
  private updateActiveRestrictedItem(itemId) {
    this.restrictedListSource.controls.forEach(element => {
      if (element.value.itemId !== itemId) {
        element.patchValue({ isActive: false });
      }
    });
  }

  private cloneParentSite() {
    let cloneParent = [];
    this.parentSites.forEach(element => {
      cloneParent.push({ isSelected: false, parentId: element.parentId, description: element.description, id: element.id })
    });

    return cloneParent;
  }

  // update site group selection from parent sites list
  private updateSiteGroupSelection(siteSource, siteIds) {
    siteIds.forEach(siteId => {
      let site = siteSource.find(s => s.id === siteId);
      if (site) {
        site.isSelected = true;
      }
    });
  }

  private onValueChanged(event) {
    this.siteForm.markAsDirty();
    let mappedElement = this.mappedGroupArr[this.currentRestrictedGroupId];
    let site = mappedElement.find(s => s.id === event.id);
    if (site) {
      site.isSelected = event.isSelected;
    }
  }

  private selectGroupConfigs(restrictedGroupId, siteSource, groupConfigs) {
    if (siteSource === null) {
      return null;
    }

    siteSource.forEach(element => {
      if (element.isSelected) {
        let restrictedItem = this.restrictedListSource.value.find(s => s.itemId === restrictedGroupId);
        groupConfigs.push({ restrictedGroupId: restrictedGroupId, restrictedGroupName: restrictedItem.itemName, siteId: element.id });
      }
    });
  }

  private onSaveChanges() {
    // delete neccessary items first
    if (this.deletedGroupIds.length > 0) {
      this.groupService.deleteGroupConfigs(this.deletedGroupIds);
    }

    let groupConfigs = [];

    // build group configs from selected restricted group name and site group name
    for (var id in this.mappedGroupArr) {
      let mappedElement = this.mappedGroupArr[id];
      this.selectGroupConfigs(id, mappedElement, groupConfigs);
    }

    // update configs later
    if (groupConfigs.length > 0) {
      this.groupService.updateGroupConfig(groupConfigs)
        .then(res => this.openNotificationDialog("Success", "Group saved successful"))
        .catch(error => this.openNotificationDialog("Fail", "Group saved unsuccessful"));
    }
  }

  private onRejectChanges() {
    this.mappedGroupArr={};
    this.onComponentInit();
  }

  private onAddNewGroupConfig() {
    this.siteForm.markAsDirty();
    let id = guidHelper.Guid.newGuid();
    this.currentRestrictedGroupId = id;
    this.selectedRowIndex = this.restrictedListSource.length;
    let restrictedItem = { itemName: 'group name', itemId: id, isActive: true };
    this.mappedGroupArr[id] = this.cloneParentSite();
    this.restrictedListSource.push(this.fb.group(restrictedItem));
    this.updateActiveRestrictedItem(id);
    this.rebuildFormFromSelectionGroup();
  }

  private onDeleteGroupConfig() {
    if (this.selectedRowIndex === undefined) {
      this.openNotificationDialog('Delete Group Config?', "Please select a config to delete");
      return;
    }

    let configItem = this.restrictedListSource.controls[this.selectedRowIndex].value;
    this.groupService.canDeleteGroupConfig(configItem.itemId)
      .then(res => {
        if (res) {
          this.restrictedListSource.removeAt(this.selectedRowIndex);
          this.deletedGroupIds.push(configItem.itemId);
          this.siteForm.markAsDirty();
        }
        else {
          this.openNotificationDialog("Error", "Role '" + configItem.itemName + "' is in use. Not able to delete!");
        }
      })
  }

  private onCloseDialog() {
    this.onClick(this.restrictedListSource.value);
  }
}