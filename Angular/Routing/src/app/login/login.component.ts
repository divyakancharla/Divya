import { Component, OnInit } from '@angular/core';
import{Router} from '@angular/router';
import { from } from 'rxjs';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
uname:string;
pwd:string;
errmsg:string;
constructor( private route:Router) { }
public validate(){
  if(this.uname=="deepu" && this.pwd=="1234")
  {
    sessionStorage.setItem("un",this.uname);
    this.route.navigateByUrl('user')
  }
  else{
    this.errmsg="Invalid Login Details";
  }
}
  

  ngOnInit() {
  }

}
