create database employeemanagement;
use employeemanagement;

create table employee_details
(
    empno int primary key,
    empname varchar(50) not null,
    empsal numeric(10,2) check(empsal >= 25000),
    emptype char(1) check(emptype in ('F','P'))
);

create procedure sp_insert_employee
(
    @empname varchar(50),
    @empsal numeric(10,2),
    @emptype char(1)
)
as
begin
    declare @empno int;
    select @empno = isnull(max(empno),1000) + 1
    from employee_details;
    insert into employee_details
    values(@empno,@empname,@empsal,@emptype);
    print 'employee inserted successfully';
end;

exec sp_insert_employee 'arun',30000,'F';

exec sp_insert_employee 'kumar',28000,'P';

select * from employee_details;

create procedure sp_UpdateSalary
(
    @empid int,
    @UpdatedSalary numeric(10,2) output
)
as
begin
    update Employee_Details
    set Empsal = Empsal + 100
    where Empno = @empid
    select @UpdatedSalary = Empsal
    from Employee_Details
    where Empno = @empid
end

select * from employee_details;