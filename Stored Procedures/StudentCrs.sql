-----------------------------------------Start Insert ----------------------------------------
create proc InsertStudentCourse @StID int , @CoID int
with encryption
as
	begin try 
		if exists (select StudentID from Students where Students.StudentID = @StID)
			insert into StudentCrs(StudentID , CourseID)
			values(@StID,@CoID)
		else 
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	InsertStudentCourse 201 , 2
	exec InsertStudentCourse 200 , 1
	exec InsertStudentCourse 202 , 2
	exec InsertStudentCourse 203 , 1


---------------------------------------------End Insert -------------------------------------------


----------------------------Select-----------------------------------------------

	create proc SelectStudentCourses @sID int
with encryption
as
	begin try 
		if exists(select StudentID from StudentCrs where StudentID=@sID)
			select * from StudentCrs sc
			where @sID=sc.StudentID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	SelectStudentCourses 201


---------------------------- End Select-----------------------------------------------
-----------------------------Start Update---------------------------------------------
alter proc UpdateStudentCourse @StuID int , @CoID int, @newCourseID int
with encryption
as
	begin try 
		if exists (select CourseID from StudentCrs where StudentID = @StuID)
			Update StudentCrs 
			set CourseID = @newCourseID 
			where StudentID = @StuID
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch

UpdateStudentCourse 204,2,1
-----------------------------Start Update---------------------------------------------
------------------------------Start Delete ------------------------------------
alter proc DeletStudentCourse @stdID int,@CoID int 
with encryption
as
	begin try 
		if exists(select CourseID from StudentCrs where StudentID=@stdID)
		delete from StudentCrs where CourseID = @CoID and StudentID=@stdID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error  "DELETE statement conflicted with the REFERENCE constraint "FK_Students_Departments"'
	end catch

	DeletStudentCourse 203,1
----------------------------------End Delete ----------------------------------