-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-03-2023 a las 21:10:32
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `votingsystem_perez`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `candidates`
--

CREATE TABLE `candidates` (
  `Candidate_number` int(11) NOT NULL,
  `full_name` varchar(50) DEFAULT NULL,
  `Position` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `candidates`
--

INSERT INTO `candidates` (`Candidate_number`, `full_name`, `Position`) VALUES
(1, 'Abegail Manayaga', 'President'),
(2, 'Jay Roa', 'Vice President'),
(3, 'Viper Oblak', 'Secretary'),
(4, 'Estel Snt', 'Treasurer'),
(5, 'Capn Tiags', 'Auditor'),
(6, 'Blossom', 'Public Relations Officer'),
(7, 'Vien lCeste', 'First Year Representative'),
(8, 'Ian Bonaparte', 'Second Year Representative'),
(9, 'Gomes Mabangis', 'Third Year Representative'),
(10, 'Ja Ve', 'Fourth Year Representative'),
(11, 'Abegail Manayaga', 'President'),
(12, 'Harold Neri', 'Vice President'),
(13, 'Viper Oblak', 'Secretary'),
(14, 'Paps Estel', 'Treasurer'),
(15, 'Capn Tiags', 'Auditor'),
(16, 'Bubbles', 'Public Relations Officer'),
(17, 'Laceste Mabangiz', 'First Year Representative'),
(18, 'Ian Bonaparte', 'Second Year Representative'),
(19, 'Malangis P. Mabangis', 'Third Year Representative'),
(20, 'Jave Martisano', 'Fourth Year Representative'),
(21, 'Abegail Manayaga', 'President'),
(22, 'Roldan Kugmo', 'Vice President'),
(23, 'Sage Xingchong', 'Secretary'),
(24, 'Estel Snt', 'Treasurer'),
(25, 'Capn Tiags', 'Auditor'),
(26, 'Blossom', 'Public Relations Officer'),
(27, 'Laceste Mabangiz', 'First Year Representative'),
(28, 'Slim Shady', 'Second Year Representative'),
(29, 'Malangis P. Mabangis', 'Third Year Representative'),
(30, 'Ja Ve', 'Fourth Year Representative'),
(31, '', ''),
(32, '', ''),
(33, '', ''),
(34, '', ''),
(35, '', ''),
(36, '', ''),
(37, '', ''),
(38, '', ''),
(39, '', ''),
(40, '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `voters`
--

CREATE TABLE `voters` (
  `Student_number` int(11) NOT NULL,
  `First_name` varchar(50) NOT NULL,
  `Last_name` varchar(50) NOT NULL,
  `Middle_name` varchar(50) NOT NULL,
  `Course` varchar(50) NOT NULL,
  `Year` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `voters`
--

INSERT INTO `voters` (`Student_number`, `First_name`, `Last_name`, `Middle_name`, `Course`, `Year`, `Email`) VALUES
(0, '', '', '', '', '', ''),
(123456, 'PATRICK', 'PEREZ', 'AGMC', 'BSIT', '3F', 'pat@rick'),
(123457, 'JAY', 'ROLDAN', 'HAROLD', 'BSIT', '3F', 'rold@roldan'),
(123458, 'JAVE', 'MARTISANO', 'MAR', 'BSIT', '3F', 'jave@martisano'),
(123459, 'LIEZEL', 'ASURTO', 'ASURTO', 'BSIT', '3F', 'liezel@azurto'),
(123460, 'HAZELLE', 'CAROLINO', 'CAROLINO', 'BSIT', '3F', 'hazelle@carolino');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `candidates`
--
ALTER TABLE `candidates`
  ADD PRIMARY KEY (`Candidate_number`);

--
-- Indices de la tabla `voters`
--
ALTER TABLE `voters`
  ADD PRIMARY KEY (`Student_number`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `candidates`
--
ALTER TABLE `candidates`
  MODIFY `Candidate_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
