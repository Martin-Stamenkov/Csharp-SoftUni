USE Geography

SELECT c.CountryCode, m.MountainRange,p.PeakName,p.Elevation FROM Countries AS c  
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains AS m ON m.Id = mc.MountainId
JOIN Peaks AS p ON p.MountainId = mc.MountainId
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

SELECT c.CountryCode,COUNT(c.CountryCode) AS MountainRanges FROM Countries AS c  
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains AS m ON m.Id = mc.MountainId
WHERE c.CountryCode IN ('US','RU', 'BG' )
GROUP BY c.CountryCode

SELECT TOP(5) c.CountryName,r.RiverName FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

SELECT ContinentCode,CurrencyCode,CurrencyCount
FROM (
	SELECT *, DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyCount DESC) AS [Currency Rank]
		FROM (
			SELECT ContinentCode,CurrencyCode, COUNT(*) AS [CurrencyCount] 
			FROM Countries
			GROUP BY ContinentCode,CurrencyCode
			) 
		AS [CurrencyCountQuery]
		WHERE CurrencyCount > 1
		) AS [CurrencyRankingQuery]
		WHERE [Currency Rank] = 1


SELECT COUNT(*) FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode=c.CountryCode
LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
WHERE m.MountainRange IS NULL



SELECT TOP (5) c.CountryName,MAX(Elevation) AS HighestPeakElevation, MAX([Length]) AS LongestRiverLength FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode=c.CountryCode
LEFT JOIN  Mountains AS m ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p ON p.MountainId=m.Id
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC,LongestRiverLength DESC, c.CountryName ASC

SELECT TOP(5) Country,
	CASE 
		WHEN PeakName IS NULL THEN '(no highest peak)'
		ELSE PeakName 
	END AS [Highest Peak Name],
	CASE 
		WHEN Elevation IS NULL THEN '0'
		ELSE Elevation 
	END AS [Highest Peak Elevation],
	CASE 
		WHEN MountainRange IS NULL THEN '(no mountain)'
		ELSE MountainRange 
	END  AS [Mountain]
FROM (
SELECT *, DENSE_RANK () OVER(PARTITION BY [Country] ORDER BY Elevation DESC) AS [Rank]
FROM(
		SELECT c.CountryName AS [Country],p.PeakName,p.Elevation,m.MountainRange 
		FROM Countries AS c
		LEFT JOIN MountainsCountries AS mc ON mc.CountryCode=c.CountryCode
		LEFT JOIN  Mountains AS m ON m.Id = mc.MountainId
		LEFT JOIN Peaks AS p ON p.MountainId=m.Id
	) AS Info
) AS [PeakRank]
WHERE [Rank] = 1


