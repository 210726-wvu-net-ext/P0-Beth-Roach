Create Table Price (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
CREATE TABLE TypeofFood (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
Create Table NameofRest (
	Id int IDENtity(1,1) Primary Key,
	Name varchar(100) not null
);

Create Table Restaurant (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null,
	NameofRest int Foreign Key References NameofRest(Id) not null,
	Price int Foreign Key REFERENCES Price(Id) not null,
	TypeofFood int Foreign Key REFERENCES TypeofFood(Id) not null
);
Drop Table Restaurant;
Drop Table Price;
Drop Table TypeofFood;
drop table NameofRest;
/*
	This is a comment
	This is ignored during execution
*/
Create Table Price(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
CREATE TABLE TypeofFood(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
Create Table NameofRest (
	Id int IDENtity(1,1) Primary Key,
	Name varchar(100) not null
);
Create Table Restaurant (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null,
	Price int Foreign Key REFERENCES Price(Id) not null,
	TypeofFood int Foreign Key REFERENCES TypeofFood(Id) not null,
	NameofRest int Foreign Key References NameofRest(ID)
);
Alter Table Restaurant

Insert Into NameofRest (Name) Values ('Marias Cafe');
Insert Into NameofRest (Name) Values ('Goodburger');
Insert Into NameofRest (Name) Values ('The Deli');
Insert Into NameofRest (Name) Values ('Marios');
Insert Into NameofRest (Name) Values ('Ramen Stop');
Insert Into NameofRest (Name) Values ('Asian Buffet');
Select * From NameofRest;
Insert Into Price (Name) Values('Expensive');
Insert Into Price (Name) Values('Moderate');
Insert Into Price (Name) Values('Cheap');
Select * From Price;
Insert Into TypeofFood(Name) Values ('Italian');
Insert Into TypeofFood (Name) Values ('American');
Insert Into TypeofFood (Name) Values ('Mexican');
Insert Into TypeofFood (Name) Values ('Asian');
Select * From TypeofFood;
Insert Into Restaurant(NameofRest, Price, TypeofFood) Values (1, 2, 3);
Select * From Restaurant;
Insert Into Restaurant(NameofRest, Price, TypeofFood) Values (2, 3, 2);
Select * From Restaurant;
Insert Into Restaurant(NameofRest, Price, TypeofFood) Values (3, 2, 2);
Select * From Restaurant;
Insert Into Restaurant(NameofRest, Price, TypeofFood) Values (4, 3, 1);
Select * From Restaurant;
Insert Into Restaurant(NameofRest, Price, TypeofFood) Values (5, 2, 4);
Select * From Restaurant;
Insert Into Restaurant(NameofRest, Price, TypeofFood) Values (6, 1, 4);
Select * From Restaurant;




