-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: cafe2_import
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `patronymic` varchar(45) DEFAULT NULL,
  `id_role` int DEFAULT NULL,
  `id_status` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_role_idx` (`id_role`),
  KEY `fk_status_idx` (`id_status`),
  CONSTRAINT `fk_role` FOREIGN KEY (`id_role`) REFERENCES `sp_role` (`id_role`),
  CONSTRAINT `fk_status` FOREIGN KEY (`id_status`) REFERENCES `sp_status` (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (12,'admin','admin','Романов','Алексей','Константинович',1,1),(13,'cook','cook','Муратов','Николай','Александрович',2,1),(14,'mixa','1234','Сорокин','Михаил','Артёмович',2,1),(15,'waiter','waiter','Александров','Адам','Кириллович',3,1),(16,'Костя','1234','Кузнецов','Константин','Никитич',3,1),(17,'arina','1234','Хохлова','Арина','Тимофеевна',1,1),(18,'anna','1234','Степанова','Анна','Германовна',2,1),(19,'yri','1234','Кудрявцев','Юрий','Степанович',2,1),(20,'angekina','1234','Кочергина','Ангелина','Мироновна',3,1),(21,'iana','1234','Котова','Яна','Марковна',3,1),(35,'lol','2к32а','1111111','111','111',3,1);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dish_status`
--

