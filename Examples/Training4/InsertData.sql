INSERT INTO [Assess].[Subject]
           ([Name]
           ,[Description])
     VALUES
           ('Sql'
           ,'Sql')		
           ,('Javascript'
           ,'Javascript');

INSERT INTO [Assess].[Level]
           ([LevelNumber]
           ,[Name])
     VALUES
           (1,'Beginner')
		   ,(2,'Intermediate')
		   ,(3,'Advanced');

INSERT INTO [Assess].[Student]
           ([FirstName]
           ,[LastName])
     VALUES
           ('Joe', 'Mackie')
           ,('Otis', 'Redding');

INSERT INTO [Assess].[Assessment]
           ([LevelNumber]
           ,[SubjectID]
           ,[Name])
     VALUES
           (1
           ,1
           ,'Sql Create, Select, Insert, Update, Delete')