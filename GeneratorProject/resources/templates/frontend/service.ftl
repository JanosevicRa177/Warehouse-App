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
  	return this.http.get<any[]>('http://localhost:8000/${class.crud.path}/');
  }
  </#if>  
  
  <#if class.crud.update == true >
  update${class.name}(data: any): Observable<any> {
  	return this.http.patch<any>('http://localhost:8000/${class.crud.path}/' + data.id, data);
  }
  </#if>
  
  <#if class.crud.create == true >
  create${class.name}(data: any): Observable<any> {
  	return this.http.post<any>('http://localhost:8000/${class.crud.path}/', data);
  }
  </#if>
  
  <#if class.crud.delete == true >
  delete${class.name}(id: number): Observable<any> {
  	return this.http.delete<any>('http://localhost:8000/${class.crud.path}/' + id);
  }
  </#if>
}
