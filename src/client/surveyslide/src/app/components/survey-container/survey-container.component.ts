import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-survey-container',
  templateUrl: './survey-container.component.html',
  styleUrls: ['./survey-container.component.scss']
})
export class SurveyContainerComponent implements OnInit {

  surveys: any[] = [];
  slides: any[] = [];
  currentSlide: any;

  constructor(private http: HttpClient) {
    this.http.get('surveys').subscribe((result: any[]) => {
      this.surveys = result;
    });
  }

  controlsChange(event) {
    const slides = this.surveys.find(s => s.id === event.survey).slides;
    this.slides = slides;
    this.currentSlide = (this.slides && event.slide) ? this.slides.find(slide => slide.id === event.slide) : null;
  }

  ngOnInit(): void {
  }

}
