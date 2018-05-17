import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../../../shared';

import {
  SiteSetupComponent, AdministrationRoutingModule, AdministrationComponent
} from '.';

@NgModule({
  imports: [
    AdministrationRoutingModule,
    CommonModule,
    SharedModule
  ],
  declarations: [
    SiteSetupComponent,
    AdministrationComponent
  ]
})
export class AdministrationModule { }
