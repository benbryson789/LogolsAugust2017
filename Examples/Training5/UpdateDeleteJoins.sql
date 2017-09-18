INSERT INTO [Assess].[StudentAssessment]
           ([StudentID]
           ,[AssessmentID]
           ,[Score]
           ,[AssessmentDate])
     VALUES
           (2
           ,1
           ,67
           ,'7/16/2017');
		   
update s
	set FirstName = 'Bob'
from assess.studentassessment sa
inner join assess.student s
	on sa.StudentID = s.StudentID
where sa.Score > 90;

select * from assess.student;

delete sa
from assess.studentassessment sa
inner join assess.student s
	on sa.StudentID = s.StudentID
where s.FirstName = 'Otis';

select * from [Assess].[StudentAssessment];

