using chamcong;
using MySql.Data.MySqlClient;
using System.Data;

namespace do_an

{
    public partial class QLThongTinNhanVien : Form
    {
        public QLThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            var conn = DbHelper.GetConnection();
            conn.Open();
            string query = "SELECT * FROM tt_nhanvien";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ma.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ma.Focus();
                return;
            }
            if (txt_ma.Text != txt_ma.Text.Trim())
            {
                MessageBox.Show("Mã nhân viên không được chứa khoảng trắng ở đầu hoặc cuối!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ma.Focus();
                return;
            }
            if (txt_ma.Text.Length > 50)
            {
                MessageBox.Show("Mã nhân viên không được vượt quá 50 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ma.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_ten.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên nhân viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_cv.Text))
            {
                MessageBox.Show("Vui lòng nhập Chức vụ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cv.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (!long.TryParse(txt_sdt.Text, out _))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tendn.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tendn.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_mk.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tx_mk.Focus();
                return;
            }
            if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_ma.Text) &&
                string.IsNullOrWhiteSpace(txt_ten.Text) &&
                string.IsNullOrWhiteSpace(txt_cv.Text) &&
                string.IsNullOrWhiteSpace(txt_sdt.Text) &&
                string.IsNullOrWhiteSpace(txt_tendn.Text) &&
                string.IsNullOrWhiteSpace(tx_mk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var conn = DbHelper.GetConnection();

            try
            {
                conn.Open();

                // Kiểm tra mã nhân viên trùng
                string checkSql = "SELECT COUNT(*) FROM tt_nhanvien WHERE maNhanVien=@ma";
                MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@ma", txt_ma.Text);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm mới nhân viên
                string sql = "INSERT INTO tt_nhanvien(maNhanVien, tenNhanVien, chucVu, ngaySinh, soDienThoaiNV, tenDangNhap, matKhau) " +
                             "VALUES (@ma, @ten, @cv, @ngay, @sdt, @tdn, @mk)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txt_ma.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txt_ten.Text);
                cmd.Parameters.AddWithValue("@cv", txt_cv.Text);
                cmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@tdn", txt_tendn.Text);
                cmd.Parameters.AddWithValue("@mk", tx_mk.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string sql = "DELETE FROM tt_nhanvien WHERE maNhanVien=@ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txt_ma.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData(); // Load lại danh sách
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_ma.Text = row.Cells["maNhanVien"].Value.ToString();
                txt_ten.Text = row.Cells["tenNhanVien"].Value.ToString();
                txt_cv.Text = row.Cells["chucVu"].Value.ToString(); // thêm dòng này
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value);
                txt_sdt.Text = row.Cells["soDienThoaiNV"].Value.ToString();
                txt_tendn.Text = row.Cells["tenDangNhap"].Value.ToString();
                tx_mk.Text = row.Cells["matKhau"].Value.ToString();
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string sql = "UPDATE tt_nhanvien SET tenNhanVien=@ten, chucVu=@cv, ngaySinh=@ngay, soDienThoaiNV=@sdt, tenDangNhap=@tdn, matKhau=@mk WHERE maNhanVien=@ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txt_ma.Text);
                cmd.Parameters.AddWithValue("@ten", txt_ten.Text);
                cmd.Parameters.AddWithValue("@cv", txt_cv.Text);
                cmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@tdn", txt_tendn.Text);
                cmd.Parameters.AddWithValue("@mk", tx_mk.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tk.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm.");
                return;
            }

            var conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM tt_nhanvien WHERE maNhanVien LIKE @ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", "%" + txt_tk.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên phù hợp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lmmoi_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_ma.Clear();
            txt_ten.Clear();
            txt_cv.Clear();
            txt_sdt.Clear();
            txt_tendn.Clear();
            tx_mk.Clear();
            txt_tk.Clear();

            dateTimePicker1.Value = DateTime.Today;
        }

        private void txt_ma_Leave(object sender, EventArgs e)
        {
            if (txt_ma.Text != txt_ma.Text.Trim())
            {
                MessageBox.Show("Mã nhân viên không được chứa khoảng trắng ở đầu hoặc cuối!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_ma.Focus();
            }
        }
    }
}
