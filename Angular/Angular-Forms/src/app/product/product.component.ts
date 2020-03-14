import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
product:FormGroup;
submit:boolean=false;
  constructor(private form:FormBuilder) { 

  }

  ngOnInit() {
    this.product=this.form.group({
      id:['',Validators.required],
      name:['',Validators.required],
      price:['',Validators.required],
      stock:['',Validators.required]})

  }
  get f(){
    return this.product.controls;
  }
Add(){
  this.submit=true;
  if(this.product.invalid){
    return
  }
  else{
    alert("Valid")
  }

}
onReset(){
  this.submit=false;
  this.product.reset();
}
}
