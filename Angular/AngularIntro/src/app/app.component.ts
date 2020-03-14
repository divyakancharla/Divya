import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularIntro';
  isdisabled:Boolean=false;
  imagepath:string='assets/Images/moana.jpg';
  mystyle:string="boldclass italiclass";
  getname():string{
    return this.title;
  }
}
