USE [master]
GO

if db_id('ProductCategoryDB') is null
	BEGIN 
		CREATE DATABASE ProductCategoryDB;
	END;
ELSE
	BEGIN
	 ALTER DATABASE ProductCategoryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	 DROP DATABASE ProductCategoryDB
	 CREATE DATABASE ProductCategoryDB;
	END
GO

USE ProductCategoryDB
GO


CREATE TABLE Products (id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                          name VARCHAR(100) NOT NULL,
)

CREATE TABLE Category (id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                          name VARCHAR(100) NOT NULL,
)

CREATE TABLE Products_Category (
                                   product_id INT NOT NULL,
                                   category_id INT NOT NULL,
                                   PRIMARY KEY (product_id, category_id),
                                   FOREIGN KEY (product_id)
                                       REFERENCES Products (id) ON DELETE CASCADE,
                                   FOREIGN KEY (category_id)
                                       REFERENCES Category (id) ON DELETE CASCADE
)