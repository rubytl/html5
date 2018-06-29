import { Component, Input } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { MsmDialogComponent } from '../../dialog.component';
import { SiteService, RestrictedGroupService } from '../../../../services';
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
  mappedGroupArr = {};
  currentRestrictedGroupId;
  constructor(bsModalRef: BsModalRef, private siteService: SiteService,
    modelService: BsModalService, private fb: FormBuilder, private groupService: RestrictedGroupService) {
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
        let restrictedElement = this.setting.restrictedList[0];
        if (restrictedElement) {
          this.currentRestrictedGroupId = restrictedElement.restrictedGroupId;
          this.onSelectGroup(restrictedElement);
        }
        else {
          this.rebuildForm();
        }
      });
  }

  // create default form group
  private createForm() {
    this.siteForm = this.fb.group({
      siteSource: this.fb.array([])
    });
  }

  private onSelectGroup(event) {
    if (!event || event === null) {
      return;
    }

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
        groupConfigs.push({ restrictedGroupId: restrictedGroupId, siteId: element.id });
      }
    });
  }

  private onSaveChanges() {
    let groupConfigs = [];

    // build group configs from selected restricted group name and site group name
    for (var id in this.mappedGroupArr) {
      let mappedElement = this.mappedGroupArr[id];
      this.selectGroupConfigs(id, mappedElement, groupConfigs);
    }

    // update changes
    if (groupConfigs.length > 0) {
      this.groupService.updateGroupConfig(groupConfigs)
        .then(res => {
          this.openNotificationDialog("Success", "Group saved successfully");
        });
    }
  }

  private onRejectChanges() {
    this.rebuildFormFromSelectionGroup();
  }

  rebuildFormFromSelectionGroup() {
    let mappedElement = this.mappedGroupArr[this.currentRestrictedGroupId];
    if (mappedElement && mappedElement.length > 0) {
      this.siteForm.setControl('siteSource', this.fb.array(siteParentTreeHelper.listToTree(mappedElement, this.fb)));
    }
  }

  private onAddNewGroupConfig() {
  }
}
