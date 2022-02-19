--------------------------------- Students ---------------------------------
   ----------------------------Start Insert ----------------------------
alter proc InsertStu @StuId int ,
			@Fname varchar(100) ,@Lname varchar(100) , 
			@NatioId int , @DeptID int
with encryption
as
	begin try

	    if not exists(select StudentID from Students where StudentID=@StuId)
			insert into Students(StudentID,Fname,Lname,NationalID,DeptID)
			values(@StuId , @Fname , @Lname , @NatioId , @DeptID)
		else 
			select'Duplicate In ID'
	end try
	begin catch 
		select 'Find Error'
	end catch
	--drop proc InsertStu
--InsertStu 1,'Mahmoud' , 'Elsayed' , 0400413 ,1
   ----------------------------End Insert ----------------------------
	
   ----------------------------Start Update ----------------------------
create proc UpdateStu @StuId int ,
			@Fname varchar(100) ,@Lname varchar(100) , 
			@NatioId int , @DeptID int
with encryption
as
	begin try
		if exists(select StudentID from Students where StudentID=@StuId)
			update Students set Fname = @Fname, Lname = @Lname,
								NationalID = @NatioId , DeptID = @DeptID
			where StudentID = @StuId
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
   ----------------------------End Update ----------------------------
   ----------------------------Start Delete ----------------------------
create proc DeletStu @StuId int 
with encryption
as
	begin try 
		if exists(select StudentID from Students where StudentID=@StuId)
			delete from Students where StudentID = @StuId
		else
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch
   ----------------------------End Delete ----------------------------
   ----------------------------Start Select ----------------------------
create proc SelectStu @StuId int
with encryption
as
	begin try
		if exists(select StudentID from Students where StudentID = @StuId)
			select * from Students 
			where StudentID = @StuId
		else 
			select 'Invalid In ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
   ----------------------------End Select ----------------------------
