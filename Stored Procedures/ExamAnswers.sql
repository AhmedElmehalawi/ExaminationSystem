--Exam Answers

-- examAnswers 505
create proc examAnswers @examID int
as
if exists(select ExamID from Exams where ExamID = @examID)
	begin
		select q.QType ,Q.QBody , q.QAnswer
		from Questions q
		where q.QID in (
			select  QID
			from ExamQuestions eq
			where ExamID =@ExamID)
		group by q.QType,Q.QBody , q.QID, q.QAnswer
	end
else
	select 'invalid Exam ID'