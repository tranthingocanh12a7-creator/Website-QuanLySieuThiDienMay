using Microsoft.VisualBasic.Devices;
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
    public partial class FormLichSu : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=sieuthidienmay;Allow Zero Datetime=true;Convert Zero Datetime=true";

        public FormLichSu()
        {
            InitializeComponent();
        }

        private void dgvLichsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHoaDon = dgvLichsu.Rows[e.RowIndex].Cells["maHoaDon"].Value.ToString();

                string query = "SELECT * FROM tt_chitiet_hoadon WHERE maHoaDon = @maHoaDon";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChitiethd.DataSource = dt;
                }
            }
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {


            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            LoadLichSu();
        }

        private void LoadLichSu(string keyword = "", DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT maHoaDon, maNhanVien, maKhachHang, ngayLap, tongThanhTien
                FROM hoadon
                WHERE 1=1";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " AND maHoaDon LIKE @kw";
                    }

                    if (tuNgay != null && denNgay != null)
                    {
                        query += " AND ngayLap >= @from AND ngayLap <= @to";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                    }

                    if (tuNgay != null && denNgay != null)
                    {
                        cmd.Parameters.AddWithValue("@from", tuNgay.Value.Date);
                        cmd.Parameters.AddWithValue("@to", denNgay.Value.Date.AddDays(1).AddTicks(-1));
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLichsu.DataSource = dt;

                    // Làm đẹp cột
                    dgvLichsu.Columns["maHoaDon"].HeaderText = "Mã hóa đơn";
                    dgvLichsu.Columns["maNhanVien"].HeaderText = "Mã nhân viên";
                    dgvLichsu.Columns["maKhachHang"].HeaderText = "Mã khách hàng";
                    dgvLichsu.Columns["ngayLap"].HeaderText = "Ngày lập";
                    dgvLichsu.Columns["tongThanhTien"].HeaderText = "Tổng thành tiền";

                    dgvLichsu.Columns["tongThanhTien"].DefaultCellStyle.Format = "#,##0 đ";
                    dgvLichsu.Columns["ngayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvLichsu.Columns["tongThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvLichsu.Columns["ngayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvLichsu.AllowUserToAddRows = false;

                    // Gọi hàm format chung (nếu có)
                    DataGridViewHelper.FormatDataGridView(dgvLichsu, currencyColumns: new[] { "tongThanhTien" });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử: " + ex.Message);
            }
        }

        






        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTukhoa.Text.Trim();
            DateTime? tuNgay = dtpTu.Value.Date;
            DateTime? denNgay = dtpDen.Value.Date;

            LoadLichSu(tuKhoa, tuNgay, denNgay);
            LoadChiTietHoaDon(tuKhoa);
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            txtTukhoa.Clear();
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            LoadLichSu();
        }

        private void dgvChitiethd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLichsu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHoaDon = dgvLichsu.Rows[e.RowIndex].Cells["maHoaDon"].Value.ToString();
                LoadChiTietHoaDon(maHoaDon);
            }
        }
        private void LoadChiTietHoaDon(string maHoaDon)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                cthd.maSanPham, 
                cthd.soLuong, 
                cthd.donGiaBan, 
                cthd.thanhTien, 
                hd.ngayLap
            FROM 
                tt_chitiet_hoadon cthd
            INNER JOIN 
                hoadon hd ON cthd.maHoaDon = hd.maHoaDon
            WHERE 
                cthd.maHoaDon = @maHoaDon";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvChitiethd.DataSource = dt;

                // 👉 Gọi Format helper
                DataGridViewHelper.FormatDataGridView(
                    dgvChitiethd,
                    currencyColumns: new[] { "donGiaBan", "thanhTien" },
                    dateColumns: new[] { "ngayLap" }
                );

                conn.Close();
            }
        }


    }
}
