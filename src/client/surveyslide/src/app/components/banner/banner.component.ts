import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.scss']
})
export class BannerComponent implements OnInit {

  title = 'Survey Slide';

  slides = [ { id: 1, title: 'omg'}, { id: 2, title: 'abc'} ];

  constructor() { }

  ngOnInit(): void {
  }

}
