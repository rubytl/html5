import { NgModule } from '@angular/core';
import { ChartsModule } from 'ng2-charts/ng2-charts';
import { SharedModule } from '../../shared';

import {
  EcbComponent, InspectRoutingModule,
  InspectComponent, EnergySingleComponent,
  TimeframeComponent,ComparetypeComponent,
  ActionComponent
} from '.';

@NgModule({
  imports: [
    InspectRoutingModule,
    ChartsModule,
    SharedModule
  ],
  declarations: [
    EcbComponent,
    InspectComponent,
    EnergySingleComponent,
    TimeframeComponent,
    ComparetypeComponent,
    ActionComponent
  ]
})
export class InspectModule { }
