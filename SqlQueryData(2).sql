CREATE DATABASE my_database;
Go

Use my_database;

CREATE TABLE Categories(
Id INT PRIMARY KEY Identity(1,1),
CategoryName Varchar(50)
);
CREATE TABLE Books(
Id INT PRIMARY KEY Identity(1,1),
Title Varchar(50) not null,
Price INT,
CategoryId INT,
IsDeleted Bit not null default 0
FOREIGN KEY(CategoryId) References Categories(Id),
);
