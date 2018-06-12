import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SiteSetupComponent } from './site-setup/site-setup.component';
import { AdministrationComponent } from './administration.component';
import { SiteTemplateSetupComponent } from './site-template-setup/site-template-setup.component';

const routes: Routes = [
  {
    path: '',
    component: AdministrationComponent,
    children: [
      {
        path: 'sitesetup',
        component: SiteSetupComponent,
        data: {
          title: 'Site Setup'
        }
      },
      {
        path: 'sitetemplate',
        component: SiteTemplateSetupComponent,
        data: {
          title: 'Site Template'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class AdministrationRoutingModule { }
