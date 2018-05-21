import { Component, OnInit, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { treeHelper } from '../../helpers';
import { TemplateService } from '../../services';

@Component({
  selector: 'msm-site-template',
  templateUrl: './msm-site-template.component.html',
  styleUrls: ['./msm-site-template.component.scss']
})
export class MsmSiteTemplateComponent implements OnInit, OnDestroy {
  templateSource: any;
  @Output() templateChange = new EventEmitter<number>();
  @Input() templateId: number;
  constructor(private templateService: TemplateService) {
  }

  ngOnInit() {
    this.getTemplates();
  }

  ngOnDestroy() {
    this.templateChange.unsubscribe();
  }

  onTemplateChanged() {
    this.templateChange.next(this.templateId);
  }

  private getTemplates() {
    this.templateService.getTemplates()
      .then(res => this.templateSource = res);
  }
}
