import { Component, OnInit } from '@angular/core';
import{Router} from '@angular/router'
import { from } from 'rxjs';
@Component({
  selector: 'app-buyer',
  templateUrl: './buyer.component.html',
  styleUrls: ['./buyer.component.css']
})
export class BuyerComponent implements OnInit {
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
