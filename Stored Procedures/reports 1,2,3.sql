
----------------------------Report to returns the Student info according to Department Number Parameter -----------------------------------------------
	create proc SelectStudentData @DepID int
with encryption
as
	begin try 
		if exists(select Fname  from Students where DeptID=@DepID)
			select * from Students 
			where DeptID=@DepID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	SelectStudentData 4
--------------------------------------End----------------------------------------------

----------------------------Report that takes the Student ID and returns the grades of the student in all courses-----------------------------------------------
	create proc GetGrades @stuID int
with encryption
as
	begin try 
		if exists(select Result  from StdExamResults where StudentID=@stuID)
			select * from StdExamResults 
			where StudentID=@stuID
		else
			select 'Invalid  ID'
	end try
	begin catch
		select 'Find Error'
	end catch

	GetGrades 200

-----------------------------------------------------End-------------------------------------------------------------------
----------------------------Report that takes the Instructor ID and returns the name of the course that he teaches and the number of the student per courses-----------------------------------------------

create proc instructorInfo @InstructorID int
as

select Instructors.Fname+' '+Instructors.Lname as InstructorName,
		CourseName, 
		COUNT(Students.StudentID) as StudentCount
from Instructors inner join InstructorCrs 
on Instructors.InstructorID = @InstructorID and Instructors.InstructorID = InstructorCrs.InstructorID inner join Courses
on InstructorCrs.CourseID = Courses.CourseID  inner join StudentCrs on StudentCrs.CourseID = Courses.CourseID inner join Students
on Students.StudentID = StudentCrs.StudentID
group by Instructors.Fname, Instructors.Lname, CourseName

instructorInfo 101

-----------------------------------------------------------

--------------------------------------End----------------------------------------------

