Use ExaminationSystem

------------------------StdExamResults------------------------------- 
------------------------Select--------------------------------
create proc selectStdExRes @Std_id int , @Exam_id int 
with encryption
as
begin
	if exists(select StudentID, ExamID from 
	StdExamResults where StudentID =@Std_id and 
	ExamID = @Exam_id)
		select ster.StudentID,ster.ExamID ,
		ster.Result from StdExamResults ster 
		where StudentID =@Std_id and ExamID = @Exam_id 
		else
		select 'Invalid ID '
end

--Test
execute selectStdExRes 1 , 1
--------------------------Insert------------------------------
create proc insertStdExRe @Std_id int , @Exam_id int ,@Result int
with encryption
as
begin
	if not exists(select StudentID, ExamID from StdExamResults where StudentID =@Std_id and ExamID = @Exam_id)
		insert into StdExamResults(StudentID,ExamID,Result)
		values(@Std_id,@Exam_id,@Result)
	else
		select 'Duplicate ID' 
end

--Test
execute insertStdExRe  2 , 2 , 30

------------------------Update--------------------------------
create proc updateStdExRe  @Exam_id int,@Std_id int ,
@Result int
with encryption
as
begin
	if exists(select StudentID, ExamID from StdExamResults 
	where StudentID =@Std_id and ExamID = @Exam_id)
		update StdExamResults set Result= @Result 
		where StudentID =@Std_id and ExamID = @Exam_id 	
		else
		select 'Invalid ID' 
end

--Test
execute updateStdExRe 1 , 2, 70 

drop proc updateStdExRe  
---------------------Delete-----------------------------------
create proc deleteStdExRe @Std_id int , @Exam_id int
with encryption
as
begin
	if exists(select StudentID, ExamID from StdExamResults 
	where StudentID =@Std_id and ExamID = @Exam_id)
		delete from StdExamResults
		where StudentID =@Std_id and ExamID = @Exam_id 	
	else
		select 'Invalid ID'
end


--Test 
execute deleteStdExRe  2,2


drop proc deleteStdExRe 


select * from StdExamResults