using DoAn1.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DoAn1
{
    public partial class SanPham : Form
    {
        DBContext db = new DBContext();
        public SanPham()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void LoadData()
        {
            DBContext db = new DBContext();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tt_sanpham";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DBContext db = new DBContext();

            // ✅ KIỂM TRA DỮ LIỆU RỖNG
            if (string.IsNullOrWhiteSpace(txtmaSanPham.Text) ||
                string.IsNullOrWhiteSpace(txttenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtdonGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtmaNhaCC.Text) ||
                string.IsNullOrWhiteSpace(txtsoLuongTon.Text) ||
                string.IsNullOrWhiteSpace(txtdonGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ✅ CHUYỂN VÀ KIỂM TRA DỮ LIỆU
                decimal donGiaBan = decimal.Parse(txtdonGiaBan.Text);
                decimal donGiaNhap = decimal.Parse(txtdonGiaNhap.Text);
                int soLuongTon = int.Parse(txtsoLuongTon.Text);

                if (donGiaBan < 0 || donGiaNhap < 0 || soLuongTon < 0)
                {
                    MessageBox.Show("Giá bán, giá nhập và số lượng tồn phải là số không âm!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO tt_sanpham (maSanPham, tenSanPham, donGiaBan, maNhaCC, soLuongTon, donGiaNhap) " +
                                   "VALUES (@ma, @ten, @giaBan, @ncc, @soLuong, @giaNhap)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmaSanPham.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txttenSanPham.Text.Trim());
                    cmd.Parameters.AddWithValue("@giaBan", donGiaBan);
                    cmd.Parameters.AddWithValue("@ncc", txtmaNhaCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@soLuong", soLuongTon);
                    cmd.Parameters.AddWithValue("@giaNhap", donGiaNhap);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadData();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá và số lượng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DBContext db = new DBContext();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE tt_sanpham SET tenSanPham=@ten, donGiaBan=@giaBan, maNhaCC=@ncc, soLuongTon=@soLuong, donGiaNhap=@giaNhap " +
                               "WHERE maSanPham=@ma";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", txtmaSanPham.Text);
                cmd.Parameters.AddWithValue("@ten", txttenSanPham.Text);
                cmd.Parameters.AddWithValue("@giaBan", decimal.Parse(txtdonGiaBan.Text));
                cmd.Parameters.AddWithValue("@ncc", txtmaNhaCC.Text);
                cmd.Parameters.AddWithValue("@soLuong", int.Parse(txtsoLuongTon.Text));
                cmd.Parameters.AddWithValue("@giaNhap", decimal.Parse(txtdonGiaNhap.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBContext db = new DBContext();
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM tt_sanpham WHERE maSanPham=@ma";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmaSanPham.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadData();
                }
            }
        }
        private bool KiemTraTrungMa(string maSP)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tt_sanpham WHERE maSanPham = @ma";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", maSP);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // ✅ Kiểm tra nếu người dùng chưa nhập mã cần tìm
            if (string.IsNullOrWhiteSpace(txtmaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để tìm kiếm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBContext db = new DBContext();
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM tt_sanpham WHERE maSanPham LIKE @ma";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", "%" + txtmaSP.Text.Trim() + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    // ✅ Kiểm tra kết quả
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã đã nhập.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmaSanPham.Text = row.Cells["maSanPham"].Value.ToString();
                txttenSanPham.Text = row.Cells["tenSanPham"].Value.ToString();
                txtdonGiaBan.Text = row.Cells["donGiaBan"].Value.ToString();
                txtmaNhaCC.Text = row.Cells["maNhaCC"].Value.ToString();
                txtsoLuongTon.Text = row.Cells["soLuongTon"].Value.ToString();
                txtdonGiaNhap.Text = row.Cells["donGiaNhap"].Value.ToString();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            LoadData();
        }
        private void ClearTextBoxes()
        {
            txtmaSanPham.Clear();
            txttenSanPham.Clear();
            txtdonGiaBan.Clear();
            txtmaNhaCC.Clear();
            txtsoLuongTon.Clear();
            txtdonGiaNhap.Clear();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap formNCC = new NhaCungCap();
            formNCC.Show();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapXuatKho formNhap = new NhapXuatKho();
            formNhap.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapXuatKho formXuat = new NhapXuatKho();
            formXuat.Show();
        }

        private void txtmaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
