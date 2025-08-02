var id;//declartion
id=1001;//initialization
console.log(typeof id);
console.log('id:'+id);

id=1002
console.log(typeof id);
console.log('id:' +id);

id="1003";
console.log(typeof id);



//
var uid:number = 1001;
var uname:string="RAJU"
var status1:boolean=true;

var data1:any;//default behave
data1=10;
console.log(typeof data1);
data1="raju";
console.log(typeof data1);
data1=true;
console.log(typeof data1);

console.log('Uid:'+uid);
console.log('Name:'+uname);
console.log('Status:'+status1);

var employee={
    id:101,
    name:"Raju",

}

@compoent{
    //meta infomation
}

class Employee{
    //properties
    id:number;
    name:string;
    salary:number;
    //method
    displayEnployeeInfomation():void{
    console.log('Id:' +this.id);
    console.log('Name:'+this.name);
    console.log('Salary:' +this.salary);
    }
}


//creat an intance for the class
var employee1 = new Employee();
console.log(employee1);
