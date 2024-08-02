-- Modifiacion tbl_proyeccion
use cine;

ALTER TABLE `tbl_proyeccion`
ADD COLUMN `Precio_Nino` decimal(10,2) NOT NULL,
ADD COLUMN `Precio_Adulto` decimal(10,2) NOT NULL,
ADD COLUMN `Precio_3ra_Edad` decimal(10,2) NOT NULL;