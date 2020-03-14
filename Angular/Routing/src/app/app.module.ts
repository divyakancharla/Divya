import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './About/about/about.component';
import { HomeComponent } from './Home/home/home.component';
import { ContactComponent } from './Contact/contact/contact.component';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './user/user.component';
import { About1Component } from './About/about1/about1.component';
import { About2Component } from './About/about2/about2.component';

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    HomeComponent,
    ContactComponent,
    LoginComponent,
    UserComponent,
    About1Component,
    About2Component
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
