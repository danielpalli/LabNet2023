import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardLayoutComponent } from './layouts/dashboard-layout/dashboard-layout.component';
import { StartPageComponent } from './pages/start-page/start-page.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { MenuListComponent } from './components/menu-list/menu-list.component';
import { CategoryPageComponent } from './pages/category-page/category-page.component';


@NgModule({
  declarations: [
    DashboardLayoutComponent,
    StartPageComponent,
    SidebarComponent,
    MenuListComponent,
    CategoryPageComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule
  ]
})
export class DashboardModule { }
