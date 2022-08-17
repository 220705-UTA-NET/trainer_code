import { Component, OnInit } from '@angular/core';
import { HttpService } from '../Services/http-service.service';
import { post } from '../Models/post';

@Component({
  selector: 'app-time',
  templateUrl: './time.component.html',
  styleUrls: ['./time.component.css']
})
export class TimeComponent implements OnInit {

  posts: any;

  constructor(public PS: HttpService) { }

  ngOnInit(): void {
  }

  displayPosts() {
    this.PS.getPosts().subscribe((data) => {
      this.posts = data;
    });
  }
}
