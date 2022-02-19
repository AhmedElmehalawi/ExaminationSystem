--------------------------------- Departments ------------------------------
    ---------------------------- Start Insert ----------------------------
create proc InsertDept @DeID int , @DeName varchar(100)
with encryption
as
	begin try 
		if not exists (select DeptID from Departments where DeptID = @DeID)
			insert into Departments(DeptID, DeptName)
			values(@DeID,@DeName)
		else 
			select 'Invalid In ID'
	end try
	begin catch
		select 'Find Error'
	end catch
--InsertDept 2,'Computer Science'
    ---------------------------- End Insert ----------------------------
   ---------------------------- Start Update ----------------------------
alter proc UpdateDept @DeID int , @DeName varchar(100)
with encryption
as
	begin try 
		if exists (select DeptID from Departments where DeptID = @DeID)
			Update Departments 
			set DeptName = @DeName 
			where DeptID = @DeID
		else select 'Invalid ID'
	end try 
	begin catch
		select 'Find Error'
	end catch
UpdateDept 1,'AI'
   ----------------------------End Update ----------------------------
   ----------------------------Start Delete ----------------------------
create proc DeleteDept @DeID int 
with encryption
as
	begin try 
		if exists(select DeptID from Departments where DeptID=@DeID)
		delete from Departments where DeptID = @DeID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error  "DELETE statement conflicted with the REFERENCE constraint "FK_Students_Departments"'
	end catch
	--drop proc DeleteDept
	--DeleteDept 1
   ----------------------------End Delete ----------------------------
   ----------------------------Start Select ----------------------------
create proc SelectDept @DeID int
with encryption
as
	begin try 
		if exists(select DeptID from Departments where DeptID=@DeID)
			select * from Departments 
			where DeptID = @DeID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch
	--drop proc SelectDept
	--SelectDept 1
   ----------------------------End Select ----------------------------