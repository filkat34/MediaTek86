-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 12 mars 2025 à 09:21
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--
-- --------------------------------------------------------

--
-- Création et utilisation de la base : `mediatek86`
--

CREATE DATABASE mediatek86;
USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(5, '2023-03-12 17:43:19', '2024-09-28 06:19:09', 2),
(13, '2023-06-13 23:29:08', '2024-05-19 05:17:28', 2),
(10, '2023-07-20 03:25:57', '2024-04-23 04:47:40', 3),
(2, '2023-12-07 14:19:14', '2024-07-30 05:31:05', 4),
(5, '2023-12-28 08:27:17', '2024-03-17 07:31:31', 2),
(14, '2023-04-14 07:32:21', '2024-06-30 09:47:15', 1),
(12, '2023-03-20 13:51:13', '2024-01-12 14:26:06', 4),
(2, '2023-10-21 10:18:23', '2024-04-16 22:21:38', 3),
(8, '2023-02-05 19:54:11', '2024-10-20 04:23:16', 4),
(9, '2023-09-23 04:51:40', '2024-01-05 19:39:40', 4),
(3, '2023-09-08 12:17:29', '2024-01-16 15:56:43', 2),
(2, '2023-12-19 06:46:46', '2024-06-29 22:08:12', 3),
(6, '2023-11-18 09:59:09', '2024-01-22 06:34:27', 3),
(2, '2023-01-02 18:02:25', '2024-12-28 18:18:41', 4),
(7, '2023-12-24 06:21:24', '2024-08-16 23:41:46', 4),
(7, '2023-03-30 09:24:27', '2024-04-28 09:54:30', 3),
(8, '2023-03-19 05:58:50', '2024-03-26 09:06:56', 3),
(14, '2023-11-18 23:59:38', '2024-09-09 02:38:18', 4),
(14, '2023-12-10 06:03:36', '2024-05-13 11:39:19', 1),
(3, '2023-11-15 08:34:50', '2024-06-03 22:07:16', 4),
(2, '2023-05-06 21:24:45', '2024-02-14 23:34:30', 1),
(8, '2023-08-14 07:54:39', '2024-05-03 16:03:00', 4),
(12, '2023-03-28 09:18:16', '2024-04-16 19:29:09', 3),
(10, '2023-01-07 12:38:05', '2024-08-07 00:07:48', 1),
(5, '2023-05-24 23:03:07', '2024-02-01 11:31:32', 3),
(11, '2023-07-09 20:30:36', '2024-06-11 03:36:16', 3),
(5, '2023-12-25 18:51:41', '2024-02-29 09:07:28', 2),
(15, '2023-09-07 19:00:45', '2024-07-24 22:11:49', 2),
(12, '2023-04-02 08:34:55', '2024-04-25 13:42:20', 3),
(10, '2023-09-07 05:20:48', '2024-09-12 01:41:39', 2),
(6, '2023-01-02 01:02:30', '2024-10-01 19:51:40', 3),
(10, '2023-10-28 08:43:10', '2024-01-28 18:13:19', 1),
(4, '2023-10-16 06:50:59', '2024-05-17 04:17:16', 3),
(7, '2023-09-12 08:43:03', '2024-11-07 18:54:45', 2),
(12, '2023-02-17 09:34:49', '2024-12-30 02:43:58', 2),
(14, '2023-10-09 16:01:46', '2024-10-05 02:33:59', 4),
(7, '2023-03-17 07:26:28', '2024-10-15 10:19:07', 2),
(8, '2023-04-16 22:22:12', '2024-09-11 20:33:47', 2),
(8, '2023-08-20 09:15:25', '2024-05-18 18:13:57', 1),
(10, '2023-06-05 21:57:00', '2024-08-11 03:11:33', 1),
(10, '2023-09-15 06:37:05', '2024-05-18 08:11:27', 3),
(6, '2023-06-17 12:51:14', '2024-06-27 17:41:30', 4),
(6, '2023-03-23 08:08:16', '2024-07-01 21:53:33', 3),
(14, '2023-11-25 15:27:03', '2024-05-02 04:26:56', 2),
(6, '2023-09-04 02:24:03', '2024-03-13 18:26:46', 2),
(2, '2023-12-15 03:10:30', '2024-02-10 10:32:45', 3),
(4, '2023-11-13 10:16:51', '2024-06-25 05:55:44', 3),
(12, '2023-06-30 19:29:47', '2024-02-21 18:39:19', 1),
(7, '2023-04-05 07:45:27', '2024-10-29 03:33:31', 3),
(8, '2023-12-18 13:32:15', '2024-06-01 10:06:57', 2),
(5, '2023-03-01 01:56:28', '2024-06-01 18:14:01', 3),
(5, '2023-12-15 20:05:53', '2024-10-30 10:14:43', 3),
(2, '2023-09-04 11:33:27', '2024-12-23 16:08:51', 3),
(5, '2023-05-02 10:27:52', '2024-08-11 22:35:44', 3),
(14, '2023-05-03 16:14:50', '2024-08-20 06:52:00', 3),
(13, '2023-03-03 06:52:42', '2024-04-29 15:07:38', 2),
(14, '2023-10-12 00:44:44', '2024-02-29 15:46:59', 3),
(3, '2023-02-10 21:19:18', '2024-04-10 18:06:45', 4),
(8, '2023-05-17 15:43:45', '2024-06-08 15:18:51', 3),
(14, '2023-01-17 01:48:39', '2024-06-01 09:58:47', 2),
(105, '2025-03-10 08:00:40', '2025-03-10 22:00:40', 1),
(3, '2025-03-25 23:59:59', '2025-03-09 09:43:38', 4),
(13, '2025-03-25 23:59:59', '2025-03-09 10:44:11', 3),
(2, '2025-03-09 04:48:36', '2025-03-26 16:48:36', 2),
(1, '2025-03-14 14:37:41', '2025-03-19 14:37:41', 2),
(105, '2025-03-18 22:39:16', '2025-04-27 02:39:16', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=107 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(15, 'Mayer', 'Josephine', '03 08 57 77 27', 'vel.arcu@google.net', 2),
(14, 'King', 'Alexis', '06 73 16 62 01', 'nunc.sed@hotmail.ca', 3),
(13, 'Johns', 'Samuel', '07 17 48 54 19', 'aenean.egestas@google.com', 2),
(12, 'Dixon', 'Justina', '09 40 15 02 97', 'semper@protonmail.net', 2),
(11, 'Cruz', 'Aiko', '02 96 42 28 60', 'amet.ornare@outlook.edu', 2),
(10, 'Gilbert', 'Dai', '06 23 36 44 36', 'in.aliquet@google.edu', 3),
(9, 'Manning', 'Tamekah', '02 35 25 21 40', 'pellentesque.massa@google.ca', 3),
(8, 'Weber', 'Lunea', '07 85 63 56 25', 'id.ante@google.com', 2),
(7, 'Ortiz', 'Herrod', '01 19 41 07 15', 'ac@aol.edu', 1),
(6, 'Barrett', 'Addison', '06 06 47 61 54', 'urna.justo@protonmail.edu', 1),
(5, 'Hahn', 'Macy', '06 18 26 76 25', 'eu@hotmail.com', 3),
(4, 'Golden', 'Steven', '05 72 20 74 28', 'integer.in.magna@protonmail.couk', 2),
(3, 'Cameron', 'Mannix', '08 51 31 72 94', 'ac.nulla.in@outlook.ca', 3),
(2, 'Logan', 'Coby', '07 80 38 41 74', 'mollis.duis@google.ca', 3),
(1, 'Gibson', 'Wanda', '03 47 03 56 98', 'turpis@icloud.net', 1),
(105, 'Katsanos', 'Filippos', '00 00 00 00 00', 'fil@aol.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('respo1', 'de23ea85ae8b759a716e07a27d261bb7eb3ebc9447506ce428c832d333cb7ddb');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

--
-- Création des utilisateurs et attribution des privilèges
--
CREATE USER 'respo1'@'localhost' 
IDENTIFIED WITH sha256_password BY 'respoMEDIA86@';
GRANT SELECT, INSERT, UPDATE, DELETE ON *.* TO 'respo1'@'localhost';
ALTER USER 'respo1'@'localhost' REQUIRE NONE WITH MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'respo1'@'localhost';

CREATE USER 'mediatek86'@'localhost' 
IDENTIFIED WITH sha256_password BY 'yZJP]YCuomae)H5k';
GRANT SELECT ON *.* TO 'mediatek86'@'localhost';
ALTER USER 'mediatek86'@'localhost' REQUIRE NONE WITH MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'localhost';
-- --------------------------------------------------------

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
