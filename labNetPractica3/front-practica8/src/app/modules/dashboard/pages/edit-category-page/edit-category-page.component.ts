import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoryService } from '../../services/category.service';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';
import { Category } from 'src/app/core/interfaces/category.interface';

@Component({
  selector: 'app-edit-category-page',
  templateUrl: './edit-category-page.component.html',
  styleUrls: ['./edit-category-page.component.css']
})
export class EditCategoryPageComponent implements OnInit {
  private fb = inject(FormBuilder);
  private categoryService = inject(CategoryService);
  private router = inject(Router);
  category!: Category;

  ngOnInit() {
    this.categoryService.getCategoryById(Number(this.router.url.split('/')[3])).subscribe((data: any) => {
      this.category = data;
      this.editCategoryForm.patchValue({
        CategoryName: this.category.CategoryName,
        Description: this.category.Description,
        Image: this.category.Image
      });
    });
  }
  public editCategoryForm: FormGroup = this.fb.group({
    Id: [this.router.url.split('/')[3]],
    CategoryName: ['', [Validators.required, Validators.minLength(3)]],
    Description: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(50)]],
    Image: ['']
  });

  putCategory() {
    Swal.fire({
      title: 'Are you sure?',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, edit it!',
      cancelButtonText: 'No, cancel!',
      reverseButtons: true
    }).then((result) => {
      if (result.isConfirmed) {
        this.categoryService.putCategory(this.editCategoryForm.value).subscribe({
          next: () => {
            this.router.navigateByUrl('/dashboard/category'),
            Swal.fire('Updated!', 'Category has been edited.', 'success');
          },
          error: (message) => {
            console.log(message);
            Swal.fire('Error', 'An error occurred while editing the category.', 'error');
          },
        });
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire('Cancelled', 'Category deletion was cancelled.', 'info');
      }
    });
  }
}
