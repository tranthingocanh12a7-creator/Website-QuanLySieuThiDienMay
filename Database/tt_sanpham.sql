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
-- Cấu trúc bảng cho bảng `tt_sanpham`
--

CREATE TABLE `tt_sanpham` (
  `maSanPham` varchar(50) NOT NULL,
  `tenSanPham` varchar(50) DEFAULT NULL,
  `maNhaCC` varchar(50) DEFAULT NULL,
  `donGiaBan` decimal(18,2) DEFAULT NULL,
  `soLuongTon` int(11) DEFAULT NULL,
  `donGiaNhap` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_sanpham`
--

INSERT INTO `tt_sanpham` (`maSanPham`, `tenSanPham`, `maNhaCC`, `donGiaBan`, `soLuongTon`, `donGiaNhap`) VALUES
('SP01', 'Tivi Samsung 43 inch', 'NCC01', 7500000.00, 10, 6800000.00),
('SP02', 'Máy Giặt LG 9kg', 'NCC02', 9500000.00, 5, 8700000.00),
('SP03', 'Tủ Lạnh Sharp 300L', 'NCC03', 11500000.00, 3, 10200000.00),
('SP04', 'Lò Vi Sóng Panasonic', 'NCC04', 3200000.00, 20, 2800000.00),
('SP05', 'Điều Hòa Daikin 1HP', 'NCC05', 8900000.00, 7, 8000000.00);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tt_sanpham`
--
ALTER TABLE `tt_sanpham`
  ADD PRIMARY KEY (`maSanPham`),
  ADD KEY `maNhaCC` (`maNhaCC`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `tt_sanpham`
--
ALTER TABLE `tt_sanpham`
  ADD CONSTRAINT `tt_sanpham_ibfk_1` FOREIGN KEY (`maNhaCC`) REFERENCES `tt_nhacc` (`maNhaCC`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
