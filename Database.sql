create database Hospital;
use Hospital;
create table medicine(
code int primary key,
name varchar(30) not null,
price numeric(5,2) not null,
);

create table Department(
Dep# int primary key,
name varchar(30) not null,
);

create table Doctors(
D# int primary key,
name varchar(30) not null,
speciality varchar(30) not null,
departmenrt_num int,
Salary int not null,
constraint DepartmentDoctorsFK  foreign key (departmenrt_num)
references  Department(Dep#)
);

create table lab(
L# int primary key,
name varchar(30) not null,
type varchar (30) not null,
cost numeric(5,2)not null,
doc_num int,
constraint DoctorsLabFK  foreign key (doc_num)
references  Doctors(D#)
);

create table Rooms(
R# int primary key,
number_of_beds int not null,
cost numeric not null,
Dep_num int,
constraint DepartmentRoomsFk foreign key (Dep_num)
references Department(Dep#)
);

create table patient(
Pat# int primary key,
name varchar(30) not null,
address varchar(50)not null,
discharge_date date not null,
admit_date date not null,
room_num int,
Phone varchar(12) not null,
constraint patientRoomFK  foreign key (room_num)
references Rooms(R#)
);

create table supervise(
D# int not null,
pat# int not null,
constraint DoctorsSuperviseFK foreign key(D#)references Doctors(D#), 
constraint PatientSuperviseFK foreign key(pat#)references patient(pat#)
);