-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 18, 2019 at 06:45 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `penjualan_roti`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `user` varchar(20) NOT NULL,
  `pass` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`user`, `pass`) VALUES
('admin', 'c4ca4238a0b923820dcc509a6f75849b');

-- --------------------------------------------------------

--
-- Table structure for table `tb_barang`
--

CREATE TABLE `tb_barang` (
  `kd_barang` int(6) NOT NULL,
  `nama_barang` varchar(25) NOT NULL,
  `kadaluarsa` date NOT NULL,
  `stok` int(3) NOT NULL,
  `harga` int(5) NOT NULL,
  `harga_beli` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_barang`
--

INSERT INTO `tb_barang` (`kd_barang`, `nama_barang`, `kadaluarsa`, `stok`, `harga`, `harga_beli`) VALUES
(1, 'roti keju', '2019-05-01', 1, 2000, 1000),
(2, 'roti melon', '2019-05-09', 0, 6000, 3000),
(3, 'Roti SAAYA', '2019-08-24', 27, 1000, 800),
(4, 'Roti campur', '2019-07-04', 15, 10000, 7000),
(5, 'Roti-roti', '2019-06-06', 0, 1000, 600),
(7, 'Yakisoba', '2019-05-14', 12, 7000, 0),
(8, 'roti buaya', '2019-06-20', 20, 100000, 50000),
(9, 'roti biasa', '2019-06-20', 50, 20000, 10000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_beli`
--

CREATE TABLE `tb_beli` (
  `id_beli` varchar(10) NOT NULL,
  `tgl_beli` date NOT NULL,
  `id_karyawan` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_beli`
--

INSERT INTO `tb_beli` (`id_beli`, `tgl_beli`, `id_karyawan`) VALUES
('KB-001', '2019-05-29', ''),
('KB-002', '2019-05-29', ''),
('KB-003', '2019-06-01', 'KAR00'),
('KB-004', '2019-06-01', ''),
('KB-005', '2019-06-01', ''),
('KB-006', '2019-06-01', ''),
('KB-007', '2019-06-01', ''),
('KB-008', '2019-06-14', ''),
('KB-009', '2019-06-14', ''),
('KB-010', '2019-06-14', ''),
('KB-011', '2019-06-19', ''),
('KB-012', '2019-06-19', ''),
('KB-013', '2019-06-19', ''),
('KB-014', '2019-06-19', ''),
('KB-015', '2019-06-20', 'KAR00'),
('KB-016', '2019-06-20', 'KAR00');

-- --------------------------------------------------------

--
-- Table structure for table `tb_dtlbeli`
--

CREATE TABLE `tb_dtlbeli` (
  `id_dtlbeli` int(10) NOT NULL,
  `id_beli` varchar(10) NOT NULL,
  `kd_barang` int(6) NOT NULL,
  `total_harga` int(6) NOT NULL,
  `jumlah_beli` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_dtlbeli`
--

INSERT INTO `tb_dtlbeli` (`id_dtlbeli`, `id_beli`, `kd_barang`, `total_harga`, `jumlah_beli`) VALUES
(24, 'KB-013', 1, 3000, 3),
(25, 'KB-014', 2, 3000, 2),
(26, 'KB-014', 3, 1600, 2),
(27, 'KB-015', 2, 6000, 2),
(28, 'KB-015', 2, 6000, 2),
(29, 'KB-016', 2, 150000, 50);

-- --------------------------------------------------------

--
-- Table structure for table `tb_dtltransaksi`
--

CREATE TABLE `tb_dtltransaksi` (
  `id_dtltransaksi` int(5) NOT NULL,
  `id_transaksi` varchar(7) NOT NULL,
  `kd_barang` int(6) NOT NULL,
  `total_harga` int(6) NOT NULL,
  `jumlah_beli` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_dtltransaksi`
--

INSERT INTO `tb_dtltransaksi` (`id_dtltransaksi`, `id_transaksi`, `kd_barang`, `total_harga`, `jumlah_beli`) VALUES
(164, 'KT-001', 3, 1000, 1),
(165, 'KT-002', 3, 12000, 2),
(166, 'KT-003', 2, 12000, 2),
(167, 'KT-004', 2, 6000, 1),
(168, 'KT-005', 1, 2000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tb_karyawan`
--

CREATE TABLE `tb_karyawan` (
  `id_karyawan` varchar(10) NOT NULL,
  `nama_karyawan` varchar(20) NOT NULL,
  `alamat` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_karyawan`
--

INSERT INTO `tb_karyawan` (`id_karyawan`, `nama_karyawan`, `alamat`) VALUES
('KAR0001', 'Mykoto', 'Gatau'),
('KAR0002', 'Myumu', 'Gatau'),
('KAR0003', 'CleveQ', 'k'),
('KAR0004', 'NegevQ', 'Gatau'),
('KAR005', 'Frengki', 'Gatau');

-- --------------------------------------------------------

--
-- Table structure for table `tb_transaksi`
--

CREATE TABLE `tb_transaksi` (
  `id_transaksi` varchar(7) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `id_karyawan` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_transaksi`
--

INSERT INTO `tb_transaksi` (`id_transaksi`, `tgl_transaksi`, `id_karyawan`) VALUES
('KT-001', '2019-06-20', ''),
('KT-002', '2019-06-20', 'KAR00'),
('KT-003', '2019-06-20', ''),
('KT-004', '2019-06-20', 'KAR00'),
('KT-005', '2019-06-20', 'KAR00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`user`);

--
-- Indexes for table `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD PRIMARY KEY (`kd_barang`);

--
-- Indexes for table `tb_beli`
--
ALTER TABLE `tb_beli`
  ADD PRIMARY KEY (`id_beli`);

--
-- Indexes for table `tb_dtlbeli`
--
ALTER TABLE `tb_dtlbeli`
  ADD PRIMARY KEY (`id_dtlbeli`);

--
-- Indexes for table `tb_dtltransaksi`
--
ALTER TABLE `tb_dtltransaksi`
  ADD PRIMARY KEY (`id_dtltransaksi`);

--
-- Indexes for table `tb_karyawan`
--
ALTER TABLE `tb_karyawan`
  ADD PRIMARY KEY (`id_karyawan`);

--
-- Indexes for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_barang`
--
ALTER TABLE `tb_barang`
  MODIFY `kd_barang` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tb_dtlbeli`
--
ALTER TABLE `tb_dtlbeli`
  MODIFY `id_dtlbeli` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tb_dtltransaksi`
--
ALTER TABLE `tb_dtltransaksi`
  MODIFY `id_dtltransaksi` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=169;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
