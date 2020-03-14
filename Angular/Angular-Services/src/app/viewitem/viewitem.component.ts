import { Component, OnInit } from '@angular/core';
import{FormBuilder,FormGroup,Validators} from '@angular/forms';
import { from } from 'rxjs';
import { ItemService } from '../Services/item.service';
import { Item } from '../item';
@Component({
  selector: 'app-viewitem',
  templateUrl: './viewitem.component.html',
  styleUrls: ['./viewitem.component.css']
})
export class ViewitemComponent implements OnInit {
itemForm:FormGroup;
submitted:boolean=false;
list:Item[];
item:Item;
  constructor(private builder:FormBuilder,private service:ItemService) { 
    this.service.GetAll().subscribe(res=>{this.list=res},err=>{console.log(err)})
  }

  ngOnInit() {
    this.itemForm=this.builder.group({
      itemid:[''],
      name:[''],
      price:[''],
      stock:['']
    });
  }
  get f() { return this.itemForm.controls; }

  onSubmit() {
      this.submitted = true;
      if(this.itemForm.valid){
        
      }
  }

  onReset() {
      this.submitted = false;
      this.itemForm.reset();
  }
  Search()
  {
    let id=this.itemForm.value["itemid"];
  this.service.GetById(id).subscribe(res=>
    
   {
     this.item=res;
     console.log(this.item);
     this.itemForm.setValue({
       itemid:this.item.itemid,
       name:this.item.name,
       price:this.item.price,
       stock:this.item.stock,
     })
    
  })}
Add(){
  this.item=new Item();
  this.item.itemid=this.itemForm.value['itemid'];
  this.item.name=this.itemForm.value['name'];
  this.item.price=Number(this.itemForm.value['price']);
  this.item.stock=Number(this.itemForm.value['stock']);
  console.log(this.item);
  this.service.Add(this.item).subscribe();

}
Delete(){
  let id=this.itemForm.value["itemid"];
  this.service.Delete(id).subscribe();
}
Update(){
 this.item=new Item();
  this.item.itemid=this.itemForm.value['itemid'];
  this.item.name=this.itemForm.value['name'];
  this.item.price=Number(this.itemForm.value['price']);
  this.item.stock=Number(this.itemForm.value['stock']);
  console.log(this.item);
  this.service.Update(this.item).subscribe();
}
}
