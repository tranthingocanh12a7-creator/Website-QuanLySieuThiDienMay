using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class TaoHoaDon : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=sieuthidienmay";

        private string maHoaDonNX;
        private string nhanVien;
        private DateTime ngayLap;
        private Boolean loaiHoaDon;

        public TaoHoaDon(string maHoaDonNX, string tenNhanVien, DateTime ngay, Boolean loaiHoaDon)
        {

            InitializeComponent();
            this.maHoaDonNX = maHoaDonNX;
            this.nhanVien = tenNhanVien;
            this.ngayLap = ngay;
            this.loaiHoaDon = loaiHoaDon;

            LoadThongTin();
            LoadChiTietHoaDon();

        }
        public TaoHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHoaDonNX = maHD;

            LoadThongTin();
            LoadChiTietHoaDon();
        }
        private void LoadThongTin()
        {
            lblNgayLap.Text = ngayLap.ToString("dd/MM/yyyy");
            lblNhanVien.Text = nhanVien;
            lblloaiHoaDon.Text = "Loại hóa đơn: " + (loaiHoaDon? "Nhập" : "Xuất");
        }

        private void LoadThongTinHoaDon()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT tenNhanVien, ngayLap, loaiHoaDon 
                                     FROM tt_hoadon 
                                     WHERE maHoaDonNX = @maHD";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHoaDonNX);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNhanVien.Text = reader["tenNhanVien"].ToString();
                            DateTime ngay = Convert.ToDateTime(reader["ngayLap"]);
                            lblNgayLap.Text = ngay.ToString("dd/MM/yyyy");

                            string loai = reader["loaiHoaDon"].ToString();
                            lblloaiHoaDon.Text = "Loại hóa đơn: " + (loai == "Nhap" ? "Nhập" : "Xuất");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin hóa đơn.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load thông tin hóa đơn: " + ex.Message);
            }
        }


        private void LoadChiTietHoaDon()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    ct.maHoaDonNX AS 'Mã Hóa Đơn',
                    ct.maSanPham AS 'Mã Sản Phẩm',
                    ct.soLuong AS 'Số Lượng',
                    sp.donGiaBan AS 'Đơn Giá',
                    (ct.soLuong * sp.donGiaBan) AS 'Thành Tiền'
                FROM tt_chitiet_nxkho ct
                JOIN tt_sanpham sp ON ct.maSanPham = sp.maSanPham
                WHERE ct.maHoaDonNX = @maHD";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHoaDonNX);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvChiTiet.DataSource = dt;

                    // Format cột số
                    dgvChiTiet.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";
                    dgvChiTiet.Columns["Thành Tiền"].DefaultCellStyle.Format = "N0";
                    dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Tính tổng tiền
                    decimal tongTien = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        tongTien += Convert.ToDecimal(row["Thành Tiền"]);
                    }

                    lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvChiTiet.Rows[e.RowIndex];
                string maHD = selectedRow.Cells["maHoaDonNX"].Value.ToString();

                // Ví dụ mở lại chính form này hoặc mở form khác
                TaoHoaDon chiTietForm = new TaoHoaDon(maHD);
                chiTietForm.Show();
            }
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {

        }
        public void InHoaDon()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false;  // In dọc nếu muốn ngang thì true

            printDoc.PrintPage += (s, e) =>
            {
                int x = 100;
                int y = 100;
                int lineHeight = 25;

                Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
                Font fontSub = new Font("Arial", 12, FontStyle.Regular);
                Font fontTable = new Font("Arial", 10, FontStyle.Regular);

                // Tiêu đề hóa đơn (giữa trang)
                string title = "HÓA ĐƠN NHẬP XUẤT KHO";
                SizeF titleSize = e.Graphics.MeasureString(title, fontTitle);
                e.Graphics.DrawString(title, fontTitle, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, y);
                y += 50;

                // Thông tin hóa đơn
                e.Graphics.DrawString($"Loại hóa đơn: {(loaiHoaDon ? "Nhập" : "Xuất")}", fontSub, Brushes.Black, x, y);
                y += lineHeight;
                e.Graphics.DrawString($"{ngayLap:dd/MM/yyyy}", fontSub, Brushes.Black, x, y);
                y += lineHeight;
                e.Graphics.DrawString(nhanVien, fontSub, Brushes.Black, x, y);
                y += 40;

                // Vẽ tiêu đề bảng
                int tableStartX = x;
                int tableStartY = y;
                int colWidth = 100;
                int colSP = 150;
                int colSoLuong = 80;
                int colDonGia = 100;
                int colThanhTien = 120;

                e.Graphics.DrawRectangle(Pens.Black, tableStartX, tableStartY, colWidth, lineHeight);
                e.Graphics.DrawString("Mã Hóa Đơn", fontTable, Brushes.Black, tableStartX + 5, tableStartY + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth, tableStartY, colSP, lineHeight);
                e.Graphics.DrawString("Mã Sản Phẩm", fontTable, Brushes.Black, tableStartX + colWidth + 5, tableStartY + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth + colSP, tableStartY, colSoLuong, lineHeight);
                e.Graphics.DrawString("Số Lượng", fontTable, Brushes.Black, tableStartX + colWidth + colSP + 5, tableStartY + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth + colSP + colSoLuong, tableStartY, colDonGia, lineHeight);
                e.Graphics.DrawString("Đơn Giá", fontTable, Brushes.Black, tableStartX + colWidth + colSP + colSoLuong + 5, tableStartY + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth + colSP + colSoLuong + colDonGia, tableStartY, colThanhTien, lineHeight);
                e.Graphics.DrawString("Thành Tiền", fontTable, Brushes.Black, tableStartX + colWidth + colSP + colSoLuong + colDonGia + 5, tableStartY + 5);

                y += lineHeight;

                // Vẽ dữ liệu chi tiết từ DataGridView (dgvChiTiet)
                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua hàng trống

                    e.Graphics.DrawRectangle(Pens.Black, tableStartX, y, colWidth, lineHeight);
                    e.Graphics.DrawString(row.Cells["Mã Hóa Đơn"].Value.ToString(), fontTable, Brushes.Black, tableStartX + 5, y + 5);

                    e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth, y, colSP, lineHeight);
                    e.Graphics.DrawString(row.Cells["Mã Sản Phẩm"].Value.ToString(), fontTable, Brushes.Black, tableStartX + colWidth + 5, y + 5);

                    e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth + colSP, y, colSoLuong, lineHeight);
                    e.Graphics.DrawString(row.Cells["Số Lượng"].Value.ToString(), fontTable, Brushes.Black, tableStartX + colWidth + colSP + 5, y + 5);

                    e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth + colSP + colSoLuong, y, colDonGia, lineHeight);
                    e.Graphics.DrawString(row.Cells["Đơn Giá"].Value.ToString(), fontTable, Brushes.Black, tableStartX + colWidth + colSP + colSoLuong + 5, y + 5);

                    e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidth + colSP + colSoLuong + colDonGia, y, colThanhTien, lineHeight);
                    e.Graphics.DrawString(row.Cells["Thành Tiền"].Value.ToString(), fontTable, Brushes.Black, tableStartX + colWidth + colSP + colSoLuong + colDonGia + 5, y + 5);

                    y += lineHeight;
                }

                y += 30;
                // Tổng tiền
                string tongTien = lblTongTien.Text;
                e.Graphics.DrawString(tongTien, fontSub, Brushes.Black, e.PageBounds.Width - 200, y);
            };

            try
            {
                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDoc;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in hóa đơn: " + ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }
    }

}

