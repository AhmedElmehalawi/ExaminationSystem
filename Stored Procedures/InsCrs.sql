-----------------------------------------Start Insert ----------------------------------------
create proc InsertInstructorCourse @insID int , @CoID int
with encryption
as
	begin try 
		if  exists (select InstructorID from Instructors where Instructors.InstructorID = @insID)
			insert into InstructorCrs(InstructorID, CourseID)
			values(@insID,@CoID)
		else 
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	--exec InsertInstructorCourse 103, 1
	

---------------------------------------------End Insert -------------------------------------------

----------------------------Start Select -----------------------------------------------

alter proc SelectInstructorCourses @InsID int
with encryption
as
	begin try 
		if exists(select ic.InstructorID from InstructorCrs ic where InstructorID=@InsID)
			select * from InstructorCrs ic
			where @InsID = ic.InstructorID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	--SelectInstructorCourses 103

---------------------------- End Select-----------------------------------------------
-----------------------------Start Update---------------------------------------------
create proc UpdateInsCourse @InsID int , @CoID int, @newCourseID int
with encryption
as
	begin try 
		if exists (select CourseID from InstructorCrs where InstructorID = @InsID)
			Update InstructorCrs 
			set CourseID = @newCourseID
			where InstructorID = @InsID
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
--UpdateInsCourse 103,1, 2
-----------------------------End Update---------------------------------------------
------------------------------Start Delete -------------------------------------------
create proc DeletInstructorCourse @InsID int, @courseID int
with encryption
as
	begin try 
		if exists(select CourseID from InstructorCrs where InstructorID=@InsID)
		delete from InstructorCrs where CourseID= @courseID and InstructorID = @InsID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error  "DELETE statement conflicted with the REFERENCE constraint "FK_Students_Departments"'
	end catch

	--DeletInstructorCourse 103,2
	
----------------------------------End Delete ----------------------------------