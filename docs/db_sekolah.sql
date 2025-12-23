-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 23, 2025 at 11:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_sekolah`
--

-- --------------------------------------------------------

--
-- Table structure for table `pendaftaran`
--

CREATE TABLE `pendaftaran` (
  `no_pendaftaran` int(8) NOT NULL,
  `tanggal_pendaftaran` date NOT NULL,
  `status` enum('diterima','ditolak','proses') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pendaftaran`
--

INSERT INTO `pendaftaran` (`no_pendaftaran`, `tanggal_pendaftaran`, `status`) VALUES
(2, '2025-12-06', ''),
(3, '2025-12-06', ''),
(4, '2025-12-22', ''),
(5, '2025-12-18', 'ditolak'),
(6, '2025-12-18', 'ditolak'),
(7, '2025-12-23', ''),
(8, '2025-12-23', 'diterima'),
(9, '2025-12-23', 'ditolak'),
(10, '2025-12-23', ''),
(11, '2025-12-23', ''),
(12, '2025-12-23', 'proses'),
(13, '2025-12-23', ''),
(14, '2025-12-23', ''),
(15, '2025-12-23', ''),
(16, '2025-12-23', ''),
(17, '2025-12-23', ''),
(18, '2025-12-23', ''),
(19, '2025-12-23', ''),
(20, '2025-12-23', ''),
(21, '2025-12-23', ''),
(22, '2025-12-23', ''),
(23, '2025-12-23', ''),
(24, '2025-12-23', ''),
(25, '2025-12-23', ''),
(26, '2025-12-23', ''),
(27, '2025-12-23', ''),
(28, '2025-12-23', 'ditolak');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `id` int(11) NOT NULL,
  `nis` int(6) NOT NULL,
  `nama_lengkap` varchar(40) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `jenis_kelamin` enum('L','P') NOT NULL COMMENT 'L = Laki-laki\r\nP=Pemempuan',
  `tempat_lahir` varchar(50) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `agama` varchar(15) NOT NULL,
  `no_telepon` varchar(15) NOT NULL,
  `ayah_kandung` varchar(40) NOT NULL,
  `ibu_kandung` varchar(40) NOT NULL,
  `wali` varchar(40) NOT NULL,
  `pekerjaan_ayah` varchar(60) NOT NULL,
  `pekerjaan_ibu` varchar(60) NOT NULL,
  `pekerjaan_wali` varchar(60) NOT NULL,
  `berat_badan` int(3) NOT NULL,
  `tinggi_badan` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`id`, `nis`, `nama_lengkap`, `nik`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `alamat`, `agama`, `no_telepon`, `ayah_kandung`, `ibu_kandung`, `wali`, `pekerjaan_ayah`, `pekerjaan_ibu`, `pekerjaan_wali`, `berat_badan`, `tinggi_badan`) VALUES
(1, 0, 'muhammad afif', '312342344', '', 'jawa ', '2025-09-09', 'jawa', '', '', '', '', '', '', '', '', 45, 178),
(2, 0, 'muhammad izzul mubarrok', '312310820', '', 'pekalongan', '2001-01-23', 'Karawang', '', '', '', '', '', '', '', '', 70, 170),
(3, 0, 'dinda', '123', '', 'rawabinog', '2025-12-22', 'rawajalu', 'islam', '44563465', 'bpk', 'ui', 'ds', 'es', 'fe', 'esf', 566, 234),
(4, 0, 'stgfs', '0', '', 'jgjg', '2025-03-22', 'gjg', 'gy', '7897', 'ata', 'ada', 'ada', 'ada', 'ada', 'ad', 0, 0),
(6, 0, 'stgfs', '3123', '', 'jgjg', '2025-03-22', 'gjg', 'gy', '7897', 'ata', 'ada', 'ada', 'ada', 'ada', 'ad', 0, 0),
(8, 0, 'stgfs', '312', '', 'jgjg', '2025-03-22', 'gjg', 'gy', '7897', 'ata', 'ada', 'ada', 'ada', 'ada', 'ad', 0, 0),
(10, 0, 'dinda', '23444455', '', 'pekalongan', '2001-03-04', 'pekalongan', 'islam', '0823212212', 'ayah', 'ibu', 'kake', 'kerja', 'kerja', 'kerja', 51, 156),
(24, 3, 'Muhammad izzul mubarrok', '77443', 'L', 'Pekalongan', '2025-12-23', 'Karawang', 'Islam', '', 'bapak', 'ibu', 'wali', 'kerja', 'kerja', 'kerja', 70, 170),
(32, 5, 'muhammad al fatih', '356778391', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(35, 6, 'muhammad al f', '2147483647', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(36, 7, '', '312353566', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(39, 8, '', '2311112', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(41, 9, '', '23116', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(42, 10, '', '2311689', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(43, 11, '', '231168990', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(48, 12, '', '231168956', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(49, 13, '', '343452378', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(50, 14, '', '34345999', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(52, 15, '', '635482813', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(53, 16, '', '23421124235233', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(54, 17, '', '352465467475686965', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(55, 1128, 'eedad', '142351454135', '', '', '2025-12-23', '', '', '', '', '', '', '', '', '', 0, 0),
(56, 2239, 'muhammad izzul mubarrok', '31231278909', 'L', 'pekalongan', '2000-11-25', 'karawang', 'islam', '98676585', 'ayah', 'ibu', 'kakek', 'kerja', 'kerja', 'kerja', 67, 170);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `nama` varchar(40) NOT NULL,
  `pasword` varchar(12) NOT NULL,
  `email` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pendaftaran`
--
ALTER TABLE `pendaftaran`
  ADD PRIMARY KEY (`no_pendaftaran`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nik` (`nik`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pendaftaran`
--
ALTER TABLE `pendaftaran`
  MODIFY `no_pendaftaran` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `siswa`
--
ALTER TABLE `siswa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
