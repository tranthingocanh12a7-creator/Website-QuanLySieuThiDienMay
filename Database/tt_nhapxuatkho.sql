-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th7 22, 2025 lúc 02:22 PM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `qlkho`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_nhapxuatkho`
--

CREATE TABLE `tt_nhapxuatkho` (
  `maHoaDonNX` varchar(50) NOT NULL,
  `maNhanVien` varchar(50) DEFAULT NULL,
  `ngayLap` date DEFAULT NULL,
  `NhapXuat` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_nhapxuatkho`
--

INSERT INTO `tt_nhapxuatkho` (`maHoaDonNX`, `maNhanVien`, `ngayLap`, `NhapXuat`) VALUES
('HDNX01', 'NV001', '2025-07-01', 1),
('HDNX02', 'NV002', '2025-07-02', 0),
('HDNX03', 'NV003', '2025-07-03', 1),
('HDNX04', 'NV004', '2025-07-04', 1),
('HDNX05', 'NV005', '2025-07-05', 0);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tt_nhapxuatkho`
--
ALTER TABLE `tt_nhapxuatkho`
  ADD PRIMARY KEY (`maHoaDonNX`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
