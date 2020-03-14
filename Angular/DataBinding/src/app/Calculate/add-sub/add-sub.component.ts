import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-sub',
  templateUrl: './add-sub.component.html',
  styleUrls: ['./add-sub.component.css']
})
export class AddSubComponent implements OnInit {
  res:number;
  constructor() { }

  ngOnInit() {
  }
public add(a:number,b:number){
 this.res=Number(a)+Number(b);

}
public sub(a:number,b:number){
  this.res=a-b;
 }
}
