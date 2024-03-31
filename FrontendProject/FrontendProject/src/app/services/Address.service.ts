import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AddressService {

  constructor(private http: HttpClient) { } 
  
  getAddress(): Observable<any[]> {
  	return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }
  
  updateAddress(data: any): Observable<any> {
  	return this.http.put<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  createAddress(data: any): Observable<any> {
  	return this.http.post<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  deleteAddress(id: number): Observable<any> {
  	return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
