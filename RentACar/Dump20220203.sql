-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: rent_a_car
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrator` (
  `jmb` varchar(45) NOT NULL,
  `korisnickoIme` varchar(45) NOT NULL,
  `lozinka` varchar(45) NOT NULL,
  `tema` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`jmb`),
  UNIQUE KEY `jmb_UNIQUE` (`jmb`),
  UNIQUE KEY `korisnickoIme_UNIQUE` (`korisnickoIme`),
  UNIQUE KEY `lozinka_UNIQUE` (`lozinka`),
  CONSTRAINT `ajmb` FOREIGN KEY (`jmb`) REFERENCES `osoba` (`jmb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
INSERT INTO `administrator` VALUES ('1111','admin1','123','Zelena');
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `automobil`
--

DROP TABLE IF EXISTS `automobil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `automobil` (
  `idAutomobil` int NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) DEFAULT NULL,
  `kubikaza` int DEFAULT NULL,
  `potrosnja` varchar(45) DEFAULT NULL,
  `gorivo` varchar(45) DEFAULT NULL,
  `transmisija` varchar(45) DEFAULT NULL,
  `godinaProizvodnje` varchar(45) DEFAULT NULL,
  `kapacitetRezervoara` int DEFAULT NULL,
  `konjskihSnaga` int DEFAULT NULL,
  `sjedista` int DEFAULT NULL,
  `cijena` int DEFAULT NULL,
  `zaduzen` tinyint DEFAULT NULL,
  `Administrator_jmb` varchar(45) NOT NULL,
  `putanja_do_slike` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idAutomobil`),
  KEY `fk_Automobil_Administrator1_idx` (`Administrator_jmb`),
  CONSTRAINT `fk_Automobil_Administrator1` FOREIGN KEY (`Administrator_jmb`) REFERENCES `administrator` (`jmb`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `automobil`
--

LOCK TABLES `automobil` WRITE;
/*!40000 ALTER TABLE `automobil` DISABLE KEYS */;
INSERT INTO `automobil` VALUES (3,'auto3',3451,'52l/1000m','benzin','Automatik','2020',60,80,6,120,1,'1111','C:\\Users\\Andrej\\Downloads\\cars.jpg'),(4,'auto4',4567,'30l/1000m','dizel','Automatik','2009',30,67,6,90,0,'1111','C:\\Users\\Andrej\\source\\repos\\RentACar\\RentACar\\car.jpg'),(5,'auto5',4567,'6l/100m','dizel','Manual','2002',65,80,6,100,0,'1111','C:\\Users\\Andrej\\Downloads\\autoo.png');
/*!40000 ALTER TABLE `automobil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iznajmljivac`
--

DROP TABLE IF EXISTS `iznajmljivac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iznajmljivac` (
  `jmb` varchar(45) NOT NULL,
  `adresa` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`jmb`),
  CONSTRAINT `jmb` FOREIGN KEY (`jmb`) REFERENCES `osoba` (`jmb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iznajmljivac`
--

LOCK TABLES `iznajmljivac` WRITE;
/*!40000 ALTER TABLE `iznajmljivac` DISABLE KEYS */;
INSERT INTO `iznajmljivac` VALUES ('11009913009','adresa2'),('1135907','adresa klijenta 1'),('454612222','adresa3');
/*!40000 ALTER TABLE `iznajmljivac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iznajmljivanje`
--

DROP TABLE IF EXISTS `iznajmljivanje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iznajmljivanje` (
  `idIznajmljivanje` int NOT NULL AUTO_INCREMENT,
  `datumZaduzenja` datetime DEFAULT NULL,
  `datumRazduzenja` datetime DEFAULT NULL,
  `Zaposleni_jmb` varchar(45) NOT NULL,
  `Zaposleni_jmb1` varchar(45) NOT NULL,
  `Automobil_idAutomobil1` int NOT NULL,
  `Iznajmljivac_jmb` varchar(45) NOT NULL,
  PRIMARY KEY (`idIznajmljivanje`),
  KEY `fk_table1_Zaposleni1_idx` (`Zaposleni_jmb`),
  KEY `fk_table1_Zaposleni2_idx` (`Zaposleni_jmb1`),
  KEY `fk_table1_Automobil1_idx` (`Automobil_idAutomobil1`),
  KEY `fk_table1_Iznajmljivac1_idx` (`Iznajmljivac_jmb`),
  CONSTRAINT `fk_table1_Automobil1` FOREIGN KEY (`Automobil_idAutomobil1`) REFERENCES `automobil` (`idAutomobil`),
  CONSTRAINT `fk_table1_Iznajmljivac1` FOREIGN KEY (`Iznajmljivac_jmb`) REFERENCES `iznajmljivac` (`jmb`),
  CONSTRAINT `fk_table1_Zaposleni1` FOREIGN KEY (`Zaposleni_jmb`) REFERENCES `zaposleni` (`jmb`),
  CONSTRAINT `fk_table1_Zaposleni2` FOREIGN KEY (`Zaposleni_jmb1`) REFERENCES `zaposleni` (`jmb`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iznajmljivanje`
--

LOCK TABLES `iznajmljivanje` WRITE;
/*!40000 ALTER TABLE `iznajmljivanje` DISABLE KEYS */;
INSERT INTO `iznajmljivanje` VALUES (2,'2022-02-03 16:22:10','2022-02-03 16:22:24','556688','556688',3,'11009913009'),(3,'2022-02-03 16:22:52','0001-01-01 00:00:00','556688','556688',3,'11009913009'),(4,'2022-02-03 19:26:14','2022-02-03 22:43:01','12345678','12345678',4,'11009913009'),(5,'2022-02-03 22:43:46','2022-02-03 22:43:51','12345678','12345678',5,'454612222'),(6,'2022-02-03 22:43:57','2022-02-03 22:44:07','12345678','12345678',5,'1135907');
/*!40000 ALTER TABLE `iznajmljivanje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `osoba`
--

DROP TABLE IF EXISTS `osoba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `osoba` (
  `jmb` varchar(45) NOT NULL,
  `ime` varchar(45) DEFAULT NULL,
  `prezime` varchar(45) DEFAULT NULL,
  `brojTelefona` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`jmb`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `brojTelefona_UNIQUE` (`brojTelefona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `osoba`
--

LOCK TABLES `osoba` WRITE;
/*!40000 ALTER TABLE `osoba` DISABLE KEYS */;
INSERT INTO `osoba` VALUES ('11009913009','Ime3','Prezime3','13031309','emailklijenta2@mail.com'),('1111','ime admina','prezime1','111123','admin@mail.com'),('1135907','klijent 1','prezime klijenta','0987123','klijent1@mial.com'),('12345678','Ime zaposlenog1','Prezime zaposlenog','112789','zaposleni1@mail.com'),('454612222','klijent3','prezimee3','554340000','emailklijenta'),('55661309','zaposleni treci','prezime zap3','009767','zap3@mail.com'),('556688','zaposleni dva','prezime dva','09124','zapo2@mail.com');
/*!40000 ALTER TABLE `osoba` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zaposleni`
--

DROP TABLE IF EXISTS `zaposleni`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zaposleni` (
  `jmb` varchar(45) NOT NULL,
  `korisnickoIme` varchar(45) NOT NULL,
  `lozinka` varchar(45) NOT NULL,
  `tema` varchar(45) DEFAULT 'Standardna',
  `onemogucen` tinyint DEFAULT '0',
  PRIMARY KEY (`jmb`),
  UNIQUE KEY `korisnickoIme_UNIQUE` (`korisnickoIme`),
  UNIQUE KEY `lozinka_UNIQUE` (`lozinka`),
  UNIQUE KEY `jmb_UNIQUE` (`jmb`),
  CONSTRAINT `zjmb` FOREIGN KEY (`jmb`) REFERENCES `osoba` (`jmb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zaposleni`
--

LOCK TABLES `zaposleni` WRITE;
/*!40000 ALTER TABLE `zaposleni` DISABLE KEYS */;
INSERT INTO `zaposleni` VALUES ('12345678','zaposleni1','123','Zelena',0),('55661309','zaposleni3','zaposleni3','Standardna',0),('556688','zaposleni2','zaposleni2','Tamna',1);
/*!40000 ALTER TABLE `zaposleni` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-03 23:06:00
