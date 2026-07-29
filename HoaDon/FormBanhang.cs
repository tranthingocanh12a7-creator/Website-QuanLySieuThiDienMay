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

namespace DOAN1
{
    public partial class FormBanhang : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=sieuthidienmay;";

        public FormBanhang()
        {
            InitializeComponent();
        }

        private void FormBanhang_Load(object sender, EventArgs e)
        {
            txtMaHd.Text = TaoMaHoaDonTuDong();
            LoadKhachHang();
            LoadSanPham();
            LoadNhanVien();
            TaoCauTrucBang();
            cbMasanpham.SelectedIndex = 1;
        }

        private void LoadKhachHang()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maKhachHang, tenKhachHang FROM tt_khachhang";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbmakhachhang.DataSource = dt;
                cbmakhachhang.DisplayMember = "maKhachHang";
                cbmakhachhang.ValueMember = "maKhachHang";
            }
        }

        private void LoadSanPham()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maSanPham FROM tt_sanpham";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMasanpham.DataSource = dt;
                cbMasanpham.DisplayMember = "maSanPham";
                cbMasanpham.ValueMember = "maSanPham";
                cbMasanpham.DropDownStyle = ComboBoxStyle.DropDown; // ✅ Thêm dòng này để cho phép nhập tay
            }
        }


        private void LoadNhanVien()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maNhanVien FROM tt_nhanvien";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbManv.DataSource = dt;
                cbManv.DisplayMember = "tenNhanVien";
                cbManv.ValueMember = "maNhanVien";
            }
        }


        private void cbMasanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMasanpham.SelectedValue == null)
                return;

            string maSP = cbMasanpham.SelectedValue.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT tenSanPham, donGiaBan, soLuongTon FROM tt_sanpham WHERE maSanPham = @maSP";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maSP", maSP);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenSanpham.Text = reader["tenSanPham"].ToString();
                        txtDonGia.Text = reader["donGiaBan"].ToString();
                        txtTonKho.Text = reader["soLuongTon"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load sản phẩm: " + ex.Message);
                }
            }
        }
        private string TaoMaHoaDonTuDong()
        {
            string maHD = "HD001";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maHoaDon FROM hoadon ORDER BY maHoaDon DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastMaHD = result.ToString(); // ví dụ "HD019"
                    int number = int.Parse(lastMaHD.Substring(2)); // lấy 019 → 19
                    number++; // tăng lên 20
                    maHD = "HD" + number.ToString("D3"); // → HD020
                }
            }

            return maHD;
        }



        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKhachHang f = new FormThemKhachHang();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                LoadKhachHang(); // Reload combobox
                cbmakhachhang.SelectedValue = f.GetMaKhachHangMoi();
            }
        }


        private void TaoCauTrucBang()
        {
            dgvThongTinSanPham.Columns.Clear();

            dgvThongTinSanPham.Columns.Add("MaSP", "Mã sản phẩm");
            dgvThongTinSanPham.Columns.Add("TenSP", "Tên sản phẩm");
            dgvThongTinSanPham.Columns.Add("DonGia", "Đơn giá");
            dgvThongTinSanPham.Columns.Add("SoLuong", "Số lượng");
            dgvThongTinSanPham.Columns.Add("ThanhTien", "Thành tiền");

            dgvThongTinSanPham.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvThongTinSanPham.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            dgvThongTinSanPham.AllowUserToAddRows = false;

            DataGridViewHelper.FormatDataGridView(dgvThongTinSanPham, currencyColumns: new[] { "DonGia", "ThanhTien" });

        }


        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if(txtTenSanpham.Text.ToString().Equals(String.Empty))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }
            int soLuongMoi = (int)nudsoluong.Value;

            if (soLuongMoi < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            int tonKho = int.Parse(txtTonKho.Text);
            string maSPMoi = cbMasanpham.SelectedValue.ToString();
            string tenSP = txtTenSanpham.Text;
            decimal donGia = decimal.Parse(txtDonGia.Text);

            // Kiểm tra tổng số lượng thêm có vượt tồn kho không
            int soLuongDaCo = 0;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSPMoi)
                {
                    soLuongDaCo += Convert.ToInt32(row.Cells["SoLuong"].Value);
                }
            }

            if (soLuongMoi + soLuongDaCo > tonKho)
            {
                MessageBox.Show("Số lượng vượt quá tồn kho!");
                return;
            }

            // Nếu sản phẩm đã có trong dgv thì cộng dồn
            bool daTonTai = false;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.Cells["MaSP"].Value != null && row.Cells["MaSP"].Value.ToString() == maSPMoi)
                {
                    int soLuongCu = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    int tongSoLuong = soLuongCu + soLuongMoi;

                    row.Cells["SoLuong"].Value = tongSoLuong;
                    row.Cells["ThanhTien"].Value = tongSoLuong * donGia;

                    daTonTai = true;
                    break;
                }
            }

            // Nếu chưa có thì thêm mới
            if (!daTonTai)
            {
                decimal thanhTien = donGia * soLuongMoi;
                dgvThongTinSanPham.Rows.Add(maSPMoi, tenSP, donGia, soLuongMoi, thanhTien);
            }

            TinhTongTien(); // Cập nhật lại tổng tiền
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            lblTongThanhTien.Text = tong.ToString("N0") + " VND";
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHd.Text.Trim();
            string maKH = cbmakhachhang.SelectedValue?.ToString();
            string maNV = cbManv.SelectedValue?.ToString();
            DateTime ngayLap = dtpNgayTao.Value;

            if (dgvThongTinSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm!");
                return;
            }

            // Tính tổng tiền
            decimal tongThanhTien = 0;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongThanhTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1. Thêm vào bảng hoadon
                    string sqlHD = @"INSERT INTO hoadon 
                (maHoaDon, ngayLap, maNhanVien, maKhachHang, tongThanhTien) 
                VALUES (@maHD, @ngayLap, @maNV, @maKH, @tongTien)";
                    MySqlCommand cmdHD = new MySqlCommand(sqlHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@maHD", maHD);
                    cmdHD.Parameters.AddWithValue("@ngayLap", ngayLap);
                    cmdHD.Parameters.AddWithValue("@maNV", maNV);
                    cmdHD.Parameters.AddWithValue("@maKH", maKH);
                    cmdHD.Parameters.AddWithValue("@tongTien", tongThanhTien);
                    cmdHD.ExecuteNonQuery();

                    // 2. Thêm từng dòng sản phẩm vào chi tiết hóa đơn và trừ tồn kho
                    foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var cellMaSP = row.Cells["MaSP"].Value;
                        var cellSoLuong = row.Cells["SoLuong"].Value;
                        var cellDonGia = row.Cells["DonGia"].Value;
                        var cellThanhTien = row.Cells["ThanhTien"].Value;

                        if (cellMaSP == null || string.IsNullOrWhiteSpace(cellMaSP.ToString())
                            || cellSoLuong == null || string.IsNullOrWhiteSpace(cellSoLuong.ToString())
                            || cellDonGia == null || string.IsNullOrWhiteSpace(cellDonGia.ToString())
                            || cellThanhTien == null || string.IsNullOrWhiteSpace(cellThanhTien.ToString()))
                            continue;

                        string maSP = cellMaSP.ToString();
                        int soLuong = Convert.ToInt32(cellSoLuong);
                        decimal donGia = Convert.ToDecimal(cellDonGia);
                        decimal thanhTien = Convert.ToDecimal(cellThanhTien);

                        // Kiểm tra tồn kho
                        string sqlCheckTonKho = "SELECT soLuongTon FROM tt_sanpham WHERE maSanPham = @maSP";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheckTonKho, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@maSP", maSP);
                        int soLuongTon = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (soLuong > soLuongTon)
                        {
                            throw new Exception($"Sản phẩm {maSP} không đủ tồn kho. Còn lại: {soLuongTon}, cần: {soLuong}");
                        }

                        // Thêm chi tiết hóa đơn
                        string sqlCT = @"INSERT INTO tt_chitiet_hoadon 
                    (maHoaDon, maSanPham, soLuong, donGiaBan, thanhTien) 
                    VALUES (@maHD, @maSP, @soLuong, @donGia, @thanhTien)";
                        MySqlCommand cmdCT = new MySqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@maHD", maHD);
                        cmdCT.Parameters.AddWithValue("@maSP", maSP);
                        cmdCT.Parameters.AddWithValue("@soLuong", soLuong);
                        cmdCT.Parameters.AddWithValue("@donGia", donGia);
                        cmdCT.Parameters.AddWithValue("@thanhTien", thanhTien);
                        cmdCT.ExecuteNonQuery();



                        // Trừ tồn kho
                        string sqlUpdate = @"UPDATE tt_sanpham 
                                     SET soLuongTon = soLuongTon - @soLuong 
                                     WHERE maSanPham = @maSP";
                        MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn, tran);
                        cmdUpdate.Parameters.AddWithValue("@soLuong", soLuong);
                        cmdUpdate.Parameters.AddWithValue("@maSP", maSP);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    tran.Commit();

                    if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "In hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                    }

                    // Làm mới
                    dgvThongTinSanPham.Rows.Clear();
                    lblTongThanhTien.Text = "";
                    txtMaHd.Text = TaoMaHoaDonTuDong(); // Mã hóa đơn mới
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            tran.Rollback();
                        }
                    }
                    catch (Exception rollbackEx)
                    {
                        MessageBox.Show("Lỗi khi rollback: " + rollbackEx.Message);
                    }

                    MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message);
                }
            }

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvThongTinSanPham.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này không?",
                                                      "Xác nhận xoá",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvThongTinSanPham.SelectedRows)
                    {
                        dgvThongTinSanPham.Rows.RemoveAt(dgvThongTinSanPham.SelectedRows[0].Index);
                        TinhTongTien(); // cập nhật lại tổng tiền sau khi xoá
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThongTinSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvThongTinSanPham.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                try
                {
                    int soLuong = Convert.ToInt32(dgvThongTinSanPham.Rows[e.RowIndex].Cells["SoLuong"].Value);
                    decimal donGia = Convert.ToDecimal(dgvThongTinSanPham.Rows[e.RowIndex].Cells["DonGia"].Value);
                    dgvThongTinSanPham.Rows[e.RowIndex].Cells["ThanhTien"].Value = soLuong * donGia;
                    TinhTongTien();
                }
                catch
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                }
            }
        }

        private void dgvThongTinSanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvThongTinSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void tsLichsubanhang_Click(object sender, EventArgs e)
        {
            FormLichSu lichSuForm = new FormLichSu();
            lichSuForm.ShowDialog();
        }

        private void doanhthu_Click(object sender, EventArgs e)
        {

        }

        private void tsDoanhthu_Click(object sender, EventArgs e)
        {
            FormDoanhThuBanHang f = new FormDoanhThuBanHang();
            f.ShowDialog();
        }
        private void ResetForm(bool reloadDataFromDB)
        {
            txtMaHd.Text = TaoMaHoaDonTuDong();

            if (reloadDataFromDB)
            {
                LoadKhachHang();
                LoadSanPham();
                LoadNhanVien();
            }

            dgvThongTinSanPham.Rows.Clear();
            lblTongThanhTien.Text = "";
            txtTenSanpham.Clear();
            txtDonGia.Clear();
            txtTonKho.Clear();
            nudsoluong.Value = 1;
            TaoCauTrucBang();

            // Đặt combobox về item đầu (nếu có)
            if (cbmakhachhang.Items.Count > 0) cbmakhachhang.SelectedIndex = 0;
            if (cbMasanpham.Items.Count > 0) cbMasanpham.SelectedIndex = 0;
            if (cbManv.Items.Count > 0) cbManv.SelectedIndex = 0;
        }

        private void tsLammoi_Click(object sender, EventArgs e)
        {
            ResetForm(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn hủy tạo đơn hiện tại không?",
        "Xác nhận hủy đơn",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ResetForm(false); // KHÔNG reload DB
                MessageBox.Show("Đã hủy đơn hàng.");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 14, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontContent = new Font("Arial", 9);
            Font fontFooter = new Font("Arial", 10, FontStyle.Italic);

            float y = 20;
            float leftMargin = 20;
            float rightMargin = e.PageBounds.Width - 20;

            // Tiêu đề
            g.DrawString("HÓA ĐƠN THANH TOÁN", fontTitle, Brushes.Black,
                         new RectangleF(leftMargin, y, rightMargin - leftMargin, fontTitle.Height),
                         new StringFormat() { Alignment = StringAlignment.Center });
            y += 30;

            // Thông tin hóa đơn
            g.DrawString($"Số hóa đơn: {txtMaHd.Text}", fontContent, Brushes.Black, leftMargin, y);
            g.DrawString($"Ngày lập: {dtpNgayTao.Value:dd/MM/yyyy}", fontContent, Brushes.Black, rightMargin - 150, y);
            y += 20;

            // Thông tin khách hàng
            g.DrawString("Tới:", fontContent, Brushes.Black, leftMargin, y);
            y += 15;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT tenKhachHang FROM tt_khachhang WHERE maKhachHang = @maKH";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maKH", cbmakhachhang.SelectedValue);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        g.DrawString($"{reader["tenKhachHang"]}", fontContent, Brushes.Black, leftMargin + 10, y);
                        y += 15;
                        g.DrawString($"{reader["soDienThoaiKH"]}", fontContent, Brushes.Black, leftMargin + 10, y);
                        y += 20;
                    }
                }
            }

            // Bảng sản phẩm
            float[] columnWidths = { 60, 150, 50, 80, 100 }; // Độ rộng các cột
            string[] headers = { "Mã hàng", "Tên hàng", "SL", "Đơn giá", "Thành tiền" };

            // Vẽ header
            float x = leftMargin;
            for (int i = 0; i < headers.Length; i++)
            {
                g.DrawString(headers[i], fontHeader, Brushes.Black, new RectangleF(x, y, columnWidths[i], fontHeader.Height));
                x += columnWidths[i];
            }
            y += 20;

            // Đường kẻ ngang
            g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y);
            y += 10;

            // Dữ liệu sản phẩm
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.IsNewRow) continue;

                x = leftMargin;
                string maSP = row.Cells["MaSP"].Value.ToString();
                string tenSP = row.Cells["TenSP"].Value.ToString();
                int sl = Convert.ToInt32(row.Cells["SoLuong"].Value);
                decimal dg = Convert.ToDecimal(row.Cells["DonGia"].Value);
                decimal tt = Convert.ToDecimal(row.Cells["ThanhTien"].Value);

                string[] values = {
            maSP,
            tenSP,
            sl.ToString(),
            dg.ToString("N0"),
            tt.ToString("N0")
        };

                for (int i = 0; i < values.Length; i++)
                {
                    g.DrawString(values[i], fontContent, Brushes.Black,
                                new RectangleF(x, y, columnWidths[i], fontContent.Height));
                    x += columnWidths[i];
                }
                y += 20;
            }

            // Tổng cộng
            y += 10;
            g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y);
            y += 15;

            g.DrawString("Tổng cộng:", fontHeader, Brushes.Black, rightMargin - 180, y);
            g.DrawString(lblTongThanhTien.Text, fontHeader, Brushes.Black, rightMargin - 80, y);
            y += 30;

            // Footer
            g.DrawString("Cảm ơn quý khách!", fontFooter, Brushes.Black,
                        new RectangleF(leftMargin, y, rightMargin - leftMargin, fontFooter.Height),
                        new StringFormat() { Alignment = StringAlignment.Center });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMasanpham_Leave(object sender, EventArgs e)
        {
            string maNhap = cbMasanpham.Text.Trim().ToUpper();
            bool tonTai = false;

            foreach (DataRowView item in cbMasanpham.Items)
            {
                if (item["maSanPham"].ToString().ToUpper() == maNhap)
                {
                    tonTai = true;
                    cbMasanpham.SelectedValue = maNhap;
                    break;
                }
            }

            if (!tonTai)
            {
                MessageBox.Show("Sản phẩm không tồn tại trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMasanpham.Focus();
            }
        }

        private void cbMasanpham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbMasanpham_Leave(sender, e); // Gọi lại hàm kiểm tra
                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn tiếng 'ding' khi nhấn Enter
            }
        }
    }
}
