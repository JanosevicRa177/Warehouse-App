import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ReceiptService {

  constructor(private http: HttpClient) { } 
  
  getReceipt(): Observable<any[]> {
  	return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }
  
  updateReceipt(data: any): Observable<any> {
  	return this.http.put<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  createReceipt(data: any): Observable<any> {
  	return this.http.post<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  deleteReceipt(id: number): Observable<any> {
  	return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
