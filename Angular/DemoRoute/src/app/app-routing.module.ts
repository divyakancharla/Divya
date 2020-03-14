import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {FirstPageComponent} from './MyDemo/first-page.component';
import {SecondPageComponent} from './MyDemo/second-page.component';
import {AppComponent} from './app.component';


const routes: Routes = [
  {path:"app-first-page",component:FirstPageComponent},
  {path:"app-second-page",component:SecondPageComponent},
  {path:"",redirectTo:"/app-first-page",pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
