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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    public partial class FormThongKeLuong : Form
    {
        public FormThongKeLuong()
        {
            InitializeComponent();
            InitGridViewColumns(); // 🔧 Bắt buộc phải có
            LoadThangNam();

        }
        private void InitGridViewColumns()
        {
            dgvLuongNV.Columns.Clear();

            dgvLuongNV.Columns.Add("maNV", "Mã nhân viên");
            dgvLuongNV.Columns.Add("tenNV", "Tên nhân viên");
            dgvLuongNV.Columns.Add("chucVu", "Chức vụ");
            dgvLuongNV.Columns.Add("tongCa", "Tổng ca");
            dgvLuongNV.Columns.Add("luongCa", "Lương/ca");
            dgvLuongNV.Columns.Add("tongLuong", "Tổng lương");
        }

        private void FormThongKeLuong_Load(object sender, EventArgs e)
        {

        }

        private void LoadThangNam()
        {
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            cbThang.SelectedIndex = DateTime.Now.Month - 1;

            for (int year = 2020; year <= DateTime.Now.Year; year++)
                cbNam.Items.Add(year);
            cbNam.SelectedItem = DateTime.Now.Year;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int thang = Convert.ToInt32(cbThang.SelectedItem);
            int nam = Convert.ToInt32(cbNam.SelectedItem);
            ThongKeLuong(thang, nam);
        }
        private void ThongKeLuong(int thang, int nam)
        {
            dgvLuongNV.Rows.Clear();
            decimal tongLuong = 0;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=sieuthidienmay;password=;"))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        nv.maNhanVien,
                        nv.tenNhanVien,
                        nv.chucVu,
                        COUNT(cc.caLam) AS tongCa,
                        CASE nv.chucVu
                            WHEN 'Quản lý' THEN 300000
                            WHEN 'Nhân viên' THEN 200000
                            ELSE 150000
                        END AS luongCa
                    FROM tt_nhanvien nv
                    JOIN tt_chamcong cc ON nv.maNhanVien = cc.maNhanVien
                    WHERE MONTH(cc.ngayChamCong) = @thang AND YEAR(cc.ngayChamCong) = @nam
                    GROUP BY nv.maNhanVien, nv.tenNhanVien, nv.chucVu";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ma = reader.GetString("maNhanVien");
                    string ten = reader.GetString("tenNhanVien");
                    string chucVu = reader.GetString("chucVu");
                    int tongCa = reader.GetInt32("tongCa");
                    int luongCa = reader.GetInt32("luongCa");
                    int tong = tongCa * luongCa;
                    tongLuong += tong;

                    dgvLuongNV.Rows.Add(ma, ten, chucVu, tongCa, luongCa, tong);
                }
                reader.Close();
            }

            lblTongLuong.Text = $"Tổng lương: {tongLuong:N0} VNĐ";
            DataGridViewHelper.FormatDataGridView(
    dgvLuongNV,
    rightAlignColumns: new[] { "tongCa", "luongCa", "tongLuong" },
    currencyColumns: new[] { "luongCa", "tongLuong" },
    centerAll: false
);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            cbThang.SelectedIndex = DateTime.Now.Month - 1;
            cbNam.SelectedItem = DateTime.Now.Year;

            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            ThongKeLuong(thang, nam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bitmap bitmap;
        private void btnIn_Click(object sender, EventArgs e)
        {
            int height = dgvLuongNV.Height;
            dgvLuongNV.Height = dgvLuongNV.RowCount * dgvLuongNV.RowTemplate.Height * 2;

            bitmap = new Bitmap(dgvLuongNV.Width, dgvLuongNV.Height);
            dgvLuongNV.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvLuongNV.Width, dgvLuongNV.Height));
            dgvLuongNV.Height = height;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            previewDialog.Height = 600;
            previewDialog.Width = 800;
            previewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO LƯƠNG NHÂN VIÊN", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new PointF(250, 20));
            e.Graphics.DrawString($"Thời gian: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", new Font("Arial", 10), Brushes.Black, new PointF(10, 60));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
