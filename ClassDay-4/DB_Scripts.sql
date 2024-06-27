-- Create Database Jun2024CDAC;
use Jun2024CDAC;
create table Customers
(
	CustomerId int Primary Key,
    ContactName varchar(100),
    City varchar(100)
);
insert into Customers Values(1,'Alisha C.','Mumbai');
insert into Customers Values(2,'John Mark','London');
insert into Customers Values(3,'Maria Andrus','Berlin');

