use cine;

#tbl clasificacion

INSERT INTO tbl_clasificacion (Nombre) VALUES ('A');
INSERT INTO tbl_clasificacion (Nombre) VALUES ('PG');
INSERT INTO tbl_clasificacion(Nombre) VALUES ('PG-13');
INSERT INTO tbl_clasificacion (Nombre) VALUES ('R');
INSERT INTO tbl_clasificacion (Nombre) VALUES ('NC-17');

select * from tbl_clasificacion;


#tbl proveedores pelicula

INSERT INTO tbl_proveedor_pelicula (Nombre) VALUES ('Warner Bros. Pictures');
INSERT INTO tbl_proveedor_pelicula (Nombre) VALUES ('Walt Disney Pictures');
INSERT INTO tbl_proveedor_pelicula (Nombre) VALUES ('Universal Pictures');
INSERT INTO tbl_proveedor_pelicula (Nombre) VALUES ('Paramount Pictures');

select * from tbl_proveedor_pelicula;

#tbl tipo sala
INSERT INTO tbl_tipo_sala (Tipo) VALUES ('MACRO XE');
INSERT INTO tbl_tipo_sala (Tipo) VALUES ('IMAX');
INSERT INTO tbl_tipo_sala (Tipo) VALUES ('4DX');
INSERT INTO tbl_tipo_sala (Tipo) VALUES ('VIP');

select * from tbl_tipo_Sala;



#tbl cargo
INSERT INTO tbl_cargo (Nombre) VALUES ('Administrador');
INSERT INTO tbl_cargo (Nombre) VALUES ('Gerente');

select * from tbl_sala;
INSERT INTO tbl_cargo (Nombre) VALUES ('Gerente');



select * from tbl_cargo;

#tbl ubicacion

INSERT INTO tbl_ubicacion (Ciudad,Direccion) VALUES ('Guatemala','CineHub Miraflores');
INSERT INTO tbl_ubicacion (Ciudad,Direccion) VALUES ('Guatemala','CineHub Oakland Mall');
INSERT INTO tbl_ubicacion (Ciudad,Direccion) VALUES ('Mixco','CineHtbl_proyeccionub SanKris Mall');
INSERT INTO tbl_ubicacion (Ciudad,Direccion) VALUES ('Villa Nueva','CineHub Plaza Villa Nueva');

select * from tbl_ubicacion;
select * from tbl_sala;
select * from tbl_tipo_sala;

INSERT INTO tbl_sala (ID_Sala,Numero_Sala, Capacidad, FK_ID_Tipo_Sala,FK_ID_Ubicacion, Estado_tbl_sala) VALUES ('1','1','50','1','1','Activo');
INSERT INTO tbl_sala (ID_Sala,Numero_Sala, Capacidad, FK_ID_Tipo_Sala,FK_ID_Ubicacion, Estado_tbl_sala) VALUES ('2','2','50','2','2','Activo');

SELECT ID_tipo_sala, Tipo FROM tbl_tipo_sala;


SELECT * FROM tbl_ubicacion;

USE CINE; 
select * from tbl_pelicula;

ALTER TABLE tbl_pelicula 
MODIFY COLUMN Imagen blob;

select * from tbl_proyeccion;

select * from tbl_sala;
select * from tbl_pelicula;
select ID_Pelicula , Titulo from tbl_pelicula;

ALTER TABLE tbl_proyeccion CHANGE Estado_tbl_cliente `Estado_tbl_proyeccion` VARCHAR(20);

#Peliculas
INSERT INTO tbl_pelicula (Titulo, Genero, Duracion, FK_ID_Clasificacion, Imagen, Sinopsis, FK_ID_Proveedor, Estado_tbl_pelicula) 
VALUES ('Inception', 'Ciencia Ficción', 148, 1, 'inception.jpg', 'Un ladrón que roba secretos corporativos a través del uso de la tecnología de sueños compartidos es dado la tarea inversa de plantar una idea en la mente de un CEO.', 1, 'Activo');

INSERT INTO tbl_pelicula (Titulo, Genero, Duracion, FK_ID_Clasificacion, Imagen, Sinopsis, FK_ID_Proveedor, Estado_tbl_pelicula) 
VALUES ('The Godfather', 'Crimen', 175, 2, 'godfather.jpg', 'La historia de la familia mafiosa Corleone bajo el patriarca Vito Corleone, enfocándose en la transformación de su hijo Michael de un forastero reacio a un despiadado jefe de la mafia.', 2, 'Activo');

INSERT INTO tbl_pelicula (Titulo, Genero, Duracion, FK_ID_Clasificacion, Imagen, Sinopsis, FK_ID_Proveedor, Estado_tbl_pelicula) 
VALUES ('The Dark Knight', 'Acción', 152, 3, 'dark_knight.jpg', 'Cuando el Joker emerge de su misterioso pasado, siembra el caos en Gotham. El Caballero Oscuro debe aceptar uno de los mayores retos psicológicos y físicos para luchar contra la injusticia.', 1, 'Activo');

INSERT INTO tbl_pelicula (Titulo, Genero, Duracion, FK_ID_Clasificacion, Imagen, Sinopsis, FK_ID_Proveedor, Estado_tbl_pelicula) 
VALUES ('Pulp Fiction', 'Crimen', 154, 4, 'pulp_fiction.jpg', 'Las vidas de dos sicarios de la mafia, un boxeador, la esposa de un gánster y dos bandidos se entrelazan en cuatro cuentos de violencia y redención.', 3, 'Activo');


#Cambios tabla proyeccion 
ALTER TABLE tbl_proyeccion 
CHANGE COLUMN Fecha_Hora Fecha DATE,
ADD COLUMN Hora TIME;


SELECT ID_tipo_sala, Tipo FROM tbl_tipo_sala;

#Insert tbl proyeccion
INSERT INTO tbl_proyeccion (FK_ID_Pelicula, FK_ID_Sala, Fecha, Estado_tbl_proyeccion, Hora) 
VALUES (1, 1, '2024-07-26', 'Activo', '18:30:00');

INSERT INTO tbl_proyeccion (FK_ID_Pelicula, FK_ID_Sala, Fecha, Estado_tbl_proyeccion, Hora) 
VALUES (2, 2, '2024-07-27', 'Activo', '20:00:00');

SELECT * FROM cine.tbl_proyeccion;

SELECT ID_Pelicula , Titulo FROM tbl_pelicula;


ALTER TABLE tbl_pelicula MODIFY COLUMN Imagen BLOB;



