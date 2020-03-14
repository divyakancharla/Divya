import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Employe } from '../employe';


@Component({
  selector: 'app-assignment-employe',
  templateUrl: './assignment-employe.component.html',
  styleUrls: ['./assignment-employe.component.css']
})
export class AssignmentEmployeComponent implements OnInit {
  submitted=false;
RegisterForm:FormGroup;
emp:Employe;
emp1:Employe[]=[];
  constructor(private Form:FormBuilder) { 
    
  }

  ngOnInit() {
    this.RegisterForm=this.Form.group({
      Id:['',[Validators.required,Validators.pattern("^[A-Z][0-9]{4}")]],
      Name:['',[Validators.required,Validators.pattern("^[A-Z]{3}$")]],
      Joindt:['',Validators.required],
      Desg:['',Validators.required],
      Mobile:['',[Validators.required,Validators.pattern("^[6,9][0-9]{9}$")]],
      email:['',Validators.email],
      password:['',[Validators.required,Validators.pattern("^[0-9A-Za-z]{5}[!@#$%^&*]{1}$")]]
    })
  }
  onSubmit()
{
  this.submitted=true;
  if(this.RegisterForm.valid)
  {
    this.emp=new Employe();
    this.emp.id=this.RegisterForm.value["Id"];
    this.emp.name=this.RegisterForm.value["Name"];
    this.emp.Joindt=new Date(this.RegisterForm.value["Joindt"])
    this.emp.desg=this.RegisterForm.value["Desg"]
    this.emp.mobile=this.RegisterForm.value["Mobile"]
    this.emp.email=this.RegisterForm.value["email"]
    this.emp.password=this.RegisterForm.value["password"]
    this.emp1.push(this.emp);
  }
}
  get f() {return this.RegisterForm.controls;}
  onReset(){
    this.submitted=false;
    this.RegisterForm.reset();
  }
  }

