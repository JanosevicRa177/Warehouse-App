import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ItemService {

  constructor(private http: HttpClient) { } 
  
  getItem(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/item/');
  }
  
  updateItem(data: any): Observable<any> {
  	return this.http.patch<any>('http://localhost:8000/item/' + data.id, data);
  }
  
  createItem(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/item/', data);
  }
  
  deleteItem(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/item/' + id);
  }
}
