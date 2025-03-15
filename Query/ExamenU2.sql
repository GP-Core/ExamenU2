Create DataBase AGENDA;
USE AGENDA;

create table USUARIOS(
	ID				INT PRIMARY KEY IDENTITY(1,1) not null,
	APATERNO	    VARCHAR(255) not null,
	AMATERNO	    VARCHAR(255) ,
	NOMBRE		    VARCHAR(255) not null,
	TELEFONO		VARCHAR(15) not null,
	CORREO			VARCHAR(64) not null
)


INSERT INTO USUARIOS VALUES
('Garc�a', 'Mart�nez', 'Miguel', '555-123-4567', 'miguel.garcia@email.com'),
( 'L�pez', 'Hern�ndez', 'Ana', '555-234-5678', 'ana.lopez@email.com'),
( 'Rodr�guez', 'S�nchez', 'Carlos', '555-345-6789', 'carlos.rodriguez@email.com'),
( 'Fern�ndez', 'G�mez', 'Laura', '555-456-7890', 'laura.fernandez@email.com'),
( 'P�rez', 'D�az', 'Jos�', '555-567-8901', 'jose.perez@email.com'),
( 'Gonz�lez', 'Torres', 'Mar�a', '555-678-9012', 'maria.gonzalez@email.com'),
( 'Ram�rez', 'Flores', 'Roberto', '555-789-0123', 'roberto.ramirez@email.com'),
( 'Mart�nez', 'Vargas', 'Sofia', '555-890-1234', 'sofia.martinez@email.com'),
( 'Torres', 'Castro', 'Alejandro', '555-901-2345', 'alejandro.torres@email.com'),
( 'Morales', 'Ruiz', 'Carmen', '555-012-3456', 'carmen.morales@email.com'),
( 'Castro', 'Mendoza', 'Francisco', '555-112-3456', 'francisco.castro@email.com'),
( 'Ortiz', 'Jim�nez', 'Diana', '555-223-4567', 'diana.ortiz@email.com'),
( 'Jim�nez', '�lvarez', 'Ricardo', '555-334-5678', 'ricardo.jimenez@email.com'),
( 'V�zquez', 'Romero', 'Isabel', '555-445-6789', 'isabel.vazquez@email.com'),
( 'Reyes', 'Moreno', 'Daniel', '555-556-7890', 'daniel.reyes@email.com');