Use ExaminationSystem

------------------------StdAnswers------------------------------- 
------------------------Select--------------------------------
create proc selectStdAns @Std_id int , @Exam_id int ,@QID int
with encryption
as
begin
	if exists(select StudentID, ExamID , QuestionID from 
	StdAnswers where StudentID =@Std_id and 
	ExamID = @Exam_id and QuestionID= @QID)
		select stdA.StudentID,stdA.ExamID ,
		stdA.QuestionID ,stdA.StudentAnswer from StdAnswers stdA 
		where StudentID =@Std_id and ExamID = @Exam_id and QuestionID= @QID
	else
		select 'Invalid ID '
end

--Test 
execute selectStdAns 1 , 1 , 1  

--------------------------Insert------------------------------
create proc insertStdA @Std_id int , @Exam_id int ,@QID int ,@STd_Ans nchar(1)
with encryption
as
begin
	if not exists(select StudentID, ExamID ,QuestionID from StdAnswers where StudentID =@Std_id and ExamID = @Exam_id and QuestionID =@QID)
		insert into StdAnswers(StudentID,ExamID,QuestionID,StudentAnswer)
		values(@Std_id,@Exam_id,@QID,@STd_Ans)
	else
		select 'Duplicate ID' 
end

--Test
execute insertStdA 1 , 2 , 2 , "a"

------------------------Update--------------------------------
create proc updateStdA @Std_id int , @Exam_id int,@QID int ,@STd_Ans nchar(1)
with encryption
as
begin
	if exists(select StudentID, ExamID, QuestionID from StdAnswers where StudentID =@Std_id and ExamID = @Exam_id and QuestionID =@QID)
		update StdAnswers set StudentAnswer = @STd_Ans 
		where StudentID =@Std_id and ExamID = @Exam_id and QuestionID = @QID
	else
		select 'Invalid Exam ID' 
end

--Test 
execute updateStdA  1 , 1 , 1 , 'd' 

---------------------Delete-----------------------------------
create proc deleteStdA @Std_id int , @Exam_id int ,@QID int
with encryption
as
begin
	if exists(select StudentID, ExamID, QuestionID from StdAnswers 
	where StudentID =@Std_id and ExamID = @Exam_id and QuestionID = @QID)
		delete from StdAnswers 
		where StudentID =@Std_id and ExamID = @Exam_id and QuestionID = @QID
	else
		select 'Invalid ID'
end

--Test 
execute deleteStdA  1, 1 , 1 

drop proc deleteStdA  