import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{ReactiveFormsModule} from '@angular/forms';
//import{FormModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PlaceorderComponent } from './placeorder/placeorder.component';

@NgModule({
  declarations: [
    AppComponent,
    PlaceorderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  
  ],
  providers: [],
  bootstrap: [PlaceorderComponent]
})
export class AppModule { }
