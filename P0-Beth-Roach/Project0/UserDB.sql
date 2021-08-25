Create Table UserName
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
Create Table UserPassword
(
	Id int IDENTITY(1,1) Primary Key,
	Name varchar(100) not null
);
Create table UserInfo
(
		Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null,
	UserName int Foreign Key REFERENCES UserName(Id) not null,
	UserPassword int Foreign Key REFERENCES UserPassword(Id) not null
);

drop Table UserName;
drop Table UserPassword;
drop table UserInfo;

Create Table UserName
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null
);
Create Table UserPassword
(
	Id int IDENTITY(1,1) Primary Key,
	Name varchar(100) not null
);
Create table UserInfo
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(100) not null,
	UserName int Foreign Key REFERENCES UserName(Id) not null,
	UserPassword int Foreign Key REFERENCES UserPassword(Id) not null
);

Insert Into UserName(Name) Values('brtre');
Insert Into UserName(Name) Values('rteww');
select * from UserName;
Insert Into UserPassword(Name) Values('fahjdeuhroi');
Insert Into UserPassword(Name) Values('dfwohfksoed');
select * from UserPassword;
Insert Into UserInfo(Name, UserName, UserPassword) Values ('User 1', 1, 1);
Select * From UserInfo;
Insert Into UserInfo(Name, UserName, UserPassword) Values ('User 2', 2, 2);
Select * From UserInfo;
