import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../Services/calculate.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor(private service:CalculateService) { }

  ngOnInit() {
    console.log('Add'+this.service.Add(12,34));
    console.log('Mul'+this.service.Mul(2,3));
    console.log('Hello'+this.service.Greet('deepu'));

  }

}
