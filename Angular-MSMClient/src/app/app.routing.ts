import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Layouts
import { FullLayoutComponent } from './layouts/full-layout.component';
import { SimpleLayoutComponent } from './layouts/simple-layout.component';

// Auth
import { AuthGuard } from './services';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full',
    canActivate: [AuthGuard]
  },
  {
    path: '',
    component: FullLayoutComponent,
    canActivate: [AuthGuard],
    data: {
      title: 'Home'
    },
    children: [
      {
        path: 'dashboard',
        loadChildren: './views/dashboard/dashboard.module#DashboardModule'
      },
      {
        path: 'inspect',
        loadChildren: './views/inspect/inspect.modude#InspectModule'
      },
      // {
      //   path: 'analyze',
      //   loadChildren: './views/analyze/analyze.module#AnalyzeModule'
      // },
      // {
      //   path: 'view',
      //   loadChildren: './views/view/view.module#ViewModule'
      // },
      {
        path: 'system',
        loadChildren: './views/system/system.module#SystemModule'
      },
      // {
      //   path: 'help',
      //   loadChildren: './views/help/help.module#HelpModule'
      // },
    ]
  },
  {
    path: 'pages',
    component: SimpleLayoutComponent,
    data: {
      title: 'Pages'
    },
    children: [
      {
        path: '',
        loadChildren: './pages/pages.module#PagesModule',
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
