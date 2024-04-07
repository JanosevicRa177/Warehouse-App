import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class UserService {

  constructor(private http: HttpClient) { } 
  
  getUser(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/user/');
  }
  
  updateUser(data: any): Observable<any> {
  	return this.http.patch<any>('http://localhost:8000/user/' + data.id, data);
  }
  
  createUser(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/user/', data);
  }
  
  deleteUser(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/user/' + id);
  }
}
