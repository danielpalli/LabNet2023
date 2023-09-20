import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoryService } from '../../services/category.service';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-new-category-page',
  templateUrl: './new-category-page.component.html',
  styleUrls: ['./new-category-page.component.css']
})
export class NewCategoryPageComponent {

  private fb = inject(FormBuilder);
  private categoryService = inject(CategoryService);
  private router = inject(Router);
  public categoryForm: FormGroup = this.fb.group({
    CategoryName: ['', [Validators.required, Validators.minLength(3)]],
    Description: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(50)]],
    Image: ['']
  });

  addCategory() {
    this.categoryService.addCategory(this.categoryForm.value).subscribe({
      next: () => this.router.navigateByUrl('/dashboard/category'),
      error: (message) => {
        Swal.fire('Error', message, 'error' )
      }
    });
  }
}
