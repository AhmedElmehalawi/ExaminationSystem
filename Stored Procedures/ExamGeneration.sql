--ExamGeneration	
		-- 1. genertae exam in exams table.  check
		-- 2. get the specific number of mc questions from questions table.
		-- 3. get the specifc number of tf questions from questions table.
		-- 4. add these questions to ExamQuestions Table.

alter proc generateExam
@courseName varchar(30), @mcQuestionsNumber int, @tfQuestionsNumber int, @examDuration time(7)
as
	begin

		declare @crsID int
		set @crsID = (select CourseID from Courses where  CourseName = @courseName)

		declare @examID int
		set @examID = (select MAX(ExamID)+1 from Exams)

		exec insertExam @examID, @courseName, @examDuration, @crsID
		
		
		 insert into ExamQuestions(QID, ExamID,Grade)
		 select top(@mcQuestionsNumber)q.QID, @examID,1 
		 from Questions q inner join Courses c
		 on q.CrsID = c.CourseID and c.CourseID = @crsID and q.QType = 'MC'
		 order by NEWID();

		 insert into ExamQuestions(QID, ExamID,Grade)
		 select top(@tfQuestionsNumber)q.QID,@examID,1 
		 from Questions q inner join Courses c
		 on q.CrsID = c.CourseID and c.CourseID = @crsID and q.QType = 'TF'
		 order by NEWID();

end	

--generateExam 'JavaScript', 4,6,'01:00'