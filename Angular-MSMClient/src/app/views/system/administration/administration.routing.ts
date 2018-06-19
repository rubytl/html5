import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SiteSetupComponent } from './site-setup/site-setup.component';
import { AdministrationComponent } from './administration.component';
import { SiteTemplateSetupComponent } from './site-template-setup/site-template-setup.component';
import { UserSetupComponent } from './user-setup/user-setup.component';

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
      },
      {
        path: 'userconfiguration',
        component: UserSetupComponent,
        data: {
          title: 'User Configuration'
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
