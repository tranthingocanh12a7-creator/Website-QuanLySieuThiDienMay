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
    public partial class FormDoanhThu : Form
    {
        string connectionString = "server=localhost;database=sieuthidienmay;uid=root;pwd=;";
        private PrintDocument printDocument = new PrintDocument();
        private Bitmap bitmap;

        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            LoadDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
        }
        private void LoadDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    ngayLap,
                                    SUM(tongThanhTien) AS tongDoanhThu
                                 FROM 
                                    hoadon
                                 WHERE 
                                    ngayLap BETWEEN @tuNgay AND @denNgay
                                 GROUP BY 
                                    ngayLap
                                 ORDER BY ngayLap";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@denNgay", denNgay);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDoanhThu.DataSource = dt;
                DataGridViewHelper.FormatDataGridView(
        dgvDoanhThu,
        rightAlignColumns: new[] { "tongDoanhThu" },
        dateColumns: new[] { "ngayLap" },
        currencyColumns: new[] { "tongDoanhThu" },
        centerAll: false // hoặc true nếu bạn muốn tất cả căn giữa
    );

                // Tính tổng doanh thu
                decimal tongTien = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongTien += Convert.ToDecimal(row["tongDoanhThu"]);
                }

                lblTongDoanhThu.Text = "" + tongTien.ToString("N0") + " VNĐ";
            }
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
            LoadDoanhThu(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO DOANH THU", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new PointF(300, 20));
            e.Graphics.DrawString($"Thời gian: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", new Font("Arial", 10), Brushes.Black, new PointF(10, 60));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int height = dgvDoanhThu.Height;
            dgvDoanhThu.Height = dgvDoanhThu.RowCount * dgvDoanhThu.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvDoanhThu.Width, dgvDoanhThu.Height);
            dgvDoanhThu.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvDoanhThu.Width, dgvDoanhThu.Height));
            dgvDoanhThu.Height = height;


            PrintPreviewDialog preview = new PrintPreviewDialog();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            LoadDoanhThu(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }
    }
}
