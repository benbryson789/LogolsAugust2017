/*
	DROP TABLE [Assess].[Answer];
	DROP TABLE [Assess].[Question];
	DROP TABLE [Assess].[StudentAssessment];
	DROP TABLE [Assess].[Assessment];
	DROP TABLE [Assess].[Subject];
	DROP TABLE [Assess].[Level];
	DROP TABLE [Assess].[Student];
*/

CREATE TABLE Assess.Student(
	StudentID int IDENTITY(1,1) NOT NULL PRIMARY KEY
	,FirstName varchar(75) NULL
	,LastName varchar(75) NULL
);

CREATE TABLE Assess.[Subject](
	[SubjectID] int IDENTITY(1,1) NOT NULL PRIMARY KEY
	,[Name] varchar(50) NULL
	,[Description] varchar(100) NULL
);

CREATE TABLE Assess.[Level](
	[LevelNumber] int NOT NULL PRIMARY KEY
	,[Name] varchar(50) NULL
);

CREATE TABLE Assess.[Assessment](
	[AssessmentID] int IDENTITY(1,1) NOT NULL PRIMARY KEY
	,[LevelNumber] int NOT NULL FOREIGN KEY REFERENCES Assess.[Level](LevelNumber)
	,[SubjectID] int NOT NULL FOREIGN KEY REFERENCES Assess.[Subject](SubjectID)
	,[Name] varchar(50) NULL
);

CREATE TABLE Assess.[StudentAssessment](
	[StudentAssessmentID] int IDENTITY(1,1) NOT NULL PRIMARY KEY
	,[StudentID] int NOT NULL FOREIGN KEY REFERENCES Assess.[Student](StudentID)
	,[AssessmentID] int NOT NULL FOREIGN KEY REFERENCES Assess.[Assessment](AssessmentID)
	,[Score] decimal(5,2) NULL
	,[AssessmentDate] datetime2 NULL
);

CREATE TABLE Assess.[Question](
	[QuestionID] int IDENTITY(1,1) NOT NULL PRIMARY KEY
	,[AssessmentID] int NOT NULL FOREIGN KEY REFERENCES Assess.[Assessment](AssessmentID)
	,[Text] varchar(150) NULL
);

CREATE TABLE Assess.[Answer](
	[AnswerID] int IDENTITY(1,1) NOT NULL PRIMARY KEY
	,[QuestionID] int NOT NULL FOREIGN KEY REFERENCES Assess.[Question](QuestionID)
	,[Text] varchar(150) NULL
);