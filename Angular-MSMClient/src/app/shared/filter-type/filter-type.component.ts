import { Component } from '@angular/core';
import { MsmTemplateComponent } from '../template.component';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'filter-type',
  templateUrl: './filter-type.component.html',
  styleUrls: ['./filter-type.component.scss']
})
export class FilterTypeComponent extends MsmTemplateComponent {
  constructor(fb: FormBuilder) {
    super(fb);
  }
}
