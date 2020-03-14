import { Component, OnInit } from '@angular/core';
import { Item } from '../item';
import { ItemService } from '../Services/item.service';
import { Order } from '../order';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
list:Order[]=[];
fileData: File = null;
items:Order;
form:FormGroup
uploadedFilePath: string = null;
name:string;
img:string;
selectedFile : File = null;
  constructor(private item:ItemService,private forms:FormBuilder) { }

  ngOnInit() 
  {
    this.form=this.forms.group({
      itemid:[''],
      image:['']
    })

  }
    // this.item.GetAll().subscribe(res=>{this.list=res
    // console.log(this.list);
    // },
    // err=>{console.log(err)});

  
public add(){
  // this.item.GetAll().subscribe(res=>{this.list=res
  //   console.log(this.list);
  //   },
  //   err=>{console.log(err)});
}

  fileEvent(event){
    this.img = event.target.files[0].name;
}

filechange()
{
  this.items=new Order();
  this.items.images=this.img;
  this.items.itemid='1003',
  this.items.orderdate=new Date("09-08-2019");
  this.items.orderid='005';
  console.log(this.items);
  this.list.push(this.items)
  this.item.add(this.items).subscribe(res=>{this.items=res,console.log(this.items)})
}
}
