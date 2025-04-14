import { Component } from '@angular/core';
import { CategoryService } from '../Service/category.service';

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {

  constructor(private CategorySer: CategoryService) { }

  ngOnInit() {
    this.getAllCAtegory();
    this.allCategory();
  }
  cat: any
  getAllCAtegory() {
    this.CategorySer.getCAtegorynew().subscribe((data) => {
      this.cat = data;
    })
  }
  viewCategory: any
  allCategory() {
    this.CategorySer.getCategory().subscribe((data: any) => {
      this.viewCategory = data;
    })
  }

}
