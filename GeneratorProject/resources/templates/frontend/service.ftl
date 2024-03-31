import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ${class.name}Service {

  constructor(private http: HttpClient) { } 
  
  <#if class.crud.read == true >
  get${class.name}(): Observable<any[]> {
  	return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }
  </#if>  
  
  <#if class.crud.update == true >
  update${class.name}(data: any): Observable<any> {
  	return this.http.put<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  </#if>
  
  <#if class.crud.create == true >
  create${class.name}(data: any): Observable<any> {
  	return this.http.post<any>('https://jsonplaceholder.typicode.com/todos', data);
  }
  </#if>
  
  <#if class.crud.delete == true >
  delete${class.name}(id: number): Observable<any> {
  	return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
  </#if>
}
