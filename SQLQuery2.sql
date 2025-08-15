Create procedure ShowStudentData(
@RollNo int)
--Exec ShowStudentData 1;
as begin 
select * from [dbo].[Students] where RollNo = @RollNo;
end
