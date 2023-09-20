import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardLayoutComponent } from './layouts/dashboard-layout/dashboard-layout.component';
import { StartPageComponent } from './pages/start-page/start-page.component';
import { CategoryPageComponent } from './pages/category-page/category-page.component';
import { NewCategoryPageComponent } from './pages/new-category-page/new-category-page.component';
import { EditCategoryPageComponent } from './pages/edit-category-page/edit-category-page.component';

const routes: Routes = [
  {
    path: '',
    component: DashboardLayoutComponent,
    children: [
      { path: '', component: StartPageComponent },
      { path: 'category', component: CategoryPageComponent },
      { path: 'new-category', component: NewCategoryPageComponent },
      { path: 'edit-category/:id', component: EditCategoryPageComponent },
      { path: '**', redirectTo: '' }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
