--1. Write a SELECT statement that returns two columns from the Invoices table: VendorID and
--PaymentSum, where PaymentSum is the sum of the PaymentTotal column. Group the result set
--by VendorID.
SELECT VendorID, PaymentSum = SUM(PaymentTotal)
FROM Invoices
GROUP BY VendorID

--2. Write a SELECT statement that returns two columns: VendorName and PaymentSum, where
--PaymentSum is the sum of the PaymentTotal column. Group the result set by VendorName.
--Return only 10 rows, corresponding to the 10 vendors who’ve been paid the most.
--Hint: Use the TOP clause and join Vendors to Invoices.
SELECT TOP 10 VendorName, PaymentSum = SUM(PaymentTotal)
FROM Invoices JOIN Vendors
	ON Invoices.VendorID = Vendors.VendorID
GROUP BY VendorName
ORDER BY PaymentSum DESC


--3. Write a SELECT statement that returns three columns: VendorName, InvoiceCount, and
--InvoiceSum. InvoiceCount is the count of the number of invoices, and InvoiceSum is the sum of
--the InvoiceTotal column. Group the result set by vendor. Sort the result set so that the vendor
--with the highest number of invoices appears first.
SELECT VendorName, InvoiceCount = COUNT(*), InvoiceSum = SUM(InvoiceTotal)
FROM Invoices JOIN Vendors
	ON Invoices.VendorID = Vendors.VendorID
GROUP BY VendorName
ORDER BY InvoiceCount DESC


--4. Write a SELECT statement that answers this question: Which vendors are being paid from
--more than one account? Return two columns: the vendor name and the total number of accounts
--that apply to that vendor’s invoices.
--Hint: Use the DISTINCT keyword to count InvoiceLineItems.AccountNo
SELECT VendorName, 'Total Number of Accounts' = COUNT(DISTINCT AccountNo)
FROM Vendors V JOIN Invoices I
	ON V.VendorID = I.VendorID
	JOIN InvoiceLineItems IL
		ON I.InvoiceID = IL.InvoiceID
GROUP BY VendorName
HAVING COUNT(DISTINCT AccountNo) > 1

--5. Write a SELECT statement that returns six columns:
--VendorID From the Invoices table
--InvoiceDate From the Invoices table
--InvoiceTotal From the Invoices table
--VendorTotal The sum of the invoice totals for each vendor
--VendorCount The count of invoices for each vendor
--VendorAvg The average of the invoice totals for each vendor
--The result set should include the individual invoices for each
SELECT VendorID, InvoiceDate, InvoiceTotal,
	SUM(InvoiceTotal) OVER (PARTITION BY VendorID) AS VendorTotal,
	COUNT(InvoiceTotal) OVER (PARTITION BY VendorID) AS VendorCount,
	AVG(InvoiceTotal) OVER (PARTITION BY VendorID) AS VendorAvg
FROM Invoices

--6. Write a SELECT statement that answers this question: Which invoices have a PaymentTotal
--that’s greater than the average PaymentTotal for all paid invoices? Return the InvoiceNumber
--and InvoiceTotal for each invoice.
SELECT InvoiceNumber, InvoiceTotal
FROM Invoices
WHERE PaymentTotal >
	(SELECT AVG(PaymentTotal)
	FROM Invoices
	WHERE PaymentTotal != 0)

--7. Write a SELECT statement that returns two columns from the GLAccounts table: AccountNo
--and AccountDescription. The result set should have one row for each account number that has
--never been used. Use a correlated subquery introduced with the NOT EXISTS operator. Sort the
--final result set by AccountNo.
SELECT AccountNo, AccountDescription
FROM GLAccounts
WHERE NOT EXISTS(
	SELECT *
	FROM InvoiceLineItems
	WHERE GLAccounts.AccountNo = InvoiceLineItems.AccountNo)
ORDER BY AccountNo

--8. Write a SELECT statement that returns four columns: VendorName, InvoiceID,
--InvoiceSequence, and InvoiceLineItemAmount for each invoice that has more than one line item
--in the InvoiceLineItems table
SELECT VendorName, I.InvoiceID, InvoiceSequence, InvoiceLineItemAmount
FROM Vendors V JOIN Invoices I
	ON V.VendorId = I.VendorID
	JOIN InvoiceLineItems IL
		ON I.InvoiceID = IL.InvoiceID
WHERE (SELECT COUNT(*) FROM InvoiceLineItems IL2 WHERE IL2.InvoiceID = I.InvoiceID) > 1