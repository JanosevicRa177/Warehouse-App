import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class WarehouseService {

  constructor(private http: HttpClient) { } 
  
  getWarehouse(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/warehouse/');
  }
  
  updateWarehouse(data: any): Observable<any> {
  	return this.http.put<any>('http://localhost:8000/warehouse/' + data.id, data);
  }
  
  createWarehouse(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/warehouse/', data);
  }
  
  deleteWarehouse(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/warehouse/' + id);
  }
}
