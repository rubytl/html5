import { NgModule } from '@angular/core';

import {
  SiteSetupComponent, AdministrationRoutingModule, AdministrationComponent
} from '.';

@NgModule({
  imports: [
    AdministrationRoutingModule,
  ],
  declarations: [
    SiteSetupComponent,
    AdministrationComponent
  ]
})
export class AdministrationModule { }
