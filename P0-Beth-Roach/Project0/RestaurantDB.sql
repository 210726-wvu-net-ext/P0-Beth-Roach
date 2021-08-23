Create Table Price 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
CREATE TABLE TypeofFood 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
Create Table Restaurant 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null,
	Price int Foreign Key REFERENCES Price(Id) not null,
	TypeofFood int Foreign Key REFERENCES TypeofFood(Id) not null
);
Drop Table Price;
Drop Table TypeofFood;
Drop Table Restaurant;

Create Table Price
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
CREATE TABLE TypeofFood
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);

Create Table Restaurant 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null,
	Price int Foreign Key REFERENCES Price(Id) not null,
	TypeofFood int Foreign Key REFERENCES TypeofFood(Id) not null
	
);


Insert Into Price (Name) Values('Expensive');
Insert Into Price (Name) Values('Moderate');
Insert Into Price (Name) Values('Cheap');
Select * From Price;
Insert Into TypeofFood(Name) Values ('Italian');
Insert Into TypeofFood (Name) Values ('American');
Insert Into TypeofFood (Name) Values ('Mexican');
Insert Into TypeofFood (Name) Values ('Asian');
Select * From TypeofFood;
Insert Into Restaurant(Name, Price, TypeofFood) Values ('Marias Cafe', 2, 3);
Select * From Restaurant;
Insert Into Restaurant(Name, Price, TypeofFood) Values ('Johnnys', 3, 2);
Select * From Restaurant;
Insert Into Restaurant(Name, Price, TypeofFood) Values ('Goodburger', 2, 2);
Select * From Restaurant;
Insert Into Restaurant(Name, Price, TypeofFood) Values ('Marios', 3, 1);
Select * From Restaurant;
Insert Into Restaurant(Name, Price, TypeofFood) Values ('Ramen Stop', 2, 4);
Select * From Restaurant;
Insert Into Restaurant(Name, Price, TypeofFood) Values ('Asian Buffet', 1, 4);
Select * From Restaurant;




