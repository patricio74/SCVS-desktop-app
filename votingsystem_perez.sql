-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-03-2023 a las 06:02:47
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
(1, 'Tumbleweeds', 'President'),
(2, 'Roldan Kugmo', 'Vice President'),
(3, 'Sage Xingchong', 'Secretary'),
(4, 'Paps Estel', 'Treasurer'),
(5, 'Capn Tiags', 'Auditor'),
(6, 'Blossom', 'Public Relations Officer'),
(7, 'Laceste Mabangiz', 'First Year Representative'),
(8, '', ''),
(9, 'Malangis P. Mabangis', 'Third Year Representative'),
(10, 'Jave Martisano', 'Fourth Year Representative'),
(11, 'Tumbleweeds', 'President'),
(12, 'Roldan Kugmo', 'Vice President'),
(13, 'Reyna B. Belinda', 'Secretary'),
(14, 'Paps Estel', 'Treasurer'),
(15, 'Capn Tiags', 'Auditor'),
(16, 'Blossom', 'Public Relations Officer'),
(17, 'Marvien Lodz', 'First Year Representative'),
(18, 'Adrn Buenaflr', 'Second Year Representative'),
(19, 'Malangis P. Mabangis', 'Third Year Representative'),
(20, 'Mar T. Sano', 'Fourth Year Representative'),
(21, 'Tumbleweeds', 'President'),
(22, 'Roldan Kugmo', 'Vice President'),
(23, 'Reyna B. Belinda', 'Secretary'),
(24, 'Paps Estel', 'Treasurer'),
(25, 'Joshua Ackerman', 'Auditor'),
(26, 'Blossom', 'Public Relations Officer'),
(27, 'Laceste Mabangiz', 'First Year Representative'),
(28, 'Slim Shady', 'Second Year Representative'),
(29, 'Jaecho Loco', 'Third Year Representative'),
(30, 'Jave Martisano', 'Fourth Year Representative');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `voters`
--

CREATE TABLE `voters` (
  `Student_number` int(11) NOT NULL,
  `First_name` varchar(50) DEFAULT NULL,
  `Last_name` varchar(50) DEFAULT NULL,
  `Middle_name` varchar(50) DEFAULT NULL,
  `Course` varchar(50) DEFAULT NULL,
  `Year` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `voters`
--

INSERT INTO `voters` (`Student_number`, `First_name`, `Last_name`, `Middle_name`, `Course`, `Year`, `Email`) VALUES
(12, 'JUAN', 'DE LA CRUZ', 'TAMAD', 'BSIT', '1D', 'walasyang@email.com'),
(132, 'PAT', 'PERZ', 'RIC', 'BSIT', '3F', 'agasf@gmail.com'),
(201, 'MANG', 'JUAN', 'J', 'BSED', '2A', 'ewanko2email.com'),
(202, 'REZNOV', 'BANGIZ', 'MA', 'BSED', '2C', 'reznov@email.com'),
(203, 'PEDRO', 'DUKO', 'PEN', 'BSBA', '3A', 'pedrokolokoy@email.com'),
(205, 'BIG', 'LEE', 'SMILE', 'BSED', '4A', 'saycheese@email.com'),
(206, 'SUN', 'ZEN', 'YAT', 'BSIT', '4I', 'drsunyatzen@email.com'),
(207, 'JOSE', 'TAMA', 'LAKAS', 'BSBA', '2A', 'joselakasamats@email.com'),
(208, 'TRINIDAD', 'MOLINA', 'GUEVARRA', 'BSED', '1A', 'trinidadgmolina@email.com'),
(209, 'JIMMY', 'RABBIT', 'B', 'BSIT', '1C', 'jbrabbit@email.com'),
(321, 'BRIM', 'STONE', 'SULFUR', 'BSIT', '1D', 'walaring@email.com'),
(402, 'JOHN PATRICK', 'PEREZ', 'DE GUEVARRA-MOLINA CRUZ Y', 'BSIT', '2I', 'jpperez077@tutanota.de'),
(73739, 'JP', 'ZEREP', 'A', 'BSIT', '2I', 'jpperez077@outlook.com');

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
  MODIFY `Candidate_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
