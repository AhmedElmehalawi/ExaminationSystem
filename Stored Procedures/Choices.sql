Use ExaminationSystem

------------------------Choices------------------------------- 
------------------------Select--------------------------------
create proc selectChoice @id int
with encryption
as
begin
	if exists(select QID from Choices where  QID = @id)
		select c.QID , Choice from Choices c 
		where QID = @id 
	else
		select 'Invalid ID'
end

--Test
execute selectChoice 1 

drop proc selectChoice 



--------------------------Insert------------------------------
create proc insertChoices @id int ,@choice varchar(50)
with encryption
as
begin
	if not exists(select QID from Choices where QID = @id and choice=@choice)
		insert into Choices(QID,choice)
		values(@id,@choice)
	else
		select 'Duplicate ID' 
end

--Test--
--insert data 
insertChoices 1,"6"
insertchoices 1,"5"
insertChoices 1,"7"

drop proc insertChoices 
------------------------Update--------------------------------
create proc updateChoice @id int,@choice varchar(50) , @new varchar(50)
with encryption
as
begin
	if exists(select QID , Choice from Choices where QID = @id and Choice = @choice)
		update Choices set Choice= @new				
		where QID = @id  and Choice = @choice
	else
		select 'Invalid ID' 
end

--Test--
execute updateChoice 1 ,"6", "a"   

drop proc updateChoice 
---------------------Delete-----------------------------------
create proc deleteChoice @id int ,@choice varchar(50)
with encryption
as
begin
	if exists(select QID from Choices where QID = @id and Choice = @choice)
		delete from Choices where QID = @id and Choice = @choice
	else
		select 'Invalid ID'
end

--Test--
execute deleteChoice 1 , "5"

drop proc deleteChoice 