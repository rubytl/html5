import { Component } from '@angular/core';
import { msmHelper } from '../../helpers';
import { MsmTemplateComponent } from '../template.component';

@Component({
  selector: 'msm-priority',
  templateUrl: './msm-priority.component.html',
  styleUrls: ['./msm-priority.component.scss']
})

export class MsmPriorityComponent extends MsmTemplateComponent {
  prioritySource = msmHelper.createPriorityList();
}
