import { Component, OnInit, inject } from '@angular/core';
import { CategoryService } from '../../services/category.service';
import { Category } from 'src/app/core/interfaces/category.interface';
import Swal from 'sweetalert2';

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
    });
  }

  deleteCategory(id: number) {
    Swal.fire({
      title: 'Are you sure?',
      text: 'You won\'t be able to revert this!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!',
      cancelButtonText: 'No, cancel!',
      reverseButtons: true
    }).then((result) => {
      if (result.isConfirmed) {
        this.categoryService.deleteCategory(id).subscribe({
          next: () => {
            this.categories = this.categories.filter((category) => category.Id !== id);
            Swal.fire('Deleted!', 'Category has been deleted.', 'success');
          },
          error: (message) => {
            console.log(message);
            Swal.fire('Error', 'An error occurred while deleting the category.', 'error');
          },
        });
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire('Cancelled', 'Category deletion was cancelled.', 'info');
      }
    });
  }
}
