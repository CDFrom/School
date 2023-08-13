--1
--Write a query using a WHERE clause that displays all the employees listed in the
--HumanResources.Employee table who have the job title Research and Development Engineer.
--Display the business entity ID number, the login ID, and the title for each one.
SELECT BusinessEntityID, LoginID, JobTitle
FROM HumanResources.Employee
WHERE JobTitle = 'Research and Development Engineer'

--2
--Write a query that displays all the rows from the Person.Person table where the rows were
--modified during the month of December in the year 2000. Display the business entity ID
--number, the name columns, and the modified date.
SELECT BusinessEntityID, FirstName, MiddleName, LastName, ModifiedDate
FROM Person.Person
WHERE ModifiedDate BETWEEN '2000-12-1' AND '2001-1-1'

--3
--Write a query displaying the order ID, order date and total due from Sales.SalesOrderHeader
--table where the total due exceeds $1,000. Retrieve only those rows where the salesperson ID is
--279 or the territory ID is 6 or 4.
SELECT SalesOrderID, OrderDate, TotalDue
FROM Sales.SalesOrderHeader
WHERE TotalDue > 1000 AND (SalesPersonID = 279 OR TerritoryID IN(6, 4))

--4
--Write a query using the Production.Product table displaying the product ID, color, and name
--columns. If the color column contains a NULL value, replace the color with No Color.
SELECT ProductID, Color, Name
FROM Production.Product
WHERE Color IS NOT NULL
UNION
SELECT ProductID, 'No Color', Name
FROM Production.Product
WHERE Color IS NULL

--5
--Write a query that displays the PersonType and the name columns from the Person.Person
--table. Sort the results so that rows with a PersonType of IN, SP, or SC sort by LastName. The
--other rows should sort by FirstName. Hint: Use the CASE function.
SELECT PersonType, FirstName, MiddleName, LastName
FROM Person.Person
ORDER BY
(CASE
	WHEN PersonType IN('IN', 'SP', 'SC')
		THEN LastName
	ELSE FirstName
END)

--6
--Write a query that displays the product ID and Sales Order ID of all the products that have been
--ordered. Sales Order details for a product con be found in Sales.SalesOrderDetail table.
SELECT ProductID, SalesOrderID
FROM Sales.SalesOrderDetail

--7
--Write a query that returns the BusinessEntityID column from the Sales.SalesPerson table along
--with every ProductID from the Production.Product table.
SELECT BusinessEntityID, ProductID
FROM Sales.SalesPerson S
	CROSS JOIN Production.Product P

--8
--Write a query that groups the products by ProductModelID along with a count. The products
--with the color blue or red need to be included. Display the rows that have a count that equals 1.
SELECT ProductModelID, COUNT(*) AS 'Count'
FROM Production.Product
WHERE Color = 'Blue' OR Color = 'Red'
GROUP BY ProductModelID, Color
HAVING COUNT(*) = 1