import { Component } from '@angular/core';
import { CategoryService } from '../Service/category.service';

@Component({
  selector: 'app-add-category',
  standalone: false,
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCAtegoryComponent {

  constructor(private ser: CategoryService) { }
  ngOnInit() { }

  addCategory(data: any) {
    debugger
    this.ser.addCategory(data).subscribe(() => {
      debugger
      alert('CAtegory Added Successfully')
    })
  }
}
