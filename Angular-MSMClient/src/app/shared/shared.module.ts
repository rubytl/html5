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
import { MsmSortingComponent } from './msm-sorting/msm-sorting.component';

@NgModule({
    imports: [CommonModule, FormsModule],
    declarations: [SpinnerComponent, FilterTypeComponent, MsmPaginatorComponent, MsmSortingComponent],
    exports: [SpinnerComponent, FilterTypeComponent, FormsModule, CommonModule, MsmPaginatorComponent, MsmSortingComponent],
})
export class SharedModule { }