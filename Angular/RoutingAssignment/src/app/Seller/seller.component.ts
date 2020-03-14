import { Component, OnInit } from '@angular/core';
import{Router} from '@angular/router'
@Component({
  selector: 'app-seller',
  templateUrl: './seller.component.html',
  styleUrls: ['./seller.component.css']
})
export class SellerComponent implements OnInit {

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
