import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/Models/customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {
  obj:Customer;
  
  constructor() {
    this.obj={cName:"Steve",Email:"Steeve@abc.com",Mobile:2344234,City:"US",Address:"7th cross,2nd Street,Dolphin,US,42445"};
   }

  ngOnInit() {
  }

}
