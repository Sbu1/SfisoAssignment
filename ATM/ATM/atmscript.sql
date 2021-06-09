--Create database
CREATE DATABASE ATM
GO

--drop database atm
--go

use atm
go

--create tables
CREATE TABLE UserInfo
(
	Username varchar (50) primary key,
	Firstname varchar (50),
	Lastname varchar (50),
	[Password] varchar (50) -- we shouldn't be storing passwords in plain text
)
GO

CREATE TABLE Bank
(
	[Name] varchar (50) primary key,
	BranchCode int,
	BranchName varchar(50)
)
GO

CREATE TABLE UserBalance
(
	UserBalanceId int primary key identity(1,1),
	Username varchar(50) foreign key references UserInfo,
	[Name] varchar(50) foreign key references Bank,
	Balance decimal(18,2),
)
GO


CREATE TABLE WITHDRAWAL
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Username varchar(50) foreign key references UserInfo,
	[Name] varchar(50) foreign key references Bank,
	UserBalanceId int foreign key references UserBalance,
	WithdrawalDate date,
	Amount int
)
GO


--insert data
INSERT INTO UserInfo (Username, Firstname, Lastname, Password)
VALUES ('sifisos', 'Sifiso', 'Shezi', 'Password'),
('sibusisos', 'Sibusiso', 'Sikhakhane', 'password1'),
('lungisanib', 'Lungisani', 'Blose', 'pass2')


INSERT INTO Bank (Name, BranchName, BranchCode)
VALUES ('Standard Bank', 'Universal', 1000000),
('Capitec', 'Universal', 300000),
('Nedbank', 'Universal', 50000)


INSERT INTO UserBalance (Username, Name, Balance)
VALUES ('sifisos', 'Capitec', 50000),
('sibusisos', 'Capitec', 50000),
('lungisanib', 'Standard Bank', 10000)

select *
from UserBalance