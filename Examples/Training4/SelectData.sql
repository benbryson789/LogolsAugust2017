SELECT FirstName 
FROM [Assess].[Student];

SELECT FirstName 
FROM [Assess].[Student]
WHERE LastName = 'Mackie';

SELECT FirstName 
FROM [Assess].[Student]
WHERE LastName <> 'Mackie';

SELECT * 
FROM [Assess].[Student]
ORDER BY LastName ASC;

SELECT * 
FROM [Assess].[Student]
ORDER BY LastName DESC;