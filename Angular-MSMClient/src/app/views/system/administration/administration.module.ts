import { NgModule } from '@angular/core';
import { SharedModule } from '../../../shared';

import {
  SiteSetupComponent, AdministrationRoutingModule,
  AdministrationComponent, SiteTemplateComponent
} from '.';
import { NewSiteTemplateComponent } from './new-site-template/new-site-template.component';

@NgModule({
  imports: [
    AdministrationRoutingModule,
    SharedModule,
  ],
  declarations: [
    SiteSetupComponent,
    AdministrationComponent,
    SiteTemplateComponent,
    NewSiteTemplateComponent,
  ]
})
export class AdministrationModule { }
