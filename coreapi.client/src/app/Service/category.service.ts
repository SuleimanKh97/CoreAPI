import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http: HttpClient) { }

  getCategory() {
    return this.http.get('https://localhost:7044/Category/getAllCategory')
  }

  getCAtegorynew() {
    return this.http.get("https://localhost:7044/Category/getAllCategory")
  }

  addCategory(data: any) {
    return this.http.post('https://localhost:7044/Category/addCategory', data)
  }
}
