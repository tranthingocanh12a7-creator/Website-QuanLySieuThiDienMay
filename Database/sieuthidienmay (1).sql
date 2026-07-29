-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th7 25, 2025 lúc 02:38 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `sieuthidienmay`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon`
--

CREATE TABLE `hoadon` (
  `maHoaDon` varchar(50) NOT NULL,
  `maNhanVien` varchar(50) NOT NULL,
  `maKhachHang` varchar(50) NOT NULL,
  `ngayLap` date NOT NULL,
  `tongThanhTien` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `hoadon`
--

INSERT INTO `hoadon` (`maHoaDon`, `maNhanVien`, `maKhachHang`, `ngayLap`, `tongThanhTien`) VALUES
('HD001', 'NV01', 'KH001', '2025-07-06', 40000),
('HD004', 'NV02', 'KH001', '2025-07-06', 15000),
('HD007', 'NV01', 'KH001', '2025-07-06', 30000),
('HD010', 'NV01', 'KH001', '2025-07-06', 57000),
('HD014', 'NV02', 'KH001', '2025-07-06', 49000),
('HD019', 'NV01', 'KH001', '2025-07-06', 15000),
('HD020', 'NV01', 'KH001', '2025-07-06', 25000),
('HD021', 'NV01', 'KH001', '2025-07-06', 15000),
('HD022', 'NV02', 'KH002', '2025-07-07', 25000),
('HD023', 'NV02', 'KH002', '2025-07-07', 12000),
('HD024', 'NV01', 'KH001', '2025-07-07', 15000),
('HD025', 'NV02', 'KH001', '2025-07-07', 51000),
('HD026', 'NV01', 'KH002', '2025-07-11', 54000),
('HD027', 'NV01', 'KH001', '2025-07-11', 12000),
('HD028', 'NV01', 'KH001', '2025-07-19', 17500000),
('HD029', 'NV01', 'KH001', '2025-07-19', 14000000),
('HD030', 'NV01', 'KH001', '2025-07-19', 20000000),
('HD031', 'NV01', 'KH001', '2025-07-19', 9500000),
('HD032', 'NV01', 'KH001', '2025-07-19', 3500000),
('HD033', 'NV01', 'KH001', '2025-07-19', 3500000),
('HD034', 'NV01', 'KH001', '2025-07-19', 3500000),
('HD035', 'NV01', 'KH001', '2025-07-19', 7000000),
('HD036', 'NV01', 'KH001', '2025-07-23', 12000000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_chamcong`
--

