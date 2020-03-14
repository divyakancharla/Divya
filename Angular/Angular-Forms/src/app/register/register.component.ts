import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { $ } from 'protractor';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  RegisterForm:FormGroup;
submitted=false;
  constructor(private fomBuilder:FormBuilder) { 
  }

  ngOnInit() {
    this.RegisterForm=this.fomBuilder.group({
     title:['',Validators.required],
     firstName:['',[Validators.required,Validators.pattern("^[a-z]{3,6}$")]],
     lastName:['',Validators.required],
     mobile:['',[Validators.required,Validators.pattern("^[6,9][0-9]{9}$")]],
     email:['',[Validators.required,Validators.email]],
     password:['',[Validators.required,Validators.minLength(6)]],
     accepTerms:['',[Validators.requiredTrue]]
    });
  }
onSubmit()
{
  this.submitted=true;
  if(this.RegisterForm.valid)
  {
    alert("valid");
  }

}
get f() {return this.RegisterForm.controls;}
onReset(){
  this.submitted=false;
  this.RegisterForm.reset();
}
}

