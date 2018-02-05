import { NgModule } from '@angular/core';
import { ChartsModule } from 'ng2-charts/ng2-charts';

import { MultigridComponent } from './multigrid.component';
import { MultigridRoutingModule } from './multigrid-routing.module';

@NgModule({
  imports: [
    MultigridRoutingModule,
    ChartsModule
  ],
  declarations: [ MultigridComponent ]
})
export class MultigridModule { }
