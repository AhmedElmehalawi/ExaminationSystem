--Exam Correction
create proc correctExam
@stID int, @examID int
as
	begin
		declare @result int = (select SUM(eq.Grade) 
					 from Questions q inner join StdAnswers sa
					 on q.QID = sa.QuestionID and q.QAnswer = sa.StudentAnswer
					 inner join ExamQuestions eq
					 on eq.QID = sa.QuestionID and eq.ExamID = @examID)
		execute insertStdExRe @stID, @examID, @result 
	
	end
execute correctExam 200,500