USE [Geography]

SELECT CountryName, IsoCode FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode

SELECT PeakName, RiverName,
LOWER(CONCAT(Peaks.PeakName, SUBSTRING(Rivers.RiverName, 2, LEN(Rivers.RiverName) - 1))) 
AS Mix 
FROM Rivers,Peaks
WHERE RIGHT(PeakName , 1) = LEFT(RiverName ,1)
ORDER BY Mix