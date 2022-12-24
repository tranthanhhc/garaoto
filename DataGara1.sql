CREATE DATABASE GaraData
GO 

CREATE TABLE db_admin (
	AdName nvarchar(50) ,
	AdPass nvarchar(50)
)

CREATE TABLE db_cars (
	CarId int IDENTITY(1,1),
	CarCode char(11) NOT NULL PRIMARY KEY,
	CarName nvarchar(30),
	CarBrand nvarchar(50),
	CarModel nvarchar(50),
	CarOwner nvarchar(50),
	CarTime datetime
)
CREATE TABLE db_employees (
	EmId int IDENTITY(1,1),
	EmCode char(11) NOT NULL PRIMARY KEY,
	EmName nvarchar(30) ,
	EmAge int, 
	EmGender nchar(20),
	EmAddress nvarchar(50)
)
CREATE TABLE db_depot (
	DeId int IDENTITY(1,1),
	DeCode char(11) NOT NULL PRIMARY KEY,
	DeName nvarchar(30),
	DeModel nvarchar(50),
	DeQua int 
)
CREATE TABLE db_bill (
	BiId int IDENTITY (1,1),
	BiCode char(11) NOT NULL PRIMARY KEY,
	BiType nvarchar(50),
	BiOName nvarchar(50),
	BiPrice int,
	BiQua int
)