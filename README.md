# DCU_FinalProject
Proyecto final de la asignatura de Diseño Centrado en el Usuario, desarrollado con el lenguaje de programación C# y la base de datos relacional SQL Server.
# Anexos del Poyecto
1. Ventana de Inicio o Home.
![image](https://user-images.githubusercontent.com/81063587/164950370-3058d5a9-b9b6-41a4-abe9-72ed89a62e1f.png)
2. Ventana de Creación de Usuario.                                                                                                                                                                                                                                                                              
![image](https://user-images.githubusercontent.com/81063587/164950326-04cb5577-9818-481f-bc8e-f6c8d05184ed.png)
3. Ventana de Buscar Usuario.                                                                                                                                              
![image](https://user-images.githubusercontent.com/81063587/164955782-cc1a9897-decb-4ffc-b423-926ba0a71bb1.png)

4. Ventana de Actualizar Usuario.

![image](https://user-images.githubusercontent.com/81063587/164955792-67d7e459-38cf-480f-a030-97c41a959617.png)

5. Ventana de Eliminar Usuario.

![image](https://user-images.githubusercontent.com/81063587/164955822-4962d44d-4f97-43a4-b731-36a419db7dcc.png)

# Creación de la DB y tablas para el proyecto de Security World

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

