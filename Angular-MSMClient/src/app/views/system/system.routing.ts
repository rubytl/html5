import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SystemComponent } from './system.component';

export const routes: Routes = [
  {
    path: '',
    component: SystemComponent,
    children: [
      {
        path: 'admin',
        loadChildren: './administration/administration.module#AdministrationModule'
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SystemRoutingModule { }
