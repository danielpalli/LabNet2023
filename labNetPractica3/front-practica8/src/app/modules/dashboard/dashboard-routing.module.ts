import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardLayoutComponent } from './layouts/dashboard-layout/dashboard-layout.component';
import { StartPageComponent } from './pages/start-page/start-page.component';

const routes: Routes = [
  {
    path: '',
    component: DashboardLayoutComponent,
    children: [
      { path: '', component: StartPageComponent },
      { path: '**', redirectTo: '' }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
