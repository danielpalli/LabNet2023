import { Component, OnInit, inject } from '@angular/core';
import { CategoryService } from '../../services/category.service';
import { Category } from 'src/app/core/interfaces/category.interface';

@Component({
  selector: 'app-category-page',
  templateUrl: './category-page.component.html',
  styleUrls: ['./category-page.component.css'],
})
export class CategoryPageComponent implements OnInit{
  categories: Category[] = [];

  private categoryService = inject(CategoryService);

  ngOnInit() {
    this.categoryService.getCategoryData().subscribe((data: any) => {
      this.categories = data;

      console.log(data);
    });
  }
}
