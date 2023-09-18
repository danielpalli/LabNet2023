import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Category } from 'src/app/core/interfaces/category.interface';
@Injectable({
  providedIn: 'root',
})
export class CategoryService {
  private _categoryData: Category[] = [];
  private http = inject(HttpClient);

  addCategory(category: any) {}

  getCategoryData(): any {
    return;
  }

}
