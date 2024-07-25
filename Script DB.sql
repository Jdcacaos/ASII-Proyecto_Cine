CREATE DATABASE Cine;
USE Cine;

CREATE TABLE tbl_ubicacion (
    ID_Ubicacion INT AUTO_INCREMENT PRIMARY KEY,
    Ciudad VARCHAR(100) NOT NULL,
    Direccion VARCHAR(200) NOT NULL
);

CREATE TABLE tbl_clasificacion (
	ID_Clasificacion INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(20)
);

CREATE TABLE tbl_proveedor_pelicula (
	ID_Proveedor INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50)
);

CREATE TABLE tbl_pelicula (
    ID_Pelicula INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(100) NOT NULL,
    Genero VARCHAR(50) NOT NULL,
    Duracion INT NOT NULL,
    FK_ID_Clasificacion INT,
    Imagen VARCHAR(100),
    Sinopsis TEXT,
    FK_ID_Proveedor INT,
    Estado_tbl_pelicula VARCHAR(20),
    FOREIGN KEY (FK_ID_Clasificacion) REFERENCES tbl_clasificacion(ID_Clasificacion),
    FOREIGN KEY (FK_ID_Proveedor) REFERENCES tbl_proveedor_pelicula(ID_Proveedor)
);

CREATE TABLE tbl_tipo_sala(
	ID_Tipo_Sala INT AUTO_INCREMENT PRIMARY KEY,
    Tipo VARCHAR(50)
);

CREATE TABLE tbl_sala (
    ID_Sala INT AUTO_INCREMENT PRIMARY KEY,
    Numero_Sala INT NOT NULL,
    Capacidad INT NOT NULL,
    FK_ID_Tipo_Sala INT,
    FK_ID_Ubicacion INT,
    FOREIGN KEY (FK_ID_Ubicacion) REFERENCES tbl_ubicacion(ID_Ubicacion),
    FOREIGN KEY (FK_ID_Tipo_Sala) REFERENCES tbl_tipo_sala(ID_Tipo_Sala),
	Estado_tbl_sala VARCHAR(20)
);

CREATE TABLE tbl_proyeccion (
    ID_Proyeccion INT AUTO_INCREMENT PRIMARY KEY,
    FK_ID_Pelicula INT,
    FK_ID_Sala INT,
    Fecha_Hora DATETIME NOT NULL,
    Estado_tbl_cliente VARCHAR(20),
    FOREIGN KEY (FK_ID_Pelicula) REFERENCES tbl_pelicula(ID_Pelicula),
    FOREIGN KEY (FK_ID_Sala) REFERENCES tbl_sala(ID_Sala)
);

CREATE TABLE tbl_cliente (
    ID_Cliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Contrasena VARCHAR(20),
    Telefono VARCHAR(15),
    NIT VARCHAR(20),
    Fecha_Nacimiento DATE,
    Estado_tbl_cliente VARCHAR(20)
);

CREATE TABLE tbl_tarjeta (
    ID_Tarjeta INT AUTO_INCREMENT PRIMARY KEY,
    FK_ID_Cliente INT,
    Numero_Tarjeta VARCHAR(16) NOT NULL,
    Fecha_Expiracion DATE NOT NULL,
    CVV INT NOT NULL,
    Nombre_Titular VARCHAR(50) NOT NULL,
    Tipo_Tarjeta VARCHAR(20), -- Por ejemplo: Visa, MasterCard, etc.
    Estado_tbl_tarjeta VARCHAR(20),
    FOREIGN KEY (FK_ID_Cliente) REFERENCES tbl_cliente(ID_Cliente)
);

CREATE TABLE tbl_cargo (
	ID_Cargo INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(20)
);

CREATE TABLE tbl_empleado (
    ID_Empleado INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FK_ID_Cargo INT,
    Email VARCHAR(100),
    Telefono VARCHAR(15),
    Estado_tbl_empleado VARCHAR(20),
    FOREIGN KEY (FK_ID_Cargo) REFERENCES tbl_cargo(ID_Cargo)
);

CREATE TABLE tbl_venta (
    ID_Venta INT AUTO_INCREMENT PRIMARY KEY,
    FK_ID_Empleado INT,
    Fecha_Hora datetime NOT NULL,
    Metodo_Pago VARCHAR(20) NOT NULL,
    Monto_Total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (FK_ID_Empleado) REFERENCES tbl_empleado(ID_Empleado)
);

CREATE TABLE tbl_reservacion (
    ID_Reservacion INT AUTO_INCREMENT PRIMARY KEY,
    FK_ID_Proyeccion INT,
    FK_ID_Cliente INT,
    FK_ID_Venta INT,
    Butaca VARCHAR(10) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Descuento DECIMAL(10, 2),
    FOREIGN KEY (FK_ID_Proyeccion) REFERENCES tbl_proyeccion(ID_Proyeccion),
    FOREIGN KEY (FK_ID_Cliente) REFERENCES tbl_cliente(ID_Cliente),
    FOREIGN KEY (FK_ID_Venta) REFERENCES tbl_venta(ID_Venta)
);

CREATE TABLE tbl_bitacora (
    ID_Bitacora INT AUTO_INCREMENT PRIMARY KEY,
    FK_ID_Cliente INT NOT NULL,
    FK_ID_Venta INT NOT NULL,
    FK_ID_Reservacion INT NOT NULL,
    Fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (FK_ID_Cliente) REFERENCES tbl_cliente(ID_Cliente),
    FOREIGN KEY (FK_ID_Venta) REFERENCES tbl_venta(ID_Venta),
    FOREIGN KEY (FK_ID_Reservacion) REFERENCES tbl_reservacion(ID_Reservacion)
);

select * from tbl_cliente;
ALTER TABLE tbl_cliente
MODIFY COLUMN Estado_tbl_cliente VARCHAR(20) DEFAULT 'Activo';

ALTER TABLE tbl_empleado
ADD COLUMN Contrasena VARCHAR(255) NOT NULL;

DROP DATABASE Cine;
