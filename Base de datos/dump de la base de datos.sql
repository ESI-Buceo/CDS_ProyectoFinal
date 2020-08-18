-- MySQL dump 10.13  Distrib 5.7.30, for Linux (x86_64)
--
-- Host: localhost    Database: dbTriage
-- ------------------------------------------------------
-- Server version	5.7.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrativo`
--

DROP TABLE IF EXISTS `administrativo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `administrativo` (
  `docidentidad` int(11) NOT NULL,
  `ndeempleado` int(11) NOT NULL,
  PRIMARY KEY (`docidentidad`),
  UNIQUE KEY `ndeempleado` (`ndeempleado`),
  CONSTRAINT `administrativo_ibfk_1` FOREIGN KEY (`docidentidad`) REFERENCES `persona` (`docidentidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrativo`
--

LOCK TABLES `administrativo` WRITE;
/*!40000 ALTER TABLE `administrativo` DISABLE KEYS */;
INSERT INTO `administrativo` VALUES (11111111,1234),(22222222,2222),(77777777,2587),(33333333,4321),(44444444,6541),(55555555,8426),(66666666,8523);
/*!40000 ALTER TABLE `administrativo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asociados`
--

DROP TABLE IF EXISTS `asociados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asociados` (
  `idPatologia` int(11) NOT NULL,
  `IdSintoma` int(11) NOT NULL,
  PRIMARY KEY (`idPatologia`,`IdSintoma`),
  KEY `IdSintoma` (`IdSintoma`),
  CONSTRAINT `asociados_ibfk_1` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`id`),
  CONSTRAINT `asociados_ibfk_2` FOREIGN KEY (`IdSintoma`) REFERENCES `sintoma` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asociados`
--

LOCK TABLES `asociados` WRITE;
/*!40000 ALTER TABLE `asociados` DISABLE KEYS */;
INSERT INTO `asociados` VALUES (4,1),(19,1),(22,1),(24,1),(26,1),(29,1),(37,1),(38,1),(39,1),(3,2),(16,2),(22,2),(24,2),(25,2),(26,2),(30,2),(34,2),(35,2),(36,2),(39,2),(2,3),(5,3),(6,3),(16,3),(24,3),(26,3),(38,3),(39,3),(3,4),(4,4),(7,4),(19,4),(25,4),(34,4),(35,4),(39,4),(4,5),(18,5),(24,5),(39,5),(20,6),(39,6),(6,8),(36,8),(39,8),(2,9),(5,9),(11,9),(39,9),(11,11),(15,11),(39,11),(11,12),(20,12),(29,12),(39,12),(5,18),(6,18),(16,18),(30,18),(39,18),(7,19),(22,19),(1,45),(36,45),(15,46),(18,46),(18,47),(36,50),(1,53),(29,67),(27,76),(27,77),(27,78),(29,78),(27,79),(29,79),(32,84),(32,86),(33,88),(33,89),(40,94),(40,95);
/*!40000 ALTER TABLE `asociados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `docidentidadPaciente` int(11) NOT NULL DEFAULT '0',
  `docidentidadMedico` int(11) NOT NULL DEFAULT '0',
  `idSesion` int(11) NOT NULL,
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `emisor` enum('P','M') DEFAULT NULL,
  `mensaje` varchar(80) NOT NULL,
  `leido` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`,`docidentidadPaciente`,`docidentidadMedico`,`idSesion`),
  KEY `docidentidadPaciente` (`docidentidadPaciente`),
  KEY `docidentidadMedico` (`docidentidadMedico`),
  KEY `idSesion` (`idSesion`),
  CONSTRAINT `chat_ibfk_1` FOREIGN KEY (`docidentidadPaciente`) REFERENCES `paciente` (`docidentidad`),
  CONSTRAINT `chat_ibfk_2` FOREIGN KEY (`docidentidadMedico`) REFERENCES `medico` (`docidentidad`),
  CONSTRAINT `chat_ibfk_3` FOREIGN KEY (`idSesion`) REFERENCES `sesion` (`idSesion`)
) ENGINE=InnoDB AUTO_INCREMENT=109 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
INSERT INTO `chat` VALUES (1,19248371,19266171,161348021,'2020-08-16 20:14:20','M','El medico ha iniciado sesion, aguarda por favor...',1),(2,19248371,19266171,161348021,'2020-08-16 20:14:20','M','Hola buenas tardes',1),(3,19248371,19266171,161348021,'2020-08-16 20:14:28','P','hola doctor',1),(4,19248371,19266171,161348021,'2020-08-16 20:14:40','M','cuanto hace que presenta este cuadro?',1),(5,19248371,19266171,161348021,'2020-08-16 20:14:53','P','desde ayer a la mañana',1),(6,19248371,19266171,161348021,'2020-08-16 20:15:05','M','Ha presentado fiebre',1),(7,19248371,19266171,161348021,'2020-08-16 20:15:18','P','no',1),(8,19248371,19266171,161348021,'2020-08-16 20:15:45','M','bien, algun otro sintoma ',1),(9,19248371,19266171,161348021,'2020-08-16 20:15:53','P','pero el dolor en el pecho me preocupo por eso le consultaba',1),(10,19248371,19266171,161348021,'2020-08-16 20:16:03','P','cansancio fisico',1),(11,19248371,19266171,161348021,'2020-08-16 20:16:09','M','La tos es con catarro?',1),(12,19248371,19266171,161348021,'2020-08-16 20:16:13','P','no',1),(13,19248371,19266171,161348021,'2020-08-16 20:16:18','P','es tos seca',1),(14,19248371,19266171,161348021,'2020-08-16 20:16:45','M','ok, bueno, estamos ante un escenario de gripe',1),(15,19248371,19266171,161348021,'2020-08-16 20:16:55','M','tomese un zolben caliente',1),(16,19248371,19266171,161348021,'2020-08-16 20:16:55','M','y a la cama',1),(17,19248371,19266171,161348021,'2020-08-16 20:17:13','M','si no recupera en 72 hrs. vuelva a contactarnos',1),(18,19248371,19266171,161348021,'2020-08-16 20:17:13','P','okey, ya me tomo uno',1),(19,19248371,19266171,161348021,'2020-08-16 20:17:23','P','muchas gracias',1),(20,19248371,19266171,161348021,'2020-08-16 20:17:30','M','gracias a Usted.',1),(21,19248371,19266171,162251781,'2020-08-16 20:23:26','M','El medico ha iniciado sesion, aguarda por favor...',1),(22,19248371,19266171,162251781,'2020-08-16 20:23:31','M','Hola',1),(23,19248371,19266171,162251781,'2020-08-16 20:23:36','M','Como esta Andrea?',1),(24,19248371,19266171,162251781,'2020-08-16 20:23:36','P','hola doc',1),(25,19248371,19266171,162251781,'2020-08-16 20:23:51','P','con molestia',1),(26,19248371,19266171,162251781,'2020-08-16 20:23:56','M','Cuanto hace que presenta este cuadro?',1),(27,19248371,19266171,162251781,'2020-08-16 20:24:16','P','los estornudos y la picazon en los ojos',1),(28,19248371,19266171,162251781,'2020-08-16 20:24:26','P','y la tos no me deja tranquila',1),(29,19248371,19266171,162251781,'2020-08-16 20:24:36','P','me duele la frente cuando bajo la cabeza',1),(30,19248371,19266171,162251781,'2020-08-16 20:25:46','M','bien, de acuerdo a sus sintomas creo que podemos estar frente a una rinitis,',1),(31,19248371,19266171,162251781,'2020-08-16 20:26:06','M','es aconsejable que visite el policlinico para que le realicen',1),(32,19248371,19266171,162251781,'2020-08-16 20:26:11','M','una revision mas profunda',1),(33,19248371,19266171,162251781,'2020-08-16 20:26:31','P','ah bueno, voy hasta ahi entonces',1),(34,19248371,19266171,162251781,'2020-08-16 20:26:36','P','muchas gracias',1),(35,19248371,19266171,162251781,'2020-08-16 20:26:41','M','Gracias por consulta',1),(36,19248371,19266171,162251781,'2020-08-16 20:26:43','M','y a las ordenes',1),(37,19248371,19266171,162251781,'2020-08-16 20:26:46','P','saludos',1),(38,19248371,19266171,163840577,'2020-08-16 20:38:59','M','El medico ha iniciado sesion, aguarda por favor...',1),(39,19248371,19266171,163840577,'2020-08-16 20:39:04','M','Hola Andra, bienvenida nuevamente',1),(40,19248371,19266171,163840577,'2020-08-16 20:39:10','P','hola doc',1),(41,19248371,19266171,163840577,'2020-08-16 20:39:10','P','como esta?',1),(42,19248371,19266171,163840577,'2020-08-16 20:39:24','M','Los calambres son en las dos manos',1),(43,19248371,19266171,163840577,'2020-08-16 20:39:24','M','?',1),(44,19248371,19266171,163840577,'2020-08-16 20:39:25','P','me siguen los calambres en las manos',1),(45,19248371,19266171,163840577,'2020-08-16 20:39:59','M','y el dolor de huesos, donde es que le duele?',1),(46,19248371,19266171,163840577,'2020-08-16 20:40:05','P','hoy es mas intenso',1),(47,19248371,19266171,163840577,'2020-08-16 20:40:20','P','los brazos y antebrazos',1),(48,19248371,19266171,163840577,'2020-08-16 20:40:39','M','Bien, esta tomando alguna medicacion?',1),(49,19248371,19266171,163840577,'2020-08-16 20:41:05','P','aun no, solo un analgesico para los dolores',1),(50,19248371,19266171,163840577,'2020-08-16 20:41:54','M','Ok, le sugiero pedir pase a un reumatologo a los efectos de que pueda hacer ',1),(51,19248371,19266171,163840577,'2020-08-16 20:41:59','M','una correcta evaluacino',1),(52,19248371,19266171,163840577,'2020-08-16 20:42:04','M','evaluacion de la situacion',1),(53,19248371,19266171,163840577,'2020-08-16 20:42:04','M','no deje estar',1),(54,19248371,19266171,163840577,'2020-08-16 20:42:13','P','bien gracias',1),(55,19248371,19266171,163840577,'2020-08-16 20:42:14','M','ya que esto puede derivar en consecuencias mayores',1),(56,19248371,19266171,163840577,'2020-08-16 20:42:20','P','pido hora para estos dias',1),(57,19248371,19266171,163840577,'2020-08-16 20:42:25','P','gracias por todo',1),(58,19248371,19266171,163840577,'2020-08-16 20:42:29','M','a las ordenes',1),(59,19248371,19266171,175705874,'2020-08-17 20:57:22','M','El medico ha iniciado sesion, aguarda por favor...',1),(60,19248371,19266171,175705874,'2020-08-17 20:57:32','M','Hola Sra. Andrea',1),(61,19248371,19266171,175705874,'2020-08-17 20:57:32','M','buenas tardes',1),(62,19248371,19266171,175705874,'2020-08-17 20:57:37','P','Hola doctor',1),(63,19248371,19266171,175705874,'2020-08-17 20:57:57','M','cuanto hace que esta con ese dolor',1),(64,19248371,19266171,175705874,'2020-08-17 20:58:02','P','y al menos una semana',1),(65,19248371,19266171,175705874,'2020-08-17 20:58:07','P','he tomado de todo',1),(66,19248371,19266171,175705874,'2020-08-17 20:58:17','M','Bien, que ha tomado?',1),(67,19248371,19266171,175705874,'2020-08-17 20:58:22','P','he tomado analgesicos',1),(68,19248371,19266171,175705874,'2020-08-17 20:58:27','P','ibuprofeno',1),(69,19248371,19266171,175705874,'2020-08-17 20:58:27','P','pero nada',1),(70,19248371,19266171,175705874,'2020-08-17 20:58:47','M','Lo que usted tiene es una contractura',1),(71,19248371,19266171,175705874,'2020-08-17 20:58:47','M','durante 10 dias',1),(72,19248371,19266171,175705874,'2020-08-17 20:59:02','M','debe tomar musculateran',1),(73,19248371,19266171,175705874,'2020-08-17 20:59:22','M','si no se mejora en 10 dias contactese nuevamente',1),(74,19248371,19266171,175705874,'2020-08-17 20:59:32','P','Perfecto, y la receta',1),(75,19248371,19266171,175705874,'2020-08-17 20:59:32','P','?',1),(76,19248371,19266171,175705874,'2020-08-17 20:59:37','M','se la hacemos llegar por email',1),(77,19248371,19266171,175705874,'2020-08-17 20:59:51','P','ok, muchas gracias',1),(78,19248371,19266171,175705874,'2020-08-17 20:59:52','M','a las ordenes',1),(79,19248371,19266171,170048568,'2020-08-17 21:01:05','M','El medico ha iniciado sesion, aguarda por favor...',1),(80,19248371,19266171,170048568,'2020-08-17 21:01:10','M','Buenas tardes',1),(81,19248371,19266171,170048568,'2020-08-17 21:01:17','P','hola doctor',1),(82,19248371,19266171,174735987,'2020-08-17 21:48:05','M','El medico ha iniciado sesion, aguarda por favor...',1),(83,19248371,19266171,174735987,'2020-08-17 21:48:05','M','Hola',1),(84,19248371,19266171,174735987,'2020-08-17 21:48:17','P','hola, buenas tardes',1),(85,19248371,19266171,174735987,'2020-08-17 21:48:17','P','como esta',1),(86,19248371,19266171,174735987,'2020-08-17 21:48:20','M','prueba de chat para enviar por email',1),(87,19248371,19266171,174735987,'2020-08-17 21:48:27','P','sigo con dolor en las manos',1),(88,19248371,19266171,174735987,'2020-08-17 21:48:27','P','chau',1),(89,19248371,19266171,175611547,'2020-08-17 21:56:20','M','El medico ha iniciado sesion, aguarda por favor...',1),(90,19248371,19266171,175611547,'2020-08-17 21:56:25','M','prueba de chat para enviar email',1),(91,19248371,19266171,175611547,'2020-08-17 21:56:28','P','buenas tardes',1),(92,19248371,19266171,175611547,'2020-08-17 21:56:33','P','saludos',1),(93,19248371,19266171,170221583,'2020-08-17 22:02:35','M','El medico ha iniciado sesion, aguarda por favor...',1),(94,19248371,19266171,170221583,'2020-08-17 22:02:40','M','prueba de chat para email',1),(95,19248371,19266171,170221583,'2020-08-17 22:02:51','P','hola doc',1),(96,19248371,19266171,170221583,'2020-08-17 22:02:51','P','todo bien',1),(97,19248371,19266171,170221583,'2020-08-17 22:02:56','P','gracias',1),(98,19248371,19266171,170221583,'2020-08-17 22:02:56','P','chau',1),(99,19248371,19266171,170442798,'2020-08-17 22:04:55','M','El medico ha iniciado sesion, aguarda por favor...',1),(100,19248371,19266171,170442798,'2020-08-17 22:05:00','M','prueba de chat para email',1),(101,19248371,19266171,170442798,'2020-08-17 22:05:11','P','hola doc',1),(102,19248371,19266171,170442798,'2020-08-17 22:05:16','P','como esta',1),(103,19248371,19266171,170442798,'2020-08-17 22:05:16','P','chau',1),(104,19248371,19266171,170914094,'2020-08-17 22:29:35','M','El medico ha iniciado sesion, aguarda por favor...',1),(105,19248371,19266171,170914094,'2020-08-17 22:29:40','M','Prueba de chat',1),(106,19248371,19266171,170914094,'2020-08-17 22:29:45','M','chatpara enviar por coreo',1),(107,19248371,19266171,170914094,'2020-08-17 22:29:57','P','holaaaa',1),(108,19248371,19266171,170914094,'2020-08-17 22:30:02','P','chau',1);
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostico`
--

DROP TABLE IF EXISTS `diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diagnostico` (
  `id` int(11) NOT NULL,
  `prioridad` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostico`
--

LOCK TABLES `diagnostico` WRITE;
/*!40000 ALTER TABLE `diagnostico` DISABLE KEYS */;
INSERT INTO `diagnostico` VALUES (230835,40),(2313519,0),(2338359,0),(22452912,0),(22473436,0),(23290899,15),(23443032,40),(23473018,10),(23560045,0),(23563929,40),(123147773,20),(123218264,20),(161348021,10),(162251781,30),(163840577,20),(164048755,40),(164324192,40),(165528049,30),(165605563,40),(170048568,40),(170221583,10),(170442798,10),(170914094,10),(174735987,20),(175611547,10),(175705874,10),(220033235,20),(221226055,20),(223749789,20),(223817701,20),(223831884,15),(223914223,40),(223931014,20),(224031467,20),(224052995,10),(224103486,40),(224125183,10),(224409124,10),(224457587,10),(224622041,0),(224649765,0),(224709775,0),(224731649,0),(224757535,10),(224758824,10),(224900784,10),(224916602,20),(224938235,20),(225018466,0),(225048046,40),(225244501,20),(230000932,0),(230356007,0),(230356675,10),(230410788,40),(230431573,20),(230507366,10),(230725151,0),(230856534,18),(231133553,18),(231300691,18),(231351453,40),(231456633,0),(231548519,40),(231603837,18),(231713646,10),(231725374,0),(231807507,10),(232015734,40),(232201235,40),(232301821,40),(232324442,40),(232605399,40),(232827939,40),(233006283,10),(233303032,30),(233402775,20),(233405677,40),(233503762,10),(233547755,40),(233845343,40),(234121094,10),(234158844,40),(234309432,40),(234325454,40),(234414523,40),(234448403,10),(234521242,40),(234606166,40),(234736513,40),(234757367,40),(234808245,40),(234908241,16),(235104121,40),(235133923,16),(235204458,40),(235405437,20),(235420201,40),(235420762,0),(235457335,16),(235539705,40),(235625797,16),(235709118,40),(235725929,40),(235736425,16),(235929985,16),(240945222,18),(241606899,10),(242127817,40),(242330669,40),(1020044310,0),(1020065635,10),(1120051944,10),(1120092513,10),(1120092731,10),(1120092818,10),(1120092954,10),(1120124837,10),(1320010533,0),(1620020845,0),(1620034010,40),(1620034322,40),(1620034815,40),(1620042218,40),(1620042440,40),(1720035405,0),(1720035923,0),(1720040037,0),(1720040336,0),(1720040627,0),(1720040728,0),(1720040919,0),(1720041018,0),(1720041219,0),(1720042652,0),(1720043755,0),(1720044037,0),(1720044205,0),(1720044354,40),(1720044551,40),(1720045304,40),(1720045404,0),(1720045526,40),(1720045630,0),(1720051739,0),(1720051836,40),(1820062218,30),(1820064333,30),(1920075430,0),(1920075541,0),(1920075700,0),(1920094357,0),(2120013822,40),(2147483647,0);
/*!40000 ALTER TABLE `diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medico` (
  `docidentidad` int(11) NOT NULL,
  `ndemedico` int(11) NOT NULL,
  PRIMARY KEY (`docidentidad`),
  UNIQUE KEY `ndemedico` (`ndemedico`),
  CONSTRAINT `medico_ibfk_1` FOREIGN KEY (`docidentidad`) REFERENCES `persona` (`docidentidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico`
--

LOCK TABLES `medico` WRITE;
/*!40000 ALTER TABLE `medico` DISABLE KEYS */;
INSERT INTO `medico` VALUES (19266173,1234),(19266171,1926),(1926174,13456),(19266175,19265),(19266176,19266),(19266172,192622);
/*!40000 ALTER TABLE `medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente` (
  `docidentidad` int(11) NOT NULL,
  PRIMARY KEY (`docidentidad`),
  CONSTRAINT `paciente_ibfk_1` FOREIGN KEY (`docidentidad`) REFERENCES `persona` (`docidentidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (19248371),(19248372),(19248373),(19248374),(19248375),(19248376),(19248377);
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patologia`
--

DROP TABLE IF EXISTS `patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patologia` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `ponderacion` int(11) NOT NULL,
  `descripcion` varchar(500) NOT NULL,
  `activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patologia`
--

LOCK TABLES `patologia` WRITE;
/*!40000 ALTER TABLE `patologia` DISABLE KEYS */;
INSERT INTO `patologia` VALUES (1,'Contracturas',10,'Dolor Muscular en todo el cuerpo',1),(2,'Gripe A',40,'La gripe A es una enfermedad infecciosa causada por un virus de la influenza tipo A,',1),(3,'Covid-19',10,'Los síntomas aparecen entre dos y catorce días, con un promedio de cinco días, después de la exposición al virus.21?22?23?24? Existe evidencia limitada que sugiere que el virus podría transmitirse uno o dos días antes de que se tengan síntomas, ya que la viremia alcanza un pico al final del período de incubación.2',1),(4,'Ataque la Higado',10,'Comé despacio y mastica muy bien. El hígado no es el responsable de tus molestias. Es un problema digestivo. Deberás tener presente todos estos consejos para evitar su progresión.',1),(5,'Sinusitis',20,'Inflamación nasal.Secreción espesa y descolorida de la nariz. Secreción por la parte posterior de la garganta (secreción posnasal). Obstrucción o congestión nasal, que dificultad para respirar por la nariz. Dolor, sensibilidad e inflamación alrededor de los ojos, las mejillas, la nariz o la frente',1),(6,'Asma',40,'Falta de aire. Dolor u opresión en el pecho. Problemas para dormir causados por falta de aire, tos o silbido al respirar.',1),(7,'Hemorroides',10,'Las hemorroides, también llamadas almorranas, son venas hinchadas en el ano y la parte inferior del recto, similares a las venas varicosas. Las hemorroides pueden desarrollarse dentro del recto (hemorroides internas) o debajo de la piel alrededor del ano (hemorroides externas).',1),(11,'Accidente cerebrovascular',40,'Un accidente cerebrovascular ocurre cuando el suministro de sangre a una parte del cerebro se interrumpe o se reduce, lo que impide que el tejido cerebral reciba oxígeno y nutrientes. Las células cerebrales comienzan a morir en minutos.',1),(15,'Artritis reumatoide',20,'La artritis reumatoide es una forma de artritis que causa dolor, inflamación, rigidez y pérdida de la función de las articulaciones. Puede afectar cualquier articulación, pero es común en las muñecas y los dedos.',1),(16,'Broncoespamo',10,'Las glándulas bronquiales se encargan de segregar una mucosidad que acaba por bloquear los bronquios impidiendo que el aire circule con normalidad. ',1),(18,'Dengue',40,'El dengue es una enfermedad infecciosa producida por el virus del dengue (DENV). Pertenece al género Flavivirus, de la familia Flaviviridae que, a la vez, pertenece al grupo de los Arbovirus (virus trasmitidos por artrópodos). Las partículas virales contienen RNA de cadena simple, son envueltas y tienen aproximadamente 40-50 nm de diámetro.',1),(19,'Patologia Uno',20,'Ingreso de nuevo patologia <sv<sd',0),(20,'Prueba de pat',10,'Prueba de patologia nueva',0),(22,'Prueba de patologia',20,'Ingreso de patologia 17/06/2020 con sus sintomas relacionados',0),(24,'Ingreso de patologia',20,'Ingreso de patologia 1 con sintomas diferentes',0),(25,'Prueba 2',40,'Ingreso de patologia 2',1),(26,'Prueba 3',30,'Ingreso de patologia 3 17/06/2020 con sintomas',1),(27,'Rinitis',30,'Usted presenta un cuadro de  Rinitis. La rinitis es una inflamación del revestimiento mucoso de la nariz, caracterizada clínicamente por uno o más síntomas: rinorrea, estornudo, prurito (picor) nasal, tos irritativa, drenaje (secreción) postnasal.',1),(28,'picazon',10,'urticaria en el cuerpo, principalmente en manos',0),(29,'test',1000,'asrgaedrgadsf',0),(30,'Broncoespasmo',10,'Las glándulas bronquiales se encargan de segregar una mucosidad que acaba por bloquear los bronquios impidiendo que el aire circule con normalidad. ',0),(31,'Patologia inactiva',10,'asrgasg',0),(32,'Acné',10,'El acné es una enfermedad que se caracteriza por la aparición de lesiones en la piel como consecuencia de una foliculitis, una inflamación y posterior infección del poro folicular (orificio de salida del pelo). Estas lesiones suelen ser granos, espinillas negras y parches rojos e inflamados, como quistes.',1),(33,'Aftas bucales',10,'Las aftas bucales son úlceras que se producen en la mucosa de la boca y constituyen una de las enfermedades bucales que  más frecuencia tiene junto con las caries. Son de tamaño pequeño (unos 5 milímetros), el color suele ser blanquecino y aparecen rodeadas por un área roja. Además, no son contagiosas.',1),(34,'Nueva Patologia',30,'Detalle',1),(35,'Nueva patologia',20,'Detalle',0),(36,'Gripe común',10,'La gripe es causada por un virus de la influenza.\r\nLa mayoría de las personas contraen la gripe cuando inhalan gotitas provenientes de la tos o los estornudos de alguien que tenga gripe. Usted también la puede contraer si toca algo que contenga el virus y luego se toca la boca, la nariz o los ojos.',1),(37,'para borrar',20,'Patologia para borrar',0),(38,'prueba',20,'adasds',0),(39,'Apendisitis',10,'aerhaerhearhaerhea',1),(40,'Piedras en Riñones',40,'Tus riñones remueven los desechos y líquidos de tu cuerpo para hacer orina.  Algunas veces cuando tienes demasiado de algún desecho y no suficiente líquidos en tu sangre, estos deshechos pueden acumularse y aglutinan en tus riñones.  Estos bodoques de deshechos son llamadas piedras en los riñones o también conocidos como cálculos renales.\r\n\r\n',1);
/*!40000 ALTER TABLE `patologia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `docidentidad` int(11) NOT NULL,
  `mail` varchar(50) NOT NULL,
  `nombres` varchar(25) NOT NULL,
  `apellidos` varchar(25) NOT NULL,
  `calle` varchar(30) DEFAULT NULL,
  `numero` varchar(8) DEFAULT NULL,
  `barrio` varchar(25) DEFAULT NULL,
  `esquina` varchar(30) DEFAULT NULL,
  `apartamento` varchar(5) DEFAULT NULL,
  `fechaNacimiento` date NOT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT '1',
  `fechaRegistro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`docidentidad`),
  UNIQUE KEY `mail` (`mail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1926174,'mariaprado@gmail.com','Maria Ester','Lima Prado','','','','','','1984-08-12',1,'2020-08-12 18:43:04'),(11111111,'usuario1@gmail.com','Mario Juan','Fernandez Corbo',NULL,NULL,NULL,NULL,NULL,'1982-04-25',1,'2020-08-11 21:40:35'),(19248371,'andrea.gonzalez@gmail.com','Andrea Laura','Gonzalez Sanchez','','','','','','1969-08-12',1,'2020-08-12 14:48:11'),(19248372,'maria.perez@gmail.com','Maria Elisa','Perez Perez','','','','','','1900-08-12',1,'2020-08-12 18:31:13'),(19248373,'julio.gonzalez@gmail.com','Julio Raul','Gonzalez Prieto','','','','','','1969-10-27',1,'2020-08-12 18:48:02'),(19248374,'luisjuan@gmail.com','Luis Juan','Gomez Diaz','','','','','','1984-01-02',1,'2020-08-12 18:53:54'),(19248375,'mariamoreno@gmail.com','Maria Lujan','Garcia Moreno','Las Heras','3256','Parque Batlle','Av. Italia','201','1980-05-14',1,'2020-08-12 18:58:16'),(19248376,'mikalu@gmail.com','Mika Lu','Capu Sala','MCastro','5544','Solymar','Dulcinea','','1980-09-21',1,'2020-08-12 19:01:38'),(19248377,'juanazapata@gmail.com','Juana Gaby','Zapata Gana','','','','','','1976-12-20',1,'2020-08-12 19:03:58'),(19266171,'arturo.muela@gmail.com','Arturo Manuel','Muela Sosa','','','','','','1974-06-12',1,'2020-08-13 23:19:05'),(19266172,'ruben.lima@gmail.com','Ruben Andre','Lima Sosa','','','','','','1983-09-20',1,'2020-08-13 23:20:11'),(19266173,'luisb@gmail.com','Luis Mario','Benedetti','La direccion','2510','el barrio','La esquina','','1984-03-22',1,'2020-08-13 23:19:49'),(19266175,'notienemail@gmail.com','Estanislao','Perez','Lima ','5646','La Blanqueada','Lavalleja','1A','1936-08-12',1,'2020-08-12 18:44:37'),(19266176,'abu_ruth@gmial.com','Ruth Rosario','Sanchez Cardozo','','','','','','1974-06-11',1,'2020-08-12 18:45:57'),(22222222,'maria.lima@gmail.com','Maria Juana','Lima','Av. De los Pinos','2516','El Barrio','La otra calle','','1984-08-12',1,'2020-08-12 14:52:54'),(33333333,'angelasoria@vidasana.com','Angela Maria','Soria Machado','','','','','','1967-02-12',1,'2020-08-12 19:07:14'),(44444444,'sebastian@vidasana.com','Sebas Tian','Guardia Segura','','','','','','1986-04-10',1,'2020-08-12 19:08:50'),(55555555,'auguspais@vidasana.com','Augus Diego','Pais Nandez','Los Caminos al Fondo','2244','Buceo','Es aca','','1990-12-26',1,'2020-08-12 19:11:41'),(66666666,'anamarialopez@vidasana.com','Ana Maria','Lopez Perez','Aguas Claras','3355','Escondido','Lado','','1995-10-22',1,'2020-08-12 19:15:02'),(77777777,'cristinamendez@vidasana.com','Cristina Maria','Mendez Pintos','','','','','','1954-01-18',1,'2020-08-12 19:16:52');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `preexistentes`
--

DROP TABLE IF EXISTS `preexistentes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `preexistentes` (
  `docidentidad` int(11) NOT NULL,
  `preexistente` varchar(40) NOT NULL,
  PRIMARY KEY (`docidentidad`,`preexistente`),
  CONSTRAINT `preexistentes_ibfk_1` FOREIGN KEY (`docidentidad`) REFERENCES `paciente` (`docidentidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preexistentes`
--

LOCK TABLES `preexistentes` WRITE;
/*!40000 ALTER TABLE `preexistentes` DISABLE KEYS */;
/*!40000 ALTER TABLE `preexistentes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recibe`
--

DROP TABLE IF EXISTS `recibe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `recibe` (
  `idDiagnostico` int(11) NOT NULL,
  `idPaciente` int(11) NOT NULL,
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idDiagnostico`,`idPaciente`,`fechaHora`),
  KEY `idPaciente` (`idPaciente`),
  CONSTRAINT `recibe_ibfk_1` FOREIGN KEY (`idDiagnostico`) REFERENCES `diagnostico` (`id`),
  CONSTRAINT `recibe_ibfk_2` FOREIGN KEY (`idPaciente`) REFERENCES `paciente` (`docidentidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recibe`
--

LOCK TABLES `recibe` WRITE;
/*!40000 ALTER TABLE `recibe` DISABLE KEYS */;
INSERT INTO `recibe` VALUES (161348021,19248371,'2020-06-16 20:13:48'),(162251781,19248371,'2020-08-16 20:22:52'),(163840577,19248371,'2020-07-16 20:38:41'),(164048755,19248371,'2020-08-16 23:40:48'),(164324192,19248371,'2020-08-16 23:43:23'),(165528049,19248371,'2020-08-16 23:55:27'),(165605563,19248371,'2020-08-16 23:56:05'),(170048568,19248371,'2020-08-17 21:00:48'),(170221583,19248371,'2020-08-17 22:02:22'),(170442798,19248371,'2020-08-17 22:04:43'),(170914094,19248371,'2020-08-17 22:09:14'),(174735987,19248371,'2020-08-17 21:47:36'),(175611547,19248371,'2020-08-17 21:56:12'),(175705874,19248371,'2020-08-17 20:57:06');
/*!40000 ALTER TABLE `recibe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesion`
--

DROP TABLE IF EXISTS `sesion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sesion` (
  `idSesion` int(11) NOT NULL,
  `estado` enum('0','1','2','3','4') DEFAULT '0',
  `fechaHoraInicioSesion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `prioridad` int(11) NOT NULL,
  PRIMARY KEY (`idSesion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesion`
--

LOCK TABLES `sesion` WRITE;
/*!40000 ALTER TABLE `sesion` DISABLE KEYS */;
INSERT INTO `sesion` VALUES (161348021,'3','2020-08-16 20:17:46',10),(162251781,'3','2020-08-16 20:26:51',30),(163840577,'3','2020-08-16 20:42:30',20),(170048568,'3','2020-08-17 21:01:29',40),(170221583,'3','2020-08-17 22:02:59',10),(170442798,'3','2020-08-17 22:05:17',10),(170914094,'3','2020-08-17 22:30:05',10),(174735987,'3','2020-08-17 21:48:32',20),(175611547,'3','2020-08-17 21:56:34',10),(175705874,'3','2020-08-17 20:59:56',10);
/*!40000 ALTER TABLE `sesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sintoma`
--

DROP TABLE IF EXISTS `sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sintoma` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintoma`
--

LOCK TABLES `sintoma` WRITE;
/*!40000 ALTER TABLE `sintoma` DISABLE KEYS */;
INSERT INTO `sintoma` VALUES (1,'Náuseas',1),(2,'Tos',1),(3,'Falta de Aire',1),(4,'Diarrea',1),(5,'Vomito',1),(6,'Náuseas',1),(8,'Dolor en el pecho',1),(9,'Dolor de Cabeza',1),(11,' Calambres en manos',1),(12,' Presion Alta',1),(13,'Perdida de Peso',0),(14,'Picor',0),(15,'Agotamiento',0),(17,'Taquicardia',0),(18,'Mareos',1),(19,'Escalofríos',1),(22,'Dolor de testiculo',1),(23,'Pérdida de apetito',1),(24,'Dolor de oído',1),(25,'cucusa',0),(27,'Ojos y piel amarillentos',1),(28,'Pigmentación amarilla de ',1),(30,'Picazon en los ojos',1),(40,'Dolor en los Genitales',1),(42,'Manchas rojizas',1),(44,'Dolor en los ojos',1),(45,'Dolor Muscular',1),(46,'Dolor en los huesos',1),(47,'Fiebre Alta',1),(49,'Fiebre baja',1),(50,'Fiebre Moderada',1),(53,'Dolor de espalda',1),(54,'Perdida de audicion',1),(57,'Prueba dos',0),(66,'Piel roja',1),(67,'Alteracion en la orina',1),(76,'Picor en los ojos',1),(77,'Estornudos',1),(78,'Tos irritativa',1),(79,'Ojos rojos',1),(81,'',0),(84,'Granos',1),(86,'Pus',1),(88,'Heridas blancas en boca',1),(89,'heridas en la lengua',1),(93,'Calambre',1),(94,'Dolor agudo en la espalda',1),(95,'Dolor al orinar',1);
/*!40000 ALTER TABLE `sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono`
--

DROP TABLE IF EXISTS `telefono`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefono` (
  `docidentidad` int(11) NOT NULL,
  `telefono` int(11) NOT NULL,
  PRIMARY KEY (`docidentidad`,`telefono`),
  CONSTRAINT `telefono_ibfk_1` FOREIGN KEY (`docidentidad`) REFERENCES `persona` (`docidentidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono`
--

LOCK TABLES `telefono` WRITE;
/*!40000 ALTER TABLE `telefono` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiene` (
  `idDiagnostico` int(11) NOT NULL,
  `idPatologia` int(11) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  PRIMARY KEY (`idDiagnostico`,`idPatologia`,`idSintoma`),
  KEY `idPatologia` (`idPatologia`),
  KEY `idSintoma` (`idSintoma`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`idDiagnostico`) REFERENCES `diagnostico` (`id`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`id`),
  CONSTRAINT `tiene_ibfk_3` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
INSERT INTO `tiene` VALUES (23473018,1,1),(175705874,1,45),(175705874,1,53),(230507366,1,1),(1020065635,1,1),(1120051944,1,1),(1120092954,1,1),(1120124837,1,1),(231351453,2,1),(234757367,2,1),(234808245,2,1),(235104121,2,1),(170048568,3,2),(170048568,3,4),(223831884,4,1),(224457587,4,1),(224758824,4,1),(23290899,5,1),(23563929,5,1),(230410788,5,1),(230431573,5,1),(231351453,5,1),(231548519,5,1),(232201235,5,1),(232301821,5,1),(232324442,5,1),(233405677,5,1),(234158844,5,1),(234606166,5,1),(234736513,5,1),(234757367,5,1),(234808245,5,1),(235104121,5,1),(235204458,5,1),(235405437,5,1),(235420201,5,1),(235709118,5,1),(235725929,5,1),(23563929,6,1),(230410788,6,1),(231548519,6,1),(232201235,6,1),(232301821,6,1),(232324442,6,1),(232605399,6,1),(232827939,6,1),(233405677,6,1),(234158844,6,1),(234606166,6,1),(234736513,6,1),(234757367,6,1),(235204458,6,1),(235420201,6,1),(235709118,6,1),(235725929,6,1),(231713646,7,1),(233006283,7,1),(233503762,7,1),(164048755,11,9),(164048755,11,11),(164048755,11,12),(164324192,11,9),(164324192,11,11),(164324192,11,12),(165605563,11,9),(165605563,11,11),(165605563,11,12),(225048046,11,1),(233547755,11,1),(234309432,11,1),(234521242,11,1),(235539705,11,1),(163840577,15,11),(163840577,15,46),(174735987,15,11),(174735987,15,46),(23563929,16,1),(225244501,16,1),(230410788,16,1),(230856534,16,1),(231133553,16,1),(231300691,16,1),(231548519,16,1),(231603837,16,1),(232201235,16,1),(232301821,16,1),(232324442,16,1),(233402775,16,1),(233405677,16,1),(234158844,16,1),(234606166,16,1),(234736513,16,1),(234757367,16,1),(234908241,16,1),(235133923,16,1),(235204458,16,1),(235420201,16,1),(235457335,16,1),(235625797,16,1),(235709118,16,1),(235725929,16,1),(235736425,16,1),(235929985,16,1),(240945222,16,1),(230835,18,1),(23443032,18,1),(223914223,18,1),(224103486,18,1),(234414523,18,1),(242127817,18,1),(242330669,18,1),(1620034010,18,1),(1620034322,18,1),(1620034815,18,1),(1620042218,18,1),(1620042440,18,1),(1720044354,18,1),(1720044551,18,1),(1720045304,18,1),(1720045526,18,1),(1720051836,18,1),(2120013822,18,1),(123147773,24,1),(123218264,24,1),(220033235,24,1),(221226055,24,1),(223749789,24,1),(223817701,24,1),(223831884,24,1),(223931014,24,1),(224031467,24,1),(224916602,24,1),(224938235,24,1),(225244501,24,1),(230856534,24,1),(231133553,24,1),(231603837,24,1),(234908241,24,1),(235133923,24,1),(235457335,24,1),(235625797,24,1),(235736425,24,1),(235929985,24,1),(240945222,24,1),(170048568,25,2),(170048568,25,4),(225244501,26,1),(230856534,26,1),(231133553,26,1),(231603837,26,1),(233303032,26,1),(233402775,26,1),(234908241,26,1),(235133923,26,1),(235457335,26,1),(235625797,26,1),(235736425,26,1),(235929985,26,1),(240945222,26,1),(162251781,27,76),(162251781,27,77),(162251781,27,78),(165528049,27,76),(165528049,27,77),(165528049,27,78),(165528049,27,79),(1820062218,27,1),(1820064333,27,1),(230856534,30,1),(231133553,30,1),(224757535,33,1),(224900784,33,1),(170048568,34,2),(170048568,34,4),(161348021,36,2),(161348021,36,8),(170221583,36,2),(170221583,36,8),(170442798,36,2),(170442798,36,8),(170914094,36,2),(170914094,36,8),(175611547,36,2),(175611547,36,8),(224052995,36,1),(224125183,36,1),(224409124,36,1),(230356675,36,1),(234448403,36,1),(23290899,39,1),(161348021,39,2),(161348021,39,8),(164048755,39,9),(164048755,39,11),(164048755,39,12),(164324192,39,9),(164324192,39,11),(164324192,39,12),(165605563,39,9),(165605563,39,11),(165605563,39,12),(170048568,39,2),(170048568,39,4),(170221583,39,2),(170221583,39,8),(170442798,39,2),(170442798,39,8),(170914094,39,2),(170914094,39,8),(175611547,39,2),(175611547,39,8),(231548519,39,1),(231807507,39,1),(232301821,39,1),(232324442,39,1),(232605399,39,1),(232827939,39,1),(233405677,39,1),(234121094,39,1),(234158844,39,1),(234448403,39,1),(235420201,39,1),(235709118,39,1),(240945222,39,1),(241606899,39,1),(233845343,40,1);
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-17 20:30:33
