--------------------------------- Questions ---------------------------------
---------------------------- Select ----------------------------
--------------- Select Question Only ---------------
create proc selectQuestion @id int
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		select q.QID , q.QType, q.QBody, q.CrsID from Questions q
		where QID = @id 
	else
		select 'Invalid Question ID'
end
--------------- Select Question With Answer ---------------
create proc selectQuestionAns @id int
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		select * from Questions
		where QID = @id 
	else
		select 'Invalid Question ID'
end

-- selectQuestion  15
-- selectQuestionAns 15

---------------------------- Insert ----------------------------
create proc insertQuestion @id int,@body varchar(30), @type nchar(2), @answer nchar(1), @courseID int
with encryption
as
begin
	if not exists(select QID from Questions where QID = @id)
	begin
		if exists(select CourseID from Courses where CourseID = @courseID)
			insert into Questions (QID,QBody,QType,QAnswer,CrsID)
			values(@id,@body,@type,@answer,@courseID)
		else
			select 'Invalid Course ID'
		end
	else
		select 'Duplicated Question ID' 
end

--insertQuestion 777,"body n","tf","1",2
--selectQuestionAns 777

---------------------------- Update ----------------------------
--------------- Update Question Ans ---------------
create proc updateQuestion @id int,@body varchar(30), @type nchar(2), @answer nchar(1)
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		update Questions set QBody = @body, QType = @type, QAnswer = @answer
				where QID = @id
	else
		select 'Invalid Question ID' 
end
--------------- Update Question Body ---------------
create proc updateQuestionBody @id int,@body varchar(30)
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		update Questions set QBody = @body
				where QID = @id
	else
		select 'Invalid Question ID' 
end

--------------- Update Question Answer ---------------
create proc updateQuestionAns @id int, @answer nchar(1)
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		update Questions set QAnswer = @answer
				where QID = @id
	else
		select 'Invalid Question ID' 
end

--------------- Update Question Type ---------------
create proc updateQuestionType @id int, @type nchar(2)
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		update Questions set QType = @type
				where QID = @id
	else
		select 'Invalid Question ID' 
end

--updateQuestion 777,"body t","tf","2"
--updateQuestionAns 777,"3"
--updateQuestionType 777,"tt"
--updateQuestionBody 777,"body mmm"
--selectQuestionAns 777

---------------------------- Delete ----------------------------
create proc deleteQuestion @id int
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		delete from Questions where QID = @id
	else
		select 'Invalid Question ID'
end

--deleteQuestion 777
--selectQuestionAns 777