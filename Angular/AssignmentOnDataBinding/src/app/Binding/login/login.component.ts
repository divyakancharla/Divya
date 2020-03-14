import { Component, OnInit } from '@angular/core';
import { Log } from '../log';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
item:Log;
res:string;

  constructor() { 
    this.item=new Log();
  }

  ngOnInit() {
    console.log(this.res)
  }
 check(name:string,pass:string){
   if(name=="Admin" && pass=="1234"){
    // this.res="Login Success";
     console.log("Login Success");
    }
      else{
      //  this.res="Login Failed";
        console.log("Login Failed");
      }
   }
 }

