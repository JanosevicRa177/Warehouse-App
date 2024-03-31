import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class WarehouseService {
  constructor(private http: HttpClient) {}

  getWarehouse(): Observable<any[]> {
    return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }

  updateWarehouse(data: any): Observable<any> {
    return this.http.put<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  createWarehouse(data: any): Observable<any> {
    return this.http.post<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  deleteWarehouse(id: number): Observable<any> {
    return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
