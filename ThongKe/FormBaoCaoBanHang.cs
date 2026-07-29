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
    public partial class FormBaoCaoBanHang : Form
    {
        string connectionString = "server=localhost;database=sieuthidienmay;uid=root;pwd=;";
        private PrintDocument printDocument = new PrintDocument();
        private Bitmap bitmap;

        public FormBaoCaoBanHang()
        {
            InitializeComponent();

        }

        private void FormBaoCaoBanHang_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            LoadBaoCao(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }
        private void LoadBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    sp.maSanPham,
                                    sp.tenSanPham,
                                    SUM(cthd.soLuong) AS tongSoLuong,
                                    SUM(cthd.soLuong * sp.donGiaBan) AS tongTien
                                 FROM 
                                    tt_chitiet_hoadon cthd
                                 JOIN 
                                    tt_sanpham sp ON cthd.maSanPham = sp.maSanPham
                                 JOIN 
                                    hoadon hd ON cthd.maHoaDon = hd.maHoaDon
                                 WHERE 
                                    hd.ngayLap BETWEEN @tuNgay AND @denNgay
                                 GROUP BY 
                                    sp.maSanPham, sp.tenSanPham";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@denNgay", denNgay);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBanHang.DataSource = dt; 
                DataGridViewHelper.FormatDataGridView(
                dgvBanHang,
                rightAlignColumns: new[] { "tongSoLuong", "tongTien" },
                dateColumns: null,
                currencyColumns: new[] { "tongTien" },
                centerAll: false
);

                // Tính tổng
                int tongSoLuong = 0;
                decimal tongTien = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongSoLuong += Convert.ToInt32(row["tongSoLuong"]);
                    tongTien += Convert.ToDecimal(row["tongTien"]);
                }

                lblTongSoLuong.Text = "" + tongSoLuong;
                lblTongTien.Text = "" + tongTien.ToString("N0") + " VNĐ";
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime? tuNgay = dtpTuNgay.Value.Date;
            DateTime? denNgay = dtpDenNgay.Value.Date;

            // Kiểm tra nếu "đến ngày" nhỏ hơn "từ ngày"
            if (denNgay < tuNgay)
            {
                MessageBox.Show("Đến ngày không được nhỏ hơn Từ ngày!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadBaoCao(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // In nội dung DataGridView
            int height = dgvBanHang.Height;
            dgvBanHang.Height = dgvBanHang.RowCount * dgvBanHang.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvBanHang.Width, dgvBanHang.Height);
            dgvBanHang.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvBanHang.Width, dgvBanHang.Height));
            dgvBanHang.Height = height;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO BÁN HÀNG", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new PointF(300, 20));
            e.Graphics.DrawString($"Thời gian: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", new Font("Arial", 10), Brushes.Black, new PointF(10, 60));
            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            LoadBaoCao(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }
    }
}
