import { NgModule } from '@angular/core';
import { AlarmComponent, AlarmRoutingModule, AlarmDetailComponent } from '.';

@NgModule({
    imports: [
        AlarmRoutingModule
    ],
    declarations: [
        AlarmComponent,
        AlarmDetailComponent
    ]
})
export class AlarmModule { }
