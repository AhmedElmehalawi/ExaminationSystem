-----------------------------------------Start Insert ----------------------------------------
create proc InsertTopic @CoID int , @ToName varchar(50)
with encryption
as
	begin try 
		if not exists (select CourseID from Topics where CourseID = @CoID)
			insert into Topics(CourseID, Topic)
			values(@CoID,@ToName)
		else 
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	InsertTopic 1, 'Introduction to c#'
	InsertTopic 2, 'Introduction to JS'

---------------------------------------------End Insert -------------------------------------------


----------------------------Select based on Topic Name-----------------------------------------------

	create proc SelectTop @ToName varchar(50)
with encryption
as
	begin try 
		if exists(select Topic from Topics where topic=@ToName)
			select * from Topics 
			where Topic= @ToName
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	SelectTop 'Introduction to JS'

----------------------------------------Select based on CourseID-------------------

		create proc SelectTopByCourse @CoID int
with encryption
as
	begin try 
		if exists(select Topic from Topics where CourseID=@CoID)
			select * from Topics 
			where CourseID= @CoID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	SelectTopByCourse 2
	SelectTopByCourse 1


---------------------------- End Select-----------------------------------------------
-----------------------------Start Update---------------------------------------------
create proc UpdateTop @CoID int , @ToName varchar(50)
with encryption
as
	begin try 
		if exists (select Topic from Topics where CourseID = @CoID)
			Update Topics 
			set Topic = @ToName
			where CourseID = @CoID
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
UpdateTop 1,'AI'
-----------------------------Start Update---------------------------------------------
------------------------------Start Delete ------------------------------------
create proc DeletTop @CoID int 
with encryption
as
	begin try 
		if exists(select Topic from Topics where CourseID=@CoID)
		delete from Topics where CourseID = @CoID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error  "DELETE statement conflicted with the REFERENCE constraint "FK_Students_Departments"'
	end catch

	--DeletTop 1
----------------------------------End Delete ----------------------------------