import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MultigridComponent } from './multigrid.component';

const routes: Routes = [
  {
    path: '',
    component: MultigridComponent,
    data: {
      title: 'MultiGrid'
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MultigridRoutingModule {}
