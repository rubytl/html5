import { NgModule } from '@angular/core';
import { SharedModule } from '../../../shared';

import {
  SiteSetupComponent, AdministrationRoutingModule,
  AdministrationComponent, SiteTemplateSetupComponent,
  UserSetupComponent
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
    UserSetupComponent,
  ]
})
export class AdministrationModule { }
