Use ExaminationSystem

------------------------ExamQuestions------------------------------- 
------------------------Select--------------------------------
create proc selectExamQ @Exid int , @QID int
with encryption
as
begin
	if exists(select ExamID , QID from ExamQuestions where ExamID = @Exid and QID = @QID)
		select * from ExamQuestions eq 
		where ExamID = @Exid and QID =@QID 
	else
		select 'Invalid Exam ID'
end
 
drop proc selectExamQ 

--Test
execute selectExamQ 1 , 1 

--------------------------Insert------------------------------
create proc insertExamQ @Exid int,@QID int ,@Grade int
with encryption
as
begin
	if not exists(select ExamID , QID from ExamQuestions where ExamID = @Exid and QID= @QID)
		insert into ExamQuestions(ExamID,QID,Grade)
		values(@Exid,@QID,@Grade)
	else
		select 'Duplicate Exam ID' 
end


--Test 
execute insertExamQ 2, 1 , 50

drop proc insertExamQ
------------------------Update--------------------------------
create proc updateExamQ @Exid int,@QID int ,@newGrade int
with encryption
as
begin
	if exists(select ExamID,QID from ExamQuestions where ExamID =@Exid and QID = @QID)
		update ExamQuestions set Grade =@newGrade				
		where ExamID = @Exid and QID = @QID
	else
		select 'Invalid Exam ID' 
end

--Test 
execute updateExamQ 1 ,1 , 70  

drop proc updateExamQ  

---------------------Delete-----------------------------------
create proc deleteExamQ @Exid int , @QID int
with encryption
as
begin
	if exists(select ExamID from ExamQuestions where ExamID = @Exid and QID =@QID)
		delete from ExamQuestions where ExamID = @Exid and QID =@QID
	else
		select 'Invalid Exam ID'
end

--Test
execute deleteExamQ 2 , 1 



drop proc deleteExamQ