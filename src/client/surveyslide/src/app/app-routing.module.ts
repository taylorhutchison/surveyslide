import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SurveyContainerComponent } from './components/survey-container/survey-container.component';


const routes: Routes = [
  { path: 'survey/:id', component: SurveyContainerComponent },
  { path: '', component: SurveyContainerComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
