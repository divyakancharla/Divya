import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../Services/calculate.service';

@Component({
  selector: 'app-test1',
  templateUrl: './test1.component.html',
  styleUrls: ['./test1.component.css'],
  providers:[CalculateService]
})
export class Test1Component implements OnInit {

  constructor(private services:CalculateService ) { }

  ngOnInit() {
  }
f(){
  console.log(this.services.Greet(''));
}
}
