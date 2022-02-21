-----------------------------------------Start Insert ----------------------------------------
create proc InsertInst @insID int , @CoID int
with encryption
as
	begin try 
		if not exists (select InstructorID from InstructorCrs where CourseID = @CoID)
			insert into InstructorCrs(InstructorID, CourseID)
			values(@insID,@CoID)
		else 
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	InsertInst 1, 1
	

---------------------------------------------End Insert -------------------------------------------

----------------------------Start Select -----------------------------------------------

create proc SelectIns @InsID int
with encryption
as
	begin try 
		if exists(select InstructorID from InstructorCrs where InstructorID=@InsID)
			select * from InstructorCrs 
			where InstructorID=@InsID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	SelectIns 1

---------------------------- End Select-----------------------------------------------
-----------------------------Start Update---------------------------------------------
alter proc UpdateCoIns @InsID int , @CoID int
with encryption
as
	begin try 
		if exists (select CourseID from InstructorCrs where InstructorID = @InsID)
			Update InstructorCrs 
			set CourseID = @CoID
			where InstructorID = @InsID
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
UpdateCoIns 1, 1
-----------------------------End Update---------------------------------------------
------------------------------Start Delete -------------------------------------------
create proc DeletIns @InsID int 
with encryption
as
	begin try 
		if exists(select InstructorID from InstructorCrs where InstructorID=@InsID)
		delete from InstructorCrs where InstructorID=@InsID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error  "DELETE statement conflicted with the REFERENCE constraint "FK_Students_Departments"'
	end catch

	DeletIns 1
	
----------------------------------End Delete ----------------------------------