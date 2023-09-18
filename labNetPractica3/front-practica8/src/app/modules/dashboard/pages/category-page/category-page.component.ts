import { Component } from '@angular/core';
import { CategoryService } from '../../services/category.service';
import { Category } from 'src/app/core/interfaces/category.interface';

@Component({
  selector: 'app-category-page',
  templateUrl: './category-page.component.html',
  styleUrls: ['./category-page.component.css'],
})
export class CategoryPageComponent {
  category!: Category[];

  constructor(private categoryService: CategoryService) {}

  ngOnInit() {
    this.categoryService.getCategoryData().subscribe((data: Category[]) => {
      this.category = data;
      console.log(data);
    });
  }
}