DROP TABLE IF EXISTS `dish_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dish_status` (
  `id_dish_status` int NOT NULL AUTO_INCREMENT,
  `name_dish_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_dish_status`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dish_status`
--

LOCK TABLES `dish_status` WRITE;
/*!40000 ALTER TABLE `dish_status` DISABLE KEYS */;
INSERT INTO `dish_status` VALUES (1,'Принят'),(2,'Готовится'),(3,'Готов'),(4,'Оплачен');
/*!40000 ALTER TABLE `dish_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `id_dish` int NOT NULL AUTO_INCREMENT,
  `name_dish` varchar(45) DEFAULT NULL,
  `price` int DEFAULT NULL,
  PRIMARY KEY (`id_dish`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Пюре',300),(2,'Омлет',150),(3,'Овощи',120),(4,'Кофе',85);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu_and_ordering`
--

DROP TABLE IF EXISTS `menu_and_ordering`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu_and_ordering` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_ordering` int DEFAULT NULL,
  `id_dish` int DEFAULT NULL,
  `count` int DEFAULT NULL,
  `summa_dish` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ordering_idx` (`id_ordering`),
  KEY `fk_dish_idx` (`id_dish`),
  CONSTRAINT `fk_dish` FOREIGN KEY (`id_dish`) REFERENCES `menu` (`id_dish`),
  CONSTRAINT `fk_ordering` FOREIGN KEY (`id_ordering`) REFERENCES `ordering` (`id_ordering`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu_and_ordering`
--

LOCK TABLES `menu_and_ordering` WRITE;
/*!40000 ALTER TABLE `menu_and_ordering` DISABLE KEYS */;
INSERT INTO `menu_and_ordering` VALUES (1,1,1,3,900),(2,2,3,1,120),(3,3,3,1,120),(4,3,4,2,170),(5,4,2,1,150);
/*!40000 ALTER TABLE `menu_and_ordering` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordering`
--

DROP TABLE IF EXISTS `ordering`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordering` (
  `id_ordering` int NOT NULL AUTO_INCREMENT,
  `name_ordering` varchar(45) DEFAULT NULL,
  `summa` int DEFAULT NULL,
  `id_waiter` int DEFAULT NULL,
  `table` varchar(45) DEFAULT NULL,
  `count_of_guests` int DEFAULT NULL,
  `id_dish_status` int DEFAULT NULL,
  PRIMARY KEY (`id_ordering`),
  KEY `fk_dish_status_idx` (`id_dish_status`),
  KEY `fk_waiter_idx` (`id_waiter`),
  CONSTRAINT `fk_dish_status` FOREIGN KEY (`id_dish_status`) REFERENCES `dish_status` (`id_dish_status`),
  CONSTRAINT `fk_waiter` FOREIGN KEY (`id_waiter`) REFERENCES `accounts` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordering`
--

LOCK TABLES `ordering` WRITE;
/*!40000 ALTER TABLE `ordering` DISABLE KEYS */;
INSERT INTO `ordering` VALUES (1,'Гренка',3000,15,'12',123,3),(2,'111',120,15,'12',1,1),(3,'kekw',290,21,'12',3,2),(4,'',150,15,'',1,1);
/*!40000 ALTER TABLE `ordering` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shifts`
--

DROP TABLE IF EXISTS `shifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shifts` (
  `id_shift` int NOT NULL AUTO_INCREMENT,
  `data_start` datetime DEFAULT NULL,
  `data_end` datetime DEFAULT NULL,
  `id_vshift` int DEFAULT NULL,
  PRIMARY KEY (`id_shift`),
  KEY `fk_vshift_idx` (`id_vshift`),
  CONSTRAINT `fk_vshift` FOREIGN KEY (`id_vshift`) REFERENCES `view_shift` (`id_vshift`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shifts`
--

LOCK TABLES `shifts` WRITE;
/*!40000 ALTER TABLE `shifts` DISABLE KEYS */;
INSERT INTO `shifts` VALUES (1,'2023-04-15 09:11:20','2023-04-15 11:00:00',1),(2,'2023-04-15 02:00:00','2023-04-15 05:00:00',2),(3,'2023-12-06 15:57:13','2023-12-06 15:57:13',1),(4,'2023-12-06 15:58:40','2023-12-06 15:58:40',1),(5,'2023-12-06 15:59:55','2023-12-06 15:59:55',1),(6,'2023-12-06 16:00:51','2023-12-06 16:00:51',1),(7,'2023-12-06 18:26:46','2023-12-31 18:26:46',2),(8,'2023-12-06 18:29:49','2023-12-04 18:29:49',2),(9,'2023-12-06 18:32:09','2023-12-17 18:32:08',1),(10,'2023-12-06 18:32:55','2023-12-06 18:32:55',1),(11,'2023-12-06 18:36:03','2023-12-06 18:36:03',2);
/*!40000 ALTER TABLE `shifts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sp_role`
--

DROP TABLE IF EXISTS `sp_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sp_role` (
  `id_role` int NOT NULL AUTO_INCREMENT,
  `name_role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sp_role`
--

LOCK TABLES `sp_role` WRITE;
/*!40000 ALTER TABLE `sp_role` DISABLE KEYS */;
INSERT INTO `sp_role` VALUES (1,'Администратор'),(2,'Повар'),(3,'Официант');
/*!40000 ALTER TABLE `sp_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sp_status`
--

DROP TABLE IF EXISTS `sp_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sp_status` (
  `id_status` int NOT NULL AUTO_INCREMENT,
  `name_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sp_status`
--

LOCK TABLES `sp_status` WRITE;
/*!40000 ALTER TABLE `sp_status` DISABLE KEYS */;
INSERT INTO `sp_status` VALUES (1,'Работает'),(2,'Уволен');
/*!40000 ALTER TABLE `sp_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `view_shift`
--

DROP TABLE IF EXISTS `view_shift`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `view_shift` (
  `id_vshift` int NOT NULL AUTO_INCREMENT,
  `name_vshift` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_vshift`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `view_shift`
--

LOCK TABLES `view_shift` WRITE;
/*!40000 ALTER TABLE `view_shift` DISABLE KEYS */;
INSERT INTO `view_shift` VALUES (1,'Дневная'),(2,'Ночная');
/*!40000 ALTER TABLE `view_shift` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `working_people`
--

DROP TABLE IF EXISTS `working_people`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `working_people` (
  `id_wp` int NOT NULL AUTO_INCREMENT,
  `id` int DEFAULT NULL,
  `id_shift` int DEFAULT NULL,
  PRIMARY KEY (`id_wp`),
  KEY `fk_id_idx` (`id`),
  KEY `fk_id_shift_idx` (`id_shift`),
  CONSTRAINT `fk_id` FOREIGN KEY (`id`) REFERENCES `accounts` (`id`),
  CONSTRAINT `fk_id_shift` FOREIGN KEY (`id_shift`) REFERENCES `shifts` (`id_shift`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `working_people`
--

LOCK TABLES `working_people` WRITE;
/*!40000 ALTER TABLE `working_people` DISABLE KEYS */;
INSERT INTO `working_people` VALUES (5,12,1),(6,13,2),(7,14,1),(8,15,2),(9,16,1),(10,20,3),(11,15,3),(12,16,3),(13,18,2),(14,18,2),(15,16,3),(16,16,3),(17,21,3),(18,19,2),(19,15,6),(20,16,6),(21,21,6),(22,21,8),(23,20,8),(24,15,9),(25,19,9),(26,13,9),(27,15,9),(28,20,11);
/*!40000 ALTER TABLE `working_people` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-11 15:01:28
