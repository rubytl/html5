import { NgModule } from '@angular/core';
import { SystemRoutingModule } from './system.routing';
import { SystemComponent } from './system.component';

@NgModule({
  imports: [
    SystemRoutingModule,
  ],
  declarations: [
    SystemComponent,
  ]
})
export class SystemModule { }
