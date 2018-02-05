import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SolarComponent } from './solar/solar.component';
import { WindComponent } from "./wind/wind.component";
import { SmartgridComponent } from "./smartgrid.component";

const routes: Routes = [
  {
    path: '',
    component: SmartgridComponent,
    data: {
      // title: 'Smartgrid'
    },
    children: [
      {
        path: 'solar',
        component: SolarComponent,
        data: {
          title: 'Solar'
        }
      },
      {
        path: 'wind',
        component: WindComponent,
        data: {
          title: 'Wind'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SmartgridRoutingModule { }
