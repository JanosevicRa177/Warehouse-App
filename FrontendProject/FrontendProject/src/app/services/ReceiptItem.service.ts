import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ReceiptItemService {

  constructor(private http: HttpClient) { } 
  
  getReceiptItem(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/receipt-item/');
  }
  
  updateReceiptItem(data: any): Observable<any> {
  	return this.http.patch<any>('http://localhost:8000/receipt-item/' + data.id, data);
  }
  
  createReceiptItem(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/receipt-item/', data);
  }
  
  deleteReceiptItem(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/receipt-item/' + id);
  }
}
