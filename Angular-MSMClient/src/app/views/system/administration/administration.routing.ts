import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SiteSetupComponent } from './site-setup/site-setup.component';
import { AdministrationComponent } from './administration.component';
import { SiteTemplateComponent } from './site-template/site-template.component';

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
        component: SiteTemplateComponent,
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
