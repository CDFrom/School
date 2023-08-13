--1. Write a CREATE VIEW statement that defines a view named InvoiceBasic that returns three columns:
--VendorName, InvoiceNumber, and InvoiceTotal.
--Then, write a SELECT statement that returns all of the columns in the view, sorted by VendorName,
--where the first letter of the vendor name is N, O, or P.
CREATE VIEW InvoiceBasic AS
	SELECT VendorName, InvoiceNumber, InvoiceTotal
	FROM Vendors V JOIN Invoices I
		ON V.VendorID = I.VendorID;

SELECT *
FROM InvoiceBasic
WHERE (VendorName LIKE 'N%') OR (VendorName LIKE 'O%') OR (VendorName LIKE 'P%')
ORDER BY VendorName;

--2. Create a view named Top10PaidInvoices that returns three columns for each vendor:
--VendorName, LastInvoice (the most recent invoice date), and SumOfInvoices (the sum of the InvoiceTotal column).
--Return only the 10 vendors with the largest SumOfInvoices and include only paid invoices.
CREATE VIEW Top10PaidInvoices AS
	SELECT TOP 10 VendorName, LastInvoice = MAX(InvoiceDate), SumOfInvoices = SUM(InvoiceTotal)
	FROM Vendors V JOIN Invoices I
		ON V.VendorID = I.VendorID
	WHERE InvoiceTotal - PaymentTotal - CreditTotal = 0
	GROUP BY VendorName
	ORDER BY SumOfInvoices DESC

--3. Create an updatable view named VendorAddress that returns the VendorID, both address columns,
--and the city, state, and zip code columns for each vendor.
--Then, write a SELECT query to examine the result set where VendorID=4.
--Next, write an UPDATE statement that changes the address so that the suite number (Ste 260) is stored in
--VendorAddress2 rather than in VendorAddress1. To verify the change, rerun your SELECT query.
CREATE VIEW VendorAddress AS
	SELECT VendorID, VendorAddress1, VendorAddress2, VendorCity, VendorState, VendorZipCode 
	FROM Vendors

SELECT *
FROM VendorAddress
WHERE VendorID = 4

UPDATE VendorAddress
SET VendorAddress2 = RIGHT(VendorAddress1, 7),
VendorAddress1 = SUBSTRING(VendorAddress1, 1, LEN(VendorAddress1)-8)
WHERE VendorID = 4

SELECT *
FROM VendorAddress
WHERE VendorID = 4