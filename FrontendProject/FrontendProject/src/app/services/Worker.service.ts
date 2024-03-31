import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class WorkerService {
  constructor(private http: HttpClient) {}

  getWorker(): Observable<any[]> {
    return this.http.get<any[]>('https://jsonplaceholder.typicode.com/todos');
  }

  updateWorker(data: any): Observable<any> {
    return this.http.put<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  createWorker(data: any): Observable<any> {
    return this.http.post<any>(
      'https://jsonplaceholder.typicode.com/todos',
      data
    );
  }

  deleteWorker(id: number): Observable<any> {
    return this.http.delete<any>('https://jsonplaceholder.typicode.com/todos');
  }
}
