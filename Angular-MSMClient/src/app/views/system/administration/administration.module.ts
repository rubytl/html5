import { NgModule } from '@angular/core';
import { SharedModule } from '../../../shared';

import {
  SiteSetupComponent, AdministrationRoutingModule,
  AdministrationComponent, SiteTemplateSetupComponent
} from '.';

@NgModule({
  imports: [
    AdministrationRoutingModule,
    SharedModule,
  ],
  declarations: [
    AdministrationComponent,
    SiteSetupComponent,
    SiteTemplateSetupComponent,
  ]
})
export class AdministrationModule { }
