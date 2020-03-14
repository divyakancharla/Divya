import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-views',
  templateUrl: './views.component.html',
  styleUrls: ['./views.component.css']
})
export class ViewsComponent implements OnInit {
  obj:Student;
  url:string="E:/Images/moanaa.jpg";
  constructor() { 
    this.obj=new Student();
    this.obj.Sid=1;
    this.obj.Sname='Dustin';
    this.obj.Dob=new Date(1984,12,23);
    this.obj.Age=34;
    this.obj.std='eleven';
  }

  ngOnInit() {
  }

}
