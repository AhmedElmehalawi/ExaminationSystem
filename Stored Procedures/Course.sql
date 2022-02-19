--------------------------------- Courses ---------------------------------
---------------------------- Select ----------------------------
create proc selectCourse @id int
with encryption
as
begin
	if exists(select CourseID from Courses where CourseID = @id)
		select * from Courses
		where CourseID = @id 
	else
		select 'Invalid Course ID'
end

-- selectCourse 200

---------------------------- Insert ----------------------------
create proc insertCourse @id int,@name varchar(30)
with encryption
as
begin
	if not exists(select CourseID from Courses where CourseID = @id)
		insert into Courses
		values(@id,@name)
	else
		select 'Duplicated Course ID' 
end

--insertCourse 222,"java"

---------------------------- Update ----------------------------
create proc updateCourse @id int,@name varchar(30)
with encryption
as
begin
	if exists(select CourseID from Courses where CourseID = @id)
		update Courses set CourseName = @name 
				where CourseID = @id
	else
		select 'Invalid Course ID' 
end

--updateCourse 222,"c++"

---------------------------- Delete ----------------------------
create proc deleteCourse @id int
with encryption
as
begin
	if exists(select CourseID from Courses where CourseID = @id)
		delete from Courses where CourseID = @id
	else
		select 'Invalid Course ID'
end

--deleteCourse 222
--selectCourse 222