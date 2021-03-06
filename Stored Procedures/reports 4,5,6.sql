-- 4- takes course ID and returns its topics   
create proc CourseTopic @courseID int
as
	if exists(select CourseID from Courses where CourseID=@courseID)
		select CourseName, Topic
		from  Topics t , Courses c
		where t.CourseID = @courseID and c.CourseID = t.CourseID
	else 
		select 'Invalid ID'
		
--CourseTopic 200

create proc CourseName @courseID int
as
	if exists(select CourseID from Courses where CourseID=@courseID)
		select CourseName
		from Courses
		where CourseID = @courseID
	else 
		select 'Invalid ID'

--CourseName 1
 
 -------------------------------------------------------
 -- 5- takes exam number and returns the Questions in it and chocies 
create proc examQuestionChoice @examID int
as
if exists(select ExamID from Exams where ExamID = @examID)
	begin
		select q.QType ,Q.QBody ,
				(select c.Choice + '-'
				from Choices c 
				where  q.QID = c.QID 
				for XML path('')) as choise
		from Questions q
		where q.QID in (
			select  QID
			from ExamQuestions eq
			where ExamID =@ExamID)
		group by q.QType,Q.QBody , q.QID 
	end
else
	select 'invalid Exam ID'

--examQuestionChoice 500

-- 6- takes exam number and the student ID 
-- then returns the Questions in this exam with the student answers.  
create proc examQuestionStudent @examID int, @studentID int
as
if exists(select ExamID from Exams where ExamID = @examID)
	begin
	if exists(select StudentID from StdAnswers where StudentID = @studentID)
	begin
		select q.QType ,q.QBody ,
				(select c.Choice + '       '
				from Choices c 
				where  q.QID = c.QID 
				for XML path('')) as choise ,q.QAnswer, s.StudentAnswer
		from Questions q, StdAnswers s
		where s.StudentID = @studentID and q.QID= s.QuestionID and q.QID in (
			select  QID
			from ExamQuestions eq
			where ExamID =@ExamID)
		group by q.QType,q.QBody , q.QID ,q.QAnswer,s.StudentAnswer
	end
	else
		select 'invalid Student ID'
	end
else
	select 'invalid Exam ID'

--examQuestionStudent 500,200