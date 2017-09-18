UPDATE [Assess].[Subject]
	SET [Description] = 'Learn the basics of Sql with Sql Server.'
WHERE [Name] = 'Sql';

select * from [Assess].[Subject];

declare @test varchar(30)
set @test = 'test'
select @test