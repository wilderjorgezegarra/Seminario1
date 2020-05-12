create database CursoMVC
go
Use CursoMVC
go

CREATE TABLE empleados(
	codEmp int primary key IDENTITY(1,1) ,
	nomEmp varchar(50) ,
	edadEmp int ,
	sexoEmp char(1) ,
	sueldoEmp money ,
)
select * from empleados
insert into empleados values('Andrea Mendoza',32,'F',2500.00)

CREATE TABLE Asignatura(
	codAsi int primary key IDENTITY(1,1) ,
	nomAsi varchar(50) ,
	)
insert into asignatura values('Seminario I')
insert into asignatura values('PPP I')
insert into asignatura values('Investigacion I')
select * from asignatura 
delete from Asignatura where nomAsi='Investigacion II'