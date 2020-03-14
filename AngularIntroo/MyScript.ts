// //console.log("Heloo World");
// // let mystring:string;
// // let mynum:Number;
// // let mystatus:boolean;
// // mystring="Jigel";
// // mynum=420;
// // mystatus=true;
// // console.log(mystring);
// // console.log(mynum);
// // console.log(mystatus);
// // let  mydata:any;
// // mydata="hello132";
// // console.log(mydata);
// // let mystring:Number;
// // mystring=54675;
// // console.log(mystring);
// // let data:any;
// // data=34+56;
// // console.log(data);
// // let tstring:string;
// // tstring="welcome to chennai";
// // console.log(tstring.slice(0,3));
// // let tdata:Number;
// // tdata=34;
// // console.log(tdata.toString()+"my result");
// // let myarray:string[];
// // let myarray1:number[];
// let myarray:Array<string>;
// let myarray1:Array<number>;
// myarray=["kalyani","divya","hamsi"];
// myarray1=[2,1,0];
// console.log(myarray);
// console.log(myarray1);
// console.log(myarray[2]);
// for(var n=0;n<myarray.length;n++)
// {
//     console.log(myarray[n]);
// }
// myarray1.forEach(function(value){
//     console.log(value);
// })
// let mytuple:[number,string,string]
// mytuple=[1,"dhg","dhu"]
// console.log(mytuple);
// let myvar:void;
// myvar=undefined;
// console.log(myvar);
// let myvar1:null;
// myvar1=null;
// console.log(myvar1);
// console.log(mytuple.pop());
// mytuple.push(3);
// console.log(mytuple);
// mytuple.push("kaly");
// console.log(mytuple);
// mytuple.push(6);
// console.log(mytuple);
// enum myEnum{sunday=0,monday,tuesday,wednesday,thursday,friday,saturday};
// console.log(myEnum.tuesday);
// for(var n=0;n<=myEnum.saturday;n++)
// {
//     console.log(myEnum[n]+" "+n);
// }
// //functions
// function myfunc(n1:number,n2:number):number
// {
//     return n1+n2;

// }
// console.log(myfunc(2,3));
// function myfunc2(n1:any,n2:any):any
// {
//     return n1+n2;

// }
// console.log(myfunc2("hi",23));
// function myfunc3(n1:any,n2:any):number
// {
//     if(typeof n1=='string'&&typeof n2=='string')
//     {
//          let x:number;
//          let y:number;
//          x=parseInt(n1);
//          y=parseInt(n2);
//          return(x+y);
//     }
// else
    
//     return n1+n2;
     

// }
// console.log(myfunc3(7,"yy"));
interface myint{
    Name:string;
    Title:string;
}
function Ifunction(data:myint):string{
    return(data.Name+" "+data.Title);
}
let data={Name:"Ravindhar Singh",Title:"I Too Had A Love Story"};
console.log(Ifunction(data));
class User{
   protected Id:number;
   public name:string;
   protected Email:string;
   protected Age:number;
   protected Phone:number;
    constructor (id:number,name:string,Email:string,Age:number,Phone:number){
        this.Id=id;
        this.name=name;
        this.Email=Email;
        this.Age=Age;
        this.Phone=Phone;
        console.log("class Created");
    }
    register(){
        console.log(this.name+""+"Successfully Registered")
    }
    getAge(id:number):number{
        if(this.Id==id){
            return(this.Age);
        }
        else{
            return 0;
        }
    }
}

//console.log(fuser.Id+"\t"+fuser.name+"\t"+fuser.Email+"\t"+fuser.Age+"\t"+fuser.Phone)

class Admin extends User{
    Type:string;
    constructor (Type:string,id:number,name:string,Email:string,Age:number,Phone:number) 
    {
        super(id,name,Email,Age,Phone)
        this.Type=Type;
    }
    display(){
        console.log(this.Id+"\t"+this.name+"\t"+this.Email+"\t"+this.Age+"\t"+this.Phone+"\t"+this.Phone)
    }
}
let fuser=new User(45,"SipSs","kassak@kass.com",78,75348957);
fuser.register();
console.log(fuser.getAge(45));
let ad=new Admin("gshgs",45,"SipSs","kassak@kass.com",78,75348957);
ad.display();


interface Iuser{
     Id:number;
   name:string;
    Email:string;
    Age:number;
    register():void
    getAge(id:number):number
    
}
class Intervel implements Iuser{
    Id:number;
   name:string;
    Email:string;
    Age:number;
    constructor (id:number,name:string,Email:string,Age:number,Phone:number){
        this.Id=id;
        this.name=name;
        this.Email=Email;
        this.Age=Age;
        //this.Phone=Phone;
        console.log("class Created");
    }
    register(){
        console.log(this.name+""+"Successfully Registered")
    }
    getAge(id:number):number{
        if(this.Id==id){
            return(this.Age);
        }
        else{
            return 0;
        }
    }

}