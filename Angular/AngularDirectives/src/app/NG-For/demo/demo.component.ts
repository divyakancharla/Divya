import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  no:number[]=[12,13,21,23,343,321,1]
  name:string[]=["Rahul","Divya","Vasu","lalli","Sindhu"]
  constructor() { 
    this.name.concat("Rohan");
  }

  ngOnInit() {
  }

}
