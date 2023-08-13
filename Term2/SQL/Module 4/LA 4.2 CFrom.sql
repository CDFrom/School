--1. For each track, return the following columns:
--a. Track Name
--b. Track Length 
--c. Album Title
--d. Artist name

--Do not include tracks without a matching album or artist.
--Order the results by album id, ascending.
SELECT T.Name AS 'Track Name', T.Milliseconds AS 'Track Length', Al.Title AS 'Album Title', Ar.Name AS 'Artist Name'
FROM Track T
JOIN Album Al
	ON T.AlbumId = Al.AlbumId
Join Artist Ar
	ON Al.ArtistId = Ar.ArtistId
ORDER BY Al.AlbumId

--2. For each track, return the following columns:
--a. Track name
--b. Track unit price
--c. Media type name
--d. Genre name

--Do not include tracks without a matching genre type or media type.
--Order by genre name alphabetically
SELECT T.Name AS 'Track name', T.UnitPrice AS 'Track unit price', M.Name AS 'Media type name', G.Name AS 'Genre name'
FROM Track T
	JOIN MediaType M
		ON T.MediaTypeId = M.MediaTypeId
	JOIN Genre G
		ON T.GenreId = G.GenreId
ORDER BY G.Name;

--3. For each track that is not in playlist, return the following
--a. Track name
--b. Size in bytes
SELECT T.Name AS 'Track name', T.Bytes AS 'Size in bytes'
FROM Track T
	LEFT JOIN PlaylistTrack PT
		ON T.TrackId = PT.TrackID
WHERE PT.TrackId IS NULL

--4. For each employee who does not support a customer, return the following
--a. First name
--b. Last name
SELECT E.FirstName AS 'First name', E.LastName AS 'Last name'
FROM Employee E
	LEFT JOIN Customer C
		ON E.EmployeeId = C.SupportRepId
WHERE C.SupportRepId IS NULL

--5. Return the following columns
--a. Last name
--b. First name
--c. Phone number

--Return a row for each customer and a row for each employee in a single table
SELECT LastName, FirstName, Phone
FROM Customer
UNION
SELECT LastName, FirstName, Phone
FROM Employee

--6. Return the following columns
--a. Name

--Name should contain a composer name or an artist name.
--Return a row for each artist and a row for each track that has a composer in a single table.
SELECT Name
FROM Artist
UNION
SELECT Composer
FROM Track
WHERE Composer IS NOT NULL