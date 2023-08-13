--1. Write SELECT INTO statements to create two test tables named VendorCopy and
--InvoiceCopy that are complete copies of the Vendors and Invoices tables. If VendorCopy
--and InvoiceCopy already exist, first code two DROP TABLE statements to delete them.
USE AP
DROP TABLE VendorCopy
DROP TABLE InvoiceCopy

SELECT *
INTO VendorCopy
FROM Vendors

SELECT *
INTO InvoiceCopy
FROM Invoices

--2. Write an INSERT statement that adds a row to the InvoiceCopy table with the following
--values:
--VendorID: 32
--InvoiceTotal: $434.58
--TermsID: 2
--InvoiceNumber: AX-014-027
--PaymentTotal: $0.00
--InvoiceDueDate: 07/8/2016
--InvoiceDate: 6/21/2016
--CreditTotal: $0.00
--PaymentDate: null
USE AP
INSERT InvoiceCopy
VALUES (32, 'AX-014-027', '6/21/2016', 434.58, 0, 0, 2, '07/8/2016', null)

--3. Write an UPDATE statement that modifies the VendorCopy table. Change the default
--account number to 403 for each vendor that has a default account number of 400.
USE AP
UPDATE VendorCopy
SET DefaultAccountNo = 403
WHERE DefaultAccountNo = 400

--4. Write an UPDATE statement that modifies the InvoiceCopy table. Change the
--PaymentDate to today’s date and the PaymentTotal to the balance due for each invoice
--with a balance due. Set today’s date with a literal date string, or use the GETDATE()
--function.
UPDATE InvoiceCopy
SET PaymentDate = GETDATE(),
	PaymentTotal = InvoiceTotal - CreditTotal
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0

--5. Write a DELETE statement that deletes all vendors in the state of Minnesota from the
--VendorCopy table.
USE AP
DELETE FROM VendorCopy
WHERE VendorState = 'MN'

--6. Write a DELETE statement for the VendorCopy table. Delete the vendors that are
--located in states from which no vendor has ever sent an invoice.
--Hint: Use a subquery coded with “SELECT DISTINCT VendorState” introduced with the
--NOT IN operator.
USE AP
DELETE FROM VendorCopy
WHERE VendorState NOT IN (
	SELECT DISTINCT VendorState
	FROM VendorCopy VC JOIN InvoiceCopy IC
		ON VC.VendorID = IC.VendorID)