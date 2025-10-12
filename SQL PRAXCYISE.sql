CREATE DATABASE Customers;
use Customers;
CREATE TABLE Customer(customer_id INT auto_increment PRIMARY KEY,
full_name varchar(255),email varchar(255) UNIQUE,city varchar(255),phone int);
INSERT INTO Customer(full_name,email,city,phone) VALUES ('Aiman Nisar','aimanmemon417@gmail.com','Karachi',03323),
('Areeba Zulfiqar','areeba78@gmail.com','Karachi',0233),
('Laiba Jabbae','laibajabbar102@gmail.com','Hyderabad',0332),
('Wajeeha Siddiqui','wajeeha32@gmail.com','Lahore',02224),
('Fatima Shaikh','fatimaa77@gmail.com','Karachi',07765);
CREATE TABLE Orders(order_id INT auto_increment PRIMARY KEY,customer_id int,order_date DATE,amount numeric(10,2),
foreign key(customer_id)  references Customer(customer_id));
select * from Customer;
INSERT INTO Orders(customer_id,order_date,amount) VALUES (6,'2025-09-17',1600.00),
(9,'2025-09-18',2999.99),
(7,'2025-09-18',566.99),
(8,'2025-09-18',1002.99),
(9,'2025-09-18',1999.99);
#QUERINH
select distinct city from Customer; #UNQIYUE CITIES IN THE DATABASES
select count(o.order_id) as "Orders",c.full_name from Orders o inner join Customer c on o.customer_id=c.customer_id
group by c.full_name order by count(o.order_id) DESC; #COUNTUBG ORDERS IF CYS
#FINDING DUPLICATES
select city,Count(*) from Customer group by city having Count(*) >1;
create table Users(u_id int auto_increment PRIMARY KEY,U_name varchar(255),u_email varchar(255));
INSERT INTO Users(U_name,u_email) 
VALUES('Burhan Arshad','burhantheschoolboy@gmail.com'),
('Zara Shaikh','zarashaikh@gmail.com'),
('Aleena Ammar','ammaraleena78@gmail.com'),
('Muhammad Burhan','burhantheschoolboy@gmail.com');

#FINDING DUPLICATES EMAILS
select u_email,COUNT(*) FROM Users group by u_email having COUNT(*) >1;

#REMOVING DUPLICATES
select * from Customer where customer_id not in (select customer_id from Orders);
CREATE TABLE employees(employee_id INT auto_increment PRIMARY KEY,employee_name VARCHAR(255),Gender varchar(255),salary numeric(19,3));
INSERT INTO employees(employee_name,Gender,salary) VALUES
('Mujtuba     Hashmi','Male',19900),
('Alishba Khan','Female',50000),
('Ambreen Shaikh','Female',80000);
SELECT *,trim(employee_name)   from employees;
select * from employees;
UPDATE employees SET employee_name=trim(employee_name) ;
SET SQL_SAFE_UPDATES = 0;
UPDATE employees SET Gender='M' where Gender='Male';
UPDATE employees SET Gender='F' where Gender='Female';

UPDATE employees set salary=30000 where salary is NULL;
#CREATING VIEW
CREATE VIEW Customer_Detailsss as select c.full_name as "Customer Name",c.email as "Customer Email",c.city,o.order_date,o.amount
from Customer c inner join Orders o on c.customer_id=o.customer_id;
