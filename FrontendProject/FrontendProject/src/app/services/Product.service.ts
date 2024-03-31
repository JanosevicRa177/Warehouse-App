import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ProductService {

  constructor(private http: HttpClient) { } 
  
  getProduct(): Observable<any[]> {
  	return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }
  
  updateProduct(data: any): Observable<any> {
  	return this.http.put<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  createProduct(data: any): Observable<any> {
  	return this.http.post<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  deleteProduct(id: number): Observable<any> {
  	return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
