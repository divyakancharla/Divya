import { Component } from '@angular/core';
import { Data } from '@angular/router';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'pipes';
  price:number=20;
  dob:Date=new Date(1998,7,9);
}
