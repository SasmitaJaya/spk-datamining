-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 22, 2018 at 01:56 PM
-- Server version: 5.6.25
-- PHP Version: 5.5.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `algoritmabayes`
--

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE IF NOT EXISTS `class` (
  `no` int(11) NOT NULL,
  `investasi` varchar(45) DEFAULT NULL,
  `ket` varchar(45) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`no`, `investasi`, `ket`) VALUES
(1, 'c1', 'Ya'),
(2, 'c2', 'Tidak');

-- --------------------------------------------------------

--
-- Stand-in structure for view `class2`
--
CREATE TABLE IF NOT EXISTS `class2` (
`investasi` varchar(45)
,`Jumlah` bigint(21)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `class3`
--
CREATE TABLE IF NOT EXISTS `class3` (
`investasi` varchar(45)
,`jumlah` bigint(21)
,`totaldata` bigint(21)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `classbenar`
--
CREATE TABLE IF NOT EXISTS `classbenar` (
`no` int(11)
,`class` varchar(45)
,`investasi` varchar(45)
,`jumlah` bigint(21)
,`totaldata` bigint(21)
,`total` decimal(24,4)
);

-- --------------------------------------------------------

--
-- Table structure for table `dataawal`
--

CREATE TABLE IF NOT EXISTS `dataawal` (
  `no` int(11) NOT NULL,
  `umur` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `penghasilan` varchar(45) DEFAULT NULL,
  `hutang` varchar(45) DEFAULT NULL,
  `investasi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dataawal`
--

INSERT INTO `dataawal` (`no`, `umur`, `status`, `penghasilan`, `hutang`, `investasi`) VALUES
(1, 'Muda', 'Lajang', 'Sedang', 'Ya', 'Tidak'),
(2, 'Muda', 'Lajang', 'Rendah', 'Ya', 'Tidak'),
(3, 'Muda', 'Lajang', 'Rendah', 'Tidak', 'Ya'),
(4, 'Muda', 'Menikah', 'Sedang', 'Ya', 'Ya'),
(5, 'Muda', 'Menikah', 'Rendah', 'Ya', 'Tidak'),
(6, 'Paruh Baya', 'Lajang', 'Tinggi', 'Ya', 'Tidak'),
(7, 'Paruh Baya', 'Lajang', 'Sedang', 'Ya', 'Tidak'),
(8, 'Paruh Baya', 'Lajang', 'Rendah', 'Tidak', 'Ya'),
(9, 'Paruh Baya', 'Menikah', 'Tinggi', 'Ya', 'Ya'),
(10, 'Paruh Baya', 'Menikah', 'Sedang', 'Ya', 'Ya'),
(11, 'Paruh Baya', 'Menikah', 'Sedang', 'Tidak', 'Ya'),
(12, 'Paruh Baya', 'Menikah', 'Rendah', 'Ya', 'Ya'),
(13, 'Tua', 'Lajang', 'Tinggi', 'Ya', 'Tidak'),
(14, 'Tua', 'Lajang', 'Tinggi', 'Tidak', 'Ya'),
(15, 'Tua', 'Lajang', 'Rendah', 'Tidak', 'Tidak'),
(16, 'Tua', 'Menikah', 'Tinggi', 'Ya', 'Ya'),
(17, 'Tua', 'Menikah', 'Sedang', 'Ya', 'Tidak'),
(18, 'Tua', 'Menikah', 'Sedang', 'Tidak', 'Ya'),
(19, 'Tua', 'Menikah', 'Rendah', 'Ya', 'Tidak');

-- --------------------------------------------------------

--
-- Table structure for table `datasoal`
--

CREATE TABLE IF NOT EXISTS `datasoal` (
  `no` int(11) NOT NULL,
  `umur` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `penghasilan` varchar(45) DEFAULT NULL,
  `hutang` varchar(45) DEFAULT NULL,
  `invstasi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `datasoal`
--

INSERT INTO `datasoal` (`no`, `umur`, `status`, `penghasilan`, `hutang`, `invstasi`) VALUES
(1, 'Muda', 'Lajang', 'Tinggi', 'Ya', ''),
(2, 'Muda', 'Lajang', 'Tinggi', 'Tidak', ''),
(3, 'Muda', 'Lajang', 'Sedang', 'Ya', 'Tidak'),
(4, 'Muda', 'Lajang', 'Sedang', 'Tidak', ''),
(5, 'Muda', 'Lajang', 'Rendah', 'Ya', 'Tidak'),
(6, 'Muda', 'Lajang', 'Rendah', 'Tidak', 'Ya'),
(7, 'Muda', 'Menikah', 'Tinggi', 'Ya', ''),
(8, 'Muda', 'Menikah', 'Tinggi', 'Tidak', ''),
(9, 'Muda', 'Menikah', 'Sedang', 'Ya', 'Ya'),
(10, 'Muda', 'Menikah', 'Sedang', 'Tidak', ''),
(11, 'Muda', 'Menikah', 'Rendah', 'Ya', 'Tidak'),
(12, 'Muda', 'Menikah', 'Rendah', 'Tidak', ''),
(13, 'Paruh Baya', 'Lajang', 'Tinggi', 'Ya', 'Tidak'),
(14, 'Paruh Baya', 'Lajang', 'Tinggi', 'Tidak', ''),
(15, 'Paruh Baya', 'Lajang', 'Sedang', 'Ya', 'Tidak'),
(16, 'Paruh Baya', 'Lajang', 'Sedang', 'Tidak', ''),
(17, 'Paruh Baya', 'Lajang', 'Rendah', 'Ya', ''),
(18, 'Paruh Baya', 'Lajang', 'Rendah', 'Tidak', 'Ya'),
(19, 'Paruh Baya', 'Menikah', 'Tinggi', 'Ya', 'Ya'),
(20, 'Paruh Baya', 'Menikah', 'Tinggi', 'Tidak', ''),
(21, 'Paruh Baya', 'Menikah', 'Sedang', 'Ya', 'Ya'),
(22, 'Paruh Baya', 'Menikah', 'Sedang', 'Tidak', 'Ya'),
(23, 'Paruh Baya', 'Menikah', 'Rendah', 'Ya', 'Ya'),
(24, 'Paruh Baya', 'Menikah', 'Rendah', 'Tidak', ''),
(25, 'Tua', 'Lajang', 'Tinggi', 'Ya', 'Tidak'),
(26, 'Tua', 'Lajang', 'Tinggi', 'Tidak', 'Ya'),
(27, 'Tua', 'Lajang', 'Sedang', 'Ya', ''),
(28, 'Tua', 'Lajang', 'Sedang', 'Tidak', ''),
(29, 'Tua', 'Lajang', 'Rendah', 'Ya', ''),
(30, 'Tua', 'Lajang', 'Rendah', 'Tidak', 'Tidak'),
(31, 'Tua', 'Menikah', 'Tinggi', 'Ya', 'Ya'),
(32, 'Tua', 'Menikah', 'Tinggi', 'Tidak', ''),
(33, 'Tua', 'Menikah', 'Sedang', 'Ya', 'Tidak'),
(34, 'Tua', 'Menikah', 'Sedang', 'Tidak', 'Ya'),
(35, 'Tua', 'Menikah', 'Rendah', 'Ya', 'Tidak'),
(36, 'Tua', 'Menikah', 'Rendah', 'Tidak', '');

-- --------------------------------------------------------

--
-- Stand-in structure for view `jumlahdata`
--
CREATE TABLE IF NOT EXISTS `jumlahdata` (
`Jumlah` bigint(21)
);

-- --------------------------------------------------------

--
-- Structure for view `class2`
--
DROP TABLE IF EXISTS `class2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `class2` AS select `dataawal`.`investasi` AS `investasi`,count(0) AS `Jumlah` from `dataawal` group by `dataawal`.`investasi`;

-- --------------------------------------------------------

--
-- Structure for view `class3`
--
DROP TABLE IF EXISTS `class3`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `class3` AS select `class2`.`investasi` AS `investasi`,`class2`.`Jumlah` AS `jumlah`,`jumlahdata`.`Jumlah` AS `totaldata` from (`class2` join `jumlahdata`);

-- --------------------------------------------------------

--
-- Structure for view `classbenar`
--
DROP TABLE IF EXISTS `classbenar`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `classbenar` AS select `class`.`no` AS `no`,`class`.`investasi` AS `class`,`class3`.`investasi` AS `investasi`,`class3`.`jumlah` AS `jumlah`,`class3`.`totaldata` AS `totaldata`,(`class3`.`jumlah` / `class3`.`totaldata`) AS `total` from (`class` join `class3` on((`class`.`ket` = `class3`.`investasi`)));

-- --------------------------------------------------------

--
-- Structure for view `jumlahdata`
--
DROP TABLE IF EXISTS `jumlahdata`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `jumlahdata` AS select count(`dataawal`.`no`) AS `Jumlah` from `dataawal`;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `dataawal`
--
ALTER TABLE `dataawal`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `datasoal`
--
ALTER TABLE `datasoal`
  ADD PRIMARY KEY (`no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `class`
--
ALTER TABLE `class`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `dataawal`
--
ALTER TABLE `dataawal`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `datasoal`
--
ALTER TABLE `datasoal`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=37;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
