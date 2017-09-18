CREATE TABLE Team1.Products
(
ProductID INT IDENTITY(1,1) NOT NULL,
ProductName VARCHAR(25) NULL
CONSTRAINT pk_products_pid PRIMARY KEY(ProductID)
);


CREATE TABLE Team1.ProductSales
(
SalesID INT IDENTITY(1,1) CONSTRAINT pk_productSales_sid PRIMARY KEY,
ProductID INT CONSTRAINT fk_productSales_pid FOREIGN KEY REFERENCES Team1.Products(ProductID),
SalesPerson VARCHAR(25)
);

insert into team1.Products values ('test1'), ('test2')

select * from team1.Products

 