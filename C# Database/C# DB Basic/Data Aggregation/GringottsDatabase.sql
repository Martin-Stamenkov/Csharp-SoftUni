USE Gringotts

SELECT COUNT(*) FROM WizzardDeposits

SELECT MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits
GROUP BY DepositGroup
 
SELECT TOP(2) DepositGroup FROM( 
SELECT DepositGroup,AVG(MagicWandSize) AS AverageWand 
FROM WizzardDeposits
GROUP BY DepositGroup
) AS LowesDeposits
ORDER BY AverageWand

SELECT DepositGroup ,SUM(DepositAmount) FROM WizzardDeposits
GROUP BY DepositGroup

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

SELECT DepositGroup,TotalSum FROM
	(
	SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
	WHERE MagicWandCreator = 'Ollivander family'
	GROUP BY DepositGroup
	) AS TotalRank
WHERE TotalSum < 150000
ORDER BY TotalSum DESC


SELECT DepositGroup,MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge FROM WizzardDeposits
GROUP BY DepositGroup,MagicWandCreator
ORDER BY MagicWandCreator,DepositGroup

SELECT AgeGroup , COUNT(AgeGroup) AS WizardCount
FROM
( 
	SELECT 
		CASE
			WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
			WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
			WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
			WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
			WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
			WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
			ELSE '[61+]'
		END AS AgeGroup
FROM WizzardDeposits
) AS WizardsAge
GROUP BY AgeGroup


SELECT LEFT(FirstName,1) AS FirstLetter  FROM WizzardDeposits
WHERE DepositGroup='Troll Chest'
GROUP BY LEFT(FirstName,1)


SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest  FROM WizzardDeposits
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup,IsDepositExpired
ORDER BY DepositGroup DESC,IsDepositExpired ASC

SELECT SUM([Difference]) FROM( SELECT FirstName AS [Host Wizard], DepositAmount AS [Host Wizard Deposit],
LEAD(FirstName) OVER (ORDER BY Id) AS [Guest Wizard],
DepositAmount - LEAD(DepositAmount) OVER (ORDER BY Id) AS [Difference]
FROM WizzardDeposits) AS [GameQuery]

SELECT * FROM WizzardDeposits
