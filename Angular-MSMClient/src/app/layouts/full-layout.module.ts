import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NAV_DROPDOWN_DIRECTIVES } from '../shared/nav-dropdown.directive';

import { SIDEBAR_TOGGLE_DIRECTIVES } from '../shared/sidebar.directive';
import { AsideToggleDirective } from '../shared/aside.directive';

// Layouts
import { FullLayoutComponent } from './full-layout.component';
import { SimpleLayoutComponent } from './simple-layout.component';
import { BreadcrumbsComponent } from '../shared/breadcrumb.component';

// Dashboard
import { MenuComponent } from '../shared/menu/menu.component';
import { SiteTreeViewComponent } from '../views/site-tree-view/site-tree-view.component';
import { SmartGridMenuComponent } from "../shared/smartgridmenu/smartgridmenu.component";

@NgModule({
  imports: [
    HttpModule,
    RouterModule,
    BrowserModule,
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
  ],
  declarations: [
    FullLayoutComponent,
    SimpleLayoutComponent,
    NAV_DROPDOWN_DIRECTIVES,
    BreadcrumbsComponent,
    SIDEBAR_TOGGLE_DIRECTIVES,
    AsideToggleDirective,
    SiteTreeViewComponent,
    MenuComponent,
    SmartGridMenuComponent
  ]
})
export class FullLayoutModule { }
