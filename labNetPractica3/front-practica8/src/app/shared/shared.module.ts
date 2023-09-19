import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { SidebarModule } from 'primeng/sidebar';
import { TableModule } from 'primeng/table';
import { InputTextareaModule } from 'primeng/inputtextarea';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ButtonModule,
    SidebarModule,
    TableModule,
    InputTextareaModule
  ],
  exports: [
    ButtonModule,
    SidebarModule,
    TableModule,
    InputTextareaModule
  ]
})
export class SharedModule { }
