import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import * as ChartJs from 'chart.js';

@Component({
  selector: 'app-barchart',
  templateUrl: './barchart.component.html',
  styleUrls: ['./barchart.component.scss']
})
export class BarchartComponent implements OnInit {

  @ViewChild('#canvas')
  canvas: ElementRef;

  constructor() { }

  ngOnInit(): void {
  }

}
