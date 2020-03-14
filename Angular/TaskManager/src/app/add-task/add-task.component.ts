import { Component, OnInit } from '@angular/core';
import { Task } from '../Models/task';
import{Router} from "@angular/router";
import { from } from 'rxjs';
@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {

  obj:Task[]=[];
  obj1:Task;
  name:string;
  priority:number;
  startdt:Date;
  enddt:Date;
  constructor(private route:Router) {
    

   }

  ngOnInit() {
  }
  public add(){
    this.obj1=new Task();
    this.obj1.name=this.name;
    this.obj1.priority=this.priority;
    this.obj1.startdt=new Date(this.startdt);
    this.obj1.enddt=new Date(this.enddt);
    if(localStorage.getItem("ui"))
    {
      this.obj=JSON.parse(localStorage.getItem("ui"));
    }
    this.obj.push(this.obj1);
   localStorage.setItem("un",JSON.stringify(this.obj))
   // sessionStorage.setItem(this.obj);
  }
public reset(){
  localStorage.clear();
  this.route.navigateByUrl("add-task");
}


}
