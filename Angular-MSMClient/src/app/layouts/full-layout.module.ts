import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';

// Layouts
import { FullLayoutComponent } from './full-layout.component';
import { SimpleLayoutComponent } from './simple-layout.component';
import { BreadcrumbsComponent } from '../shared/breadcrumb.component';

// Dashboard
import { MsmMenuComponent } from '../shared/menu/menu.component';
import { SiteTreeViewComponent } from '../views/site-tree-view/site-tree-view.component';
import { TreeViewComponent } from '../views/site-tree-view/tree-view.component';
import { SharedModule } from '../shared';
import { RollingAlarmComponent } from '../views/rolling-alarm/rolling-alarm.component';

@NgModule({
  imports: [
    RouterModule,
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
    SharedModule
  ],
  declarations: [
    FullLayoutComponent,
    SimpleLayoutComponent,
    BreadcrumbsComponent,
    SiteTreeViewComponent,
    TreeViewComponent,
    MsmMenuComponent,
    RollingAlarmComponent
  ]
})
export class FullLayoutModule { }
