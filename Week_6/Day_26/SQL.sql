CREATE DATABASE ProductDB;
USE ProductDB;

CREATE TABLE Products
(
    ProductId INT PRIMARY KEY IDENTITY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
---Insert

CREATE PROCEDURE sp_InsertProduct
    @ProductName VARCHAR(100),
    @Category VARCHAR(50),
    @Price DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Products(ProductName, Category, Price)
    VALUES (@ProductName, @Category, @Price)
END

---View

CREATE PROCEDURE sp_GetAllProducts
AS
BEGIN
    SELECT * FROM Products
END

---Update
CREATE PROCEDURE sp_UpdateProduct
    @ProductId INT,
    @ProductName VARCHAR(100),
    @Category VARCHAR(50),
    @Price DECIMAL(10,2)
AS
BEGIN
    UPDATE Products
    SET ProductName=@ProductName,
        Category=@Category,
        Price=@Price
    WHERE ProductId=@ProductId
END

---Delete
CREATE PROCEDURE sp_DeleteProduct
    @ProductId INT
AS
BEGIN
    DELETE FROM Products WHERE ProductId=@ProductId
END

