import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';
import { EditCategoryComponent } from './edit-category/edit-category.component';
import { AddCAtegoryComponent } from './add-category/add-category.component';
import { FormsModule, ReactiveFormsModule, } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    CategoryComponent,
    EditCategoryComponent,
    AddCAtegoryComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
