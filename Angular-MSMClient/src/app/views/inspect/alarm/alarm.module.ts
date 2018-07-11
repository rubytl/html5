import { NgModule } from '@angular/core';
import { AlarmComponent, AlarmRoutingModule, AlarmDetailComponent } from '.';
import { SharedModule } from '../../../shared';

@NgModule({
    imports: [
        AlarmRoutingModule,
        SharedModule
    ],
    declarations: [
        AlarmComponent,
        AlarmDetailComponent
    ]
})
export class AlarmModule { }
