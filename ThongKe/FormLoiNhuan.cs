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

namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    public partial class FormLoiNhuan : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=sieuthidienmay;");
        Bitmap bitmap;
        PrintDocument printDocument = new PrintDocument();

        public FormLoiNhuan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            // Đặt mặc định khoảng thời gian từ đầu tháng tới hiện tại
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            LoadLoiNhuan();
        }
        private void LoadLoiNhuan()
        {
            DateTime tuNgay = dtpTu.Value.Date;
            DateTime denNgay = dtpDen.Value.Date;

            string query = @"
                SELECT 
                    sp.maSanPham,
                    sp.tenSanPham,
                    SUM(ct.soLuong) AS tongSoLuong,
                    sp.donGiaNhap,
                    sp.donGiaBan,
                    SUM(ct.soLuong * sp.donGiaBan) AS tongDoanhThu,
                    SUM(ct.soLuong * sp.donGiaNhap) AS tongVon,
                    SUM(ct.soLuong * (sp.donGiaBan - sp.donGiaNhap)) AS loiNhuan
                FROM tt_chitiet_hoadon ct
                JOIN tt_sanpham sp ON ct.maSanPham = sp.maSanPham
                JOIN hoadon hd ON ct.maHoaDon = hd.maHoaDon
                WHERE hd.ngayLap BETWEEN @tuNgay AND @denNgay
                GROUP BY sp.maSanPham, sp.tenSanPham, sp.donGiaNhap, sp.donGiaBan
                ORDER BY loiNhuan DESC;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@denNgay", denNgay);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvLoiNhuan.DataSource = dt;
            DataGridViewHelper.FormatDataGridView(
    dgvLoiNhuan,
    rightAlignColumns: new[] { "tongSoLuong", "donGiaNhap", "donGiaBan", "tongDoanhThu", "tongVon", "loiNhuan" },
    dateColumns: null,
    currencyColumns: new[] { "donGiaNhap", "donGiaBan", "tongDoanhThu", "tongVon", "loiNhuan" },
    centerAll: false
);

            // Tính tổng lợi nhuận
            decimal tongLoiNhuan = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["loiNhuan"] != DBNull.Value)
                    tongLoiNhuan += Convert.ToDecimal(row["loiNhuan"]);
            }

            lblTongLoiNhuan.Text = "Tổng lợi nhuận: " + tongLoiNhuan.ToString("N0") + " ₫";
        }
        private void FormLoiNhuan_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime? tuNgay = dtpTu.Value.Date;
            DateTime? denNgay = dtpDen.Value.Date;

            // Kiểm tra nếu "đến ngày" nhỏ hơn "từ ngày"
            if (denNgay < tuNgay)
            {
                MessageBox.Show("Đến ngày không được nhỏ hơn Từ ngày!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadLoiNhuan();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;
            LoadLoiNhuan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Tăng chiều cao tạm thời để in toàn bộ
            int originalHeight = dgvLoiNhuan.Height;
            dgvLoiNhuan.Height = dgvLoiNhuan.RowCount * dgvLoiNhuan.RowTemplate.Height + dgvLoiNhuan.ColumnHeadersHeight;

            bitmap = new Bitmap(dgvLoiNhuan.Width, dgvLoiNhuan.Height);
            dgvLoiNhuan.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvLoiNhuan.Width, dgvLoiNhuan.Height));
            dgvLoiNhuan.Height = originalHeight;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;

            preview.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO LỢI NHUẬN", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new PointF(300, 20));
            e.Graphics.DrawString($"Thời gian: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", new Font("Arial", 10), Brushes.Black, new PointF(10, 60));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
