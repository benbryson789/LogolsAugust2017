-- ======================================================
-- Create Scalar Function Template for Azure SQL Database
-- ======================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Joseph Mackie
-- Create Date: 7/16/2017
-- Description: Return Full Name
-- Call:		SELECT dbo.GetFullName('Joe', 'Mackie')
-- =============================================
CREATE FUNCTION [dbo].[GetFullName]
(
    -- Add the parameters for the function here
    @FirstName varchar(75)
	,@LastName varchar(75)
)
RETURNS varchar(150)
AS
BEGIN
    -- Return the result of the function
    RETURN @FirstName + ' ' + @LastName;
END
GO

