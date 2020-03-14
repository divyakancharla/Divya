import { Component, OnInit } from '@angular/core';
import { Task } from '../Models/task';

@Component({
  selector: 'app-view-task',
  templateUrl: './view-task.component.html',
  styleUrls: ['./view-task.component.css']
})
export class ViewTaskComponent implements OnInit {
dat:Task[];
  constructor() {
      this.dat=JSON.parse(localStorage.getItem("un"));

   }

  ngOnInit() {
  }

}
