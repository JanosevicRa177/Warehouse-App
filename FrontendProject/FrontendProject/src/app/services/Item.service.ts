import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ItemService {
  constructor(private http: HttpClient) {}

  getItem(): Observable<any[]> {
    return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }

  updateItem(data: any): Observable<any> {
    return this.http.put<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  createItem(data: any): Observable<any> {
    return this.http.post<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  deleteItem(id: number): Observable<any> {
    return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
