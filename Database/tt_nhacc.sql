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
-- Cấu trúc bảng cho bảng `tt_nhacc`
--

CREATE TABLE `tt_nhacc` (
  `maNhaCC` varchar(50) NOT NULL,
  `tenNhaCC` varchar(50) DEFAULT NULL,
  `soDienThoaiNhaCC` varchar(50) DEFAULT NULL,
  `diaChiNhaCC` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_nhacc`
--

INSERT INTO `tt_nhacc` (`maNhaCC`, `tenNhaCC`, `soDienThoaiNhaCC`, `diaChiNhaCC`) VALUES
('NCC01', 'Công ty Điện Máy A', '0909123456', '12 Lê Lợi, TP.HCM'),
('NCC02', 'Thiết Bị Điện B', '0912345678', '45 Nguyễn Huệ, TP.HCM'),
('NCC03', 'Điện Tử Gia Dụng C', '0987654321', '78 Trần Hưng Đạo, Hà Nội'),
('NCC04', 'Nhà Phân Phối D', '0933222111', '33 Phạm Văn Đồng, Đà Nẵng'),
('NCC05', 'Điện Máy Siêu Tốc E', '0977555666', '99 Quang Trung, Cần Thơ');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tt_nhacc`
--
ALTER TABLE `tt_nhacc`
  ADD PRIMARY KEY (`maNhaCC`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
