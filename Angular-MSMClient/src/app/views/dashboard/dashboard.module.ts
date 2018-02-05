import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

import { DashboardComponent } from './dashboard.component';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { MapViewComponent } from './map-view/map-view.component';
import { ListViewComponent } from './list-view/list-view.component';
import { ListViewApiService } from '../../services/list-view.service';

@NgModule({
  imports: [
    DashboardRoutingModule,
    CommonModule
  ],
  declarations: [
    DashboardComponent,
    MapViewComponent,
    ListViewComponent
  ],
  providers: [
    ListViewApiService
  ],
})
export class DashboardModule { }
