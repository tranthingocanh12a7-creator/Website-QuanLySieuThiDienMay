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
    public partial class FormNhapXuatKho : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=sieuthidienmay;";
        private MySqlConnection conn;
        Bitmap bitmap;

        public FormNhapXuatKho()
        {

            InitializeComponent();
            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;
            LoadNhapXuatKho();
            LoadSanPham();
            LoadComboBoxLoai();

        }
        private void LoadComboBoxLoai()
        {
            cbLoaiNX.Items.Clear();
            cbLoaiNX.Items.Add("Tất cả");
            cbLoaiNX.Items.Add("Nhập");
            cbLoaiNX.Items.Add("Xuất");
            cbLoaiNX.SelectedIndex = 0; // mặc định chọn "Tất cả"
        }

        private void LoadNhapXuatKho()
        {
            DateTime tuNgay = dtpTu.Value.Date;
            DateTime denNgay = dtpDen.Value.Date;
            string loai = cbLoaiNX.SelectedItem?.ToString();
            string maSP = cbSanpham.SelectedValue?.ToString();

            string query = @"
        SELECT 
            nx.maSanPham,
            sp.tenSanPham,
            nx.ngay,
            nx.soLuong,
            nx.NhapXuat
        FROM tt_chitiet_nxkho nx
        JOIN tt_sanpham sp ON nx.maSanPham = sp.maSanPham
        WHERE nx.ngay BETWEEN @tuNgay AND @denNgay";

            if (loai == "Nhập")
                query += " AND nx.NhapXuat = 1";
            else if (loai == "Xuất")
                query += " AND nx.NhapXuat = 0";
            // Nếu là "Tất cả" thì không thêm điều kiện gì

            if (!string.IsNullOrEmpty(maSP))
                query += " AND nx.maSanPham = @maSP";

            query += " ORDER BY nx.ngay DESC";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=sieuthidienmay;"))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                    cmd.Parameters.AddWithValue("@denNgay", denNgay);
                    if (!string.IsNullOrEmpty(maSP))
                        cmd.Parameters.AddWithValue("@maSP", maSP);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Thêm cột "Loai"
                    if (!dt.Columns.Contains("Loai"))
                        dt.Columns.Add("Loai", typeof(string));

                    int tongNhap = 0;
                    int tongXuat = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        int soLuong = Convert.ToInt32(row["soLuong"]);
                        int nhapXuat = Convert.ToInt32(row["NhapXuat"]);

                        if (nhapXuat == 1)
                        {
                            row["Loai"] = "Nhập";
                            tongNhap += soLuong;
                        }
                        else
                        {
                            row["Loai"] = "Xuất";
                            tongXuat += soLuong;
                        }
                    }

                    dgvNhapXuat.DataSource = dt;

                    // Format lại grid
                    DataGridViewHelper.FormatDataGridView(
                        dgvNhapXuat,
                        rightAlignColumns: new[] { "soLuong" },
                        dateColumns: new[] { "ngay" },
                        currencyColumns: null,
                        centerAll: false
                    );

                    // Hiển thị tổng
                    lblTongSoLuongNhap.Text = tongNhap.ToString("N0");
                    lblTongSoLuongXuat.Text = tongXuat.ToString("N0");
                }
            }
        }






        private void FormNhapXuatKho_Load(object sender, EventArgs e)
        {
            // Gán ngày mặc định
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            // Load loại nhập/xuất
            cbLoaiNX.Items.Clear();
            cbLoaiNX.Items.Add("Tất cả");
            cbLoaiNX.Items.Add("Nhập");
            cbLoaiNX.Items.Add("Xuất");
            cbLoaiNX.SelectedIndex = 0; // ✅ Chọn mặc định là Tất cả

            // Load danh sách sản phẩm
            LoadDanhSachSanPham();

            // Gọi hàm load dữ liệu
            LoadNhapXuatKho();
        }

        private void LoadDanhSachSanPham()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maSanPham, tenSanPham FROM tt_sanpham";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Thêm dòng "Tất cả"
                DataRow allRow = dt.NewRow();
                allRow["maSanPham"] = "";
                allRow["tenSanPham"] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);

                cbSanpham.DataSource = dt;
                cbSanpham.DisplayMember = "tenSanPham";
                cbSanpham.ValueMember = "maSanPham";
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            DateTime? tuNgay = dtpTu.Value.Date;
            DateTime? denNgay = dtpDen.Value.Date;

            // Kiểm tra nếu "đến ngày" nhỏ hơn "từ ngày"
            if (denNgay < tuNgay)
            {
                MessageBox.Show("Đến ngày không được nhỏ hơn Từ ngày!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadNhapXuatKho();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            // Đặt lại loại nhập/xuất về "Tất cả"
            cbLoaiNX.SelectedIndex = 0;

            // Load lại danh sách sản phẩm và chọn "Tất cả"
            LoadSanPham(); // hoặc LoadDanhSachSanPham() tùy bạn đang dùng tên nào
            cbSanpham.SelectedIndex = 0;

            // Load lại dữ liệu nhập xuất kho
            LoadNhapXuatKho();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO NHẬP / XUẤT KHO", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 30));
            e.Graphics.DrawString($"Thời gian: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", new Font("Arial", 10), Brushes.Black, new PointF(10, 60));
            e.Graphics.DrawImage(bitmap, 50, 80);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int originalHeight = dgvNhapXuat.Height;

            dgvNhapXuat.Height = dgvNhapXuat.RowCount * dgvNhapXuat.RowTemplate.Height + dgvNhapXuat.ColumnHeadersHeight;
            bitmap = new Bitmap(dgvNhapXuat.Width, dgvNhapXuat.Height);
            dgvNhapXuat.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvNhapXuat.Width, dgvNhapXuat.Height));
            dgvNhapXuat.Height = originalHeight;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument1;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void cbLoaiNX_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNhapXuatKho();
        }

        private void LoadSanPham()
        {
            
            string query = "SELECT maSanPham, tenSanPham FROM tt_sanpham";
            string connectionString = "server=localhost;user id=root;password=;database=sieuthidienmay;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Thêm dòng "Tất cả"
                DataRow allRow = dt.NewRow();
                allRow["maSanPham"] = "";
                allRow["tenSanPham"] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);

                cbSanpham.DataSource = dt;
                cbSanpham.DisplayMember = "tenSanPham";
                cbSanpham.ValueMember = "maSanPham";
            }
        }


        private void cbSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNhapXuatKho();
        }
    }
}
