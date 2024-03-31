import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ReceiptItemService {
  constructor(private http: HttpClient) {}

  getReceiptItem(): Observable<any[]> {
    return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }

  updateReceiptItem(data: any): Observable<any> {
    return this.http.put<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  createReceiptItem(data: any): Observable<any> {
    return this.http.post<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  deleteReceiptItem(id: number): Observable<any> {
    return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
