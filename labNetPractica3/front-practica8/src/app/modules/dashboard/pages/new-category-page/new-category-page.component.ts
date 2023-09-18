import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoryService } from '../../services/category.service';

@Component({
  selector: 'app-new-category-page',
  templateUrl: './new-category-page.component.html',
  styleUrls: ['./new-category-page.component.css']
})
export class NewCategoryPageComponent {

  private fb = inject(FormBuilder);
  private categoryService = inject(CategoryService);

  public categoryForm: FormGroup = this.fb.group({
    name: ['', [Validators.required, Validators.minLength(3)]],
    description: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(50)]],
    Image: ['', [Validators.required]]
  });

}
