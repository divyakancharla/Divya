import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-demo11',
  templateUrl: './demo11.component.html',
  styleUrls: ['./demo11.component.css']
})
export class Demo11Component implements OnInit {
  val:boolean=false;
list:Student[]=[];
sid:number;
sname:string;
std:string;
stds:string[]=["I","II","III"];
age:number;
item:Student;
  constructor() {
    this.list=[{sid:16,sname:'Rohan',std:'it',age:12},{sid:13,sname:'Roheni',std:'Uit',age:12},{sid:16,sname:'Mohan',std:'it',age:12},{sid:12,sname:'Mohini',std:'iGt',age:12},
    {sid:15,sname:'Kahan',std:'it',age:15},{sid:14,sname:'Komani',std:'it',age:12},{sid:11,sname:'RohanayA',std:'iMt',age:12}]

   }

  ngOnInit() {
  }
public Add(){
  this.item=new Student();
  this.item.sid=this.sid;
  this.item.sname=this.sname;
  this.item.std=this.std;
  this.item.age=this.age;
  this.list.push(this.item);
  console.log(this.item)
}
}
