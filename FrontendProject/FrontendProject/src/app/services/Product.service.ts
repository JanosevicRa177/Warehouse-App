import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ProductService {

  constructor(private http: HttpClient) { } 
  
  getProduct(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/product/');
  }
  
  updateProduct(data: any): Observable<any> {
  	return this.http.put<any>('http://localhost:8000/product/' + data.id, data);
  }
  
  createProduct(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/product/', data);
  }
  
  deleteProduct(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/product/' + id);
  }
}
