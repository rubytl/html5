import { NgModule } from '@angular/core';
import { SharedModule } from '../../../shared';

import {
  SiteSetupComponent, AdministrationRoutingModule,
  AdministrationComponent
} from '.';

@NgModule({
  imports: [
    AdministrationRoutingModule,
    SharedModule,
  ],
  declarations: [
    SiteSetupComponent,
    AdministrationComponent,
  ]
})
export class AdministrationModule { }
