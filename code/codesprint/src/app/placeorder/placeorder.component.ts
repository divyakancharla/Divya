import { Component, OnInit, ViewChild } from '@angular/core';
import{FormBuilder, FormGroup, Validators} from '@angular/forms'
@Component({
  selector: 'app-placeorder',
  templateUrl: './placeorder.component.html',
  styleUrls: ['./placeorder.component.css']
})
export class PlaceorderComponent implements OnInit {

  show: false;
  name:string;
PlaceForm:FormGroup;
submitted=false;
  constructor(private formbuild:FormBuilder) { 

  }

  ngOnInit() {
   this.PlaceForm= this.formbuild.group({
     Inr: ['', [Validators.required, Validators.pattern('^[0-9]{1,8}$')]],
     Paisa: ['', [Validators.required, Validators.pattern('^[0-99]{1,2}$')]],
     Firstname: ['', [Validators.required, Validators.pattern('^[a-zA-Z]{5,20}$')]],
     Lastname: ['', [Validators.required, Validators.pattern('^[a-zA-Z]{5,20}$')]],
     Street: ['', [Validators.required, Validators.pattern('^[a-zA-Z0-9-:]{3,30}$')]],
     City: ['', [Validators.required, Validators.pattern('^[a-zA-Z]{3,30}$')]],
     State: ['', [Validators.required, Validators.pattern('^[a-zA-Z]{3,30}$')]],
     Pincode: ['', [Validators.required, Validators.pattern('^[0-9]{6}$')]],
     Bfirstname: ['', [Validators.required, Validators.pattern('^[a-zA-Z]{5,20}$')]],
     Blastname: ['', [Validators.required, Validators.pattern('^[a-zA-Z]{5,20}$')]],
     Email: ['', [Validators.required, Validators.email]],
     Country: ['', Validators.required],
     Mobileno: ['', [Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
    })
  }
  get f()
  {
    return this.PlaceForm.controls;
  }
 
  onSubmit()
  {
  this.submitted=true;
  if(this.PlaceForm.valid){
    return this.reset();
  }else{
    alert("invalid")
  }
  }
  reset() {
   this.PlaceForm.reset();
  }
   
  }
  




