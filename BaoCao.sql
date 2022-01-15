Create database HR2
use HR2
go
create table Employee_2119110242(
idEmployee nvarchar(255),
Name nvarchar(255),
DateBirth date,
Gender bit,
PlaceBirth nvarchar(255),
idDepartment nvarchar(10)
)
go
Create table Deparment_2119110242(
idDepartment nvarchar(10),
Name nvarchar(255),
)
insert into Deparment_2119110242 values('IT',N'Công nghệ thông tin');
insert into Deparment_2119110242 values('KT',N'Kế toán');
insert into Deparment_2119110242 values('KSNB',N'Kiểm soát nội bộ');
select *from Deparment_2119110242

insert into Employee_2119110242 values(N'C53418',N'Trần Tiến','2000-10-11',1,N'Hà Nội','IT');
insert into Employee_2119110242 values(N'X53416',N'Nguyễn Cường','1999-07-21',0,N'Đắk Lắk','KT');
insert into Employee_2119110242 values(N'M53417',N'Nguyễn Hào','2001-12-25',1,N'TP.Hồ Chí Minh','KSNB');

Create Procedure getEmployees
As 
Begin 
	Select * 
	From Employee_2119110242
End 
Exec getEmployees

Create Procedure addEmp(@idEmployee nvarchar(255),@Name nvarchar(255),@DateBirth date,@Gender bit,@PlaceBirth nvarchar(255),@idDepartment nvarchar(10))
as 
Begin 
	insert into Employee_2119110242 values(@idEmployee,@Name,@DateBirth,@Gender,@PlaceBirth,@idDepartment);
End

Create Procedure deleteEmp (@idEmployee nvarchar(255))
As
Begin
	delete from Employee_2119110242 where idEmployee = @idEmployee;
End


Create Procedure editEmp(@idEmployee nvarchar(255),@Name nvarchar(255),@DateBirth date,@Gender bit,@PlaceBirth nvarchar(255),@idDepartment nvarchar(10))
as
Begin
	update Employee_2119110242 set Name=@Name,
						DateBirth=@DateBirth,
						Gender=@Gender,
						PlaceBirth=@PlaceBirth,
						idDepartment=@idDepartment
	where idEmployee=@idEmployee;
end


Create Procedure getAllDep
As 
Begin 
	Select * 
	From Deparment_2119110242
End 
delete from Deparment_2119110242


Create Procedure readDep(@idDepartment nvarchar(10))
as
begin
select*
from Deparment_2119110242
where idDepartment=@idDepartment
end
