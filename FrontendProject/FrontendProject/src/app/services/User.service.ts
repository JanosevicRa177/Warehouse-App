import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class UserService {

  constructor(private http: HttpClient) { } 
  
  getUser(): Observable<any[]> {
  	return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }
  
  updateUser(data: any): Observable<any> {
  	return this.http.put<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  createUser(data: any): Observable<any> {
  	return this.http.post<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  
  deleteUser(id: number): Observable<any> {
  	return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
