import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-on-directives',
  templateUrl: './on-directives.component.html',
  styleUrls: ['./on-directives.component.css']
})
export class OnDirectivesComponent implements OnInit {
obj:Employee[]=[];
    pid:number;
    pname:string;
    domain:string;
    startdt:Date;
    enddt:Date;
    item:Employee;
  constructor() {
   
    this.obj=[{pid:45,pname:"divya",domain:"java",startdt:new Date("09/08/1998"),enddt:new Date("09/08/2020")}]
   }

  ngOnInit() {
  }
public Add(){
  this.item=new Employee();
  this.item.pid=this.pid;
  this.item.pname=this.pname;
  this.item.domain=this.domain;
  this.item.startdt=this.startdt;
  this.item.enddt=this.enddt;
  this.obj.push(this.item)
}
}
