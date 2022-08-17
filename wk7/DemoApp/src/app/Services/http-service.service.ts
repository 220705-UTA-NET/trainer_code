import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { post } from '../Models/post';


@Injectable({
  providedIn: 'root'
})

export class HttpService {

  private rootUrl = 'http://jsonplaceholder.typicode.com/';

  constructor(private http: HttpClient) { }
  
  public getPosts(): Observable<post[]> 
  {
    return this.http.get<post[]>(this.rootUrl + 'posts');
  }
}

