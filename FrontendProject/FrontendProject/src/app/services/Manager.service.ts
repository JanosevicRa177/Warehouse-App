import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ManagerService {
  constructor(private http: HttpClient) {}

  getManager(): Observable<any[]> {
    return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }

  updateManager(data: any): Observable<any> {
    return this.http.put<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  createManager(data: any): Observable<any> {
    return this.http.post<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  deleteManager(id: number): Observable<any> {
    return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
