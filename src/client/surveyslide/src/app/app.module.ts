import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule, HttpClient, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ProxyInterceptor } from './http-interceptors/proxy.interceptor';
import { SlideContainerComponent } from './components/slide-container/slide-container.component';
import { BannerComponent } from './components/banner/banner.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { SurveyContainerComponent } from './components/survey-container/survey-container.component';
import { BarchartComponent } from './components/barchart/barchart.component';


@NgModule({
  declarations: [
    AppComponent,
    SlideContainerComponent,
    BannerComponent,
    SurveyContainerComponent,
    BarchartComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatToolbarModule,
    MatSelectModule,
    MatInputModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: ProxyInterceptor, multi: true },
    HttpClient
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
