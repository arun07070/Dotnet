create database Assessment;
use Assessment;

create table Books (
    id int primary key,
    title varchar(100) not null,
    author varchar(100) not null,
    isbn bigint not null unique,
    published_date datetime not null
);

insert into Books values
(1, 'My First SQL book',  'Mary Parker', 981483029127, '2012-02-22 12:08:17'),
(2, 'My Second SQL book', 'John Mayer', 857300923713, '1972-07-03 09:22:45'),
(3, 'My Third SQL book',  'Cary Flint', 523120967812, '2015-10-18 14:05:44');

create table Reviews (
    id int primary key,
    book_id int,
    reviewer_name varchar(100),
    content varchar(255),
    rating int check (rating between 1 and 5),
    published_date datetime,
    foreign key (book_id) references books(id)
);

insert into Reviews values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10');

create table Customers (
    id int primary key,
    name varchar(50),
    age int,
    address varchar(100),
    salary decimal(10,2)
);

insert into Customers values
(1,'Ramesh',32,'Ahmedabad',2000),
(2,'Khilan',25,'Delhi',1500),
(3,'kaushik',23,'Kota',2000),
(4,'Chaitali',25,'Mumbai',6500),
(5,'Hardik',27,'Bhopal',8500),
(6,'Komal',22,'MP',4500),
(7,'Muffy',24,'Indore',10000);

create table Orders (
    oid int primary key,
    order_date datetime,
    customer_id int,
    amount decimal(10,2),
    foreign key (customer_id) references customers(id)
);

insert into Orders values
(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500),
(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060);

create table Employee (
    id int primary key,
    name varchar(50),
    age int,
    address varchar(100),
    salary decimal(10,2) null
);

insert into Employee values
(1,'Ramesh',32,'Ahmedabad',2000),
(2,'Khilan',25,'Delhi',1500),
(3,'kaushik',23,'Kota',2000),
(4,'Chaitali',25,'Mumbai',6500),
(5,'Hardik',27,'Bhopal',8500),
(6,'Komal',22,'MP',NULL),
(7,'Muffy',24,'Indore',NULL);

create table Studentdetails (
    registerno int primary key,
    name varchar(50),
    age int,
    qualification varchar(50),
    mobileno bigint,
    mail_id varchar(100),
    location varchar(50),
    gender char(1)
);

insert into StudentDetails values
(2,'Sai',22,'B.E',9952836777,'Sai@gmail.com','Chennai','M'),
(3,'Kumar',20,'BSC',7890125648,'Kumar@gmail.com','Madurai','M'),
(4,'Selvi',22,'B.Tech',8904567342,'selvi@gmail.com','Selam','F'),
(5,'Nisha',25,'M.E',7834672310,'Nisha@gmail.com','Theni','F'),
(6,'SaiSaran',21,'B.A',7890345678,'saran@gmail.com','Madurai','F'),
(7,'Tom',23,'BCA',8901234675,'Tom@gmail.com','Pune','M');

select * from Books
where author like '%er';

select b.title, b.author, r.reviewer_name
from Books b
join reviews r
on b.id = r.book_id;

select reviewer_name, count(*) as review_count
from Reviews
group by reviewer_name
having count(*) > 1;

select name from Customers
where address like '%o%';

select order_date, count(distinct customer_id) as total_customers
from Orders
group by order_date;

select lower(name) as employee_name
from Employee
where salary is null;

select gender, count(*) as total_count
from studentdetails
group by gender;