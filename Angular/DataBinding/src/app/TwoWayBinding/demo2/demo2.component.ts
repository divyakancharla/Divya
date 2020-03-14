import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';
import { Employe } from '../employe';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
item:Employe
  constructor() { 
    this.item=new Employe();
  }

  ngOnInit() {
  }
public Add(){
  console.log(this.item)
}
}
