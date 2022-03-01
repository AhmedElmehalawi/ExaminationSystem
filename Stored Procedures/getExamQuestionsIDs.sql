create proc getExamQuesionsIDs 
@examID int
with encryption
as
	begin
		select EQ.QID 
		from ExamQuestions eq INNER JOIN Exams e
		on e.ExamID = eq.ExamID AND e.ExamID = @examID
end

--getExamQuesionsIDs 500