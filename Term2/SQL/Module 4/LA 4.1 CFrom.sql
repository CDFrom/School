--1. Write a SELECT statement that returns all columns from the Vendors table
--inner-joined with the Invoices table.
SELECT *
FROM Vendors V
JOIN Invoices I
	ON V.VendorID = I.VendorID;

--2. Write a SELECT statement that returns four columns:
--VendorName From the Vendors table
--InvoiceNumber From the Invoices table
--InvoiceDate From the Invoices table
--Balance InvoiceTotal minus the sum of PaymentTotal and CreditTotal

--The result set should have one row for each invoice with a non-zero balance.
--Sort the result set by VendorName in ascending order.
SELECT V.VendorName, I.InvoiceNumber, I.InvoiceDate, Balance = I.InvoiceTotal - (I.PaymentTotal + I.CreditTotal)
FROM Vendors V
JOIN Invoices I
	ON V.VendorID = I.VendorID
WHERE I.InvoiceTotal - (I.PaymentTotal + I.CreditTotal) > 0
ORDER BY V.VendorName;

--3. Write a SELECT statement that returns three columns:
--VendorName From the Vendors table
--DefaultAccountNo From the Vendors table
--AccountDescription From the GLAccounts table

--The result set should have one row for each vendor, with the account number and
--account description for that vendor’s default account number. Sort the result set by
--AccountDescription, then by VendorName.
SELECT V.VendorName, V.DefaultAccountNo, GL.AccountDescription
FROM Vendors V
JOIN GLAccounts GL
	ON V.DefaultAccountNo = GL.AccountNo
ORDER BY GL.AccountDescription, V.VendorName;

--4. Write a SELECT statement that returns five columns from three tables, all using column aliases:
--Vendor  VendorName column
--Date  InvoiceDate column
--Number  InvoiceNumber column
--#  InvoiceSequence column
--LineItem InvoiceLineItemAmount column

--Assign the following correlation names to the tables:
--‘V’ for Vendors table
--‘I’ for Invoices table
--‘LI’ for InvoiceLineItems table

--Sort the final result set by Vendor, Date, Number, and #.
SELECT V.VendorName AS Vendor,
	I.InvoiceDate AS Date,
	I.InvoiceNumber AS Number,
	LI.InvoiceSequence AS #,
	LI.InvoiceLineItemAmount AS LineItem
FROM Vendors V
JOIN Invoices I
	ON V.VendorID = I.VendorID
JOIN InvoiceLineItems LI
	ON I.InvoiceID = LI.InvoiceID
ORDER BY Vendor, Date, Number, #;

--5.Use the UNION operator to generate a result set consisting of two columns
--from the Vendors table: VendorName and VendorState.

--If the vendor is in California, the VendorState value should be “CA”;
--otherwise, the VendorState value should be “Outside CA.”

--Sort the final result set by VendorName.
SELECT VendorName, VendorState
FROM Vendors
WHERE VendorState = 'CA'
UNION
SELECT VendorName, 'Outside CA'
FROM Vendors
WHERE VendorState != 'CA'
ORDER BY VendorName;