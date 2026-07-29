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
using DoAn1.model;
using DoAn1;

namespace DoAn1
{

    public partial class NhapXuatKho : Form
    {
        DBContext db = new DBContext();
        private BindingList<ChiTietHoaDon> dsChiTietTam = new BindingList<ChiTietHoaDon>();

        public NhapXuatKho()
        {
            InitializeComponent();
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            dtpNgayLap.Value = DateTime.Now;
        }
        private string GenerateMaHoaDon()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT maHoaDonNX FROM tt_chitiet_nxkho WHERE maHoaDonNX LIKE 'HDNX%' ORDER BY CAST(SUBSTRING(maHoaDonNX, 5) AS UNSIGNED) DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();

                int nextNumber = 1;
                if (result != null)
                {
                    string lastMa = result.ToString();
                    if (lastMa.Length >= 5 && int.TryParse(lastMa.Substring(4), out int currentNumber))
                    {
                        nextNumber = currentNumber + 1;
                    }
                }
                return $"HDNX{nextNumber.ToString("D2")}";
            }
        }




        private void btnThemChiTietHD_Click(object sender, EventArgs e)
        {
            if (cbloaiHoaDon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại hóa đơn!");
                return;
            }
            else
                cbloaiHoaDon.Enabled = false;
            try
            {
                string maSanPham = cboSP.SelectedItem?.ToString() ?? "";
                string maHoaDon = txtMaPhieu.Text;

                // ✅ Kiểm tra thiếu thông tin
                if (string.IsNullOrWhiteSpace(maSanPham) || string.IsNullOrWhiteSpace(txtsoLuongTon.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Kiểm tra định dạng số lượng và giá trị
                if (!int.TryParse(txtsoLuongTon.Text.Trim(), out int soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Kiểm tra trùng sản phẩm
                if (dsChiTietTam.Any(ct => ct.maSanPham == maSanPham))
                {
                    MessageBox.Show("Sản phẩm này đã được thêm vào hóa đơn rồi. Vui lòng sửa hoặc xóa trước khi thêm lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Tạo chi tiết hóa đơn
                ChiTietHoaDon ct = new ChiTietHoaDon()
                {
                    maHoaDon = maHoaDon,
                    maSanPham = maSanPham,
                    tenSanPham = txtTenSanPham.Text.ToString(),
                    donGia = long.Parse(txtdonGia.Text),
                    tongSP = long.Parse(lblTongTienSanPham.Text),
                    soLuong = soLuong
                };
                dsChiTietTam.Add(ct);
                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = dsChiTietTam;

                DinhDangDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DinhDangDataGridView()
        {
            if (dgvChiTiet.Columns.Contains("DonGiaBan"))
                dgvChiTiet.Columns["DonGiaBan"].DefaultCellStyle.Format = "N0";

            if (dgvChiTiet.Columns.Contains("ThanhTien"))
                dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                // Lấy giá trị từ giao diện
                string maHoaDon = txtMaPhieu.Text;
                string maSP = cboSP.SelectedItem?.ToString() ?? "";
                int soLuong = int.Parse(txtsoLuongTon.Text);

                // Câu lệnh cập nhật
                string query = "UPDATE tt_chitiet_nxkho " +
                               "SET maSanPham = @masp, soLuong = @sl," +
                               "WHERE maHoaDonNX = @maHoaDonNX";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                cmd.Parameters.AddWithValue("@masp", maSP);
                cmd.Parameters.AddWithValue("@sl", soLuong);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn cần sửa.");
                }
            }
        }
        private void NhapXuatKho_Load(object sender, EventArgs e)
        {
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Text = GenerateMaHoaDon();
            LoadComboBox();
            cboSP.SelectedIndexChanged += cboSP_SelectedIndexChanged;
            DinhDangDataGridView();
        }


        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

                cboSP.SelectedItem = row.Cells["maSanPham"].Value.ToString();
                txtsoLuongTon.Value = Convert.ToDecimal(row.Cells["soLuong"].Value);

            }
        }

        private void btnXoaChiTietHD_Click(object sender, EventArgs e)
        {

            if (dgvChiTiet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maHoaDon = txtMaPhieu.Text;
                string maSanPham = dgvChiTiet.CurrentRow.Cells["maSanPham"].Value.ToString();

                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM tt_chitiet_nxkho WHERE maHoaDonNX = @maHD AND maSanPham = @maSP";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHoaDon);
                    cmd.Parameters.AddWithValue("@maSP", maSanPham);
                    cmd.ExecuteNonQuery();
                }

                var itemToRemove = dsChiTietTam.FirstOrDefault(x => x.maSanPham == maSanPham);
                if (itemToRemove != null)
                {
                    dsChiTietTam.Remove(itemToRemove);
                }

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = dsChiTietTam;
                DinhDangDataGridView();
            }
        }

        private void LoadComboBox()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();


                // Load sản phẩm
                cboSP.Items.Clear();
                MySqlCommand cmd2 = new MySqlCommand("SELECT maSanPham FROM tt_sanpham", conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    cboSP.Items.Add(reader2.GetString("maSanPham"));
                }
                reader2.Close();
            }
        }

        private void txtHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    foreach (var ct in dsChiTietTam)
                    {
                        string query = "INSERT INTO tt_chitiet_nxkho (maHoaDonNX, maSanPham, soLuong) " +
                                       "VALUES (@maHoaDonNX, @maSanPham, @soLuong)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@maHoaDonNX", ct.maHoaDon);
                        cmd.Parameters.AddWithValue("@maSanPham", ct.maSanPham);
                        cmd.Parameters.AddWithValue("@soLuong", ct.soLuong);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã lưu chi tiết hóa đơn thành công!");
                dsChiTietTam.Clear();
                dgvChiTiet.DataSource = null;
                LoadDataTongHop();  // Cập nhật lại danh sách
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu chi tiết hóa đơn: " + ex.Message);
            }
        }
        private void LoadDataTongHop()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT c.maHoaDonNX, c.maSanPham, c.soLuong, " +
                                "n.NhapXuat, n.maNhanVien, n.ngayLap " +
                                "FROM tt_chitiet_nxkho AS c JOIN tt_nhapxuatkho AS n " +
                                "ON c.maHoaDonNX = n.maHoaDonNX;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTiet.DataSource = dt;
            }
        }


        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cboSP.SelectedItem?.ToString() ?? "";
            if (!string.IsNullOrEmpty(maSP))
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT tenSanPham, donGiaBan, soLuongTon FROM tt_sanpham WHERE maSanPham = @maSP";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtdonGia.Text = reader["donGiaBan"].ToString();
                        txtTenSanPham.Text = reader["tenSanPham"].ToString();
                        lblTonKho.Text = reader["soLuongTon"].ToString();
                    }

                    reader.Close();
                }
            }

            if (txtsoLuongTon.Value != null)
                txtsoLuongTon_ValueChanged(sender, e);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNhanVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền tên nhân viên thực hiện!");
                    return;
                }

                string maHD = txtMaPhieu.Text.Trim();
                string nhanVien = cboNhanVien.Text;
                DateTime ngayLap = dtpNgayLap.Value;

                Boolean loaiNhapXuat = (cbloaiHoaDon.Text.ToString().Equals("Nhập") ? true : false);

                using (var conn = db.GetConnection())
                {
                    conn.Open();


                    string checkQuery = "SELECT COUNT(*) FROM tt_nhapxuatkho WHERE maHoaDonNX = @maHD";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@maHD", maHD);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());


                    if (count == 0)
                    {
                        string insertHD = "INSERT INTO tt_nhapxuatkho(maHoaDonNX, maNhanVien, ngayLap, NhapXuat) " +
                                          "VALUES (@maHD, @nv, @ngay, @loai)";
                        MySqlCommand cmdInsertHD = new MySqlCommand(insertHD, conn);
                        cmdInsertHD.Parameters.AddWithValue("@maHD", maHD);
                        cmdInsertHD.Parameters.AddWithValue("@nv", nhanVien);
                        cmdInsertHD.Parameters.AddWithValue("@ngay", ngayLap);
                        cmdInsertHD.Parameters.AddWithValue("@loai", loaiNhapXuat);
                        cmdInsertHD.ExecuteNonQuery();
                    }


                    foreach (var ct in dsChiTietTam)
                    {
                        string insertCT = "INSERT INTO tt_chitiet_nxkho(maHoaDonNX, maSanPham, soLuong, ngay, NhapXuat) " +
                                          "VALUES (@maHD, @maSP, @soLuong, @ngay, @loai)";
                        MySqlCommand cmdCT = new MySqlCommand(insertCT, conn);
                        cmdCT.Parameters.AddWithValue("@maHD", ct.maHoaDon);
                        cmdCT.Parameters.AddWithValue("@maSP", ct.maSanPham);
                        cmdCT.Parameters.AddWithValue("@soLuong", ct.soLuong);
                        cmdCT.Parameters.AddWithValue("@ngay", ngayLap);
                        cmdCT.Parameters.AddWithValue("@loai", loaiNhapXuat);
                        cmdCT.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã lưu hóa đơn và chi tiết thành công!");


                TaoHoaDon formIn = new TaoHoaDon(maHD, nhanVien, ngayLap, loaiNhapXuat);
                formIn.ShowDialog();

                dsChiTietTam.Clear();
                dgvChiTiet.DataSource = null;
                txtMaPhieu.Text = GenerateMaHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtsoLuongTon_ValueChanged(object sender, EventArgs e)
        {
            if (!txtdonGia.Text.Equals(string.Empty))
            {
                if (cbloaiHoaDon.SelectedIndex == 1)
                {
                    if (txtsoLuongTon.Value > decimal.Parse(lblTonKho.Text))
                    {
                        MessageBox.Show("Số lượng tồn kho không đủ để xuất!");
                        cbloaiHoaDon.SelectedIndex = -1;
                    }
                }
                decimal sum = txtsoLuongTon.Value * long.Parse(txtdonGia.Text);
                lblTongTienSanPham.Text = sum.ToString();
            }
        }

        private void cbloaiHoaDon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex != -1 && cbloaiHoaDon.SelectedIndex == 1)
            {
                if (txtsoLuongTon.Value > decimal.Parse(lblTonKho.Text))
                {
                    MessageBox.Show("Số lượng tồn kho không đủ để xuất!");
                    cbloaiHoaDon.SelectedIndex = -1;
                }
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LoadDataTongHop();
        }
    }
}

