-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: cine
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacora` (
  `ID_Bitacora` int NOT NULL AUTO_INCREMENT,
  `FK_ID_Cliente` int NOT NULL,
  `FK_ID_Venta` int NOT NULL,
  `FK_ID_Reservacion` int NOT NULL,
  `Fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID_Bitacora`),
  KEY `FK_ID_Cliente` (`FK_ID_Cliente`),
  KEY `FK_ID_Venta` (`FK_ID_Venta`),
  KEY `FK_ID_Reservacion` (`FK_ID_Reservacion`),
  CONSTRAINT `tbl_bitacora_ibfk_1` FOREIGN KEY (`FK_ID_Cliente`) REFERENCES `tbl_cliente` (`ID_Cliente`),
  CONSTRAINT `tbl_bitacora_ibfk_2` FOREIGN KEY (`FK_ID_Venta`) REFERENCES `tbl_venta` (`ID_Venta`),
  CONSTRAINT `tbl_bitacora_ibfk_3` FOREIGN KEY (`FK_ID_Reservacion`) REFERENCES `tbl_reservacion` (`ID_Reservacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacora`
--

LOCK TABLES `tbl_bitacora` WRITE;
/*!40000 ALTER TABLE `tbl_bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cargo`
--

DROP TABLE IF EXISTS `tbl_cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cargo` (
  `ID_Cargo` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cargo`
--

