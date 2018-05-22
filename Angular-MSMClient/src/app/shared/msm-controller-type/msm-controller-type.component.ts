import { Component } from '@angular/core';
import { msmHelper } from '../../helpers';
import { MsmTemplateComponent } from '../template.component';

@Component({
  selector: 'msm-controller-type',
  templateUrl: './msm-controller-type.component.html',
  styleUrls: ['./msm-controller-type.component.scss']
})
export class MsmControllerTypeComponent extends MsmTemplateComponent {
  controllerSource = msmHelper.createControllerTypeList();
}
