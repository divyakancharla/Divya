import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import {AppRoutingModule} from './app-routing.module' ;
import { AppComponent } from './app.component';
import { FirstPageComponent } from './MyDemo/first-page.component';
import { SecondPageComponent } from './MyDemo/second-page.component';
import { RouterModule,Routes } from '@angular/router';
const  appRoutes:Routes=[
  {path:"app-first-page",component:FirstPageComponent},
  {path:"app-second-page",component:SecondPageComponent},
  {path:"",redirectTo:"/app-first-page",pathMatch:"full"}
 ]
@NgModule({
  declarations: [
    AppComponent,
    FirstPageComponent,
    SecondPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
