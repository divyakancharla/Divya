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
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
function Ifunction(data) {
    return (data.Name + " " + data.Title);
}
var data = { Name: "Ravindhar Singh", Title: "I Too Had A Love Story" };
console.log(Ifunction(data));
var User = /** @class */ (function () {
    function User(id, name, Email, Age, Phone) {
        this.Id = id;
        this.name = name;
        this.Email = Email;
        this.Age = Age;
        this.Phone = Phone;
        console.log("class Created");
    }
    User.prototype.register = function () {
        console.log(this.name + "" + "Successfully Registered");
    };
    User.prototype.getAge = function (id) {
        if (this.Id == id) {
            return (this.Age);
        }
        else {
            return 0;
        }
    };
    return User;
}());
//console.log(fuser.Id+"\t"+fuser.name+"\t"+fuser.Email+"\t"+fuser.Age+"\t"+fuser.Phone)
var Admin = /** @class */ (function (_super) {
    __extends(Admin, _super);
    function Admin(Type, id, name, Email, Age, Phone) {
        var _this = _super.call(this, id, name, Email, Age, Phone) || this;
        _this.Type = Type;
        return _this;
    }
    Admin.prototype.display = function () {
        console.log(this.Id + "\t" + this.name + "\t" + this.Email + "\t" + this.Age + "\t" + this.Phone + "\t" + this.Phone);
    };
    return Admin;
}(User));
var fuser = new User(45, "SipSs", "kassak@kass.com", 78, 75348957);
fuser.register();
console.log(fuser.getAge(45));
var ad = new Admin("gshgs", 45, "SipSs", "kassak@kass.com", 78, 75348957);
ad.display();
var Intervel = /** @class */ (function () {
    function Intervel(id, name, Email, Age, Phone) {
        this.Id = id;
        this.name = name;
        this.Email = Email;
        this.Age = Age;
        //this.Phone=Phone;
        console.log("class Created");
    }
    Intervel.prototype.register = function () {
        console.log(this.name + "" + "Successfully Registered");
    };
    Intervel.prototype.getAge = function (id) {
        if (this.Id == id) {
            return (this.Age);
        }
        else {
            return 0;
        }
    };
    return Intervel;
}());
