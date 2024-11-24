-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: psh_game
-- ------------------------------------------------------
-- Server version	9.1.0

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
-- Table structure for table `players`
--

DROP TABLE IF EXISTS `players`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `players` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nickname` varchar(45) DEFAULT NULL,
  `ProfileImage` varchar(100) DEFAULT NULL,
  `Score` int DEFAULT '0',
  `CreationDate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `players`
--

LOCK TABLES `players` WRITE;
/*!40000 ALTER TABLE `players` DISABLE KEYS */;
INSERT INTO `players` VALUES (1,'EtienneTaylor','https://randomuser.me/api/portraits/men/38.jpg',55,'2024-11-23 17:36:07'),(2,'JoseKelly','https://randomuser.me/api/portraits/men/87.jpg',51,'2024-11-23 17:36:18'),(3,'CraigHarris','https://randomuser.me/api/portraits/men/74.jpg',91,'2024-11-23 17:36:23'),(4,'HerbertFournier','https://randomuser.me/api/portraits/men/83.jpg',22,'2024-11-23 17:36:36'),(5,'GracielaOquendo','https://randomuser.me/api/portraits/women/19.jpg',89,'2024-11-23 17:36:36'),(6,'MarijanaLouis','https://randomuser.me/api/portraits/women/72.jpg',78,'2024-11-23 17:36:42'),(7,'MatheusGroth','https://randomuser.me/api/portraits/men/16.jpg',77,'2024-11-23 17:36:42'),(8,'CarolynGutierrez','https://randomuser.me/api/portraits/women/43.jpg',29,'2024-11-23 17:36:42'),(9,'RoseRoss','https://randomuser.me/api/portraits/women/96.jpg',47,'2024-11-23 17:36:48'),(10,'AnastácioRezende','https://randomuser.me/api/portraits/men/30.jpg',21,'2024-11-23 17:47:16'),(11,'RosemaryLawrence','https://randomuser.me/api/portraits/women/60.jpg',46,'2024-11-23 17:48:09'),(12,'SalvatoreUlbricht','https://randomuser.me/api/portraits/men/16.jpg',48,'2024-11-23 17:48:10'),(13,'Klaus DieterKunz','https://randomuser.me/api/portraits/men/61.jpg',28,'2024-11-23 17:48:10'),(14,'NoahJohnson','https://randomuser.me/api/portraits/men/40.jpg',44,'2024-11-23 17:48:10'),(15,'JorgeCruz','https://randomuser.me/api/portraits/men/28.jpg',20,'2024-11-23 17:48:11'),(16,'AnujnaRamesh','https://randomuser.me/api/portraits/women/51.jpg',4,'2024-11-23 17:48:16'),(17,'زهراکریمی','https://randomuser.me/api/portraits/women/84.jpg',77,'2024-11-23 17:48:17'),(18,'AngieWilliams','https://randomuser.me/api/portraits/women/45.jpg',56,'2024-11-23 17:48:17'),(19,'HarryJackson','https://randomuser.me/api/portraits/men/79.jpg',73,'2024-11-23 17:48:17'),(20,'AgarRodrigues','https://randomuser.me/api/portraits/women/73.jpg',53,'2024-11-23 17:48:17'),(21,'MarizeteBarbosa','https://randomuser.me/api/portraits/women/91.jpg',69,'2024-11-23 17:48:18'),(22,'EvieZhang','https://randomuser.me/api/portraits/women/79.jpg',49,'2024-11-23 17:48:18');
/*!40000 ALTER TABLE `players` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-24 14:23:24
