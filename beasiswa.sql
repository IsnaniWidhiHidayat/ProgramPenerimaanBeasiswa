-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: beasiswa
-- ------------------------------------------------------
-- Server version	5.7.9-log

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
-- Table structure for table `beasiswa`
--

DROP TABLE IF EXISTS `beasiswa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `beasiswa` (
  `Npm` varchar(9) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Jenis_beasiswa` enum('PPA','BBM') NOT NULL,
  `ipk` decimal(3,2) NOT NULL,
  `Aktif_Organisasi` enum('Ketua','Pengurus','Anggota') DEFAULT NULL,
  `Financial` double unsigned NOT NULL,
  `Prestasi` enum('Internasional','Nasional','Regional','Lokal') DEFAULT NULL,
  `Diterima` enum('Ya','Tidak') NOT NULL,
  PRIMARY KEY (`Npm`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel beasiswa kopertis 2015';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beasiswa`
--

LOCK TABLES `beasiswa` WRITE;
/*!40000 ALTER TABLE `beasiswa` DISABLE KEYS */;
INSERT INTO `beasiswa` VALUES ('0112P003','WULAN RAHMAWATI','BBM',3.29,'Pengurus',1500000,NULL,'Ya'),('0112U002','SRI AYU AGUSTINA','BBM',3.37,'Anggota',2000000,NULL,'Ya'),('0112U007','RIKRIK GUSTIMAN SURYANTO','PPA',3.45,'Ketua',5968659,'Nasional','Ya'),('0112U025','ICHWAN LAZUARDI N','PPA',3.58,'Anggota',5326135,'Internasional','Ya'),('0112U041','MUHAMMAD SALMAN ALFARISI','PPA',3.42,'Pengurus',4000000,NULL,'Ya'),('0112U047','NOVRIANSYAH IDRIS ADJAM','PPA',3.12,'Anggota',4263252,NULL,'Ya'),('0112U058','MARSYA NUR ARITA','PPA',3.51,'Anggota',4204900,NULL,'Ya'),('0112U075','RACY MEGA SHAFIRA NURRAHMAYA','PPA',3.43,'Anggota',6056250,NULL,'Ya'),('0112U088','NILUH PUTU LILA DITHA','PPA',3.65,'Pengurus',1000000,NULL,'Ya'),('0112U106','DEBBY DEBORA MARINTAN KENNDY','BBM',3.35,'Anggota',1200000,NULL,'Ya'),('0112U113','FIKA RAMDHANY','PPA',3.46,'Pengurus',3000000,NULL,'Ya'),('0112U151','DINDA AYU IZMI','BBM',3.57,'Anggota',3486734,NULL,'Tidak'),('0112U154','RIDHWAN NUGRAHA','PPA',3.57,'Anggota',5021076,NULL,'Ya'),('0112U155','PUTRI RIZEKI NURFALAH','PPA',3.85,'Pengurus',2756900,NULL,'Ya'),('0112U167','INDAH MARIANA','PPA',3.28,'Anggota',5000000,NULL,'Ya'),('0112U183','RETNO MERIYANDI','BBM',3.24,'Anggota',3000000,NULL,'Tidak'),('0112U207','ANDINI DWIYANTI','PPA',3.42,'Anggota',4087300,NULL,'Tidak'),('0112U213','DHEA GEAVANY HANAFI','PPA',3.45,'Anggota',17000000,NULL,'Tidak'),('0112U215','ALLFILIA FEBIRRA','BBM',3.85,'Anggota',3955000,NULL,'Tidak'),('0112U233','SEKAR ENDAH PUSPA NINGRUM','PPA',3.66,'Pengurus',9862200,NULL,'Tidak'),('0112U248','SRI WAHYUNI','BBM',3.57,'Anggota',2500000,NULL,'Ya'),('0112U258','M RIZKA DAMAYANTI','BBM',3.39,'Anggota',1291000,NULL,'Ya'),('0112U264','ANASTASYA TRIANTIAS','PPA',3.80,'Anggota',2000000,NULL,'Tidak'),('0112U267','FIRNA SRI REZEKI','PPA',3.63,'Anggota',2750000,NULL,'Tidak'),('0112U280','TRI GITA GUMANTI','PPA',3.38,'Pengurus',5022800,NULL,'Tidak'),('0112U282','TONI SUGIHARTO','BBM',3.74,'Anggota',1500000,NULL,'Ya'),('0112U286','BANI AJI PRATAMA','PPA',3.63,'Ketua',5715011,NULL,'Ya'),('0112U323','SELVI NURYENIA','BBM',3.05,'Pengurus',2500000,NULL,'Tidak'),('0112U347','ESTER EVELINE TOBING','BBM',3.39,'Pengurus',1000000,NULL,'Ya'),('0112U357','NOVARIA OKTAVIANI','BBM',3.70,'Anggota',1500000,NULL,'Ya'),('0112U382','SULISTYO TRI ASTUTI S','PPA',3.48,'Anggota',4729600,NULL,'Tidak'),('0112U391','DINNAR FITRIA PUTRI PITALOKA','BBM',3.56,'Pengurus',3000000,NULL,'Ya'),('0112U397','ASTRID CHAERINNISA PUTRI NURDIANA','BBM',3.34,'Pengurus',1943625,NULL,'Ya'),('0112U398','ADNI AGISTA RAHIM','PPA',3.45,'Pengurus',5035500,NULL,'Tidak'),('0112U400','GITTA PRAMESWARI','PPA',3.80,'Pengurus',18517964,NULL,'Tidak'),('0112U402','HANNA FRISKA PASARIBU','BBM',3.57,'Pengurus',2339400,NULL,'Ya'),('0112U404','NABABAN HASIHOLAN 1','BBM',3.60,'Anggota',1500000,NULL,'Ya'),('0112U408','RANI MARDIANI','BBM',3.45,'Anggota',2000000,NULL,'Ya'),('0112U410','BAKHRUL ULUM ASYSYIDIQI','PPA',3.23,'Ketua',5108800,'Internasional','Ya'),('0113U007','HILMA YOLANDA PUTRIA DEWI','PPA',3.30,'Anggota',4368500,NULL,'Tidak'),('0113U025','SANI AGHNIA AHSANAH','BBM',2.77,'Pengurus',1867500,NULL,'Tidak'),('0113U041','THIA CHAIRUNNISA POETRI','BBM',3.65,'Anggota',500000,NULL,'Ya'),('0113U045','SHELINDA ARISANDI PUTRI','PPA',3.52,'Pengurus',2684300,NULL,'Ya'),('0113U052','ESTER AROURA HARIANDJA','PPA',3.25,'Pengurus',4322900,NULL,'Tidak'),('0113U082','ANNISA ASTARI PUTRI','PPA',3.43,'Anggota',4599200,NULL,'Tidak'),('0113U092','INTEN ROSMALINA','PPA',3.80,'Anggota',5705490,NULL,'Tidak'),('0113U094','NURFITRI ARDYANI','PPA',3.57,'Pengurus',5583200,NULL,'Tidak'),('0113U097','OSSIE RIZKIA UTAMI','PPA',3.42,'Anggota',3000000,NULL,'Tidak'),('0113U127','RESTI PERMATASARI','BBM',3.55,'Anggota',2000000,NULL,'Ya'),('0113U129','META MARCELINA','BBM',3.88,'Anggota',2689301,NULL,'Ya'),('0113U151','MAYA MULKI MUSTIKA','PPA',3.78,'Anggota',7929440,NULL,'Tidak'),('0113U161','HELMA ADITIA','PPA',3.80,'Anggota',2027000,NULL,'Tidak'),('0113U165','SEPTIA MONALISA','PPA',3.42,'Pengurus',4852100,NULL,'Tidak'),('0113U174','MARISSA BELLA JULIANA ','BBM',3.00,'Anggota',500000,NULL,'Ya'),('0113U176','HARUMI NURSELLAWATI','PPA',3.27,'Anggota',3053800,NULL,'Tidak'),('0113U177','SANDRA SINTIA','PPA',3.86,'Anggota',2057960,NULL,'Tidak'),('0113U190','AISYAH INTENSARI NURADI','BBM',3.65,'Anggota',3000000,NULL,'Ya'),('0113U211','RARASSATIKA AINUNNISA','PPA',3.81,'Anggota',4244200,NULL,'Tidak'),('0113U214','LILIS MARYANTI','PPA',3.78,'Anggota',3000000,NULL,'Tidak'),('0113U215','PUTI SEPTAMIRA NANDIAN','PPA',3.61,'Anggota',3000000,NULL,'Tidak'),('0113U240','FEBBY HYDRALIA AYU SAVITRI','BBM',3.02,'Pengurus',900000,NULL,'Ya'),('0113U248','SHINTA ACHADYANINGSIH','BBM',3.34,'Anggota',559600,NULL,'Ya'),('0113U251','SOFI ULFAH OKTIANA','BBM',3.37,'Anggota',1700000,NULL,'Ya'),('0113U258','ARINI USWATUN HASANAH KOMARA','BBM',3.28,'Anggota',1500000,NULL,'Ya'),('0113U270','NABILA PUTRI','PPA',3.76,'Pengurus',9399550,NULL,'Tidak'),('0113U272','IRENE PAULINA SIMANUNGKALIT','PPA',3.44,'Anggota',4605300,NULL,'Tidak'),('0113U273','NERISSA ARVIANA','PPA',3.42,'Pengurus',2302188,NULL,'Tidak'),('0113U287','RINA ANGGRAENI','PPA',3.77,'Anggota',3000000,NULL,'Tidak'),('0113U296','MEIRICHA RAHMAN','BBM',3.50,'Anggota',2226000,NULL,'Ya'),('0113U298','VIENA PUTRI VERNANDA','PPA',3.63,'Anggota',2371100,NULL,'Tidak'),('0113U328','TRESNA DITA GUSTARI','PPA',3.62,'Anggota',4158400,NULL,'Tidak'),('0113U329','ALBIAN MARIE MARUF','PPA',3.32,'Pengurus',5500000,NULL,'Tidak'),('0113U340','RINA NOVIANA','PPA',3.93,'Pengurus',1590000,NULL,'Ya'),('0113U353','IMELDA FERONIKA SIMBOLON','BBM',3.22,'Anggota',1278993,NULL,'Tidak'),('0113U354','SYIFA FARADILA','PPA',3.35,'Pengurus',5539995,NULL,'Tidak'),('0113U366','SYFA FIJRIESTARI SURYONO','PPA',3.63,'Pengurus',763975,'Regional','Ya'),('0113U381','FATIMA ZENA ZETIRA','BBM',3.29,'Pengurus',750000,NULL,'Ya'),('0113U405','DITHA PARAMITA SUNARYA','BBM',3.44,'Anggota',3907800,NULL,'Ya'),('0113U409','ALFI ALFAUZIA AZIZIAH','PPA',3.47,'Pengurus',2000000,'Lokal','Ya'),('0113U438','RIDWAN FAUZI','PPA',3.45,'Pengurus',16045111,NULL,'Tidak'),('0113U446','MILY NUR AMALIA','PPA',3.91,'Pengurus',4785800,NULL,'Ya'),('0113U448','ANGGITA PURWANTI','BBM',3.40,'Anggota',2282900,NULL,'Ya'),('0113U449','MUTIA KHARISMA AULIA','PPA',3.00,'Pengurus',4000000,'Lokal','Tidak'),('0113U451','MIRZA MARUF','BBM',3.72,'Anggota',1000000,NULL,'Ya'),('0113U463','GILANG NOOR ALAMSYAH','PPA',3.39,'Anggota',6150191,'Regional','Tidak'),('0113U465','ASEP DODDY RAKHMAT','PPA',3.36,'Anggota',3000000,NULL,'Tidak'),('0113U481','GINA LEVANI SOESILO','PPA',3.59,'Pengurus',9500000,NULL,'Tidak'),('0113U494','AFAUZAN LIZIKRIE','PPA',3.65,'Anggota',3279915,'Lokal','Ya'),('0113U515','RAHAYU RAMADRIANI','PPA',3.78,'Anggota',4500000,NULL,'Tidak'),('0113U524','SYIFA MULYA RESTIAN','BBM',3.30,'Pengurus',2842230,NULL,'Ya'),('0113U535','MOCHAMMAD FITYAN MUNGGARAN','BBM',2.95,'Pengurus',3100000,NULL,'Tidak'),('0113U547','OKTORIENES TRI PURWANTO','BBM',3.17,'Anggota',2939400,NULL,'Tidak'),('0113U570','KHAIRUN NISAK ','PPA',3.37,'Anggota',3000000,NULL,'Tidak'),('0113U576','SURYANINGRUM RISA SAPUTRI','BBM',3.58,'Pengurus',2000000,NULL,'Ya'),('0113U580','RENATA CLAUDIA S','PPA',3.16,'Pengurus',3000000,NULL,'Tidak'),('011401035','ANASTASIA YULIANI DEWI SETYAWATI','PPA',3.89,'Anggota',1037568,NULL,'Tidak'),('011401096','ANISA NUR KAMILA','PPA',3.83,'Anggota',4132800,NULL,'Tidak'),('011401116','SOPI YULIATI ','PPA',3.50,'Anggota',3750000,NULL,'Tidak'),('011401120','ENDAH YANIASIH','PPA',3.89,'Anggota',2337700,NULL,'Tidak'),('011401134','WESTY JUNIASTI','PPA',3.89,'Anggota',3733300,NULL,'Tidak'),('011401200','EVELYN PERTIWI PUTRI','PPA',3.83,'Anggota',4277331,NULL,'Tidak'),('011401220','SANTI DWI MULYATI','PPA',3.89,'Anggota',2500000,'Nasional','Ya'),('011401250','ANGGI FEBRIYANTI SUJANA','PPA',4.00,'Anggota',9508000,NULL,'Tidak'),('011401257','ERDIANA NUR AIDINA','PPA',3.72,'Anggota',7000000,NULL,'Tidak'),('011401282','SILVYA NUR RACHMI','PPA',4.00,'Anggota',1072783,NULL,'Tidak'),('011401340','LIA AYU RESTIANA','BBM',3.56,'Anggota',2354000,NULL,'Ya'),('011401345','ROSALINA SIHITE','PPA',3.72,'Anggota',4000000,NULL,'Tidak'),('011401361','NANDA OCTAVIA','PPA',3.83,'Anggota',1323000,NULL,'Tidak'),('011401395','NAERITA ','PPA',3.83,'Anggota',4500000,NULL,'Tidak'),('011401501','FEBBY OLIVIA JEFANY','PPA',3.83,'Anggota',2000000,NULL,'Tidak'),('0212U036','DENYSHA RAMDHANI','BBM',3.58,'Anggota',450000,NULL,'Ya'),('0212U046','CITRA NATYA PUTRI','PPA',3.26,'Pengurus',3914000,NULL,'Tidak'),('0212U056','DAUD DARWANTO','BBM',3.06,'Anggota',1390000,NULL,'Tidak'),('0212U094','KHARISMA DWI PRABAWANTI','PPA',3.34,'Anggota',9494217,NULL,'Tidak'),('0212U101','ERIKA PUSPITASARI EFENDI','PPA',3.64,'Pengurus',7000000,NULL,'Tidak'),('0212U148','MUHAMAD NUR IKSANI','BBM',3.56,'Pengurus',1500000,NULL,'Ya'),('0212U150','ROBBYANSYAH SURYANA','BBM',3.43,'Anggota',1500000,NULL,'Ya'),('0212U155','FADHLIH HADIAN','BBM',3.26,'Anggota',1585356,NULL,'Ya'),('0212U184','ADHITYA SOFYAN','PPA',3.53,'Pengurus',1200000,'Internasional','Ya'),('0212U248','REGINA YULIANI','PPA',3.52,'Pengurus',6848000,NULL,'Tidak'),('0212U267','NURUL GANTINA','PPA',3.78,'Pengurus',3000000,NULL,'Ya'),('0212U342','RAKKA DWI UTAMA RIZKY','BBM',2.90,'Pengurus',1500000,NULL,'Ya'),('0212U390','NADYA AYU BENITA','PPA',3.51,'Anggota',3858113,NULL,'Tidak'),('0212U425','MUHAMAD NIZAR NOVIANTO','PPA',3.26,'Anggota',5125600,NULL,'Tidak'),('0212U437','ASTRID RETCITA BILHAQ','BBM',3.31,'Ketua',2000000,NULL,'Ya'),('0212U542','IHYA ULUMUDDIN SY','PPA',3.52,'Ketua',988950,'Nasional','Ya'),('0212U579','NOVANDA PRADWI','BBM',3.34,'Pengurus',1500000,NULL,'Ya'),('0212U595','LEVI NOVIYANTI','PPA',3.42,'Anggota',2931900,NULL,'Tidak'),('0213U001','VICKE RUSVIANY','PPA',3.88,'Anggota',9214000,NULL,'Tidak'),('0213U030','FIKRI RAKA NOVEBRIAN','BBM',3.25,'Pengurus',2200000,NULL,'Tidak'),('0213U039','AMALIA HASANAH','BBM',3.59,'Anggota',1000000,NULL,'Ya'),('0213U051','HANIFIA KUSDARINI','PPA',3.47,'Anggota',4719180,NULL,'Tidak'),('0213U084','NOVIANTY NURUL PRATIWI','PPA',3.92,'Anggota',2669300,NULL,'Tidak'),('0213U099','FEBY PERMANA','BBM',3.26,'Anggota',750000,NULL,'Ya'),('0213U125','DENAIS KANTI A.D.','PPA',3.63,'Anggota',4857800,NULL,'Tidak'),('0213U137','AZREENA CHANTIKA AZIS','PPA',3.62,'Anggota',4500000,NULL,'Tidak'),('0213U163','ASTI DWIANI PUTRI','PPA',3.59,'Anggota',4892000,NULL,'Tidak'),('0213U164','MOHAMAD AKBAR ALISYAHBANA','BBM',3.38,'Ketua',1500000,NULL,'Ya'),('0213U180','GALIH MOCHAMAD NURHANDIMAN','PPA',3.28,'Pengurus',1836310,NULL,'Tidak'),('0213U217','ADHITYA RIZKI RAMADHAN','BBM',3.28,'Pengurus',1862525,NULL,'Ya'),('0213U267','MUHAMAD RURI PERMANA','PPA',3.61,'Anggota',2830200,NULL,'Tidak'),('0213U274','TITAN SYAHRONI','PPA',3.36,'Pengurus',12000000,NULL,'Tidak'),('0213U283','WIDIA ASTUTI ABRYANI','PPA',3.71,'Pengurus',879468,'Lokal','Ya'),('0213U300','YOGA ADITYA WIDYAWAN','PPA',3.30,'Pengurus',7548451,'Regional','Ya'),('0213U320','PUTERI DENA FAJRIANI','PPA',3.66,'Anggota',1500000,NULL,'Tidak'),('0213U330','EVI YULIANI HERTIANA','PPA',3.59,'Pengurus',3000000,NULL,'Ya'),('0213U363','DESSY EKA HERAWATI','PPA',3.35,'Anggota',4000000,NULL,'Tidak'),('0213U383','RAFI ADITYA HERDIAWAN','PPA',3.05,'Pengurus',3000000,NULL,'Tidak'),('0213U392','FINKA SHERLYARTI','BBM',3.61,'Anggota',10277365,NULL,'Tidak'),('0213U430','GINA SARAH ALANIA','PPA',3.76,'Anggota',6300000,NULL,'Tidak'),('0213U435','MERY ELFARANI SIMARMATA','PPA',3.69,'Pengurus',7837074,NULL,'Tidak'),('0213U445','LIRA MUSTIKA SARI','PPA',3.96,'Anggota',2500000,NULL,'Tidak'),('0213U463','DEBBY OKTAFIANI RUHIAT','PPA',3.62,'Anggota',3919000,NULL,'Tidak'),('0213U476','OLGA PUSPITAWENING','PPA',3.52,'Pengurus',2439525,NULL,'Ya'),('0213U487','YOHANA CLARA ELITA PANGARIBUAN','BBM',3.33,'Pengurus',2000000,NULL,'Ya'),('0213U488','KHALISA BALQIS','PPA',3.97,'Anggota',26542765,NULL,'Tidak'),('0213U498','ETI RINA MITA','BBM',3.20,'Pengurus',1500000,NULL,'Ya'),('0213U504','ASRININGSIH SOFIYANTI','PPA',3.74,'Anggota',1809750,NULL,'Ya'),('0213U509','KENTRI ANI GULTOM','BBM',3.83,'Anggota',1000000,NULL,'Ya'),('0213U520','RADEN ANGGI ROSDIANI','PPA',3.45,'Anggota',3979500,NULL,'Tidak'),('0213U538','ANSHOR AUZAN AMANNUDIN','PPA',3.44,'Pengurus',2519800,NULL,'Tidak'),('0213U546','SHALLY NATALIA ','BBM',3.68,'Pengurus',4586000,NULL,'Ya'),('0213U567','SRI RUCITA','PPA',3.38,'Anggota',4000000,NULL,'Tidak'),('0213U577','TIARA ANDIANI RACHIM','PPA',3.20,'Anggota',10000000,NULL,'Tidak'),('0213U589','DEWI ALMIRA DARMAWAN','BBM',3.60,'Pengurus',1000000,NULL,'Ya'),('0213U594','FITRI YANTI SAGALA','BBM',3.78,'Anggota',1500000,NULL,'Ya'),('0213U622','SARAH SENTIKA','PPA',3.63,'Anggota',7694207,NULL,'Tidak'),('0213U630','LUKI CHANDRA SASMITA','PPA',3.67,'Anggota',7000000,NULL,'Tidak'),('0213U635','ADITIYA FARDIANA RAHMAN','BBM',3.54,'Anggota',2368289,NULL,'Tidak'),('0213U652','INTAN PURNAMA SARI','BBM',3.72,'Anggota',2000000,NULL,'Ya'),('0213U688','INDRIYANNI','PPA',3.85,'Anggota',4309400,NULL,'Tidak'),('0213U727','YEREMIA CLS','PPA',3.39,'Pengurus',3000000,NULL,'Tidak'),('0213U732','PRATIWI DWI YANTI','PPA',3.31,'Anggota',4729600,NULL,'Tidak'),('021401034','DHAFIN FAZA GHANI','PPA',3.67,'Pengurus',20000000,'Regional','Ya'),('021401191','RITA MUSTAFA','PPA',3.67,'Anggota',1500000,NULL,'Tidak'),('021401223','AFIF SETIAWAN','PPA',3.67,'Anggota',4500000,NULL,'Tidak'),('021401248','OKTA EKA PUTRA','BBM',3.72,'Anggota',1500000,NULL,'Ya'),('021401313','GESTI PERIBADI PURMA','PPA',4.00,'Anggota',5000000,NULL,'Tidak'),('021401429','ANUGRAH DIAN UTAMI PUTRI SULAEMAN','PPA',3.89,'Anggota',2500000,NULL,'Tidak'),('021401456','VERA FAUZIAH','PPA',3.67,'Anggota',5772800,NULL,'Tidak'),('021401465','VENNA DENISHA','PPA',3.67,'Anggota',6642860,NULL,'Tidak'),('021401526','INDRIATI MELANDA UTAMI','PPA',3.61,'Anggota',3733300,NULL,'Tidak'),('021401542','IVAN APRIANSYAH','PPA',3.89,'Anggota',15499300,NULL,'Tidak'),('021401618','ILMA AMALIA','PPA',3.56,'Anggota',3000000,NULL,'Tidak'),('021401631','FERA RAHMAWATI','PPA',3.67,'Anggota',3178400,NULL,'Tidak'),('021401683','GINA NUR FIRASSANDI','PPA',4.00,'Anggota',4454581,NULL,'Tidak'),('021401748','FEBRINA MARIA SANTOSO','BBM',3.56,'Anggota',3500000,NULL,'Tidak'),('021411001','MONICA WAHYUNING ASRI','PPA',3.33,'Pengurus',1800000,NULL,'Tidak'),('021421010','VINA TRIYANTI','PPA',4.00,'Anggota',5237700,NULL,'Tidak'),('0313U007','NURISA ROSINDAH','BBM',3.91,'Anggota',2609267,NULL,'Ya'),('0313U028','SHELPIA PURWASIH','BBM',3.60,'Anggota',2250000,NULL,'Ya'),('0313U029','VIKA FEBRIANTI','PPA',3.97,'Anggota',2000000,NULL,'Ya'),('041401044','ESTER YULINAR LAROSA','PPA',4.00,'Anggota',2400000,NULL,'Ya'),('0513U012','HAMZAH AGUNG AZHARI','PPA',3.81,'Anggota',2316200,NULL,'Tidak'),('0513U020','LENA YULINA','PPA',3.78,'Pengurus',5535400,NULL,'Tidak'),('0513U024','NIDA ALMIRA','PPA',3.88,'Pengurus',4778400,NULL,'Ya'),('051401005','HAFIDHOH','PPA',3.78,'Anggota',300000,NULL,'Tidak'),('0612U001','KARLINA','PPA',3.72,'Pengurus',2000000,NULL,'Tidak'),('0612U004','FEGA EKA WAHYUDIN','BBM',2.81,'Ketua',635632,NULL,'Ya'),('0612U015','AGAM RUSTIAWAN','BBM',3.17,'Pengurus',1500000,NULL,'Ya'),('0612U017','PRIMA AUDITA','PPA',3.64,'Pengurus',1095173,NULL,'Ya'),('0613U011','RINDAH PAWESTI','PPA',3.36,'Pengurus',4000000,NULL,'Tidak'),('0613U019','RULLY SURYA WIJAYA','BBM',3.07,'Pengurus',1200000,NULL,'Ya'),('0613U031','FITRI RIZKI AMELIA','PPA',3.88,'Pengurus',2500000,NULL,'Tidak'),('0613U039','ERI WIANA HIDAYAT','BBM',3.07,'Pengurus',3186494,NULL,'Tidak'),('0613U042','FAUZIA PUSPITA DEWI','BBM',3.86,'Pengurus',10507680,NULL,'Tidak'),('0712U006','SYAFIRA ALFA MONICA','PPA',3.65,'Anggota',2263327,NULL,'Tidak'),('0712U011','PUTRI LIANA','BBM',3.01,'Pengurus',2500000,NULL,'Ya'),('0713U011','NURLIANA','BBM',2.92,'Anggota',900000,NULL,'Ya'),('0713U016','MARIA FRANSISKA','BBM',3.30,'Pengurus',2545675,NULL,'Ya'),('0713U025','AUDIA','PPA',3.51,'Anggota',3000000,NULL,'Ya'),('0713U032','TANYA SARAH LARASATI','BBM',3.20,'Pengurus',3000000,NULL,'Ya'),('071401004','RAFA ADITYA RAMADHAN','PPA',3.80,'Anggota',2377942,NULL,'Tidak'),('071401024','NATASYA PUTRI SUPARMAN','BBM',3.60,'Anggota',2426900,NULL,'Ya'),('0813U004','DIAH NOVIANTI DEWI','PPA',3.90,'Pengurus',2720000,NULL,'Ya'),('0813U007','ADI WIGUNA','BBM',3.43,'Ketua',3150000,NULL,'Ya'),('0813U008','NABILA HIDAYAT','PPA',3.84,'Pengurus',4401500,NULL,'Tidak'),('081401004','DIANA GANEPA','PPA',4.00,'Anggota',3159100,NULL,'Tidak'),('081401005','SHINTA DEA GLOBULINA','BBM',3.09,'Anggota',1200000,NULL,'Tidak'),('081401009','RIZKY PRABOWO','PPA',4.00,'Anggota',5000000,NULL,'Tidak'),('081401011','DEWI SRI WAHYUNI','BBM',3.27,'Anggota',1000000,NULL,'Ya'),('0912U002','VALENTINA WIDYTA PRATIWI','BBM',2.90,'Ketua',3500000,NULL,'Ya'),('0912U004','GALIH PRAWIRA ADI DARMA','BBM',3.45,'Ketua',2000000,NULL,'Ya'),('091401004','ANDAMSARI HABIBIE FENI','PPA',3.85,'Anggota',5196300,NULL,'Tidak'),('091401015','MOCHAMMAD IRFAN REIFALDY','PPA',3.45,'Anggota',4009400,NULL,'Tidak'),('091401020','DELLY RUCHMAT','PPA',4.00,'Anggota',3000000,NULL,'Tidak'),('091401021','HERLINAWATI','PPA',3.85,'Anggota',1000000,NULL,'Tidak'),('1013U008','NOVIA ANDRIANI','PPA',3.73,'Anggota',3000000,NULL,'Ya'),('1113U005','INDRIANITA DWI WAHYUNING TIAS','PPA',3.72,'Pengurus',21496370,NULL,'Ya'),('1113U010','YUDI TRI GUNTARA','PPA',3.19,'Pengurus',1600000,NULL,'Tidak'),('1113U015','SYIFA AFIANA MUKDAS','PPA',3.14,'Pengurus',5367500,NULL,'Tidak'),('1113U017','FIRMAN NURDIANA','BBM',3.65,'Pengurus',2600000,NULL,'Ya'),('1113U019','HENDRIAN RACHMANDA','PPA',3.31,'Pengurus',1572100,NULL,'Tidak'),('111431004','TUBAGUS MUHAMMAD TAUFIQ GHANDUR','BBM',2.98,'Anggota',2558750,NULL,'Ya');
/*!40000 ALTER TABLE `beasiswa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-06 16:44:17
