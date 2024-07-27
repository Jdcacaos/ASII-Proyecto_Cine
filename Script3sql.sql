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
INSERT INTO tbl_ubicacion (Ciudad,Direccion) VALUES ('Mixco','CineHub SanKris Mall');
INSERT INTO tbl_ubicacion (Ciudad,Direccion) VALUES ('Villa Nueva','CineHub Plaza Villa Nueva');

select * from tbl_ubicacion;
select * from tbl_sala;
select * from tbl_tipo_sala;

INSERT INTO tbl_sala (ID_Sala,Numero_Sala, Capacidad, FK_ID_Tipo_Sala,FK_ID_Ubicacion, Estado_tbl_sala) VALUES ('1','1','50','1','1','Activo');
INSERT INTO tbl_sala (ID_Sala,Numero_Sala, Capacidad, FK_ID_Tipo_Sala,FK_ID_Ubicacion, Estado_tbl_sala) VALUES ('2','2','50','2','2','Activo');

SELECT ID_tipo_sala, Tipo FROM tbl_tipo_sala;

