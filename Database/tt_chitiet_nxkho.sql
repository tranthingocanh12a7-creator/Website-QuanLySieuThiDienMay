-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th7 22, 2025 lúc 02:21 PM
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
-- Cấu trúc bảng cho bảng `tt_chitiet_nxkho`
--

CREATE TABLE `tt_chitiet_nxkho` (
  `maHoaDonNX` varchar(50) NOT NULL,
  `maSanPham` varchar(50) NOT NULL,
  `soLuong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_chitiet_nxkho`
--

INSERT INTO `tt_chitiet_nxkho` (`maHoaDonNX`, `maSanPham`, `soLuong`) VALUES
('HDNX01', 'SP03', 2),
('HDNX02', 'SP02', 1),
('HDNX03', 'SP05', 3),
('HDNX04', 'SP04', 10),
('HDNX09', 'SP01', 10),
('HDNX10', 'SP03', 3),
('HDNX11', 'SP02', 5),
('HDNX12', 'SP01', 10);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tt_chitiet_nxkho`
--
ALTER TABLE `tt_chitiet_nxkho`
  ADD PRIMARY KEY (`maHoaDonNX`,`maSanPham`),
  ADD KEY `maSanPham` (`maSanPham`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `tt_chitiet_nxkho`
--
ALTER TABLE `tt_chitiet_nxkho`
  ADD CONSTRAINT `tt_chitiet_nxkho_ibfk_2` FOREIGN KEY (`maSanPham`) REFERENCES `tt_sanpham` (`maSanPham`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
