import { Component, OnInit } from '@angular/core';

@Component({

  templateUrl: './first-page.component.html',
  styleUrls: ['./first-page.component.css']
})
export class FirstPageComponent implements OnInit {
  title:string="Firstpage";
  name:string="sandhya";
  date:string="2-11-2020";
  constructor() { }

  ngOnInit() {
  }

}
