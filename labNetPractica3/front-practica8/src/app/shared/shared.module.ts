import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { SidebarModule } from 'primeng/sidebar';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ButtonModule,
    SidebarModule,
  ],
  exports: [
    ButtonModule,
    SidebarModule,
  ]
})
export class SharedModule { }
