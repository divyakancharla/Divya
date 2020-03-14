import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { BuyitemComponent } from './Buyer/buyitem/buyitem.component';
import { ViewCartComponent } from './Buyer/view-cart/view-cart.component';
import { PaymentComponent } from './Buyer/payment/payment.component';
import { BuyerComponent } from './Buyer/buyer.component';
import { SellerComponent } from './Seller/seller.component';
import { AdditemComponent } from './Seller/additem/additem.component';
import { ViewitemsComponent } from './Seller/viewitems/viewitems.component';
import { AdminComponent } from './Admin/admin.component';
import { AddCategoryComponent } from './Admin/add-category/add-category.component';
import { AddRemoveBuyerComponent } from './Admin/add-remove-buyer/add-remove-buyer.component';
import { AddRemoveSellerComponent } from './Admin/add-remove-seller/add-remove-seller.component';


const routes: Routes = [
  {path:"Login",component:LoginComponent},
  {path:"Buyer",component:BuyerComponent,children:[{
    path:"Buyitem",component:BuyitemComponent},{ path:"Viewcart",component:ViewCartComponent},
    {path:"payment",component:PaymentComponent}]},
  {path:"seller",component:SellerComponent,children:[{
    path:"Additem",component:AdditemComponent},{path:"viewitems",component:ViewitemsComponent}
  ]},
  {path:"Admin",component:AdminComponent,children:[{
    path:"add-category",component:AddCategoryComponent},{path:"add-remove-buyer",component:AddRemoveBuyerComponent},
    {path:"add-remove-seller",component:AddRemoveSellerComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
