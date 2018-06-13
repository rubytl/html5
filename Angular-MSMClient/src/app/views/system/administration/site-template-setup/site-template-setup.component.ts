import { Component, OnChanges } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { BsModalService } from 'ngx-bootstrap/modal';
import { IAppState } from '../../../../store';
import { CommonComponent } from '../../../common/common.component';
import { TemplateService } from '../../../../services';
import { NewSiteTemplateComponent } from '../new-site-template/new-site-template.component';

@Component({
  selector: 'msm-site-template-setup',
  templateUrl: './site-template-setup.component.html',
  styleUrls: ['./site-template-setup.component.scss']
})
export class SiteTemplateSetupComponent extends CommonComponent {
  siteTemplateForm: FormGroup;
  private originalTemplateSource = [];
  private selectedRowIndex: number;
  private deletedTemplatedIs = [];
  constructor(private templateService: TemplateService, modalService: BsModalService,
    ngRedux: NgRedux<IAppState>, private fb: FormBuilder) {
    super(ngRedux, modalService);
  }

  // get site source
  get siteTemplateSource(): FormArray {
    return this.siteTemplateForm.get('siteTemplateSource') as FormArray;
  }

  // rebuild form if there are any changes
  ngOnChanges() {
    this.rebuildForm();
  }

  // row click and get the appopriate index
  onRowClick(i) {
    this.selectedRowIndex = i;
  }

  onAddNewSiteTemplate() {
    let templateSource = [];
    templateSource.push({ itemId: '', itemName: '' });
    this.originalTemplateSource.forEach(element => {
      templateSource.push({ itemId: element.templateId, itemName: element.templateId + "(" + element.templateName + ")", data: element })
    });
    let setting = { templateSource: templateSource, editTemplate: false };
    var newSiteRef = this.modalService.show(NewSiteTemplateComponent, { initialState: { setting } });
    this.onAfterAddingNewSite(newSiteRef);
  }

  onOpenSiteTemplate(i) {
    let template = this.siteTemplateSource.controls[i].value;
    let setting = { existingTemplate: template, editTemplate: true };
    var newSiteRef = this.modalService.show(NewSiteTemplateComponent, { initialState: { setting } });
    this.onAfterEditingSite(newSiteRef, i);
  }

  onDeleteSiteTemplate() {
    if (this.selectedRowIndex === undefined) {
      this.openNotificationDialog('Delete Template?', "Please select a template to delete");
      return;
    }

    let template = this.siteTemplateSource.controls[this.selectedRowIndex].value;
    this.templateService.canDeleteTemplate(template.templateId)
      .then(res => {
        if (res) {
          this.siteTemplateSource.removeAt(this.selectedRowIndex);
          this.deletedTemplatedIs.push(template.templateId);
          this.siteTemplateForm.markAsDirty();
        }
        else {
          this.openNotificationDialog("Error", "SiteTemplate " + template.templateId + " is used in Site table. Not able to delete!");
        }
      })
  }

  // rebuild form if user reject changes
  onRejectChanges() {
    this.rebuildForm();
  }

  // handle workflow when user accept changes from the gui
  onSaveChanges() {
    // save delete templates
    this.templateService.deleteTemplates(this.deletedTemplatedIs)
      .then(res => {
        this.updateLocalVariables();
        this.openNotificationDialog('Success', 'Template deleted successfully');
      });
  }

  // called when component is inited
  protected onComponentInit() {
    this.createForm();
    this.getsiteTemplatePaging();
  }

  // after page changed
  protected onAfterPageChanged() {
    this.getsiteTemplatePaging();
  }

  // get sites by ids
  private getsiteTemplatePaging() {
    this.templateService.getsiteTemplates(this.paging.pageIndex, this.paging.pageSize)
      .then(res => {
        this.originalTemplateSource = res;
        this.rebuildForm();
      });
  }

  // create default form group
  private createForm() {
    this.siteTemplateForm = this.fb.group({
      siteTemplateSource: this.fb.array([])
    });
  }

  // rebuild form if any changed
  private rebuildForm() {
    const sites = this.originalTemplateSource.map(site => this.fb.group(site));
    const siteFormArray = this.fb.array(sites);
    this.siteTemplateForm.setControl('siteTemplateSource', siteFormArray);
  }

  private updateLocalVariables() {
    this.deletedTemplatedIs = [];
    this.originalTemplateSource = this.siteTemplateSource.value;
  }

  private onAfterAddingNewSite(newSiteRef) {
    newSiteRef.content.onClose.subscribe(result => {
      if (result) {
        this.originalTemplateSource.push(result);
        this.siteTemplateSource.push(this.fb.group(result));
      }

      newSiteRef.content.onClose.unsubscribe();
    });
  }

  private onAfterEditingSite(newSiteRef, index) {
    newSiteRef.content.onClose.subscribe(result => {
      if (result) {
        this.siteTemplateSource.controls[index] = this.fb.group(result);
      }

      newSiteRef.content.onClose.unsubscribe();
    });
  }
}
