import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Home/home/home.component';
import { AboutComponent } from './About/about/about.component';
import { ContactComponent } from './Contact/contact/contact.component';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './user/user.component';
import { About1Component } from './About/about1/about1.component';
import { About2Component } from './About/about2/about2.component';


const routes: Routes = [
  {path:'home',component:HomeComponent},
  {path:'about',component:AboutComponent,children:
  [{path:'about1',component:About1Component},
  {path:'about2',component:About2Component}]},
  {path:'contact',component:ContactComponent},
  {path:'Login',component:LoginComponent},
  {path:'user',component:UserComponent},
  {path:'',redirectTo:'Login',pathMatch:"full"}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
