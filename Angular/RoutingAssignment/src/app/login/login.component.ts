import { Component, OnInit } from '@angular/core';
import{Router} from '@angular/router';
import { from } from 'rxjs';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
Bname:string;
errmsg:string;
Bpass:string;

  constructor(private route:Router)
   { 
   
  }

  ngOnInit() {
  }
public validate(){
  if(this.Bname=="steve" && this.Bpass=="1234"){
    sessionStorage.setItem("un",this.Bname);
    this.route.navigateByUrl('Buyer');
  }
  else if(this.Bname=="dustibun" && this.Bpass=="1234"){
    sessionStorage.setItem("un",this.Bname);
    this.route.navigateByUrl('seller');
  }
  else if(this.Bname=="suzypo" && this.Bpass=="1234"){
    sessionStorage.setItem("un",this.Bname);
    this.route.navigateByUrl('Admin');
  }
  else{
    this.errmsg="Invalid Credentials";
  }
}
}
