-- MariaDB dump 10.19  Distrib 10.11.6-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: Fulbank
-- ------------------------------------------------------
-- Server version	10.11.6-MariaDB-0+deb12u1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Account`
--

DROP TABLE IF EXISTS `Account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Account` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `balance` decimal(16,6) NOT NULL,
  `idHolder` int(11) NOT NULL,
  `idCurrency` int(11) NOT NULL,
  `idType` int(11) NOT NULL,
  `idSubstitute` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idHolder` (`idHolder`),
  KEY `idCurrency` (`idCurrency`),
  KEY `idType` (`idType`),
  KEY `idSubstitute` (`idSubstitute`),
  CONSTRAINT `Account_ibfk_1` FOREIGN KEY (`idHolder`) REFERENCES `Users` (`id`),
  CONSTRAINT `Account_ibfk_2` FOREIGN KEY (`idCurrency`) REFERENCES `currencyTypes` (`id`),
  CONSTRAINT `Account_ibfk_3` FOREIGN KEY (`idType`) REFERENCES `Type` (`id`),
  CONSTRAINT `Account_ibfk_4` FOREIGN KEY (`idSubstitute`) REFERENCES `Users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Account`
--

LOCK TABLES `Account` WRITE;
/*!40000 ALTER TABLE `Account` DISABLE KEYS */;
INSERT INTO `Account` VALUES
(1,79.000000,1,1,1,NULL),
(2,0.000108,1,3,1,NULL),
(3,0.000000,7,1,1,NULL),
(4,0.000000,7,3,1,NULL),
(5,0.000000,7,4,1,NULL),
(6,0.000000,8,1,1,NULL),
(7,0.000000,8,3,1,NULL),
(8,0.000000,8,4,1,NULL),
(9,0.000000,9,1,1,NULL),
(10,0.000000,9,3,1,NULL),
(11,0.000000,9,4,1,NULL);
/*!40000 ALTER TABLE `Account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Actions`
--

DROP TABLE IF EXISTS `Actions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Actions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `description` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Actions`
--

LOCK TABLES `Actions` WRITE;
/*!40000 ALTER TABLE `Actions` DISABLE KEYS */;
INSERT INTO `Actions` VALUES
(1,'withdrawal','withdrawal money from ATM'),
(2,'deposit','Deposit money for an ATM'),
(3,'transfer','Account1 transfer to Account2');
/*!40000 ALTER TABLE `Actions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Operation`
--

DROP TABLE IF EXISTS `Operation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Operation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `account1` int(11) NOT NULL,
  `account2` int(11) DEFAULT NULL,
  `amount1` decimal(7,6) NOT NULL,
  `amount2` decimal(7,6) DEFAULT NULL,
  `exchangeRate` decimal(16,8) NOT NULL,
  `idAction` int(11) NOT NULL,
  `_date` datetime NOT NULL,
  `idUser` int(11) NOT NULL,
  `idTerminal` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `account1` (`account1`),
  KEY `account2` (`account2`),
  KEY `idAction` (`idAction`),
  KEY `idUser` (`idUser`),
  KEY `idTerminal` (`idTerminal`),
  CONSTRAINT `Operation_ibfk_1` FOREIGN KEY (`account1`) REFERENCES `Account` (`id`),
  CONSTRAINT `Operation_ibfk_2` FOREIGN KEY (`account2`) REFERENCES `Account` (`id`),
  CONSTRAINT `Operation_ibfk_3` FOREIGN KEY (`idAction`) REFERENCES `Actions` (`id`),
  CONSTRAINT `Operation_ibfk_4` FOREIGN KEY (`idUser`) REFERENCES `Users` (`id`),
  CONSTRAINT `Operation_ibfk_5` FOREIGN KEY (`idTerminal`) REFERENCES `Terminals` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Operation`
--

LOCK TABLES `Operation` WRITE;
/*!40000 ALTER TABLE `Operation` DISABLE KEYS */;
INSERT INTO `Operation` VALUES
(1,1,NULL,0.000000,NULL,1.00000000,3,'2024-12-18 14:35:19',1,1),
(2,1,NULL,1.000000,NULL,1.00000000,3,'2024-12-18 14:37:34',1,1);
/*!40000 ALTER TABLE `Operation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Terminals`
--

DROP TABLE IF EXISTS `Terminals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Terminals` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `location` varchar(255) DEFAULT NULL,
  `Balance` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Terminals`
--

LOCK TABLES `Terminals` WRITE;
/*!40000 ALTER TABLE `Terminals` DISABLE KEYS */;
INSERT INTO `Terminals` VALUES
(1,'Lycée Fulbert, Chartres',500);
/*!40000 ALTER TABLE `Terminals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Type`
--

DROP TABLE IF EXISTS `Type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `rate` decimal(16,6) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Type`
--

LOCK TABLES `Type` WRITE;
/*!40000 ALTER TABLE `Type` DISABLE KEYS */;
INSERT INTO `Type` VALUES
(1,'compte courant',0.000000);
/*!40000 ALTER TABLE `Type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES
(1,'Kaneko','a5'),
(2,'Noa','Enculer'),
(3,'un user','P@ssw0rd'),
(4,'test','oui'),
(5,'test2','oui'),
(6,'test3','oui'),
(7,'test4','oui'),
(8,'test5','oui'),
(9,'test6','oui');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `currencyTypes`
--

DROP TABLE IF EXISTS `currencyTypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `currencyTypes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `currencyTypes`
--

LOCK TABLES `currencyTypes` WRITE;
/*!40000 ALTER TABLE `currencyTypes` DISABLE KEYS */;
INSERT INTO `currencyTypes` VALUES
(3,'bitcoin'),
(2,'dollar'),
(4,'ethereum'),
(1,'euro');
/*!40000 ALTER TABLE `currencyTypes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-01 19:37:09
