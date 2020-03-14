import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Demo1Component } from './NG-IF/demo1/demo1.component';
import { DemoComponent } from './NG-For/demo/demo.component';
import { Demo11Component } from './NG-For/demo11/demo11.component';
import { OnDirectivesComponent } from './Assignment/on-directives/on-directives.component';
import { SwitchIntroComponent } from './NG-Switch/switch-intro/switch-intro.component';


@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    DemoComponent,
    Demo11Component,
    OnDirectivesComponent,
    SwitchIntroComponent
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
