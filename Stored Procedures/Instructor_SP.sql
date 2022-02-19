--------------------------------- Instructors ---------------------------------
   ----------------------------Start Insert ----------------------------
create proc InsertIns @InsId int , 
					@Fname varchar(100) ,@Lname varchar(100) , 
					@Salary int , @DeptID int
with encryption
as
	begin try

	    if not exists(select InstructorID from Instructors where InstructorID=@InsId)
			insert into Instructors(InstructorID,Fname,Lname,Salary,DeptID)
			values(@InsId , @Fname , @Lname , @Salary , @DeptID)
		else 
			select'Duplicate In ID'
	end try
	begin catch 
		select 'Find Error'
	end catch
InsertIns 1,'Ayman' , 'Lotfy' , 8000,1
   ----------------------------End Insert ------------------------------
   ----------------------------Start Update ----------------------------
alter proc UpdateIns @InsId int , 
					@Fname varchar(100) ,@Lname varchar(100) , 
					@Salary int , @DeptID int
with encryption
as
	begin try

	    if  exists(select InstructorID from Instructors where InstructorID=@InsId)
			Update Instructors set Fname = @Fname, Lname = @Lname,
								Salary = @Salary , DeptID = @DeptID
			where InstructorID = @InsId
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch

--UpdateIns 1,'Nasser' , 'Kassem' , 7000, 1
   ----------------------------End Update ----------------------------
   ----------------------------Start Delete ----------------------------
create proc DeleteIns @InsID int 
with encryption
as
	begin try 
		if exists(select InstructorID from Instructors where InstructorID=@InsID)
			delete from Instructors where InstructorID = @InsID
		else
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch
--DeleteIns 1
   ----------------------------End Delete ----------------------------
   ----------------------------Start Select ----------------------------
create proc SelectIns @InsID int
with encryption
as
	begin try
		if exists(select InstructorID from Instructors where InstructorID = @InsID)
			select * from Instructors 
			where InstructorID = @InsID
		else 
			select 'Invalid In ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
   ----------------------------End Select ----------------------------
