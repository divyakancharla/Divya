import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './Interpolation/demo/demo.component';
import { ViewsComponent } from './Interpolation/views/views.component';
import { ViewCustomerComponent } from './Views/view-customer/view-customer.component';
import { EventDemoComponent } from './EventBinding/event-demo/event-demo.component';
import { AddSubComponent } from './Calculate/add-sub/add-sub.component';
import { Demo1Component } from './TwoWayBinding/demo1/demo1.component';
import { Demo2Component } from './TwoWayBinding/demo2/demo2.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    ViewsComponent,
    ViewCustomerComponent,
    EventDemoComponent,
    AddSubComponent,
    Demo1Component,
    Demo2Component
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
