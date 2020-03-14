import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularDemo';
  Customer:any[]=[{name:'fasakk',country:'India',Age:23},{name:"Nakk",country:'India',Age:45},{name:'Odhuu',country:'Africa',Age:87}]
  Student:any[]=[
    {professiom:'farmer',"student":[{name:'Ohoooh',country:'India',Age:23}]},
    {professiom:'Painter',"student":[{name:"Ahhaaa",country:'India',Age:45}]},
    {professiom:'Scientist',"student":[{name:'Eheee',country:'Africa',Age:87}]}];
    name:string='divya';
    //divya:boolean=false;
}

