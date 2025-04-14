import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCAtegoryComponent } from './add-category/add-category.component';

const routes: Routes = [
  { path: 'add', component: AddCAtegoryComponent }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
