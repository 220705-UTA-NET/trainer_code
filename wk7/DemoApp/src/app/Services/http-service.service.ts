import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { post } from '../Models/post';


@Injectable({
  providedIn: 'root'
})

export class HttpService {

  private jsonplaceholder = 'https://jsonplaceholder.typicode.com/';
  private helloapp = 'http://localhost:8080/';

  constructor(private http: HttpClient) { }
  
  public getPosts(): Observable<post[]> 
  {
    return this.http.get<post[]>(this.jsonplaceholder + 'posts');
  }

  public getTime(): Observable<any>
  {
    return this.http.get<any>(this.helloapp + 'time');
  }
}

