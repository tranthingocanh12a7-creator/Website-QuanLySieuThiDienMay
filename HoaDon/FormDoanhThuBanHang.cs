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
    public partial class FormDoanhThuBanHang : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=sieuthidienmay;");

        public FormDoanhThuBanHang()
        {
            InitializeComponent();
            LoadDoanhThu();
        }

        private void LoadDoanhThu()
        {
            string query = @"
                SELECT 
                    hd.maHoaDon,
                    hd.ngayLap,
                    nv.maNhanVien,  -- dùng mã thay vì tên
                    SUM(ct.soLuong * ct.donGiaBan) AS tongTien
                FROM hoadon hd
                JOIN tt_chitiet_hoadon ct ON hd.maHoaDon = ct.maHoaDon
                JOIN tt_nhanvien nv ON hd.maNhanVien = nv.maNhanVien
                GROUP BY hd.maHoaDon, hd.ngayLap, nv.maNhanVien
                ORDER BY hd.ngayLap DESC";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDoanhthu.DataSource = dt;

            DataGridViewHelper.FormatDataGridView(
                dgvDoanhthu,
                rightAlignColumns: new[] { "tongTien" },
                dateColumns: new[] { "ngayLap" },
                currencyColumns: new[] { "tongTien" },
                centerAll: false
            );

            // Tính tổng doanh thu
            decimal tongDoanhThu = 0;
            foreach (DataRow row in dt.Rows)
            {
                tongDoanhThu += row["tongTien"] != DBNull.Value ? Convert.ToDecimal(row["tongTien"]) : 0;
            }


            lbTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0") + "₫";
        }
        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            LoadMaNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtptu.Value.Date;
            DateTime denNgay = dtpden.Value.Date;
            string maNV = cbmanv.SelectedValue?.ToString(); // Lấy mã nhân viên từ ComboBox

            string query = @"
                SELECT 
                    hd.maHoaDon,
                    hd.ngayLap,
                    nv.maNhanVien,
                    SUM(ct.soLuong * ct.donGiaBan) AS tongTien
                FROM hoadon hd
                JOIN tt_chitiet_hoadon ct ON hd.maHoaDon = ct.maHoaDon
                JOIN tt_nhanvien nv ON hd.maNhanVien = nv.maNhanVien
                WHERE hd.ngayLap BETWEEN @tuNgay AND @denNgay
                  AND nv.maNhanVien = @maNV
                GROUP BY hd.maHoaDon, hd.ngayLap, nv.maNhanVien
                ORDER BY hd.ngayLap DESC";

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@denNgay", denNgay);
                cmd.Parameters.AddWithValue("@maNV", maNV);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDoanhthu.DataSource = dt;

                DataGridViewHelper.FormatDataGridView(
                    dgvDoanhthu,
                    rightAlignColumns: new[] { "tongTien" },
                    dateColumns: new[] { "ngayLap" },
                    currencyColumns: new[] { "tongTien" },
                    centerAll: false
                );
                // Format cột ngày
                dgvDoanhthu.Columns["ngayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Tính tổng doanh thu
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tongTien"] != DBNull.Value)
                    {
                        tongDoanhThu += Convert.ToDecimal(row["tongTien"]);
                    }
                }

                lbTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0") + "₫";
            }
            conn.Close();

        }

        private void LoadMaNhanVien()
        {
            string query = "SELECT maNhanVien FROM tt_nhanvien";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbmanv.DataSource = dt;
            cbmanv.DisplayMember = "maNhanVien";
            cbmanv.ValueMember = "maNhanVien";
        }
        private void lbTongDoanhThu_Click(object sender, EventArgs e)
        {

        }
        private void LoadTatCaDoanhThu()
        {
            DateTime tuNgay = dtptu.Value.Date;
            DateTime denNgay = dtpden.Value.Date;

            string query = @"
    SELECT 
        hd.maHoaDon,
        hd.ngayLap,
        nv.maNhanVien,
        SUM(ct.soLuong * ct.donGiaBan) AS tongTien
    FROM hoadon hd
    JOIN tt_chitiet_hoadon ct ON hd.maHoaDon = ct.maHoaDon
    JOIN tt_nhanvien nv ON hd.maNhanVien = nv.maNhanVien
    WHERE hd.ngayLap BETWEEN @tuNgay AND @denNgay
    GROUP BY hd.maHoaDon, hd.ngayLap, nv.maNhanVien
    ORDER BY hd.ngayLap DESC";

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@denNgay", denNgay);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDoanhthu.DataSource = dt;

                DataGridViewHelper.FormatDataGridView(
                    dgvDoanhthu,
                    rightAlignColumns: new[] { "tongTien" },
                    dateColumns: new[] { "ngayLap" },
                    currencyColumns: new[] { "tongTien" },
                    centerAll: false
                );

                dgvDoanhthu.Columns["ngayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Tính tổng
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tongTien"] != DBNull.Value)
                        tongDoanhThu += Convert.ToDecimal(row["tongTien"]);
                }

                lbTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0") + "₫";
            }
            conn.Close();
        }


        private void btnTailai_Click(object sender, EventArgs e)
        {
            // Reset ngày về mặc định (ví dụ: tháng hiện tại)
            dtptu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpden.Value = DateTime.Now;

            // Reset ComboBox về item đầu tiên
            cbmanv.SelectedIndex = 0;

            // Gọi lại hàm load tất cả
            LoadTatCaDoanhThu();
        }
    }
}
    

