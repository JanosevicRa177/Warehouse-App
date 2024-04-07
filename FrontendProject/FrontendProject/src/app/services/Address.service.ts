import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AddressService {

  constructor(private http: HttpClient) { } 
  
  getAddress(): Observable<any[]> {
  	return this.http.get<any[]>('http://localhost:8000/address/');
  }
  
  updateAddress(data: any): Observable<any> {
  	return this.http.put<any>('http://localhost:8000/address/' + data.id, data);
  }
  
  createAddress(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/address/', data);
  }
  
  deleteAddress(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/address/' + id);
  }
}
