using DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN1
{
    public partial class FormThongKe : Form
    {
        private string connectionString = "server=localhost;user=root;database=sieuthidienmay;password=;";

        public FormThongKe()
        {
            InitializeComponent();
            LoadComboBoxThangNam();

        }
        private void LoadComboBoxThangNam()
        {
            // Tháng: 1 đến 12
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            // Năm: 2020 đến năm hiện tại
            int currentYear = DateTime.Now.Year;
            for (int y = 2020; y <= currentYear; y++)
                cbNam.Items.Add(y);

            // Thiết lập mặc định là tháng hiện tại và năm hiện tại
            cbThang.SelectedItem = DateTime.Now.Month;
            cbNam.SelectedItem = DateTime.Now.Year;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void loadTongQuan()
        {
            if (cbThang.SelectedItem == null || cbNam.SelectedItem == null)
                return;

            int thang = int.Parse(cbThang.SelectedItem.ToString());
            int nam = int.Parse(cbNam.SelectedItem.ToString());

            int tongSoLuongBan = 0;
            decimal tongDoanhThu = 0;
            decimal tongTienNhap = 0;
            int tongSoCaLam = 0;
            int tongTonKho = 0;
            decimal luongNhanVien = 0;
            decimal loiNhuan = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Tổng số lượng bán
                MySqlCommand cmd1 = new MySqlCommand(@"
            SELECT SUM(soLuong) 
            FROM tt_lichsu 
            WHERE Loai = 'Ban' 
              AND MONTH(thoiGian) = @thang 
              AND YEAR(thoiGian) = @nam", conn);
                cmd1.Parameters.AddWithValue("@thang", thang);
                cmd1.Parameters.AddWithValue("@nam", nam);
                tongSoLuongBan = Convert.ToInt32(cmd1.ExecuteScalar() ?? 0);

                // Tổng doanh thu
                MySqlCommand cmd2 = new MySqlCommand(@"
            SELECT SUM(soLuong * giaBan) 
            FROM tt_lichsu 
            WHERE Loai = 'Ban' 
              AND MONTH(thoiGian) = @thang 
              AND YEAR(thoiGian) = @nam", conn);
                cmd2.Parameters.AddWithValue("@thang", thang);
                cmd2.Parameters.AddWithValue("@nam", nam);
                tongDoanhThu = Convert.ToDecimal(cmd2.ExecuteScalar() ?? 0);

                // Tổng tiền nhập
                MySqlCommand cmd3 = new MySqlCommand(@"
            SELECT SUM(soLuong * giaNhap) 
            FROM tt_lichsu 
            WHERE Loai = 'Nhap' 
              AND MONTH(thoiGian) = @thang 
              AND YEAR(thoiGian) = @nam", conn);
                cmd3.Parameters.AddWithValue("@thang", thang);
                cmd3.Parameters.AddWithValue("@nam", nam);
                tongTienNhap = Convert.ToDecimal(cmd3.ExecuteScalar() ?? 0);

                // Tổng số ca làm
                MySqlCommand cmd4 = new MySqlCommand(@"
            SELECT COUNT(*) 
            FROM tt_luong 
            WHERE MONTH(ngaylam) = @thang 
              AND YEAR(ngaylam) = @nam", conn);
                cmd4.Parameters.AddWithValue("@thang", thang);
                cmd4.Parameters.AddWithValue("@nam", nam);
                tongSoCaLam = Convert.ToInt32(cmd4.ExecuteScalar() ?? 0);

                // Tổng tồn kho hiện tại
                MySqlCommand cmd5 = new MySqlCommand("SELECT SUM(soLuong) FROM tt_sanpham", conn);
                tongTonKho = Convert.ToInt32(cmd5.ExecuteScalar() ?? 0);
            }

            // Tính lương và lợi nhuận
            luongNhanVien = tongSoCaLam * 200;
            loiNhuan = tongDoanhThu - tongTienNhap - luongNhanVien;

            // Hiển thị
            lbltongspb.Text = tongSoLuongBan.ToString();
            lbltongdoanhthu.Text = tongDoanhThu.ToString("N0");
            lblnhap.Text = tongTienNhap.ToString("N0");
            lblluongnhanvien.Text = luongNhanVien.ToString("N0");
            lblloinhuan.Text = loiNhuan.ToString("N0");
            lbltonkho.Text = tongTonKho.ToString();
        }




        private void LoadReport()
        {

        }

        private void btnloinhuan_Click(object sender, EventArgs e)
        {
            new FormLoiNhuan().Show(this);
        }

        private void btnBaocaobanhang_Click(object sender, EventArgs e)
        {
            new FormBaoCaoBanHang().Show(this);

        }

        private void btnLuongnv_Click(object sender, EventArgs e)
        {
            new FormThongKeLuong().Show(this);
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            new FormDoanhThu().Show(this);

        }

        private void btnnhapxuatkho_Click(object sender, EventArgs e)
        {
            new FormNhapXuatKho().Show(this);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem == null || cbNam.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm.");
                return;
            }

            int thang = Convert.ToInt32(cbThang.SelectedItem);
            int nam = Convert.ToInt32(cbNam.SelectedItem);

            ThongKe(thang, nam);
        }
        private void ThongKe(int thang, int nam)
        {
            int tongSanPhamBan = 0;
            decimal tongDoanhThu = 0;
            decimal tongTienNhap = 0;
            int tongCaLam = 0;
            int luongNV = 0;
            decimal loiNhuan = 0;
            int tonKho = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Tổng sản phẩm bán (join hoadon + chitiet_hoadon theo tháng)
                string sqlSPBan = @"
            SELECT SUM(cthd.soLuong) AS TongSL, SUM(cthd.thanhTien) AS DoanhThu
            FROM tt_chitiet_hoadon cthd
            JOIN hoadon hd ON hd.maHoaDon = cthd.maHoaDon
            WHERE MONTH(hd.ngayLap) = @thang AND YEAR(hd.ngayLap) = @nam";
                using (MySqlCommand cmd = new MySqlCommand(sqlSPBan, conn))
                {
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tongSanPhamBan = reader["TongSL"] != DBNull.Value ? Convert.ToInt32(reader["TongSL"]) : 0;
                            tongDoanhThu = reader["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(reader["DoanhThu"]) : 0;
                        }
                    }
                }

                // Tổng tiền nhập (chỉ lấy NhậpXuat = 1 tức là Nhập)
                string sqlTienNhap = @"
            SELECT SUM(ct.soLuong * sp.donGiaNhap) AS TongNhap
            FROM tt_chitiet_nxkho ct
            JOIN tt_sanpham sp ON sp.maSanPham = ct.maSanPham
            WHERE ct.NhapXuat = 1 AND MONTH(ct.ngay) = @thang AND YEAR(ct.ngay) = @nam";
                using (MySqlCommand cmd = new MySqlCommand(sqlTienNhap, conn))
                {
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    object result = cmd.ExecuteScalar();
                    tongTienNhap = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }

                // Tổng ca làm từ chấm công
                string sqlChamCong = @"
            SELECT COUNT(*) AS TongCa
            FROM tt_chamcong
            WHERE MONTH(ngayChamCong) = @thang AND YEAR(ngayChamCong) = @nam";
                using (MySqlCommand cmd = new MySqlCommand(sqlChamCong, conn))
                {
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    tongCaLam = Convert.ToInt32(cmd.ExecuteScalar());
                }

                luongNV = tongCaLam * 200000;

                // Lợi nhuận
                loiNhuan = tongDoanhThu - tongTienNhap - luongNV;

                // Tồn kho (tổng số lượng tồn còn lại)
                string sqlTonKho = "SELECT SUM(soLuongTon) FROM tt_sanpham";
                using (MySqlCommand cmd = new MySqlCommand(sqlTonKho, conn))
                {
                    object result = cmd.ExecuteScalar();
                    tonKho = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }

            // Gán vào các Label
            lbltongspb.Text = tongSanPhamBan.ToString();
            lbltongdoanhthu.Text = tongDoanhThu.ToString("N0") + " đ";
            lblnhap.Text = tongTienNhap.ToString("N0") + " đ";
            lblluongnhanvien.Text = luongNV.ToString("N0") + " đ";
            lblloinhuan.Text = loiNhuan.ToString("N0") + " đ";
            lbltonkho.Text = tonKho.ToString();
        }

    }
}

