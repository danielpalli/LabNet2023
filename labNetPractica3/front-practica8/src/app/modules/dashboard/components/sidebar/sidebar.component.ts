import { Component } from '@angular/core';

@Component({
  selector: 'dashboard-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {
  expanded = false;

  toggleExpanded() {
    this.expanded = !this.expanded;
  }
}
