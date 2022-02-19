--------------------------------- Questions ---------------------------------
---------------------------- Select ----------------------------
--------------- Select Question Only ---------------
create proc selectQuestion @id int
with encryption
as
begin
	if exists(select QID from Questions where QID = @id)
		select q.QID , q.QType, q.QBody from Questions q
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

-- selectQuestion 700
-- selectQuestionAns 700

---------------------------- Insert ----------------------------
create proc insertQuestion @id int,@body varchar(30), @type nchar(2), @answer nchar(1)
with encryption
as
begin
	if not exists(select QID from Questions where QID = @id)
		insert into Questions (QID,QBody,QType,QAnswer)
		values(@id,@body,@type,@answer)
	else
		select 'Duplicated Question ID' 
end

--insertQuestion 777,"body n","tf","1"
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