--2. Write a SELECT statement that returns these column names and data from the OrderItems table: 
--ItemID The ItemID column
--ItemPrice The ItemPrice column
--DiscountAmount The DiscountAmount column
--Quantity The Quantity column
--PriceTotal A column that’s calculated by multiplying the item price by the quantity
--DiscountTotal A column that’s calculated by multiplying the discount amount by the quantity
--ItemTotal A column that’s calculated by subtracting the discount amount from the item price
--and then multiplying by the quantity
--Only return rows where the ItemTotal is greater than 500.
--Sort the result set by item total in descending sequence.
SELECT ItemID, ItemPrice, DiscountAmount, Quantity,
	PriceTotal = ItemPrice * Quantity,
	DiscountTotal = DiscountAmount * Quantity,
	ItemTotal = (ItemPrice - DiscountAmount) * Quantity
FROM OrderItems
WHERE (ItemPrice - DiscountAmount) * Quantity > 500
ORDER BY ItemTotal DESC

--3. Write a SELECT statement that returns these columns from the Orders table:
--OrderID The OrderID column
--OrderDate The OrderDate column
--ShipDate The ShipDate column
--Return only the rows where the ShipDate column contains a null value.
SELECT OrderID, OrderDate, ShipDate
FROM Orders
WHERE ShipDate IS NULL

--6. Write a SELECT statement that joins the Customers, Orders, OrderItems, and Products tables.
--This statement should return these columns:
--LastName, FirstName, OrderDate, ProductName, ItemPrice, DiscountAmount, and Quantity. 
--Use aliases for the tables. 
--Sort the final result set by LastName, OrderDate, and ProductName.
SELECT C.LastName, C.FirstName, O.OrderDate, P.ProductName, OI.ItemPrice, OI.DiscountAmount, OI.Quantity
FROM Customers C
	JOIN Orders O
		ON C.CustomerID = O.CustomerID
	JOIN OrderItems OI
		ON O.OrderID = OI.OrderID
	JOIN Products P
		ON OI.ProductID = P.ProductID
ORDER BY C.LastName, O.OrderDate, P.ProductName

--9. Write a SELECT statement that returns one row for each category that has products with these columns:
--The CategoryName column from the Categories table
--The count of the products in the Products table
--The list price of the most expensive product in the Products table
--Sort the result set so the category with the most products appears first.
SELECT CategoryName, COUNT(ProductID) AS 'Number of Products', MAX(ListPrice) AS 'Highest Price'
FROM Categories C
	JOIN Products P
		ON C.CategoryID = P.CategoryID
GROUP BY CategoryName
ORDER BY COUNT(ProductID) DESC

--10.Write a SELECT statement that returns these columns: 
--The count of the number of orders in the Orders table 
--The sum of the TaxAmount columns in the Orders table 
SELECT COUNT(OrderID) AS 'Number of Orders', SUM(TaxAmount) AS 'Total Tax Amount'
FROM Orders

--11.Write a SELECT statement that returns the same result set as this SELECT statement, but don’t use a join.
--Instead, use a subquery in a WHERE clause that uses the IN keyword. 
--SELECT DISTINCT CategoryName 
--FROM Categories c JOIN Products p 
--ON c.CategoryID = p.CategoryID 
--ORDER BY CategoryName 
SELECT DISTINCT CategoryName
FROM Categories
WHERE CategoryID IN (
	SELECT DISTINCT CategoryID
	FROM Products)
ORDER BY CategoryName

--12.Write an INSERT statement that adds this row to the Customers table:
--EmailAddress: rick@raven.com
--Password: (empty string)
--FirstName: Rick
--LastName: Raven
--Use a column list for this statement.
INSERT INTO Customers(EmailAddress, Password, FirstName, LastName)
VALUES ('rick@raven.com','', 'Rick', 'Raven')

--14.Write an INSERT statement that adds this row to the Categories table: 
--CategoryName: Brass
--Code the INSERT statement so SQL Server automatically generates the value for the CategoryID column.
INSERT INTO Categories
VALUES ('Brass')