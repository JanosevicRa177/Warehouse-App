import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ReceiptService {

  constructor(private http: HttpClient) { } 
  
  getReceipt(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/receipt/');
  }
  
  updateReceipt(data: any): Observable<any> {
  	return this.http.patch<any>('http://localhost:8000/receipt/' + data.id, data);
  }
  
  createReceipt(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/receipt/', data);
  }
  
  deleteReceipt(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/receipt/' + id);
  }
}
