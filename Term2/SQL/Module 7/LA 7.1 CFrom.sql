--1. Write a SELECT statement that returns four columns based on the InvoiceTotal column
--of the Invoices table:
--o Use the CAST function to return the first column as data type decimal with 2
--digits to the right of the decimal point.
--o Use CAST to return the second column as a varchar
--o Use the CONVERT function to return the third column as the same data type as
--the first column.
--o Use CONVERT to return the fourth column as a varchar, using style 1
USE AP
SELECT CAST(InvoiceTotal AS decimal(12,2)) AS First,
	CAST(InvoiceTotal AS varchar) AS Second,
	CONVERT(decimal(12,2), InvoiceTotal) AS Third,
	CONVERT(varchar, InvoiceTotal, 1) AS Fourth
FROM Invoices

--2. Write a SELECT statement that returns two columns based on the Vendors table. The
--first column, Contact, is the vendor contact name in this format: first name followed by
--last initial (for example, “John S.”) The second column, Phone, is the VendorPhone
--column without the area code. Only return rows for those vendors in the 559 area code.
--Sort the result set by first name, then last name.
USE AP
SELECT VendorContactFName + ' ' + SUBSTRING(VendorContactLName, 1, 1) + '.' AS Contact,
	SUBSTRING(VendorPhone, 7, 8) AS Phone
FROM Vendors
WHERE VendorPhone LIKE '(559%'
ORDER BY VendorContactFName, VendorContactLName

--3. Write a SELECT statement that returns the InvoiceNumber and balance due for every
--invoice with a non-zero balance and an InvoiceDueDate that’s less than 30 days from
--today.
USE AP
SELECT InvoiceNumber, 'Balance Due' = InvoiceTotal - PaymentTotal - CreditTotal
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal != 0 AND
	InvoiceDueDate < (GETDATE() + 30)