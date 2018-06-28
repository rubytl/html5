// include directives/components commonly used in features modules in this shared modules
// and import me into the feature module
// importing them individually results in: Type xxx is part of the declarations of 2 modules: ... Please consider moving to a higher module...
// https://github.com/angular/angular/issues/10646  

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { TabsModule } from 'ngx-bootstrap/tabs';

import { SpinnerComponent } from './spinner/spinner.component';
import { FilterTypeComponent } from './filter-type/filter-type.component';
import { MsmPaginatorComponent } from './msm-paginator/msm-paginator.component';
import { MsmSortingComponent, SortingToggleDirective } from './msm-sorting/msm-sorting.component';
import { NAV_DROPDOWN_DIRECTIVES } from './nav-dropdown.directive';
import { SIDEBAR_TOGGLE_DIRECTIVES } from './sidebar.directive';
import { AsideToggleDirective } from './aside.directive';
import { MsmMultipleSortingComponent } from './msm-multiple-sorting/msm-multiple-sorting.component';
import { MsmDialogComponent } from './msm-dialog/msm-dialog.component';
import { MsmFooterComponent } from './msm-footer/msm-footer.component';
import { MsmAsideComponent } from './msm-aside/msm-aside.component';
import { MsmPriorityComponent } from './msm-priority/msm-priority.component';
import { MsmControllerTypeComponent } from './msm-controller-type/msm-controller-type.component';
import { MsmSitegroupComponent } from './msm-sitegroup/msm-sitegroup.component';
import { MsmSiteTemplateComponent } from './msm-site-template/msm-site-template.component';
import { MsmSnmpTemplateComponent } from './msm-snmp-template/msm-snmp-template.component';
import { MsmSnmpDataTemplateComponent } from './msm-snmp-data-template/msm-snmp-data-template.component';
import { MsmMonitorComponent } from './msm-monitor/msm-monitor.component';
import { RestrictedSiteConfigurationComponent } from '../views/system/administration/restricted-site-configuration/restricted-site-configuration.component';

// In some cases entryComponents under lazy loaded modules will not work,
// as a workaround I need to put these components here
import { NewSiteComponent } from '../views/system/administration/new-site/new-site.component';
import { NewSiteGroupComponent } from '../views/system/administration/new-group/new-group.component';
import { NewSiteTemplateComponent } from '../views/system/administration/new-site-template/new-site-template.component';
import { NewUserComponent } from '../views/system/administration/new-user/new-user.component';
import { ResetPasswordComponent } from '../views/system/administration/reset-password/reset-password.component';
import { GroupConfigurationComponent } from '../views/system/administration/group-configuration/group-configuration.component';

@NgModule({
    imports: [CommonModule, FormsModule, ReactiveFormsModule, TabsModule],
    declarations: [SpinnerComponent, FilterTypeComponent, MsmPaginatorComponent, MsmSortingComponent,
        NAV_DROPDOWN_DIRECTIVES, SIDEBAR_TOGGLE_DIRECTIVES, AsideToggleDirective,
        SortingToggleDirective, MsmMultipleSortingComponent, MsmDialogComponent,
        MsmFooterComponent, MsmAsideComponent,
        MsmPriorityComponent, MsmControllerTypeComponent, MsmSitegroupComponent,
        MsmSiteTemplateComponent, MsmSnmpTemplateComponent, MsmSnmpDataTemplateComponent,
        MsmMonitorComponent,
        NewSiteComponent, NewSiteGroupComponent, NewSiteTemplateComponent,
        NewUserComponent, ResetPasswordComponent, GroupConfigurationComponent,
        RestrictedSiteConfigurationComponent],
    exports: [FormsModule, CommonModule, ReactiveFormsModule, TabsModule,
        SpinnerComponent, FilterTypeComponent, MsmPaginatorComponent, MsmSortingComponent,
        NAV_DROPDOWN_DIRECTIVES, SIDEBAR_TOGGLE_DIRECTIVES, AsideToggleDirective,
        SortingToggleDirective, MsmMultipleSortingComponent, MsmDialogComponent,
        MsmFooterComponent, MsmAsideComponent,
        MsmPriorityComponent, MsmControllerTypeComponent, MsmSitegroupComponent,
        MsmSiteTemplateComponent, MsmSnmpTemplateComponent, MsmSnmpDataTemplateComponent,
        MsmMonitorComponent, RestrictedSiteConfigurationComponent],
    entryComponents:
        [
            MsmDialogComponent,
            NewSiteComponent,
            NewSiteGroupComponent,
            NewSiteTemplateComponent,
            NewUserComponent,
            ResetPasswordComponent,
            GroupConfigurationComponent
        ]
})
export class SharedModule { }
