-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 18, 2022 at 08:08 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `votingsystem_perez`
--

-- --------------------------------------------------------

--
-- Table structure for table `candidates`
--

CREATE TABLE `candidates` (
  `Candidate_number` int(11) NOT NULL,
  `full_name` varchar(50) DEFAULT NULL,
  `Position` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `candidates`
--

INSERT INTO `candidates` (`Candidate_number`, `full_name`, `Position`) VALUES
(1, 'Abegail Manayaga', 'President'),
(2, 'Harold Neri', 'Vice President'),
(3, 'Sage Xingchong', 'Secretary'),
(4, 'John Perlt', 'Treasurer'),
(5, 'Capn Tiags', 'Auditor'),
(6, 'Buttercup', 'Public Relations Officer'),
(7, 'Vien lCeste', 'First Year Representative'),
(8, 'Slim Shady', 'Second Year Representative'),
(9, 'Gomes Mabangis', 'Third Year Representative'),
(10, 'Abegail Manayaga', 'President'),
(11, 'Harold Neri', 'Vice President'),
(12, 'Sage Xingchong', 'Secretary'),
(13, 'John Perlt', 'Treasurer'),
(14, 'Capn Tiags', 'Auditor'),
(15, 'Buttercup', 'Public Relations Officer'),
(16, 'Vien lCeste', 'First Year Representative'),
(17, 'Slim Shady', 'Second Year Representative'),
(18, 'Gomes Mabangis', 'Third Year Representative'),
(19, 'Bagtak sa Lamoksi', 'President'),
(20, 'Jay Roa', 'Vice President'),
(21, 'Sage Xingchong', 'Secretary'),
(22, 'Estel Snt', 'Treasurer'),
(23, 'Joshua Ackerman', 'Auditor'),
(24, 'Buttercup', 'Public Relations Officer'),
(25, 'Marvien Lodz', 'First Year Representative'),
(26, 'Adrn Buenaflr', 'Second Year Representative'),
(27, 'Jaecho Loco', 'Third Year Representative'),
(28, 'Bagtak sa Lamoksi', 'President'),
(29, 'Roldan Kugmo', 'Vice President'),
(30, 'Reyna b. Belinda', 'Secretary'),
(31, 'Paps Estel', 'Treasurer'),
(32, 'Joshua Ackerman', 'Auditor'),
(33, 'Blossom', 'Public Relations Officer'),
(34, 'Laceste Mabangiz', 'First Year Representative'),
(35, 'Adrn Buenaflr', 'Second Year Representative'),
(36, 'Gomes Mabangis', 'Third Year Representative'),
(37, 'Bagtak sa Lamoksi', 'President'),
(38, 'Jay Roa', 'Vice President'),
(39, 'Sage Xingchong', 'Secretary'),
(40, 'Estel Snt', 'Treasurer'),
(41, 'Capn Tiags', 'Auditor'),
(42, 'Buttercup', 'Public Relations Officer'),
(43, 'Laceste Mabangiz', 'First Year Representative'),
(44, 'Ian Bonaparte', 'Second Year Representative'),
(45, 'Gomes Mabangis', 'Third Year Representative'),
(46, 'Bagtak sa Lamoksi', 'President'),
(47, 'Harold Neri', 'Vice President'),
(48, 'Sage Xingchong', 'Secretary'),
(49, 'John Perlt', 'Treasurer'),
(50, 'Eggroll Tiagan', 'Auditor'),
(51, 'Buttercup', 'Public Relations Officer'),
(52, 'Marvien Lodz', 'First Year Representative'),
(53, 'Adrn Buenaflr', 'Second Year Representative'),
(54, 'Malangis P. Mabangis', 'Third Year Representative'),
(55, 'Abegail Manayaga', 'President'),
(56, 'Jay Roa', 'Vice President'),
(57, 'Viper Oblak', 'Secretary'),
(58, 'Estel Snt', 'Treasurer'),
(59, 'Capn Tiags', 'Auditor'),
(60, 'Blossom', 'Public Relations Officer'),
(61, 'Vien lCeste', 'First Year Representative'),
(62, 'Ian Bonaparte', 'Second Year Representative'),
(63, 'Gomes Mabangis', 'Third Year Representative'),
(64, 'Tumbleweeds', 'President'),
(65, 'Roldan Kugmo', 'Vice President'),
(66, 'Reyna b. Belinda', 'Secretary'),
(67, 'Paps Estel', 'Treasurer'),
(68, 'Joshua Ackerman', 'Auditor'),
(69, 'Buttercup', 'Public Relations Officer'),
(70, 'Laceste Mabangiz', 'First Year Representative'),
(71, 'Slim Shady', 'Second Year Representative'),
(72, 'Jaecho Loco', 'Third Year Representative'),
(73, 'Bagtak sa Lamoksi', 'President'),
(74, 'Harold Neri', 'Vice President'),
(75, 'Sage Xingchong', 'Secretary'),
(76, 'John Perlt', 'Treasurer'),
(77, 'Eggroll Tiagan', 'Auditor'),
(78, 'Buttercup', 'Public Relations Officer'),
(79, 'Marvien Lodz', 'First Year Representative'),
(80, 'Adrn Buenaflr', 'Second Year Representative'),
(81, 'Malangis P. Mabangis', 'Third Year Representative'),
(82, 'Abegail Manayaga', 'President'),
(83, 'Harold Neri', 'Vice President'),
(84, 'Reyna b. Belinda', 'Secretary'),
(85, 'Estel Snt', 'Treasurer'),
(86, 'Eggroll Tiagan', 'Auditor'),
(87, 'Buttercup', 'Public Relations Officer'),
(88, 'Laceste Mabangiz', 'First Year Representative'),
(89, 'Adrn Buenaflr', 'Second Year Representative'),
(90, 'Gomes Mabangis', 'Third Year Representative'),
(91, 'Bagtak sa Lamoksi', 'President'),
(92, 'Jay Roa', 'Vice President'),
(93, 'Reyna b. Belinda', 'Secretary'),
(94, 'Estel Snt', 'Treasurer'),
(95, 'Eggroll Tiagan', 'Auditor'),
(96, 'Buttercup', 'Public Relations Officer'),
(97, 'Marvien Lodz', 'First Year Representative'),
(98, 'Slim Shady', 'Second Year Representative'),
(99, 'Gomes Mabangis', 'Third Year Representative'),
(100, 'Abegail Manayaga', 'President'),
(101, 'Harold Neri', 'Vice President'),
(102, 'Reyna b. Belinda', 'Secretary'),
(103, 'Estel Snt', 'Treasurer'),
(104, 'Eggroll Tiagan', 'Auditor'),
(105, 'Buttercup', 'Public Relations Officer'),
(106, 'Vien lCeste', 'First Year Representative'),
(107, 'Ian Bonaparte', 'Second Year Representative'),
(108, 'Gomes Mabangis', 'Third Year Representative'),
(109, 'Tumbleweeds', 'President'),
(110, 'Harold Neri', 'Vice President'),
(111, 'Viper Oblak', 'Secretary'),
(112, 'Estel Snt', 'Treasurer'),
(113, 'Eggroll Tiagan', 'Auditor'),
(114, 'Buttercup', 'Public Relations Officer'),
(115, 'Laceste Mabangiz', 'First Year Representative'),
(116, 'Adrn Buenaflr', 'Second Year Representative'),
(117, 'Gomes Mabangis', 'Third Year Representative'),
(118, 'Bagtak sa Lamoksi', 'President'),
(119, 'Jay Roa', 'Vice President'),
(120, 'Reyna b. Belinda', 'Secretary'),
(121, 'John Perlt', 'Treasurer'),
(122, 'Capn Tiags', 'Auditor'),
(123, 'Buttercup', 'Public Relations Officer'),
(124, 'Laceste Mabangiz', 'First Year Representative'),
(125, 'Adrn Buenaflr', 'Second Year Representative'),
(126, 'Jaecho Loco', 'Third Year Representative'),
(127, 'Abegail Manayaga', 'President'),
(128, 'Harold Neri', 'Vice President'),
(129, 'Reyna b. Belinda', 'Secretary'),
(130, 'Estel Snt', 'Treasurer'),
(131, 'Eggroll Tiagan', 'Auditor'),
(132, 'Buttercup', 'Public Relations Officer'),
(133, 'Laceste Mabangiz', 'First Year Representative'),
(134, 'Adrn Buenaflr', 'Second Year Representative'),
(135, 'Gomes Mabangis', 'Third Year Representative'),
(136, 'Bagtak sa Lamoksi', 'President'),
(137, 'Jay Roa', 'Vice President'),
(138, 'Reyna b. Belinda', 'Secretary'),
(139, 'John Perlt', 'Treasurer'),
(140, 'Capn Tiags', 'Auditor'),
(141, 'Buttercup', 'Public Relations Officer'),
(142, 'Laceste Mabangiz', 'First Year Representative'),
(143, 'Slim Shady', 'Second Year Representative'),
(144, 'Jaecho Loco', 'Third Year Representative'),
(145, 'Abegail Manayaga', 'President'),
(146, 'Harold Neri', 'Vice President'),
(147, 'Reyna b. Belinda', 'Secretary'),
(148, 'John Perlt', 'Treasurer'),
(149, 'Joshua Ackerman', 'Auditor'),
(150, 'Blossom', 'Public Relations Officer'),
(151, 'Marvien Lodz', 'First Year Representative'),
(152, 'Slim Shady', 'Second Year Representative'),
(153, 'Gomes Mabangis', 'Third Year Representative');

-- --------------------------------------------------------

--
-- Table structure for table `party_list`
--

CREATE TABLE `party_list` (
  `Partylist_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `party_list`
--

INSERT INTO `party_list` (`Partylist_name`) VALUES
('Manayaganda Partylist'),
('Manayaganda Partylist'),
('Allan 10k Partylist'),
('Ako Hakdogg Partylist'),
('Manayaganda Partylist'),
('Allan 10k Partylist'),
('Manayaganda Partylist'),
('Ako Hakdogg Partylist'),
('Ako Hakdogg Partylist'),
('Ako Hakdogg Partylist'),
('Manayaganda Partylist'),
('Manayaganda Partylist'),
('Ako Hakdogg Partylist'),
('Manayaganda Partylist'),
('Manayaganda Partylist'),
('Ako Hakdogg Partylist'),
('Manayaganda Partylist');

-- --------------------------------------------------------

--
-- Table structure for table `voters`
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
-- Dumping data for table `voters`
--

INSERT INTO `voters` (`Student_number`, `First_name`, `Last_name`, `Middle_name`, `Course`, `Year`, `Email`) VALUES
(12, 'Juan', 'de la Cruz', 'Tamad', 'BSIT', '1c', 'walasyang@email.com'),
(201, 'Mang', 'Juan', 'J', 'BSED', '2a', 'ewanko2email.com'),
(202, 'Reznov', 'Bangiz', 'Ma', 'BSED', '2c', 'reznov@email.com'),
(203, 'Pedro', 'Duko', 'Pen', 'BSBA', '3a', 'pedrokolokoy@email.com'),
(204, 'Bagtak', 'Bullfrog', 'Na', 'BSIT', '3b', 'bagtakyawa@email.com'),
(205, 'Big', 'Lee', 'Smile', 'BSED', '1d', 'saycheese@email.com'),
(206, 'Sun', 'Zen', 'Yat', 'BSIT', '2i', 'drsunyatzen@email.com'),
(207, 'Jose', 'Tama', 'Lakas', 'BSBA', '2a', 'joselakasamats@email.com'),
(208, 'Trinidad', 'Molina', 'Guevarra', 'BSED', '1a', 'trinidadgmolina@email.com'),
(209, 'Jimmy', 'Rabbit', 'B', 'BSIT', '1c', 'jbrabbit@email.com'),
(210, 'Uzu', 'Naruto', 'Maki', 'BSIT', '2a', 'uzumimak@email.com'),
(211, 'Sponge', 'Bob', 'Cola', 'BSBA', '1b', 'yellowsponge@email.com'),
(212, 'Johny', 'Bravo', 'Haha', 'BSIT', '2i', 'emailko@email.com'),
(213, 'Oh', 'Ver', 'Lee', 'BSED', '2c', 'dikaiiwan@email.com'),
(321, 'Brim', 'Stone', 'Sulfur', 'BSIT', '1d', 'walaring@email.com'),
(402, 'John Patrick', 'Perez', 'de Guevarra-Molina Cruz y', 'BSIT', '2i', 'jpperez077@tutanota.de'),
(73739, 'Jp', 'Zerep', 'Amaranto', 'BSIT', '2i', 'jpperez077@outlook.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `candidates`
--
ALTER TABLE `candidates`
  ADD PRIMARY KEY (`Candidate_number`);

--
-- Indexes for table `voters`
--
ALTER TABLE `voters`
  ADD PRIMARY KEY (`Student_number`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `candidates`
--
ALTER TABLE `candidates`
  MODIFY `Candidate_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=154;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
