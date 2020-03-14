import { Component, OnInit } from '@angular/core';
import{Router} from '@angular/router';
@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  uname:string;
  constructor( private route:Router) {
    if(sessionStorage.getItem("un")){
      this.uname=sessionStorage.getItem("un")
    }
    else{
      route.navigateByUrl("Login");
    }
   }
   public logout(){
     sessionStorage.clear();
     this.route.navigateByUrl('Login');
   }


  ngOnInit() {
  }

}
