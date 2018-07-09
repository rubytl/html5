import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AlarmDetailComponent } from './alarm-detail/alarm-detail.component';
import { AlarmComponent } from './alarm.component';

const routes: Routes = [
    {
        path: '',
        component: AlarmComponent,
        children: [
            {
                path: 'detail',
                component: AlarmDetailComponent,
                data: {
                    title: 'Alarm Details'
                }
            }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class AlarmRoutingModule { }
