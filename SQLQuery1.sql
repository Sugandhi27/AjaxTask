use task

create table dbCountry
(
cid int not null identity(1,1) primary key,
cname varchar(100)
);

create table dbState
(
sid int not null identity(1,1) primary key,
sname varchar(100),
cid int
);

create table dbCity
(
cityid int not null identity(1,1) primary key,
cityname varchar(100),
sid int
);

select * from dbCity
select * from dbState

