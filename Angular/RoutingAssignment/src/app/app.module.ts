import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { BuyitemComponent } from './Buyer/buyitem/buyitem.component';
import { ViewCartComponent } from './Buyer/view-cart/view-cart.component';
import { PaymentComponent } from './Buyer/payment/payment.component';
import { AdditemComponent } from './Seller/additem/additem.component';
import { ViewitemsComponent } from './Seller/viewitems/viewitems.component';
import { AddCategoryComponent } from './Admin/add-category/add-category.component';
import { AddRemoveSellerComponent } from './Admin/add-remove-seller/add-remove-seller.component';
import { AddRemoveBuyerComponent } from './Admin/add-remove-buyer/add-remove-buyer.component';
import { from } from 'rxjs';
import { BuyerComponent } from './Buyer/buyer.component';
import { SellerComponent } from './Seller/seller.component';
import { AdminComponent } from './Admin/admin.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    BuyitemComponent,
    ViewCartComponent,
    PaymentComponent,
    AdditemComponent,
    ViewitemsComponent,
    AddCategoryComponent,
    AddRemoveSellerComponent,
    AddRemoveBuyerComponent,
    BuyerComponent,
    SellerComponent,
    AdminComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
