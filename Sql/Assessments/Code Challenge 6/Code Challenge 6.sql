create database CodeChallenge6;
use CodeChallenge6;
use Assignment2;

select datename(weekday, '2005-03-15') as dayofweek;

select datediff(day, '2005-03-15', getdate()) as ageindays;

select * from emp
where datediff(year, hiredate, getdate()) > 5
and month(hiredate) = month(getdate());

create table employee
(
    empno int primary key,
    ename varchar(30),
    sal decimal(10,2),
    doj date
);

begin transaction;

insert into employee values (1, 'arun', 25000, '2022-01-10');
insert into employee values (2, 'kumar', 30000, '2021-03-15');
insert into employee values (3, 'rahul', 28000, '2020-05-20');

update employee
set sal = sal + (sal * 0.15) where empno = 2;
select * from employee;

delete from employee where empno = 1;
select * from employee;

insert into employee(empno, ename, sal, doj) values (1,'arun',25000,'2022-01-10');

commit transaction;

select * from employee;

create function Calculatebonus
(
    @Deptno int,
    @Salary decimal(10,2)
)
returns decimal(10,2)
as
begin
    declare @Bonus decimal(10,2);
    if @Deptno = 10
        set @Bonus = @Salary * 0.15;
    else if @Deptno = 20
        set @Bonus = @Salary * 0.20;
    else
        set @Bonus = @Salary * 0.05;
    return @Bonus;
end;

select empno, ename, deptno, sal,
    dbo.Calculatebonus(deptno, sal) as Bonus
from emp;

create procedure sp_updatesalessalary
as
begin
    update e
    set e.sal = e.sal + 500
    from emp e
    inner join dept d
        on e.deptno = d.deptno
    where d.dname = 'sales'
    and e.sal < 1500;
end;

exec sp_updatesalessalary;
select * from emp;