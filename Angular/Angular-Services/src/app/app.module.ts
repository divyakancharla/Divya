import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalculateService } from './Services/calculate.service';
import { TestComponent } from './test/test.component';
import { Test1Component } from './test1/test1.component';
import {ReactiveFormsModule} from '@angular/forms';
import { from } from 'rxjs';
import { DemoComponent } from './demo/demo.component';
import { ItemService } from './Services/item.service';
import { ViewitemComponent } from './viewitem/viewitem.component';
@NgModule({
  declarations: [
    AppComponent,
    TestComponent,
    Test1Component,
    DemoComponent,
    ViewitemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [CalculateService,ItemService],
  bootstrap: [DemoComponent]
})
export class AppModule { }
