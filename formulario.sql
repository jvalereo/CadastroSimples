use master

go

IF EXISTS(SELECT name FROM master.dbo.sysdatabases
where name='formulario')
DROP DATABASE formulario

CREATE DATABASE formulario

go
use formulario
go

CREATE	table usuario(

id_usar int identity(1,1) primary key not null,
nome varchar(30) not null,
sobrenome varchar(30) not null,
celular varchar(30) not null

)

select * from usuario

delete usuario
