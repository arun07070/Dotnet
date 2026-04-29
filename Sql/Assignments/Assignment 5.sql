create database Assignment5;
use  Assignment5;

create table employee_master (
    emp_id int primary key,
    emp_name varchar(25),
    gender varchar(10),
    basic_salary decimal(10,2),
    dept_id int
);
insert into employee_master values (101,'arun','male',5000,1);
insert into employee_master values (102,'athish','male',8000,2);
insert into employee_master values (103,'barani','female',6000,3);

create or alter procedure usp_generate_payslip
    @id int
as
begin
    declare 
        @name varchar(25),
        @sal decimal(10,2),
        @hra_amt decimal(10,2),
        @da_amt decimal(10,2),
        @pf_amt decimal(10,2),
        @it_amt decimal(10,2),
        @total_ded decimal(10,2),
        @gross_sal decimal(10,2),
        @net_sal decimal(10,2);
    select 
        @name = emp_name,
        @sal = basic_salary
    from employee_master
    where emp_id = @id;
    select 
        @hra_amt = @sal * 0.10,
        @da_amt  = @sal * 0.20,
        @pf_amt  = @sal * 0.08,
        @it_amt  = @sal * 0.05;
    set @total_ded = @pf_amt + @it_amt;
    set @gross_sal = @sal + @hra_amt + @da_amt;
    set @net_sal   = @gross_sal - @total_ded;
    print '=========== PAYSLIP ===========';
    print 'ID        : ' + cast(@id as varchar);
    print 'NAME      : ' + @name;
    print 'SALARY    : ' + cast(@sal as varchar);
    print 'HRA (10%) : ' + cast(@hra_amt as varchar);
    print 'DA  (20%) : ' + cast(@da_amt as varchar);
    print 'PF  (8%)  : ' + cast(@pf_amt as varchar);
    print 'IT  (5%)  : ' + cast(@it_amt as varchar);
    print 'DEDUCTION : ' + cast(@total_ded as varchar);
    print 'GROSS     : ' + cast(@gross_sal as varchar);
    print 'NET       : ' + cast(@net_sal as varchar);
end;

exec usp_generate_payslip 101;

create table holiday_list (
    h_date date,
    h_name varchar(50)
);
insert into holiday_list values 
('2026-01-01','New Year'),
('2026-08-15','Independence Day'),
('2026-10-02','Gandhi Jayanthi'),
('2026-04-29','Diwali');

create or alter trigger trg_no_dml_on_holidays
on employee_master
after insert, update, delete
as
begin
    declare @hname varchar(50);
    select top 1 @hname = h_name
    from holiday_list
    where h_date = convert(date, getdate());
    if @hname is not null
    begin
        raiserror('Due to %s you cannot perform data changes',16,1,@hname);
        rollback transaction;
    end
end;

update employee_master
set emp_name = 'dhivya'
where emp_id = 102;