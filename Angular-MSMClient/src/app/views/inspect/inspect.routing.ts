import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { EcbComponent } from './ecb/ecb.component';
import { InspectComponent } from './inspect.component';
import { EnergySingleComponent } from './energy/energy.component';

const routes: Routes = [
  {
    path: '',
    component: InspectComponent,
    data: {
      // title: 'Inspect'
    },
    children: [
      {
        path: 'ecb',
        component: EcbComponent,
        data: {
          title: 'ECB'
        }
      },
      {
        path: 'energy',
        component: EnergySingleComponent,
        data: {
          title: 'Energy trend'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InspectRoutingModule { }
