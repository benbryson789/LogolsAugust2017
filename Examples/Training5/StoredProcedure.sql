-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Joseph Mackie
-- Create Date: 7/16/2017
-- Description: Return Student Assessments
-- Call:		EXEC [Assess].[GetStudentAssessments] 1
-- =============================================
CREATE PROCEDURE [Assess].[GetStudentAssessments]
(
    @StudentID int
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

	SELECT 
		sa.StudentAssessmentID
		,sa.StudentID
		,sa.AssessmentID
		,s.FirstName + ' ' + s.LastName as FullName
		,sa.Score
		,sa.AssessmentDate
	FROM Assess.Student s
	INNER JOIN Assess.StudentAssessment sa
		ON sa.StudentID = s.StudentID
	WHERE s.StudentID = @StudentID
END
GO
