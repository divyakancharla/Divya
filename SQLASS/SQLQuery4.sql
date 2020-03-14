create table Customers( Customerid char(5) not null,
CompanyName varchar(40) not null,
contactName char(30) null,
Address varchar(60) null,
City char(15) null,
Phone char(24) null,
Fax char(24) null
)
create table Orders(OrderId integer not null,
customerId char(5) not null,
Orderdate datetime null,
Shippeddate datetime null,
Freight money null,
Shipname varchar(40) null,
Shipaddres varchar(60) null,
Quantity integer null)

alter table Orders alter column shipregion integer  null



alter table Orders drop  [CK__Orders__shipregi__1920BF5C]
alter table Orders drop column shipregion
select * from Orders
insert into Orders values( 10,'ord01',getdate(),getdate(), 100.0, 'Windstar', 'Ocean' ,1)
alter table Orders add default getdate() for orderdate
select * from Orders

sp_rename 'Customers.City','Town'
select * from Customers

create table Employe(Deptno int primary key,Deptname varchar(20) not null,Location varchar(30) not null)

create table department(
Dno char(5) primary key,
Dname varchar(30) not null,
location varchar(30) not null

)
insert into department values('d1','Research','Dallas')
insert into department values('d2','Accounting','Seattle')
insert into department values('d3','Marketing','Dallas')
create table employee(
eid int not null,
efname varchar(10),
elname varchar(15),
Dno varchar(15),
)
insert into employee values(25348,'Matthew','Smith','d3')
insert into employee values(10102,'Ann','Jones','d3')
insert into employee values(  18316,	'John',	'Barrimore',	'd1')
insert into employee values( 29346,	'James'	,'James',	'd2')
select * from employee
create table project(
pno char(5) not null,
pname varchar(40) ,
budget int 

)
insert into project values('p1','Apollo',120000)
insert into project values ('p2	','Gemini',	95000)
insert into project values('p3',	'Mercury',	185600)
select * from project

create table works_on(
eid int not null,
pno char(5) not null,
job varchar(30) ,
e_date date

)
insert into works_on values(10102,'p1','Analyst','10.1.1997')
insert into works_on values( 10102,	'p3',	'manager',	'1999.1.1')
insert into works_on values(25348,	'p2',	'Clerk',	'1998.2.15')
insert into works_on values(18316	,'p2',	NULL,'	1998.6.1')
insert into works_on values(986,	'p2',	NULL,'	1997.12.15')
insert into works_on values(2581,	'p3	','Analyst','	1998.10.15')
insert into works_on values(9031	,'p1',	'Manager',	'1998.4.15')
insert into works_on values(28559	,'p1',	NULL	,'1998.8.1')
insert into works_on values(28559,	'p2'	,'Clerk','	1992.2.1')
insert into works_on values(9031	,'p3',	'Clerk',	'1997.11.15')
insert into works_on values(29346	,'p1',	'Clerk',	'1998.1.4')
select * from works_on
select eid from works_on
select eid from works_on where pno='p2' and  eid<1000
select eid from works_on where year(e_date)!='1998'
select eid from works_on where pno='p1' and (job='Analyst' or job='Manager')
select e_date from works_on where pno='p2' and job IS NULL
select eid,elname from employee where efname like '%t%t%'
select eid,efname from employee where elname like '%es' And (elname like '%_a%' or elname like '%_o%')
select e.eid from employee e,Department d where Location IN(select location from department where d.Location='Seattle')
select elname,efname from employee,works_on where e_date='04.01.1998'
select employee.*,department.* from employee right join department on department.Dno=employee.Dno 
select efname,elname from employee left join works_on on employee.eid=works_on.eid where works_on.e_date='1998.1.4'
select count(dname) from department group by location
select max(eid) as Hammam from works_on
select job from works_on Group by job having COUNT(job)>=2
select works_on.eid from works_on left join employee on works_on.eid=employee.eid where works_on.job='Clerk'