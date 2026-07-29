<div align="center">

# 🏪 Quản Lý Siêu Thị Điện Máy Mini

Ứng dụng desktop quản lý siêu thị điện máy quy mô nhỏ — xây dựng bằng **C# WinForms (.NET 6.0)** và **MySQL**.
Hỗ trợ quản lý bán hàng, kho, nhân viên, chấm công và thống kê doanh thu – lợi nhuận.

![C#](https://img.shields.io/badge/C%23-.NET%206.0-purple)
![MySQL](https://img.shields.io/badge/Database-MySQL-blue)
![WinForms](https://img.shields.io/badge/UI-WinForms-orange)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)

</div>

---

## 📑 Mục lục

- [Giới thiệu](#-giới-thiệu)
- [Tính năng chính](#-tính-năng-chính)
- [Giao diện](#-giao-diện)
- [Công nghệ sử dụng](#-công-nghệ-sử-dụng)
- [Kiến trúc hệ thống](#-kiến-trúc-hệ-thống)
- [Cài đặt & Chạy project](#-cài-đặt--chạy-project)
- [Thành viên nhóm](#-thành-viên-nhóm)
- [Định hướng phát triển](#-định-hướng-phát-triển)

---

## 📖 Giới thiệu

Tại nhiều cửa hàng / siêu thị điện máy mini hiện nay, việc quản lý sản phẩm, đơn hàng, nhân viên hay doanh thu vẫn còn thực hiện thủ công hoặc dùng các công cụ đơn giản như Excel, dẫn đến sai sót, mất thời gian và khó mở rộng quy mô.

Dự án xây dựng một phần mềm quản lý giúp:

- Tự động hóa quá trình bán hàng, lập và in hóa đơn
- Quản lý kho hàng, nhà cung cấp, nhập/xuất hàng hóa
- Quản lý thông tin và chấm công nhân viên
- Thống kê doanh thu, lương, lợi nhuận theo thời gian thực

---

## ✨ Tính năng chính

### 🔐 Đăng nhập & phân quyền
- Xác thực tài khoản, phân quyền theo vai trò **Quản lý** / **Nhân viên**
- Mỗi vai trò truy cập giao diện và chức năng khác nhau

### 👤 Quản lý nhân viên
- Thêm / sửa / xóa thông tin nhân viên
- Chấm công theo ca, chống chấm công trùng trong cùng một ngày

### 🧾 Quản lý bán hàng
- Tạo hóa đơn bán hàng, tự động tính tổng tiền
- Tự động cập nhật tồn kho sau khi thanh toán
- Xem lại lịch sử đơn hàng, lọc theo mã hoặc khoảng ngày

### 📦 Quản lý kho & sản phẩm
- Quản lý danh mục sản phẩm và nhà cung cấp
- Lập phiếu nhập / xuất kho
- Kiểm tra tồn kho, cảnh báo khi xuất vượt số lượng có sẵn

### 📊 Thống kê & báo cáo
- Tính lương nhân viên theo doanh số / ca làm
- Thống kê doanh thu, lợi nhuận theo ngày / tháng / sản phẩm
- Xuất và in báo cáo

---

## 🧑‍💻 Vai trò của tôi: Developer & Manual Tester

Trong dự án này, tôi tham gia với vai trò kép **Developer** kiêm **Manual Tester** cho module `<Tên module bạn phụ trách, VD: Quản lý bán hàng>`, cụ thể:

**Với vai trò Developer:**
- Phát triển giao diện WinForms và xử lý nghiệp vụ cho module `<...>`
- Viết logic kết nối và truy vấn dữ liệu với MySQL theo mô hình 3 lớp

**Với vai trò Manual Tester:**
- Tự kiểm thử thủ công (manual testing) toàn bộ luồng nghiệp vụ trước khi bàn giao cho nhóm, theo các kỹ thuật:
  - **Functional Testing** — kiểm tra từng chức năng (thêm/sửa/xóa/tìm kiếm) hoạt động đúng yêu cầu
  - **Boundary Testing** — kiểm tra các trường hợp biên như tồn kho = 0, xuất vượt số lượng, chấm công trùng ca
  - **Negative Testing** — thử nhập sai định dạng, để trống trường bắt buộc, sai tài khoản/mật khẩu để kiểm tra xử lý lỗi
  - **End-to-end Testing** — kiểm tra xuyên suốt luồng nghiệp vụ, ví dụ: tạo hóa đơn → trừ tồn kho → cập nhật doanh thu thống kê
- Đối chiếu dữ liệu trước và sau thao tác trực tiếp trên MySQL Workbench để xác nhận hệ thống ghi/cập nhật đúng bảng dữ liệu
- Phát hiện và phản hồi lại nhóm các trường hợp lỗi phát sinh (VD: cho phép xuất kho âm, chấm công trùng không bị chặn) để chỉnh sửa trước khi hoàn thiện

> *Vì đây là đồ án học tập nên nhóm thực hiện kiểm thử thủ công theo từng chức năng trong quá trình phát triển, chưa xây dựng bộ test case chính thức hay áp dụng kiểm thử tự động (automation testing).*

---

## 🖼 Giao diện

### Đăng nhập
Giao diện đầu tiên khi khởi động hệ thống, xác thực tài khoản và điều hướng theo phân quyền.
<img width="700"  alt="Đăng nhập" src="https://github.com/user-attachments/assets/1b2e7850-66a9-4066-9e54-4451abbccd56" />

### Trang chủ
Nơi truy cập toàn bộ chức năng chính, giao diện thay đổi tùy theo vai trò đăng nhập.
<img width="700" alt="Trang chủ" src="https://github.com/user-attachments/assets/d6fad837-0b0b-48fa-a21e-77943051837c" />

### Quản lý nhân viên
Thêm / sửa / xóa thông tin, phân quyền và chấm công cho nhân viên.
<img width="700" alt="Quản lý nhân viên" src="https://github.com/user-attachments/assets/3c52e4c3-7cd7-41bf-afa5-cabc42067944" />

### Quản lý bán hàng
Lập hóa đơn bán hàng, tính tổng tự động và cập nhật tồn kho theo thời gian thực.
<img width="700" alt="Quản lý bán hàng" src="https://github.com/user-attachments/assets/f0414652-82ad-40c3-a489-8af8374547b4" />

### Quản lý sản phẩm
Quản lý danh mục sản phẩm, nhà cung cấp và phiếu nhập / xuất kho.
<img width="700" alt="Quản lý sản phẩm" src="https://github.com/user-attachments/assets/13bfce88-0e38-42d0-9e81-d1385f3f5136" />

### Thống kê và báo cáo
Thống kê doanh thu, lương nhân viên, lợi nhuận theo khoảng thời gian và hỗ trợ in báo cáo.
<img width="700" alt="Thống kê và báo cáo" src="https://github.com/user-attachments/assets/3fbaa5a3-7014-4a78-8dbe-9ead5fe2161a" />

---
## Vai trò

**Developer & Manual Tester**

### Công việc thực hiện

#### Phát triển hệ thống
- Phân tích yêu cầu và thiết kế cơ sở dữ liệu.
- Xây dựng giao diện người dùng bằng C# WinForms (hoặc Java JSP/Servlet nếu là project web).
- Phát triển các chức năng: Đăng nhập, Quản lý sản phẩm, Quản lý khách hàng, Giỏ hàng, Đơn hàng, Thanh toán và Hóa đơn.
- Xử lý các thao tác CRUD và kết nối cơ sở dữ liệu MySQL.
- Kiểm tra, sửa lỗi và tối ưu chức năng trong quá trình phát triển.

#### Kiểm thử
- Thiết kế và thực hiện Test Case cho các chức năng chính.
- Thực hiện Functional Testing và kiểm tra tính đúng đắn của dữ liệu.
- Kiểm tra dữ liệu trên MySQL sau khi thực hiện các thao tác.
- Ghi nhận, theo dõi và kiểm thử lại (Retesting) sau khi sửa lỗi.
## 🛠 Công nghệ sử dụng

| Thành phần | Công nghệ |
|---|---|
| Ngôn ngữ | C# |
| Giao diện | Windows Forms (.NET 6.0) |
| Cơ sở dữ liệu | MySQL |
| Kiến trúc | 3 lớp (Presentation – Business Logic – Data Access) |

## 🏗 Kiến trúc hệ thống

Hệ thống được xây dựng theo **mô hình 3 lớp**, mỗi chức năng quản lý tuân theo mô hình **CRUD**:

- **Presentation Layer** — Các form giao diện WinForms
- **Business Logic Layer** — Kiểm tra dữ liệu, tính toán, điều phối nghiệp vụ
- **Data Access Layer** — Kết nối và truy vấn dữ liệu từ MySQL

---

## 🚀 Cài đặt & Chạy project

### Yêu cầu
- Visual Studio 2022 trở lên
- .NET 6.0 SDK
- MySQL Server

### Các bước thực hiện

```bash
# 1. Clone repository
git clone https://github.com/tranthingocanh12a7-creator/Website-QuanLySieuThiDienMay.git

# 2. Import database
# Vào MySQL, tạo database mới và import file sieuthidienmay.sql trong thư mục Database/

# 3. Cấu hình chuỗi kết nối
# Mở file cấu hình kết nối (App.config / connection string trong code)
# và cập nhật server, username, password MySQL của bạn

# 4. Mở project bằng Visual Studio
# Mở file QuanLySieuThiDienMay.sln, Restore NuGet packages nếu được yêu cầu

# 5. Build & Run
# Nhấn F5 hoặc Start để chạy chương trình
```

---

## 👥 Thành viên nhóm 8

| Họ và tên | MSSV |
|---|---|
| Lê Thị Thủy Ngân | 22103100247 |
| Trần Thị Ngọc Ánh | 22103100326 |
| Vũ Thị Giang | 22103100300 |
| Nguyễn Linh Chi | 22103100295 |
| Lê Thị Ánh Linh | 22103100258 |

---

## 🔭 Định hướng phát triển

- [ ] Tích hợp máy in hóa đơn, máy quét mã vạch
- [ ] Hỗ trợ thanh toán điện tử
- [ ] Mở rộng quản lý theo mô hình chuỗi cửa hàng
- [ ] Kết nối trực tuyến, đồng bộ dữ liệu real-time

---

<div align="center">

**Đồ án 1 — Khoa Công nghệ Thông tin — Trường Đại học Kinh tế Kỹ thuật Công nghiệp**

</div>
