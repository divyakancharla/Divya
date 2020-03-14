import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'my-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent 
 {
firstname:string='rani';
lastname:string='raj';
email:string='Sandhyayenikapati@gamil.com';
age:number=20;
getStyle()
{
let styles={"font-style":"italic","color":"green"}
return styles;
}
onClick()
{
  console.log("You Clicked");
}
}
