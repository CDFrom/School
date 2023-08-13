USE BaseballData
--9.	Return all school ids and names that are not in one of the following states: NY, LA, CA, MN
SELECT schoolID, schoolName FROM schools WHERE schoolState NOT IN ('NY','LA','CA','MN')

--10.	Return the player ids and states of all players who are from one of the following cities: Tampa, Minneapolis, Rochester, Chicago
SELECT playerID, birthState FROM players WHERE birthCity IN ('Tampa', 'Minneapolis', 'Rochester', 'Chicago')

--11.	Return the player ids and award names for each award that was a tie between 1990 and 2000
SELECT playerID, awardID FROM awardsplayers WHERE tie IS NOT NULL AND yearID BETWEEN 1990 AND 2000

--12.	Return the player and year id of all pitching rows with an IPOuts value between 100 and 200, and which have a non-null BAOPP value
SELECT playerID, yearID FROM pitching WHERE IPOuts BETWEEN 100 AND 200 AND BAOPP IS NOT NULL

--13.	Return the playerIds of all players who died on the same month and day in which they were born.
SELECT playerID FROM players WHERE deathMonth = birthMonth AND deathDay = birthDay

--14.	Return the team ID and year ID for all teams which had a world series win (WSWin) while having an attendance of less than 500000
SELECT teamID, yearID FROM teams WHERE WSWin LIKE 'Y' AND attendance < 500000

--15.	For all hall of fame winners, return the hofID and yearID of those columns:
--a.	hofID
--b.	yearID
--c.	closeOrNot
--i.	CloseorNot should be ‘Won’  for someone has won the award if votes meets or exceeds the value of needed
--ii.	closeOrNot should be 'Nail Biter' if the difference between the votes and the votes needed is less than 5 percent of the total number of ballots cast. 
--iii.	Otherwise, closeOrNot should be 'Landslide' 
SELECT hofID, yearID,
	CASE
		WHEN (votes-needed) < (ballots*0.05) THEN 'Nail Biter'
		WHEN votes >= needed THEN 'Won'
		ELSE 'Landslide'
	END AS closeOrNot
FROM halloffame
WHERE inducted LIKE 'Y'

--16.	For all players, return the following columns:
--a.	player id
--b.	last name
--c.	first name
--d.	sameBirthDeath
--i.	sameBirthDeath should be 1 if the player died in the same country, city, and state in which they were born, 0 if any of those fields do not match, and NULL if any of the fields are NULL
SELECT playerID AS 'player id', nameLast AS 'last name', nameFirst AS 'first name',
	CASE
		WHEN birthCity IS NULL
			OR birthCountry IS NULL
			OR birthState IS NULL
			OR deathCity IS NULL
			OR deathCountry IS NULL
			OR deathState IS NULL
			THEN NULL
		WHEN birthCity = deathCity
			AND birthCountry = deathCountry
			AND birthState = deathState
			THEN 1
		ELSE 0
	END AS sameBirthDeath
FROM players