CREATE TABLE `tt_chamcong` (
  `MaNhanVien` varchar(50) NOT NULL,
  `ngayChamCong` datetime NOT NULL,
  `caLam` tinyint(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_chamcong`
--

INSERT INTO `tt_chamcong` (`MaNhanVien`, `ngayChamCong`, `caLam`) VALUES
('NV01', '2025-06-01 00:00:00', 1),
('NV01', '2025-06-06 00:00:00', 2),
('NV02', '2025-06-01 00:00:00', 3),
('NV02', '2025-07-09 00:00:00', 1),
('NV02', '2025-07-09 00:00:00', 2),
('NV03', '2025-06-02 00:00:00', 2),
('NV03', '2025-07-21 00:00:00', 1),
('NV04', '2025-06-02 00:00:00', 3),
('NV04', '2025-07-14 07:58:19', 2),
('NV04', '2025-07-18 23:18:27', 2),
('NV04', '2025-07-19 20:56:29', 1),
('NV04', '2025-07-19 20:56:29', 2),
('NV04', '2025-07-19 20:56:29', 3),
('NV05', '2025-06-03 00:00:00', 1),
('NV05', '2025-06-03 00:00:00', 3),
('NV05', '2025-07-14 07:36:02', 2),
('NV05', '2025-07-14 07:36:02', 3),
('NV06', '2025-06-02 00:00:00', 3),
('NV06', '2025-07-14 07:56:52', 1),
('NV06', '2025-07-14 07:56:52', 3);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_chitiet_hoadon`
--

CREATE TABLE `tt_chitiet_hoadon` (
  `maHoaDon` varchar(50) NOT NULL,
  `maSanPham` varchar(50) NOT NULL,
  `soLuong` int(11) NOT NULL,
  `donGiaBan` decimal(10,0) DEFAULT NULL,
  `thanhTien` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_chitiet_hoadon`
--

INSERT INTO `tt_chitiet_hoadon` (`maHoaDon`, `maSanPham`, `soLuong`, `donGiaBan`, `thanhTien`) VALUES
('HD001', 'SP02', 2, 15000, 30000),
('HD001', 'SP01', 1, 10000, 10000),
('HD004', 'SP02', 1, 15000, 15000),
('HD007', 'SP01', 3, 10000, 30000),
('HD010', 'SP03', 1, 12000, 12000),
('HD010', 'SP02', 3, 15000, 45000),
('HD014', 'SP02', 1, 15000, 15000),
('HD014', 'SP01', 1, 10000, 10000),
('HD014', 'SP03', 2, 12000, 24000),
('HD019', 'SP02', 1, 15000, 15000),
('HD020', 'SP01', 1, 10000, 10000),
('HD020', 'SP02', 1, 15000, 15000),
('HD021', 'SP02', 1, 15000, 15000),
('HD022', 'SP01', 1, 10000, 10000),
('HD022', 'SP02', 1, 15000, 15000),
('HD023', 'SP03', 1, 12000, 12000),
('HD024', 'SP02', 1, 15000, 15000),
('HD025', 'SP02', 1, 15000, 15000),
('HD025', 'SP03', 3, 12000, 36000),
('HD026', 'SP02', 2, 15000, 30000),
('HD026', 'SP03', 2, 12000, 24000),
('HD027', 'SP03', 1, 12000, 12000),
('HD028', 'SP05', 1, 9500000, 9500000),
('HD028', 'SP01', 1, 8000000, 8000000),
('HD029', 'SP03', 1, 7000000, 7000000),
('HD029', 'SP03', 1, 7000000, 7000000),
('HD030', 'SP01', 1, 8000000, 8000000),
('HD030', 'SP02', 1, 12000000, 12000000),
('HD031', 'SP05', 1, 9500000, 9500000),
('HD032', 'SP04	', 1, 3500000, 3500000),
('HD033', 'SP04	', 1, 3500000, 3500000),
('HD034', 'SP04	', 1, 3500000, 3500000),
('HD035', 'SP03', 1, 7000000, 7000000),
('HD036', 'SP02', 1, 12000000, 12000000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_chitiet_nxkho`
--

CREATE TABLE `tt_chitiet_nxkho` (
  `maHoaDonNX` varchar(50) NOT NULL,
  `maSanPham` varchar(50) NOT NULL,
  `soLuong` int(11) DEFAULT NULL,
  `ngay` date DEFAULT NULL,
  `NhapXuat` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_chitiet_nxkho`
--

INSERT INTO `tt_chitiet_nxkho` (`maHoaDonNX`, `maSanPham`, `soLuong`, `ngay`, `NhapXuat`) VALUES
('HDNX01', 'SP02', 150, '2025-07-01', 1),
('HDNX01', 'SP03', 200, '2025-07-01', 1),
('HDNX02', 'SP02', 30, '2025-07-03', 0),
('HDNX03', 'SP01', 100, '2025-07-01', 1),
('HDNX04', 'SP01', 20, '2025-07-02', 0),
('HDNX05', 'SP02', 10, NULL, NULL),
('HDNX05', 'SP04	', 12, NULL, NULL),
('HDNX05', 'SP05', 3, NULL, NULL),
('HDNX06', 'SP05', 3, '2025-07-23', 0),
('HDNX07', 'SP02', 3, '2025-07-23', 0),
('HDNX07', 'SP05', 3, '2025-07-23', 0),
('HDNX08', 'SP05', 3, '2025-07-23', 0),
('HDNX09', 'SP04	', 20, '2025-07-24', 0),
('HDNX10', 'SP02', 1, '2025-07-24', 1),
('HDNX11', 'SP01', 2, '2025-07-24', 1),
('HDNX11', 'SP02', 7, '2025-07-24', 1),
('HDNX11', 'SP04	', 10, '2025-07-24', 1),
('HDNX11', 'SP05', 7, '2025-07-24', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_khachhang`
--

CREATE TABLE `tt_khachhang` (
  `maKhachHang` varchar(50) NOT NULL,
  `tenKhachHang` varchar(50) NOT NULL,
  `soDienThoaiKH` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_khachhang`
--

INSERT INTO `tt_khachhang` (`maKhachHang`, `tenKhachHang`, `soDienThoaiKH`) VALUES
('KH001', 'le thi anh linh', '035353'),
('KH002', 'vu thi giang', '09238943'),
('KH003', 'LE THI ANH LINH', '0353532429'),
('KH004', 'LE THI LAN', '037579996');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_nhacc`
--

CREATE TABLE `tt_nhacc` (
  `maNhaCC` varchar(50) NOT NULL,
  `tenNhaCC` varchar(50) NOT NULL,
  `soDienThoaiNhaCC` varchar(50) NOT NULL,
  `diaChiNhaCC` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_nhacc`
--

INSERT INTO `tt_nhacc` (`maNhaCC`, `tenNhaCC`, `soDienThoaiNhaCC`, `diaChiNhaCC`) VALUES
('NCC01', 'Panasonic Việt Nam', '0901234567', 'Hà Nội'),
('NCC02', 'Samsung Electronics', '0912345678', 'TP Hồ Chí Minh'),
('NCC03', 'LG Việt Nam', '0923456789', 'Đà Nẵng'),
('NCC04', 'Daikin Việt Nam', '0934567890', 'Hải Phòng'),
('NCC05', 'Sunhouse Việt Nam', '0945678901', 'Cần Thơ'),
('NCC06', 'Tôn Hoa Sen', '0333780035', 'Ninh Bình'),
('NCC07', 'Toyata', '0395185597', 'Nhật Bản'),
('NCC08', 'Apple', '0123456789', 'US');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_nhanvien`
--

CREATE TABLE `tt_nhanvien` (
  `maNhanVien` varchar(50) NOT NULL,
  `tenNhanVien` varchar(50) NOT NULL,
  `chucVu` varchar(50) NOT NULL,
  `ngaySinh` date NOT NULL,
  `soDienThoaiNV` varchar(50) NOT NULL,
  `tenDangNhap` varchar(50) NOT NULL,
  `matKhau` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_nhanvien`
--

INSERT INTO `tt_nhanvien` (`maNhanVien`, `tenNhanVien`, `chucVu`, `ngaySinh`, `soDienThoaiNV`, `tenDangNhap`, `matKhau`) VALUES
('NV01', 'Lê Thu Hiền', 'Quản lý', '2005-05-01', '0973759758', 'hien01', '123'),
('NV02', 'Nguyễn Thu Trang', 'Nhân viên', '2005-06-11', '0316491245', 'trang02', '456'),
('NV03', 'Bùi Khánh Linh', 'Nhân viên', '2004-08-30', '0164578932', 'linh03', '789'),
('NV04', 'Nguyễn Linh Chi', 'Nhân viên', '2006-02-13', '0346852167', 'chi04', '147'),
('NV05', 'Trần Mạnh Trường', 'Nhân viên', '2002-06-02', '0964572236', 'truong05', '258'),
('NV06', 'Lê Văn An', 'Nhân viên', '2000-08-02', '0321455235', 'an06', '954');

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
('HDNX05', 'NV005', '2025-07-05', 0),
('HDNX06', 'Vũ Thị Giang', '2025-07-23', 0),
('HDNX07', 'Vũ Thị Giang', '2025-07-23', 0),
('HDNX08', 'Vũ Thị Giang', '2025-07-23', 0),
('HDNX09', '', '2025-07-24', 0),
('HDNX10', '', '2025-07-24', 1),
('HDNX11', '', '2025-07-24', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tt_sanpham`
--

CREATE TABLE `tt_sanpham` (
  `maSanPham` varchar(50) NOT NULL,
  `tenSanPham` varchar(50) NOT NULL,
  `donGiaBan` decimal(10,0) NOT NULL,
  `maNhaCC` varchar(50) NOT NULL,
  `soLuongTon` int(11) NOT NULL,
  `donGiaNhap` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tt_sanpham`
--

INSERT INTO `tt_sanpham` (`maSanPham`, `tenSanPham`, `donGiaBan`, `maNhaCC`, `soLuongTon`, `donGiaNhap`) VALUES
('SP01', 'Máy lạnh Panasonic 1HP', 8000000, 'NCC01', 8, 7000000),
('SP02', 'Tủ lạnh Samsung Inverter', 12000000, 'NCC02', 3, 10500000),
('SP03', 'Máy giặt LG', 7000000, 'NCC03', 12, 6300000),
('SP04	', 'Quạt điều hòa Kangaroo', 3500000, 'NCC04', 0, 2000000),
('SP05', 'Điều hòa Daikin 1.5HP', 9500000, 'NCC01', 3, 8500000);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`maHoaDon`),
  ADD KEY `maKhachHang` (`maKhachHang`),
  ADD KEY `maNhanVienBanHang` (`maNhanVien`);

--
-- Chỉ mục cho bảng `tt_chamcong`
--
ALTER TABLE `tt_chamcong`
  ADD PRIMARY KEY (`MaNhanVien`,`ngayChamCong`,`caLam`);

--
-- Chỉ mục cho bảng `tt_chitiet_hoadon`
--
ALTER TABLE `tt_chitiet_hoadon`
  ADD KEY `maHoaDon` (`maHoaDon`),
  ADD KEY `maSanPham` (`maSanPham`);

--
-- Chỉ mục cho bảng `tt_chitiet_nxkho`
--
ALTER TABLE `tt_chitiet_nxkho`
  ADD PRIMARY KEY (`maHoaDonNX`,`maSanPham`),
  ADD KEY `maSanPham` (`maSanPham`);

--
-- Chỉ mục cho bảng `tt_khachhang`
--
ALTER TABLE `tt_khachhang`
  ADD PRIMARY KEY (`maKhachHang`);

--
-- Chỉ mục cho bảng `tt_nhacc`
--
ALTER TABLE `tt_nhacc`
  ADD PRIMARY KEY (`maNhaCC`);

--
-- Chỉ mục cho bảng `tt_nhanvien`
--
ALTER TABLE `tt_nhanvien`
  ADD PRIMARY KEY (`maNhanVien`);

--
-- Chỉ mục cho bảng `tt_nhapxuatkho`
--
ALTER TABLE `tt_nhapxuatkho`
  ADD PRIMARY KEY (`maHoaDonNX`);

--
-- Chỉ mục cho bảng `tt_sanpham`
--
ALTER TABLE `tt_sanpham`
  ADD PRIMARY KEY (`maSanPham`),
  ADD KEY `maNhaCCSP` (`maNhaCC`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `maKhachHang` FOREIGN KEY (`maKhachHang`) REFERENCES `tt_khachhang` (`maKhachHang`),
  ADD CONSTRAINT `maNhanVienBanHang` FOREIGN KEY (`maNhanVien`) REFERENCES `tt_nhanvien` (`maNhanVien`);

--
-- Các ràng buộc cho bảng `tt_chamcong`
--
ALTER TABLE `tt_chamcong`
  ADD CONSTRAINT `MaNhanVien` FOREIGN KEY (`MaNhanVien`) REFERENCES `tt_nhanvien` (`maNhanVien`);

--
-- Các ràng buộc cho bảng `tt_chitiet_hoadon`
--
ALTER TABLE `tt_chitiet_hoadon`
  ADD CONSTRAINT `maHoaDon` FOREIGN KEY (`maHoaDon`) REFERENCES `hoadon` (`maHoaDon`),
  ADD CONSTRAINT `maSanPham` FOREIGN KEY (`maSanPham`) REFERENCES `tt_sanpham` (`maSanPham`);

--
-- Các ràng buộc cho bảng `tt_chitiet_nxkho`
--
ALTER TABLE `tt_chitiet_nxkho`
  ADD CONSTRAINT `maHoaDonNXkho` FOREIGN KEY (`maHoaDonNX`) REFERENCES `tt_nhapxuatkho` (`maHoaDonNX`),
  ADD CONSTRAINT `tt_chitiet_nxkho_ibfk_1` FOREIGN KEY (`maSanPham`) REFERENCES `tt_sanpham` (`maSanPham`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `tt_sanpham`
--
ALTER TABLE `tt_sanpham`
  ADD CONSTRAINT `maNhaCCSP` FOREIGN KEY (`maNhaCC`) REFERENCES `tt_nhacc` (`maNhaCC`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
