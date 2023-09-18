import { Component, Input } from '@angular/core';

@Component({
  selector: 'menu-list',
  templateUrl: './menu-list.component.html',
  styleUrls: ['./menu-list.component.css']
})
export class MenuListComponent {
  @Input() menuIcons: string[] = [];
  @Input() menuItems: string[] = [];
  @Input() menuLinks: string[] = [];
}
