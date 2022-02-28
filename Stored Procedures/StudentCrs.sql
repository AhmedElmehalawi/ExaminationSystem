-----------------------------------------Start Insert ----------------------------------------
create proc InsertStudent @StID int , @CoID int
with encryption
as
	begin try 
		if not exists (select StudentID from StudentCrs where CourseID = @CoID)
			insert into StudentCrs(StudentID , CourseID)
			values(@StID,@CoID)
		else 
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	InsertStudent 1 , 1

---------------------------------------------End Insert -------------------------------------------


----------------------------Select-----------------------------------------------

	create proc SelectStudent @sID int
with encryption
as
	begin try 
		if exists(select StudentID from StudentCrs where CourseID=@sID)
			select * from StudentCrs 
			where CourseID=@sID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	SelectStudent 1


---------------------------- End Select-----------------------------------------------
-----------------------------Start Update---------------------------------------------
create proc UpdateStudent @StuID int , @CoID int
with encryption
as
	begin try 
		if exists (select StudentID from StudentCrs where CourseID = @CoID)
			Update StudentCrs 
			set StudentID = @StuID 
			where CourseID = @CoID
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch

UpdateStudent 2,1
-----------------------------Start Update---------------------------------------------
------------------------------Start Delete ------------------------------------
create proc DeletStudent @CoID int 
with encryption
as
	begin try 
		if exists(select StudentID from StudentCrs where CourseID=@CoID)
		delete from StudentCrs where CourseID = @CoID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error  "DELETE statement conflicted with the REFERENCE constraint "FK_Students_Departments"'
	end catch

	DeletStudent 1
----------------------------------End Delete ----------------------------------