USE MyGuitarShop
GO
--1
--Write a stored procedure named spInsertCategory that adds a new row to the Categories table.
--To do that, this procedure should have one parameter for the category name.
--(CategoryID is an IDENTITY Column, so it will be populated automatically)
--Code at least two EXEC statements that test this procedure.
--(Note that this table doesn’t allow duplicate category names.)

CREATE PROCEDURE spInsertCategory(@categoryName varchar(max))
AS
BEGIN
	INSERT INTO Categories
	VALUES (@categoryName)
END
GO

EXEC spInsertCategory 'Harmonicas'
EXEC spInsertCategory 'Cellos'
GO

--2
--Write a function named fnDiscountPrice that calculates the discount price of an item in the OrderItems table.
--Hint: Discount Price = Item Price - Discount Amount.
--To do that, this function should accept one parameter for the item ID, and it should return the value of the discount price for that item.

CREATE FUNCTION fnDiscountPrice(@itemID int)
RETURNS money
AS
BEGIN
	DECLARE @discount money = (
		SELECT DiscountPrice = ItemPrice - DiscountAmount
		FROM OrderItems
		WHERE ItemID = @itemID)
	RETURN @discount
END
GO

--3
--Write a function named fnItemTotal that calculates the total amount of an item in the OrderItems table
--Hint: Total Amount = Discount Price multiplied by quantity
--To do that, this function should accept one parameter for the item ID, it should use the DiscountPrice function
--that you created in question 2, and it should return the value of the total for that item.

CREATE FUNCTION fnItemTotal(@itemID int)
RETURNS money
AS
BEGIN
	DECLARE @itemTotal money = (
		SELECT dbo.fnDiscountPrice(@itemID) * Quantity
		FROM OrderItems
		WHERE ItemID = @itemID)
	RETURN @itemTotal
END
GO

--4
--Write a script that creates and calls a stored procedure named spUpdateProductDiscount that updates the
--DiscountPercent column in the Products table. This procedure should have one parameter for the product ID
--and another for the discount percent.
--If the value for the DiscountPercent column is a negative number, the stored procedure should raise an error
--that indicates that the value for this column must be a positive number.
--Code at least two EXEC statements that test this procedure.

CREATE PROCEDURE spUpdateProductDiscount(@productID int, @discountPercent money)
AS
BEGIN
	IF @discountPercent < 0
		THROW 50001, 'Discount Percent must be a positive value', 1;
	ELSE
		UPDATE Products
		SET DiscountPercent = @discountPercent
		WHERE ProductID = @productID
END
GO

EXEC spUpdateProductDiscount 1, 35;
EXEC spUpdateProductDiscount 5, 25;
EXEC spUpdateProductDiscount 5, -25;
GO

--5
--Write a stored procedure named spInsertProduct that inserts a row into the Products table. 
--This stored procedure should accept five parameters. One parameter for each of these columns: CategoryID, ProductCode, ProductName, ListPrice, and DiscountPercent.
--The stored procedure should set the Description column to an empty string, and DateAdded column to the current date.
--( Product ID column is an IDENTITY column, so no need to supply values to it)
--If the value for the ListPrice column is a negative number, the stored procedure should raise an error that indicates that this column doesn’t accept negative numbers.
--Similarly, the procedure should raise an error if the value for the DiscountPercent column is a negative number.
--Code at least two EXEC statements that test this procedure.

CREATE PROCEDURE spInsertProduct(@categoryID int, @productCode varchar(32), @productName varchar(128), @listPrice money, @discountPercent money)
AS
BEGIN
	IF @listPrice < 0
		THROW 50001, 'List price cannot be negative.', 1
	ELSE IF @discountPercent < 0
		THROW 50002, 'Discount Percent cannot be negative.', 1
	ELSE
	BEGIN
		INSERT INTO Products
		VALUES (@categoryID, @productCode, @productName, '', @listPrice, @discountPercent, GETDATE())
	END
END
GO

EXEC spInsertProduct 1, 'gtest', 'Gibson Test', 999.99, 15.00
EXEC spInsertProduct 5, 'htest', 'Harmonica Test', 125.95, 5.00
EXEC spInsertProduct 1, 'gtest', 'Gibson Test', -999.99, 15.00
GO
EXEC spInsertProduct 1, 'gtest', 'Gibson Test', 999.99, -15.00
GO

--6
--Create a trigger named Products_UPDATE that checks the new value for the DiscountPercent column of the Products table.
--This trigger should raise an appropriate error if the discount percent is greater than 100 or less than 0.
--If the new discount percent is between 0 and 1, this trigger should modify the new discount percent by multiplying it by 100.
--That way, a discount percent of .2 becomes 20.
--Test this trigger with an appropriate UPDATE statement.

CREATE TRIGGER Products_UPDATE
ON Products
FOR UPDATE, INSERT
AS
BEGIN
	DECLARE @discountPercent money = (
		SELECT DiscountPercent
		FROM inserted)
	IF @discountPercent > 100 OR @discountPercent < 0
		THROW 50001, 'Discount percent value must be between 0 and 100', 1;
	ELSE IF @discountPercent BETWEEN 0 AND 1
		UPDATE Products
		SET DiscountPercent = @discountPercent * 100
		WHERE ProductID = (SELECT ProductID FROM inserted)
END
GO

UPDATE Products
SET DiscountPercent = 0.25
WHERE ProductID = 11
GO

--7
--Create a trigger named Products_INSERT that inserts the current date for the DateAdded
--column of the Products table if the value for that column is null.
--Test this trigger with an appropriate INSERT statement.

CREATE TRIGGER Products_INSERT
ON Products
FOR INSERT
AS
BEGIN
	DECLARE @insertedDate date = (
		SELECT DateAdded
		FROM inserted)
	IF @insertedDate IS NULL
	BEGIN
		UPDATE Products
		SET DateAdded = GETDATE()
		WHERE ProductID = (
			SELECT ProductID
			FROM inserted)
	END
END
GO

INSERT INTO Products
VALUES (3, 'dtest', 'Drum Set Test', 'Testing out our Products_INSERT trigger.', 724.95, 0.10, NULL)
GO

--8
--Create a table named ProductsAudit. This table should have all columns of the Products table, except the Description column.
--Also, it should have an AuditID column for its primary key, and the DateAdded column should be changed to DateUpdated.
--Create a trigger named ProductsAudit_UPDATE. This trigger should insert the old data about the product into the ProductsAudit
--table after the row is updated. Then, test this trigger with an appropriate UPDATE statement.

CREATE TABLE ProductsAudit(
	AuditID int IDENTITY PRIMARY KEY,
	ProductID int,
	CategoryID int,
	ProductCode varchar(16),
	ProductName varchar(128),
	ListPrice money,
	DiscountPercent money,
	DateUpdated datetime)
GO

CREATE TRIGGER ProductsAudit_UPDATE
ON Products
FOR UPDATE
AS
BEGIN
	INSERT INTO ProductsAudit
	SELECT ProductID, CategoryID, ProductCode, ProductName, ListPrice, DiscountPercent, GETDATE()
	FROM deleted
END
GO

UPDATE Products
SET ListPrice = 599.99
WHERE ProductID = 13