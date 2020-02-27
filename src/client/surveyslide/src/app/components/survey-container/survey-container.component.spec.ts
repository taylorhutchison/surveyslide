import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SurveyContainerComponent } from './survey-container.component';

describe('SurveyContainerComponent', () => {
  let component: SurveyContainerComponent;
  let fixture: ComponentFixture<SurveyContainerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SurveyContainerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SurveyContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
