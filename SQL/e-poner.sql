-- Active: 1716323923095@@bwcsz1zo9o3rlrkn9kjp-mysql.services.clever-cloud.com@3306@bwcsz1zo9o3rlrkn9kjp
CREATE TABLE DocumentTypes(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Abbreviation VARCHAR(30)
);

CREATE TABLE Customers(
   Id INT PRIMARY KEY AUTO_INCREMENT,
   FirstName VARCHAR(50),
   LastName VARCHAR(50),
   DocumentTypeId INTEGER,
   IdentificationNumber VARCHAR(100),
   Email VARCHAR(255),
   PhoneNumber INTEGER,
   Birthdate DATE NULL
);

CREATE TABLE Users(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Username VARCHAR(50) UNIQUE,
    DocumentTypeId INTEGER,
    IdentificationNumber VARCHAR(100),
    Email VARCHAR(255) UNIQUE,
    Password VARCHAR(255)
);

ALTER TABLE `Customers` ADD FOREIGN KEY (DocumentTypeId) REFERENCES DocumentTypes(Id);

ALTER TABLE `Users` ADD FOREIGN KEY (DocumentTypeId) REFERENCES DocumentTypes(Id);
