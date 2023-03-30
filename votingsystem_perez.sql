-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-03-2023 a las 19:48:59
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
(1, 'Eduardo Reyes', 'President'),
(2, 'Ysabel Rivera', 'Vice President'),
(3, 'Benigno Tan', 'Secretary'),
(4, 'Emilio Ramos', 'Treasurer'),
(5, 'Ramonito Cruz', 'Auditor'),
(6, 'Trinidad Lopez', 'Public Relations Officer'),
(7, 'Romulo Rodriguez', 'First Year Representative'),
(8, 'Aurora Reyes', 'Second Year Representative'),
(9, 'Manuelito Cruz', 'Third Year Representative'),
(10, 'Domingo Abad', 'Fourth Year Representative'),
(11, 'Eduardo Reyes', 'President'),
(12, 'Rosario Garcia', 'Vice President'),
(13, 'Victoria Reyes', 'Secretary'),
(14, 'Consuelo Cruz', 'Treasurer'),
(15, 'Marcelo Mercado', 'Auditor'),
(16, 'Trinidad Lopez', 'Public Relations Officer'),
(17, 'Romulo Rodriguez', 'First Year Representative'),
(18, 'Ana Luna', 'Second Year Representative'),
(19, 'Rodrigo Flores', 'Third Year Representative'),
(20, 'Angelita Sarmiento', 'Fourth Year Representative');

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
(123456, 'PATRICK', 'PEREZ', 'AGMC', 'BS Information Technology', '3C', 'pat@rick'),
(123457, 'JAY', 'ROLDAN', 'HAROLD', 'BS Secondary Education', '1A', 'rold@roldan'),
(123458, 'JAVE', 'MARTISANO', 'MAR', 'BS Computer Engineering', '4B', 'jave@martisano'),
(123459, 'LIEZEL', 'ASURTO', 'ASURTO', 'BS Entrepreneurship', '1D', 'liezel@azurto'),
(123460, 'HAZELLE', 'CAROLINO', 'CAROLINO', 'BS Business Management', '2B', 'hazelle@carolino');

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
  MODIFY `Candidate_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
