-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 28-03-2024 a las 14:51:47
-- Versión del servidor: 8.3.0
-- Versión de PHP: 8.1.2-1ubuntu2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `scvs_perez`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `admin`
--

CREATE TABLE `admin` (
  `admin_id` int NOT NULL,
  `rfid` varchar(10) DEFAULT NULL,
  `email` varchar(25) NOT NULL,
  `pword` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `firstname` varchar(25) NOT NULL,
  `middlename` varchar(25) NOT NULL,
  `lastname` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `admin`
--

INSERT INTO `admin` (`admin_id`, `rfid`, `email`, `pword`, `firstname`, `middlename`, `lastname`) VALUES
(1, '0015847422', 'pat@rick', 'p3rez', 'JOHN', 'PATRICK', 'PEREZ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `candidate`
--

CREATE TABLE `candidate` (
  `candid_id` int NOT NULL,
  `candid_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `candid_position` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `candidate`
--

INSERT INTO `candidate` (`candid_id`, `candid_name`, `candid_position`) VALUES
(1, 'JUAN DE LA CRUZ', 'PRESIDENT'),
(2, 'MARIA CRUZ', 'PRESIDENT'),
(3, 'EDUARDO REYES', 'PRESIDENT'),
(4, 'ROSARIO GARCIA', 'VICE PRESIDENT'),
(5, 'FERDINAND LIM', 'VICE PRESIDENT'),
(6, 'YSABEL RIVERA', 'VICE PRESIDENT'),
(7, 'BENIGNO TAN', 'SECRETARY'),
(8, 'VICTORIA REYES', 'SECRETARY'),
(9, 'RAFAELA VILLANUEVA', 'SECRETARY'),
(10, 'JOSEFA ALCANTARA', 'TREASURER'),
(11, 'EMILIO RAMOS', 'TREASURER'),
(12, 'CONSUELO CRUZ', 'TREASURER'),
(13, 'MARCELO MERCADO', 'AUDITOR'),
(14, 'PAZ HERRERA', 'AUDITOR'),
(15, 'RAMONITO CRUZ', 'AUDITOR'),
(16, 'TRINIDAD LOPEZ', 'PUBLIC RELATIONS OFFICER'),
(17, 'MARCELINA REYES', 'PUBLIC RELATIONS OFFICER'),
(18, 'RICARDO DE LA CRUZ', 'PUBLIC RELATIONS OFFICER'),
(19, 'ROMULO RODRIGUEZ', 'FIRST YEAR REPRESENTATIVE'),
(20, 'ESPERANZA GONZALES', 'FIRST YEAR REPRESENTATIVE'),
(21, 'FELIPE CRUZ', 'FIRST YEAR REPRESENTATIVE'),
(22, 'ANA LUNA', 'SECOND YEAR REPRESENTATIVE'),
(23, 'GREGORIO SANTOS', 'SECOND YEAR REPRESENTATIVE'),
(24, 'AURORA REYES', 'SECOND YEAR REPRESENTATIVE'),
(25, 'MANUELITO CRUZ', 'THIRD YEAR REPRESENTATIVE'),
(26, 'LOURDES DE LA CRUZ', 'THIRD YEAR REPRESENTATIVE'),
(27, 'RODRIGO FLORES', 'THIRD YEAR REPRESENTATIVE'),
(28, 'GLORIA SANCHEZ', 'FOURTH YEAR REPRESENTATIVE'),
(29, 'DOMINGO ABAD', 'FOURTH YEAR REPRESENTATIVE'),
(30, 'ANGELITA SARMIENTO', 'FOURTH YEAR REPRESENTATIVE'),
(35, 'HAHAHA', 'FOURTH YEAR REPRESENTATIVE'),
(36, 'JUAN DE LA CRUZ', 'THIRD YEAR REPRESENTATIVE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `election`
--

CREATE TABLE `election` (
  `election_id` int NOT NULL,
  `election_name` varchar(50) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `student`
--

CREATE TABLE `student` (
  `user_id` int NOT NULL,
  `rfid` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `firstname` varchar(25) NOT NULL,
  `middlename` varchar(25) NOT NULL,
  `lastname` varchar(25) NOT NULL,
  `course` varchar(50) NOT NULL,
  `yrsec` varchar(25) NOT NULL,
  `email` varchar(25) NOT NULL,
  `pword` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `phone_number` varchar(13) DEFAULT NULL,
  `votestatus` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `student`
--

INSERT INTO `student` (`user_id`, `rfid`, `firstname`, `middlename`, `lastname`, `course`, `yrsec`, `email`, `pword`, `phone_number`, `votestatus`) VALUES
(23001, '0015847422', 'JOHN', 'PATRICK', 'PEREZ', 'BS INFORMATION TECHNOLOGY', '4A', 'pat@rick', 'p3rez', '+639231231234', 'voted'),
(23002, '2222222222', 'JA', 'VE', 'MARTISANO', 'BS COMPUTER ENGINEERING', '1A', 'ja@ve', 'martisano', NULL, 'voted'),
(23003, '3333333333', 'JAY ', 'HAROLD', 'ROLD', 'BS ELEMENTARY EDUCATION', '1B', 'ha@rold', 'roldan', NULL, NULL),
(23004, '4444444444', 'HAHAHA', 'HEHEHE', 'HIHIHI', 'BS SECONDARY EDUCATION', '3F', 'hah@ha', 'hehehe', NULL, NULL),
(23005, '5555555555', 'JOSE', 'P', 'RIZZ', 'BS BUSINESS MANAGEMENT', '4A', 'jo@se', 'jrizz', NULL, 'voted'),
(23006, '7777777777', 'JUAN', 'DE LA', 'CRUZ', 'BS INFORMATION TECHNOLOGY', '3E', 'jdlcroix', 'croixword', NULL, 'voted'),
(23007, '8888888888', 'HAHAHAHAHA', 'AHAAAAAAHHHHHHHHHHHHHHHHH', 'AHAHAHA', 'BS COMPUTER ENGINEERING', '2A', 'hahaha@haha', 'hahahaha', NULL, NULL),
(23008, '9999900000', 'JOHN', 'PATR', 'PERE', 'BS INFORMATION TECHNOLOGY', '1A', 'perez', 'perez', NULL, NULL),
(23009, '9999990090', 'PAT', 'RICC', 'ZEREP', 'BS COMPUTER ENGINEERING', '1B', 'jp@p3rez', 'jP_123zereP', NULL, 'voted'),
(23010, '1239123912', 'JUAN', 'DE LA', 'CRUZZ', 'BS INFORMATION TECHNOLOGY', '1A', 'jdl@cruz', 'dlcruZjuaN23', '+639231231231', 'voted'),
(23011, '1233121233', 'BIG', 'SMILE', 'LEE', 'BS COMPUTER ENGINEERING', '2B', 'smile@lee', 'bslee', '+639281234124', 'voted'),
(23012, '9879898779', 'JOHN', 'ESTEL', 'PERLT', 'BS INFORMATION TECHNOLOGY', '4D', 'je@perlt', 'perlt', '+639281231231', NULL),
(23013, '1233333333', 'ABEGAIL', 'MANA', 'YAGA', 'BS INFORMATION TECHNOLOGY', '4D', 'manayaga@bee', 'manayaga', '+639081242141', NULL),
(23014, '1243334444', 'JOSHUA', 'ALEJANDRO', 'TIAGAN', 'BS INFORMATION TECHNOLOGY', '4D', 'jo@shua', 'tiagan', '+639213423432', NULL),
(23015, '1231231231', 'JUDE', 'THADEUZ', 'RICAFORT', 'BS INFORMATION TECHNOLOGY', '4D', 'judy@yow', 'ricafort', '+639081231231', NULL),
(23016, NULL, 'AKO', 'SI', 'PATRICK', 'BS INFORMATION TECHNOLOGY', '1A', 'pat@riccc', 'p3rezzz', '+639081234567', NULL),
(23017, NULL, 'J', 'P', 'ZEREP', 'BS INFORMATION TECHNOLOGY', '1A', 'p@tricio', '', '+639081234567', NULL),
(23018, NULL, 'AB', 'CD', 'EF', 'BS INFORMATION TECHNOLOGY', '1A', 'haha', 'hehe', '09081234123', NULL),
(23019, NULL, 'ONE', 'TWO', 'THREE', 'BS INFORMATION TECHNOLOGY', '3F', 'aaaa@aaaa', 'AAAAAAAAAAAAA', '09181716151', NULL),
(23020, NULL, 'PAT', 'RICK', 'PERZ', 'BS INFORMATION TECHNOLOGY', '1A', 'usern@me', 'PASSWORD', '+639282131231', NULL),
(23022, NULL, 'AB', 'CD', 'EF', 'BS INFORMATION TECHNOLOGY', '1A', 'haha', 'hehe', '09081234123', NULL),
(23023, NULL, 'TRINIDAD', 'XD', 'GUEVARRA', 'BS BUSINESS MANAGEMENT', '4D', 'trinid@d', 'molina', '+639081233212', NULL),
(23024, NULL, 'CARMEN', 'GUEVARRA', 'MOLINA', 'BS ENTREPRENEURSHIP', '3A', 'carmen', 'moli', '09880987567', NULL),
(23025, NULL, 'AAA', 'BBB', 'CCC', 'BS INFORMATION TECHNOLOGY', '1A', 'dddd', 'eeee', '09909090909', 'voted'),
(23026, NULL, 'ABCD', 'ABCD', 'ABCD', 'BS INFORMATION TECHNOLOGY', '1A', 'abc@d', 'abcd', '09090909099', NULL),
(23027, NULL, 'AAA', 'BBB', 'CCC', 'BS INFORMATION TECHNOLOGY', '1A', 'dddd', 'eeeef', '09909090909', NULL),
(23028, NULL, 'ABCDEF', 'QWERTY', 'ZXCVB', 'BS INFORMATION TECHNOLOGY', '1A', 'hhahahaa', 'wasdwasd', '09099090987', NULL),
(23029, NULL, 'WASD', 'WASD', 'WASD', 'BS INFORMATION TECHNOLOGY', '1A', 'wasd', 'wasd', '+639081234321', NULL),
(23030, '0980980980', 'SECRET ', 'OPO', 'MEDYO', 'BS INFORMATION TECHNOLOGY', '1A', 'pogiako123@gmail.com', 'hahasecret', '091233444455', NULL),
(23031, '124231231', 'DSADSAD', 'ASDASDSA', 'ADSADSA', 'BS INFORMATION TECHNOLOGY', '4A', '232323', '2323', '+632323232323', NULL),
(23032, '121213', 'ASDASDA', 'ASDASDSAD', 'ASDASD', 'BS ELEMENTARY EDUCATION', '3F', 'javepogi', '1234', '+632222222222', NULL),
(23033, '1221121', 'ASDASD', 'SDASDSAD', 'DSDASDSWA', 'BS ELEMENTARY EDUCATION', '4B', 'javepogi', '1234', '+631212121212', NULL),
(23034, '-', 'LOUIE', 'TU', 'BOLSKI', 'BS INFORMATION TECHNOLOGY', '1D', 'wasdwasd', 'wasdwasd', '09286551967', 'voted'),
(23035, '1', 'PAT', 'RI', 'CKPRZ', 'BS INFORMATION TECHNOLOGY', '3F', 'patrick@zerep', 'zerep', '+639929082009', 'voted'),
(23036, '2', 'J', 'DL', 'CRUZ', 'BS COMPUTER ENGINEERING', '3C', 'hahahaha', 'hahahaha', '+639929082009', NULL),
(23037, '321', 'JP', 'A', 'ZEREP', 'BS INFORMATION TECHNOLOGY', '1A', 'p@trick', 'p@trick', '+639929082009', NULL),
(23038, '123456789', 'JOANNE', 'PUYO', 'GALLARTE', 'BS INFORMATION TECHNOLOGY', '3F', 'jetrallag@gmail.com', 'JoanneGallarte', '+639610864152', NULL),
(23039, '0015849594', 'NICZ', 'M', 'NDRN', 'BS INFORMATION TECHNOLOGY', '1D', 'nicz@nicz', 'nicz', '+639504300815', NULL),
(23040, '0015851747', 'NICKY', 'M', 'SLENDRINA', 'BS INFORMATION TECHNOLOGY', '1D', 'nicz@mndrn', 'nicz', '+639504300815', NULL),
(23041, '0015937458', 'PATRICK', 'AASFASDVAX', 'ZEREP', 'BS COMPUTER ENGINEERING', '3F', 'patrick@zerep', 'zerep', '+639929082009', NULL),
(23042, '0015807818', 'JP', 'A', 'PEREZ', 'BS COMPUTER ENGINEERING', '4A', 'awsf', 'awsd', '+639929082009', 'voted'),
(23043, NULL, 'J', 'P', 'PEREZ', 'BS INFORMATION TECHNOLOGY', '1A', 'perezz', 'perezz', '12345678901', NULL),
(23044, NULL, 'EY', 'EY', 'EY', 'BS COMPUTER ENGINEERING', '3E', 'ey@gmail.com', 'EY', '09123456789', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vote`
--

CREATE TABLE `vote` (
  `vote_id` int NOT NULL,
  `candid_id` int NOT NULL,
  `election_id` int DEFAULT NULL,
  `user_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `vote`
--

INSERT INTO `vote` (`vote_id`, `candid_id`, `election_id`, `user_id`) VALUES
(1, 2, NULL, 23001),
(2, 5, NULL, 23001),
(3, 8, NULL, 23001),
(4, 17, NULL, 23001),
(5, 14, NULL, 23001),
(6, 11, NULL, 23001),
(7, 20, NULL, 23001),
(8, 23, NULL, 23001),
(9, 26, NULL, 23001),
(10, 29, NULL, 23001),
(11, 2, NULL, 23001),
(12, 5, NULL, 23001),
(13, 2, NULL, 23001),
(14, 5, NULL, 23001),
(15, 8, NULL, 23001),
(16, 16, NULL, 23001),
(17, 13, NULL, 23001),
(18, 12, NULL, 23001),
(19, 19, NULL, 23001),
(20, 24, NULL, 23001),
(21, 26, NULL, 23001),
(22, 29, NULL, 23001),
(23, 2, NULL, 23001),
(24, 5, NULL, 23001),
(25, 8, NULL, 23001),
(26, 17, NULL, 23001),
(27, 14, NULL, 23001),
(28, 11, NULL, 23001),
(29, 20, NULL, 23001),
(30, 23, NULL, 23001),
(31, 26, NULL, 23001),
(32, 29, NULL, 23001),
(33, 2, NULL, 23001),
(34, 5, NULL, 23001),
(35, 8, NULL, 23001),
(36, 14, NULL, 23001),
(37, 11, NULL, 23001),
(38, 17, NULL, 23001),
(39, 23, NULL, 23001),
(40, 26, NULL, 23001),
(41, 20, NULL, 23001),
(42, 35, NULL, 23001),
(46, 35, NULL, 23001),
(47, 22, NULL, 23001),
(48, 2, NULL, 23001),
(49, 4, NULL, 23001),
(50, 8, NULL, 23001),
(51, 17, NULL, 23001),
(52, 14, NULL, 23001),
(53, 11, NULL, 23001),
(54, 20, NULL, 23001),
(55, 26, NULL, 23001),
(56, 2, NULL, 23001),
(57, 6, NULL, 23001),
(58, 7, NULL, 23001),
(59, 17, NULL, 23001),
(60, 13, NULL, 23001),
(61, 12, NULL, 23001),
(62, 20, NULL, 23001),
(63, 24, NULL, 23001),
(64, 27, NULL, 23001),
(65, 30, NULL, 23001),
(66, 35, NULL, 23001),
(67, 2, NULL, 23016),
(68, 6, NULL, 23016),
(69, 7, NULL, 23016),
(70, 10, NULL, 23016),
(71, 13, NULL, 23016),
(72, 17, NULL, 23016),
(73, 21, NULL, 23016),
(74, 22, NULL, 23016),
(75, 36, NULL, 23016),
(76, 35, NULL, 23016),
(77, 2, NULL, 23016),
(78, 6, NULL, 23016),
(79, 7, NULL, 23016),
(80, 10, NULL, 23016),
(81, 13, NULL, 23016),
(82, 17, NULL, 23016),
(83, 21, NULL, 23016),
(84, 22, NULL, 23016),
(85, 36, NULL, 23016),
(86, 35, NULL, 23016),
(87, 2, NULL, 23016),
(88, 6, NULL, 23016),
(89, 7, NULL, 23016),
(90, 10, NULL, 23016),
(91, 13, NULL, 23016),
(92, 17, NULL, 23016),
(93, 21, NULL, 23016),
(94, 22, NULL, 23016),
(95, 36, NULL, 23016),
(96, 35, NULL, 23016),
(97, 1, NULL, 23016),
(98, 4, NULL, 23016),
(99, 8, NULL, 23016),
(100, 12, NULL, 23016),
(101, 15, NULL, 23016),
(102, 16, NULL, 23016),
(103, 19, NULL, 23016),
(104, 24, NULL, 23016),
(105, 25, NULL, 23016),
(106, 28, NULL, 23016),
(107, 1, NULL, 23016),
(108, 4, NULL, 23016),
(109, 8, NULL, 23016),
(110, 12, NULL, 23016),
(111, 2, NULL, 23016),
(112, 35, NULL, 23016),
(113, 35, NULL, 23016),
(114, 35, NULL, 23025),
(116, 23, NULL, 23034),
(117, 11, NULL, 23034),
(118, 13, NULL, 23034),
(119, 17, NULL, 23034),
(120, 8, NULL, 23034),
(121, 5, NULL, 23034),
(122, 1, NULL, 23034),
(123, 21, NULL, 23034),
(124, 28, NULL, 23034),
(125, 3, NULL, 23035),
(126, 4, NULL, 23035),
(127, 9, NULL, 23035),
(128, 18, NULL, 23035),
(129, 25, NULL, 23035),
(130, 22, NULL, 23035),
(131, 15, NULL, 23035),
(132, 11, NULL, 23035),
(133, 19, NULL, 23035),
(134, 28, NULL, 23035),
(135, 15, NULL, 23035),
(136, 11, NULL, 23035),
(137, 17, NULL, 23035),
(138, 8, NULL, 23035),
(139, 4, NULL, 23035),
(140, 3, NULL, 23035),
(141, 22, NULL, 23035),
(142, 19, NULL, 23035),
(143, 25, NULL, 23035),
(144, 28, NULL, 23035),
(145, 19, NULL, 23035),
(146, 35, NULL, 23035),
(147, 35, NULL, 23035),
(148, 1, NULL, 23035),
(149, 4, NULL, 23035),
(150, 8, NULL, 23035),
(151, 17, NULL, 23035),
(152, 14, NULL, 23035),
(153, 11, NULL, 23035),
(154, 19, NULL, 23035),
(155, 23, NULL, 23035),
(156, 26, NULL, 23035),
(157, 29, NULL, 23035),
(158, 1, NULL, 23036),
(159, 5, NULL, 23036),
(160, 8, NULL, 23036),
(161, 2, NULL, 23001),
(162, 24, NULL, 23001),
(163, 26, NULL, 23001),
(164, 3, NULL, 23042),
(165, 5, NULL, 23042),
(166, 8, NULL, 23042),
(167, 11, NULL, 23042),
(168, 13, NULL, 23042),
(169, 17, NULL, 23042),
(170, 20, NULL, 23042),
(171, 23, NULL, 23042);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indices de la tabla `candidate`
--
ALTER TABLE `candidate`
  ADD PRIMARY KEY (`candid_id`);

--
-- Indices de la tabla `election`
--
ALTER TABLE `election`
  ADD PRIMARY KEY (`election_id`);

--
-- Indices de la tabla `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`user_id`);

--
-- Indices de la tabla `vote`
--
ALTER TABLE `vote`
  ADD PRIMARY KEY (`vote_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `election_id` (`election_id`),
  ADD KEY `candid_id` (`candid_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `candidate`
--
ALTER TABLE `candidate`
  MODIFY `candid_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de la tabla `election`
--
ALTER TABLE `election`
  MODIFY `election_id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `student`
--
ALTER TABLE `student`
  MODIFY `user_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23045;

--
-- AUTO_INCREMENT de la tabla `vote`
--
ALTER TABLE `vote`
  MODIFY `vote_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=172;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `vote`
--
ALTER TABLE `vote`
  ADD CONSTRAINT `vote_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `student` (`user_id`),
  ADD CONSTRAINT `vote_ibfk_2` FOREIGN KEY (`election_id`) REFERENCES `election` (`election_id`),
  ADD CONSTRAINT `vote_ibfk_3` FOREIGN KEY (`candid_id`) REFERENCES `candidate` (`candid_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