LOCK TABLES `tbl_cargo` WRITE;
/*!40000 ALTER TABLE `tbl_cargo` DISABLE KEYS */;
INSERT INTO `tbl_cargo` VALUES (1,'Administrador'),(2,'Gerente');
/*!40000 ALTER TABLE `tbl_cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clasificacion`
--

DROP TABLE IF EXISTS `tbl_clasificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_clasificacion` (
  `ID_Clasificacion` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Clasificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_clasificacion`
--

LOCK TABLES `tbl_clasificacion` WRITE;
/*!40000 ALTER TABLE `tbl_clasificacion` DISABLE KEYS */;
INSERT INTO `tbl_clasificacion` VALUES (1,'A'),(2,'PG'),(3,'PG-13'),(4,'R'),(5,'NC-17');
/*!40000 ALTER TABLE `tbl_clasificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cliente` (
  `ID_Cliente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Contrasena` varchar(20) DEFAULT NULL,
  `Telefono` varchar(15) DEFAULT NULL,
  `NIT` varchar(20) DEFAULT NULL,
  `Fecha_Nacimiento` date DEFAULT NULL,
  `Estado_tbl_cliente` varchar(20) DEFAULT 'Activo',
  PRIMARY KEY (`ID_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,'Victor','Castellanes','vic@gmail.com','123','1478596','1478859','2000-02-25','Activo');
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_empleado`
--

DROP TABLE IF EXISTS `tbl_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_empleado` (
  `ID_Empleado` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `FK_ID_Cargo` int DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telefono` varchar(15) DEFAULT NULL,
  `Estado_tbl_empleado` varchar(20) DEFAULT NULL,
  `Contrasena` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_Empleado`),
  KEY `FK_ID_Cargo` (`FK_ID_Cargo`),
  CONSTRAINT `tbl_empleado_ibfk_1` FOREIGN KEY (`FK_ID_Cargo`) REFERENCES `tbl_cargo` (`ID_Cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_empleado`
--

LOCK TABLES `tbl_empleado` WRITE;
/*!40000 ALTER TABLE `tbl_empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pelicula`
--

DROP TABLE IF EXISTS `tbl_pelicula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pelicula` (
  `ID_Pelicula` int NOT NULL AUTO_INCREMENT,
  `Titulo` varchar(100) NOT NULL,
  `Genero` varchar(50) NOT NULL,
  `Duracion` int NOT NULL,
  `FK_ID_Clasificacion` int DEFAULT NULL,
  `Imagen` blob,
  `Sinopsis` text,
  `FK_ID_Proveedor` int DEFAULT NULL,
  `Estado_tbl_pelicula` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Pelicula`),
  KEY `FK_ID_Clasificacion` (`FK_ID_Clasificacion`),
  KEY `FK_ID_Proveedor` (`FK_ID_Proveedor`),
  CONSTRAINT `tbl_pelicula_ibfk_1` FOREIGN KEY (`FK_ID_Clasificacion`) REFERENCES `tbl_clasificacion` (`ID_Clasificacion`),
  CONSTRAINT `tbl_pelicula_ibfk_2` FOREIGN KEY (`FK_ID_Proveedor`) REFERENCES `tbl_proveedor_pelicula` (`ID_Proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pelicula`
--

LOCK TABLES `tbl_pelicula` WRITE;
/*!40000 ALTER TABLE `tbl_pelicula` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pelicula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proveedor_pelicula`
--

DROP TABLE IF EXISTS `tbl_proveedor_pelicula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proveedor_pelicula` (
  `ID_Proveedor` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedor_pelicula`
--

LOCK TABLES `tbl_proveedor_pelicula` WRITE;
/*!40000 ALTER TABLE `tbl_proveedor_pelicula` DISABLE KEYS */;
INSERT INTO `tbl_proveedor_pelicula` VALUES (1,'Warner Bros. Pictures'),(2,'Walt Disney Pictures'),(3,'Universal Pictures'),(4,'Paramount Pictures');
/*!40000 ALTER TABLE `tbl_proveedor_pelicula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proyeccion`
--

DROP TABLE IF EXISTS `tbl_proyeccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proyeccion` (
  `ID_Proyeccion` int NOT NULL AUTO_INCREMENT,
  `FK_ID_Pelicula` int DEFAULT NULL,
  `FK_ID_Sala` int DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Estado_tbl_proyeccion` varchar(20) DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  PRIMARY KEY (`ID_Proyeccion`),
  KEY `FK_ID_Pelicula` (`FK_ID_Pelicula`),
  KEY `FK_ID_Sala` (`FK_ID_Sala`),
  CONSTRAINT `tbl_proyeccion_ibfk_1` FOREIGN KEY (`FK_ID_Pelicula`) REFERENCES `tbl_pelicula` (`ID_Pelicula`),
  CONSTRAINT `tbl_proyeccion_ibfk_2` FOREIGN KEY (`FK_ID_Sala`) REFERENCES `tbl_sala` (`ID_Sala`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proyeccion`
--

LOCK TABLES `tbl_proyeccion` WRITE;
/*!40000 ALTER TABLE `tbl_proyeccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proyeccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reservacion`
--

DROP TABLE IF EXISTS `tbl_reservacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_reservacion` (
  `ID_Reservacion` int NOT NULL AUTO_INCREMENT,
  `FK_ID_Proyeccion` int DEFAULT NULL,
  `FK_ID_Cliente` int DEFAULT NULL,
  `FK_ID_Venta` int DEFAULT NULL,
  `Butaca` varchar(10) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `Descuento` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID_Reservacion`),
  KEY `FK_ID_Proyeccion` (`FK_ID_Proyeccion`),
  KEY `FK_ID_Cliente` (`FK_ID_Cliente`),
  KEY `FK_ID_Venta` (`FK_ID_Venta`),
  CONSTRAINT `tbl_reservacion_ibfk_1` FOREIGN KEY (`FK_ID_Proyeccion`) REFERENCES `tbl_proyeccion` (`ID_Proyeccion`),
  CONSTRAINT `tbl_reservacion_ibfk_2` FOREIGN KEY (`FK_ID_Cliente`) REFERENCES `tbl_cliente` (`ID_Cliente`),
  CONSTRAINT `tbl_reservacion_ibfk_3` FOREIGN KEY (`FK_ID_Venta`) REFERENCES `tbl_venta` (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reservacion`
--

LOCK TABLES `tbl_reservacion` WRITE;
/*!40000 ALTER TABLE `tbl_reservacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reservacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_sala`
--

DROP TABLE IF EXISTS `tbl_sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_sala` (
  `ID_Sala` int NOT NULL AUTO_INCREMENT,
  `Numero_Sala` int NOT NULL,
  `Capacidad` int NOT NULL,
  `FK_ID_Tipo_Sala` int DEFAULT NULL,
  `FK_ID_Ubicacion` int DEFAULT NULL,
  `Estado_tbl_sala` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Sala`),
  KEY `FK_ID_Ubicacion` (`FK_ID_Ubicacion`),
  KEY `FK_ID_Tipo_Sala` (`FK_ID_Tipo_Sala`),
  CONSTRAINT `tbl_sala_ibfk_1` FOREIGN KEY (`FK_ID_Ubicacion`) REFERENCES `tbl_ubicacion` (`ID_Ubicacion`),
  CONSTRAINT `tbl_sala_ibfk_2` FOREIGN KEY (`FK_ID_Tipo_Sala`) REFERENCES `tbl_tipo_sala` (`ID_Tipo_Sala`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_sala`
--

LOCK TABLES `tbl_sala` WRITE;
/*!40000 ALTER TABLE `tbl_sala` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tarjeta`
--

DROP TABLE IF EXISTS `tbl_tarjeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tarjeta` (
  `ID_Tarjeta` int NOT NULL AUTO_INCREMENT,
  `FK_ID_Cliente` int DEFAULT NULL,
  `Numero_Tarjeta` varchar(16) NOT NULL,
  `Fecha_Expiracion` date NOT NULL,
  `CVV` int NOT NULL,
  `Nombre_Titular` varchar(50) NOT NULL,
  `Tipo_Tarjeta` varchar(20) DEFAULT NULL,
  `Estado_tbl_tarjeta` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Tarjeta`),
  KEY `FK_ID_Cliente` (`FK_ID_Cliente`),
  CONSTRAINT `tbl_tarjeta_ibfk_1` FOREIGN KEY (`FK_ID_Cliente`) REFERENCES `tbl_cliente` (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tarjeta`
--

LOCK TABLES `tbl_tarjeta` WRITE;
/*!40000 ALTER TABLE `tbl_tarjeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tarjeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_sala`
--

DROP TABLE IF EXISTS `tbl_tipo_sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_sala` (
  `ID_Tipo_Sala` int NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Tipo_Sala`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_sala`
--

LOCK TABLES `tbl_tipo_sala` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_sala` DISABLE KEYS */;
INSERT INTO `tbl_tipo_sala` VALUES (1,'MACRO XE'),(2,'IMAX'),(3,'4DX'),(4,'VIP');
/*!40000 ALTER TABLE `tbl_tipo_sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ubicacion`
--

DROP TABLE IF EXISTS `tbl_ubicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ubicacion` (
  `ID_Ubicacion` int NOT NULL AUTO_INCREMENT,
  `Ciudad` varchar(100) NOT NULL,
  `Direccion` varchar(200) NOT NULL,
  PRIMARY KEY (`ID_Ubicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ubicacion`
--

LOCK TABLES `tbl_ubicacion` WRITE;
/*!40000 ALTER TABLE `tbl_ubicacion` DISABLE KEYS */;
INSERT INTO `tbl_ubicacion` VALUES (1,'Guatemala','CineHub Miraflores'),(2,'Guatemala','CineHub RussMall'),(4,'Guatemala','CineHub Pradera z10'),(7,'Mixco','CineHub SanKris Mall'),(8,'Villa Nueva','CineHub Plaza Villa Nueva'),(10,'Guatemala','CineHub Oakland Mall');
/*!40000 ALTER TABLE `tbl_ubicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_venta`
--

DROP TABLE IF EXISTS `tbl_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_venta` (
  `ID_Venta` int NOT NULL AUTO_INCREMENT,
  `FK_ID_Empleado` int DEFAULT NULL,
  `Fecha_Hora` datetime NOT NULL,
  `Metodo_Pago` varchar(20) NOT NULL,
  `Monto_Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID_Venta`),
  KEY `FK_ID_Empleado` (`FK_ID_Empleado`),
  CONSTRAINT `tbl_venta_ibfk_1` FOREIGN KEY (`FK_ID_Empleado`) REFERENCES `tbl_empleado` (`ID_Empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_venta`
--

LOCK TABLES `tbl_venta` WRITE;
/*!40000 ALTER TABLE `tbl_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_venta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-07-26 22:57:41
