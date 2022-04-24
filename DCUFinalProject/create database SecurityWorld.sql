create database SecurityWorld

use SecurityWorld

create table Usuario(
id int identity (1,1) not null,
nombre varchar(20) not null,
apellido varchar(40) not null,
correo varchar(100) not null,
telefono varchar(11) not null
)

insert into Usuario (nombre, apellido, correo, telefono) values ('Wagner', 'Suarez Suarez', 'wagner2195@hotmail.com', '8293800416')

select * from Usuario