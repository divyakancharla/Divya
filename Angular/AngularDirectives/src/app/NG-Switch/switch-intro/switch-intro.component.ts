import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-switch-intro',
  templateUrl: './switch-intro.component.html',
  styleUrls: ['./switch-intro.component.css']
})
export class SwitchIntroComponent implements OnInit {
items:any[]=[{name:'one',val:2},{name:'Two',val:3},{name:'Three',val:4}];
select:string='one';
  constructor() { }

  ngOnInit() {
  }

}
