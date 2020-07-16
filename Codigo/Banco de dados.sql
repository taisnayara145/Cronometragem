-- Adminer 4.2.5 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `modelo`;
CREATE TABLE `modelo` (
  `modelocod` int(11) NOT NULL AUTO_INCREMENT,
  `modelonome` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`modelocod`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

DROP TABLE IF EXISTS `posto`;
CREATE TABLE `posto` (
  `postocod` int(11) NOT NULL AUTO_INCREMENT,
  `postonome` varchar(10) COLLATE utf8_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`postocod`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

DROP TABLE IF EXISTS `tempo`;
CREATE TABLE `tempo` (
  `timercod` int(11) NOT NULL AUTO_INCREMENT,
  `timertempo` double NOT NULL,
  `timerdata` date NOT NULL,
  `timerhora` time NOT NULL,
  `timerposto` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `timermodelo` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `timeroperador` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`timercod`)
) ENGINE=InnoDB AUTO_INCREMENT=723 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

-- 2020-07-10 15:32:44