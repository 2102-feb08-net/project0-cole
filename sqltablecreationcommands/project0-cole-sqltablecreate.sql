--Create Schema for Project

CREATE SCHEMA proj0;
GO

-- Code Below Creates Various Tables

create table proj0.Inventory(

	Id int not null Identity(1,1) Primary Key,

	StoreId int not null,

	ProductId int not null,

	Quantity int not null

)

create table proj0.Customer (

	Id int not null Identity(1,1) Primary Key,

	FirstName nvarchar(50) not null,

	LastName nvarchar(50) not null,


)

drop table proj0.StoreLocation



create table proj0.StoreLocation (

	Id int not null Identity(1,1) Primary Key,

	Address nvarchar(100) not null,

	City nvarchar(100) not null,

	State nvarchar(20) not null,

	PhoneNumber nvarchar(20) not null,


)

drop table proj0.Orders

create table proj0.Orders(

	Id int not null Identity(1,1) Primary Key,

	TimeCreated datetime2 null,

	CustomerId int not null,

	StoreLocationId int not null,


)

create table proj0.OrderLine(

	Id int not null Identity(1,1) Primary Key,

	OrderId int not null,

	ProductId int not null,

	Quantity int not null


)

create table proj0.Inventory(

	Id int not null Identity(1,1) Primary Key,

	ProductId int not null,

	StoreId int null,

	Quantity int not null

)


create table proj0.StoreLocation (

	Id int not null Identity(1,1) Primary Key,

	Address nvarchar(100) not null,

	City nvarchar(100) not null,

	State nvarchar(20) not null,

	PhoneNumber nvarchar(20) not null,


)

Insert into proj0.StoreLocation(Location,PhoneNumber) 
Values

Insert into proj0.Customer (FirstName,LastName) 
Values
('Brent','Trimmer'),
('Rick','Ash'),
('Al','Wopton'),
('Mary','oLeery'),
('Trent','Shack'),
('Carl','Tron'),
('Mary','Beth')

Select * from proj0.Customer

drop table proj0.Product;

create table proj0.Product (

	 Id int not null Identity(1,1) Primary Key,

	 ProductName nvarchar(50) not null,

	 Price Money,
	

)

Insert into proj0.Product(ProductName,Price) Values (,)
