INSERT INTO [Assess].[StudentAssessment]
           ([StudentID]
           ,[AssessmentID]
           ,[Score]
           ,[AssessmentDate])
     VALUES
           (1
           ,1
           ,97.5
           ,'7/16/2017');

select * from assess.student
select * from assess.assessment
select * from assess.studentassessment

select * 
from assess.studentassessment
cross join assess.student

select * 
from assess.studentassessment sa
inner join assess.student s
	on sa.StudentID = s.StudentID

select * 
from assess.student s
left outer join assess.studentassessment sa
	on sa.StudentID = s.StudentID

select * 
from assess.student s
full outer join assess.studentassessment sa
	on sa.StudentID = s.StudentID

select s.FirstName + ' ' + s.LastName as FullName
from assess.student s
full outer join assess.studentassessment sa
	on sa.StudentID = s.StudentID

