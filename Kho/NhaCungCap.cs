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
    public partial class NhaCungCap : Form
    {
        DBContext db = new DBContext();
        public NhaCungCap()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadData()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT maNhaCC AS 'Mã NCC', tenNhaCC AS 'Tên nhà cung cấp', " +
                                   "soDienThoaiNhaCC AS 'SĐT', diaChiNhaCC AS 'Địa chỉ' FROM tt_nhacc";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KiemTraTrungMa(string maNCC)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tt_nhacc WHERE maNhaCC = @ma";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", maNCC);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // ✅ Kiểm tra người dùng có nhập mã NCC hay không
            if (string.IsNullOrWhiteSpace(txtmaNhacc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM tt_nhacc WHERE maNhaCC LIKE @ma";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", "%" + txtmaNhacc.Text.Trim() + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp có mã phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // ✅ Kiểm tra dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(txtmaNhCC.Text) ||
                string.IsNullOrWhiteSpace(txttenNhaCC.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Kiểm tra trùng mã nhà cung cấp
            if (KiemTraTrungMa(txtmaNhCC.Text.Trim()))
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại. Vui lòng nhập mã khác!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO tt_nhacc (maNhaCC, tenNhaCC, soDienThoaiNhaCC, diaChiNhaCC) " +
                                   "VALUES (@ma, @ten, @sdt, @diachi)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmaNhCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txttenNhaCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE tt_nhacc 
                         SET tenNhaCC = @ten, 
                             soDienThoaiNhaCC = @sdt, 
                             diaChiNhaCC = @diachi 
                         WHERE maNhaCC = @ma";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", txtmaNhCC.Text);
                cmd.Parameters.AddWithValue("@ten", txttenNhaCC.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp để cập nhật.");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM tt_nhacc WHERE maNhaCC=@ma";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmaNhCC.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtmaNhCC.Text = row.Cells[0].Value?.ToString();
                txttenNhaCC.Text = row.Cells[1].Value?.ToString();
                txtSDT.Text = row.Cells[2].Value?.ToString();
                txtDiaChi.Text = row.Cells[3].Value?.ToString();
            }
        }

        private NhaCungCap? formNCC;

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formNCC == null || formNCC.IsDisposed)
            {
                formNCC = new NhaCungCap();
                formNCC.Show();
            }
            else
            {
                formNCC.BringToFront();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
