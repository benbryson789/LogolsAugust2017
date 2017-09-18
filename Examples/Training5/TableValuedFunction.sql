-- =========================================================
-- Create Inline Function Template for Azure SQL Database
-- =========================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Joseph Mackie
-- Create date: 7/16/2017
-- Description:	Return Students with Full Name
-- Call:		SELECT * FROM GetStudentsWithFullName()
-- =============================================
CREATE FUNCTION GetStudentsWithFullName
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT 
		StudentID
		,FirstName
		,LastName
		,FirstName + ' ' + LastName AS FullName
	FROM [Assess].[Student]
)
GO
