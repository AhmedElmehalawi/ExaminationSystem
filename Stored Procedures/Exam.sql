--------------------------------- Exams ---------------------------------
---------------------------- Select ----------------------------
create proc selectExam @id int
with encryption
as
begin
	if exists(select ExamID from Exams where ExamID = @id)
		select * from Exams
		where ExamID = @id 
	else
		select 'Invalid Exam ID'
end

-- selectExam 300

---------------------------- Insert ----------------------------
create proc insertExam @id int,@name varchar(30), @duration time(7), @courseID int
with encryption
as
begin
	if not exists(select ExamID from Exams where ExamID = @id)
		begin
			if exists(select CourseID from Courses where CourseID = @courseID)
				insert into Exams(ExamID, ExamName, ExamDuration ,CourseID)
				values(@id, @name, @duration, @courseID)
			else
				select 'Invalid Course ID'
		end
	else
		select 'Duplicated Exam ID' 
end

--insertExam 333,"test me","01:02:00","301"
--selectExam 333

---------------------------- Update ----------------------------
create proc updateExam @id int,@name varchar(30), @duration time(7), @courseID int
with encryption
as
begin
	if exists(select ExamID from Exams where ExamID = @id)
		begin
			if exists(select CourseID from Courses where CourseID = @courseID)
				update Exams set ExamName = @name, ExamDuration = @duration, CourseID = @courseID
				where ExamID = @id
			else
				select 'Invalid Course ID'
		end
	else
		select 'Invalid Exam ID' 
end

--updateExam 333,"test one","02:00:00","201"
--selectExam 333

---------------------------- Delete ----------------------------
create proc deleteExam @id int
with encryption
as
begin
	if exists(select ExamID from Exams where ExamID = @id)
		delete from Exams where ExamID = @id
	else
		select 'Invalid Exam ID'
end

--deleteExam 333
--selectExam 333