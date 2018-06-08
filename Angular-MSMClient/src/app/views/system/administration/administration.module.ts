import { NgModule } from '@angular/core';
import { SharedModule } from '../../../shared';

import {
  SiteSetupComponent, AdministrationRoutingModule,
  AdministrationComponent, SiteTemplateComponent
} from '.';

@NgModule({
  imports: [
    AdministrationRoutingModule,
    SharedModule,
  ],
  declarations: [
    SiteSetupComponent,
    AdministrationComponent,
    SiteTemplateComponent,
  ]
})
export class AdministrationModule { }
