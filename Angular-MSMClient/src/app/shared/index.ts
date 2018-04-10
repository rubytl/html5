// include directives/components commonly used in features modules in this shared modules
// and import me into the feature module
// importing them individually results in: Type xxx is part of the declarations of 2 modules: ... Please consider moving to a higher module...
// https://github.com/angular/angular/issues/10646  

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

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

@NgModule({
    imports: [CommonModule, FormsModule],
    declarations: [SpinnerComponent, FilterTypeComponent, MsmPaginatorComponent, MsmSortingComponent,
        NAV_DROPDOWN_DIRECTIVES, SIDEBAR_TOGGLE_DIRECTIVES, AsideToggleDirective,
        SortingToggleDirective, MsmMultipleSortingComponent, MsmDialogComponent,
        MsmFooterComponent, MsmAsideComponent],
    exports: [SpinnerComponent, FilterTypeComponent, FormsModule, CommonModule, MsmPaginatorComponent, MsmSortingComponent,
        NAV_DROPDOWN_DIRECTIVES, SIDEBAR_TOGGLE_DIRECTIVES, AsideToggleDirective,
        SortingToggleDirective, MsmMultipleSortingComponent, MsmDialogComponent,
        MsmFooterComponent, MsmAsideComponent],
    entryComponents:
        [
            MsmDialogComponent
        ]
})
export class SharedModule { }
