create database studentdata
use studentdata

create table country(country_id int primary key identity(1,1), CountryName varchar(50))
create table province(province_id int primary key identity(1,1), ProvinceName varchar(50), count_id int foreign key references country(country_id))
create table city(city_id int primary key identity(1,1), CityName varchar(50), Prov_id int foreign key references province(province_id))

insert into country values('Pakistan'),('USA'),('UK'),('Chaina'),('Turkey')
select * from country
insert into province values('USA',2),('UK',3),('Chaina',3),('Turkey',4)

select * from province
insert into city values('Karachi',1),('Hyderabad',1),('Larkana',1),('Lahore',2),('Rawalpindhi',2),('Queta',3),('USA',5),('UK',6),('Chaina',7),('Turkey',8)
select * from city


create table class (Class_id int primary key identity(1,1), ClassName varchar(50))
insert into class values('Five')
select * from class

create table studentdata
(
Student_id int primary key identity(1,1),
FName varchar(50),
LName varchar(50),
FatherName varchar(50),
FatherID varchar(50),
Email varchar(50),
Mobile varchar(50),
DOB varchar(50),
DOR varchar(50),
Cls_id int foreign key references class(Class_id),
Adress varchar(50),
gender varchar(50),
c_id int foreign key references country(country_id),
p_id int foreign key references province(province_id),
ct_id int foreign key references city(city_id)
)

select * from studentdata


select studentdata.Student_id, studentdata.FName, studentdata.LName, studentdata.FatherName, studentdata.FatherID, studentdata.Email,studentdata.Mobile,studentdata.DOB,studentdata.DOR, class.ClassName, studentdata.Adress, studentdata.gender, country.CountryName, province.ProvinceName, city.CityName from studentdata inner join class on studentdata.Cls_id=class.Class_id inner join country on studentdata.c_id=country.country_id inner join province on studentdata.p_id=province.province_id inner join city on studentdata.ct_id=city.city_id

create table exper(Ex_id int primary key identity(1,1), Expertise varchar(50))
insert into exper  values('Java'),('C#'),('Python'),('PHP')

create table teacherdata
(
Teach_id int primary key identity(1,1),
TeachName varchar(50),
TeachLastName varchar(50),
TeachFaterhName varchar(50),
TeachID varchar(50),
TeachEmail varchar(50),
TeachMobile varchar(50),
teachDOB varchar(50),
Expertise int foreign key references exper(Ex_id),
TeachAdd varchar(50),
TeachGender varchar(50),
Teachc_id int foreign key references country(country_id),
Teachp_id int foreign key references province(province_id),
Teachct_id int foreign key references city(city_id)
)

select * from teacherdata

select teacherdata.Teach_id, teacherdata.TeachName, teacherdata.TeachLastName, teacherdata.TeachFaterhName, teacherdata.TeachID, teacherdata.TeachEmail, teacherdata.TeachMobile, teacherdata.teachDOB,exper.Expertise, teacherdata.TeachAdd, teacherdata.TeachGender, country.CountryName,province.ProvinceName, city.CityName from teacherdata inner join exper on exper.Ex_id=teacherdata.Expertise inner join country on country.country_id=teacherdata.Teachc_id inner join province on province.province_id=teacherdata.Teachp_id inner join city on city.city_id=teacherdata.Teachct_id


create table studentclass
(Class_id int primary key identity(1,1), Class_Name varchar(30))

insert into studentclass values('One'),('Two'),('Three'),('Four'),('Five')

create table StudentMonths
(Month_ID int primary key identity(1,1), Months varchar(50))
insert into StudentMonths values('Janurary'),('Feburary'), ('March'),('April'),('May'),('June'),('July'),('August'),('September'),('October'),('November'),('December')

select * from StudentMonths


create table fees_Form(F_ID int primary key identity(1,1), Student_Name_Id int foreign key references studentdata(Student_id), Class_St_ID int foreign key references studentclass(Class_id), Month_ID int foreign key references StudentMonths(Month_ID), DO_Adminision varchar(50), Amount int)
select * from fees_Form


select fees_Form.F_ID,studentdata.FName, studentclass.Class_Name,StudentMonths.Months, fees_Form.DO_Adminision,fees_Form.Amount from fees_Form inner join studentdata on fees_Form.Student_Name_Id=studentdata.Student_id inner join studentclass on fees_Form.Class_St_ID=studentclass.Class_id inner join StudentMonths on fees_Form.Month_ID=StudentMonths.Month_ID 


create table Registration
(Registration_ID int primary key identity(1,1), UserName varchar(30), UserPassword varchar(30))

insert into Registration values('Admin','admin')
select * from Registration



