import { Component, OnInit, Input, SimpleChanges, OnChanges } from '@angular/core';

@Component({
  selector: 'app-slide-container',
  templateUrl: './slide-container.component.html',
  styleUrls: ['./slide-container.component.scss']
})
export class SlideContainerComponent implements OnInit, OnChanges {

  @Input()
  slide: any;

  categories = [];
  series = [];

  constructor() { }

  ngOnInit(): void {
  }

  ngOnChanges(changes: SimpleChanges) {
    if  (this.slide) {
      this.categories = this.slide.options.map(s => s.title);
      this.series = this.slide.options.map(s => s.count);
    }
  }

}
