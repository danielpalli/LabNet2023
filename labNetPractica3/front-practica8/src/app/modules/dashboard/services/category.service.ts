import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Category } from 'src/app/core/interfaces/category.interface';
import { environment } from 'src/environments/environments';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root',
})
export class CategoryService {

  private http = inject(HttpClient);
  private readonly baseUrl: string = environment.baseUrl;

  getCategoryById(id: number): Observable<Category> {
    return this.http.get<Category>(`${this.baseUrl}/api/category/${id}`);
  }

  addCategory(category: any): Observable<Category> {
    return this.http.post<Category>(`${this.baseUrl}/api/category`, category);
  }

  getCategoryData(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.baseUrl}/api/category`);
  }

  deleteCategory(id: number): Observable<Category> {
    return this.http.delete<Category>(`${this.baseUrl}/api/category/${id}`);
  }

  putCategory(category: any): Observable<Category> {
    return this.http.put<Category>(`${this.baseUrl}/api/category`, category);
  }
}
