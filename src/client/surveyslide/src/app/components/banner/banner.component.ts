import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.scss']
})
export class BannerComponent implements OnInit {

  @Input()
  slides: any[] = [];

  @Input()
  surveys: any[] = [];

  @Output()
  controlsChange = new EventEmitter<any>();

  title = 'Survey Slide';

  controls: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.controls = this.fb.group({
      survey: null,
      slide: null
    });

    this.controls.valueChanges.subscribe(change => this.controlsChange.emit(change));
  }

}
