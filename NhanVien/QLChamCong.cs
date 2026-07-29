using MySql.Data.MySqlClient;
using System.Data;

namespace chamcong
{
    public partial class QLChamCong : Form
    {
        public QLChamCong()
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
            string query = @"
        SELECT MaNhanVien, ngayChamCong,
            MAX(caLam = 1) AS Ca1,
            MAX(caLam = 2) AS Ca2,
            MAX(caLam = 3) AS Ca3
        FROM tt_chamcong
        GROUP BY MaNhanVien, ngayChamCong
        ORDER BY ngayChamCong DESC";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }
        private void ClearForm()
        {
            txt_manv.Clear();
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            txt_tk.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();
            DateTime ngay = dateTimePicker1.Value.Date;

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                return;
            }
            
            if (maNV.Contains(" "))
            {
                MessageBox.Show("Mã nhân viên không được chứa khoảng trắng!");
                return;
            }

            
            if (ngay > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày chấm công không được lớn hơn ngày hiện tại!");
                return;
            }

            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ca làm!");
                return;
            }
            if (maNV.Length > 50)
            {
                MessageBox.Show("Mã nhân viên không được vượt quá 50 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string checkNVSql = "SELECT COUNT(*) FROM tt_chamcong" +" WHERE MaNhanVien = @ma";
                MySqlCommand checkNVCmd = new MySqlCommand(checkNVSql, conn);
                checkNVCmd.Parameters.AddWithValue("@ma", maNV);
                int exists = Convert.ToInt32(checkNVCmd.ExecuteScalar());

                if (exists == 0)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!");
                    return;
                }

                List<int> caLamList = new List<int>();
                if (checkBox1.Checked) caLamList.Add(1);
                if (checkBox2.Checked) caLamList.Add(2);
                if (checkBox3.Checked) caLamList.Add(3);

                foreach (int ca in caLamList)
                {
                    string checkSql = "SELECT COUNT(*) FROM tt_chamcong WHERE MaNhanVien=@ma AND ngayChamCong=@ngay AND caLam=@ca";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@ma", maNV);
                    checkCmd.Parameters.AddWithValue("@ngay", ngay);
                    checkCmd.Parameters.AddWithValue("@ca", ca);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0) continue;

                    string insertSql = "INSERT INTO tt_chamcong (MaNhanVien, ngayChamCong, caLam) VALUES (@ma, @ngay, @ca)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@ma", maNV);
                    insertCmd.Parameters.AddWithValue("@ngay", ngay);
                    insertCmd.Parameters.AddWithValue("@ca", ca);

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Chấm công thành công!");
                LoadData();
                ClearForm();
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string ma = txt_manv.Text.Trim();
                DateTime ngay = dateTimePicker1.Value.Date;

                List<int> caList = new List<int>();
                if (checkBox1.Checked) caList.Add(1);
                if (checkBox2.Checked) caList.Add(2);
                if (checkBox3.Checked) caList.Add(3);

                foreach (int ca in caList)
                {
                    string sql = "DELETE FROM tt_chamcong WHERE MaNhanVien = @ma AND ngayChamCong = @ngay AND caLam = @ca";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                    cmd.Parameters.AddWithValue("@ca", ca);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa thành công!");
                LoadData();
                ClearForm();
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ bảng.");
                return;
            }

            var conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string ma = txt_manv.Text.Trim();
                DateTime ngay = dateTimePicker1.Value.Date;

               
                string deleteSql = "DELETE FROM tt_chamcong WHERE MaNhanVien=@ma AND ngayChamCong=@ngay";
                MySqlCommand deleteCmd = new MySqlCommand(deleteSql, conn);
                deleteCmd.Parameters.AddWithValue("@ma", ma);
                deleteCmd.Parameters.AddWithValue("@ngay", ngay);
                deleteCmd.ExecuteNonQuery();

                
                List<int> caLamList = new List<int>();
                if (checkBox1.Checked) caLamList.Add(1);
                if (checkBox2.Checked) caLamList.Add(2);
                if (checkBox3.Checked) caLamList.Add(3);

                foreach (int ca in caLamList)
                {
                    string insertSql = "INSERT INTO tt_chamcong (MaNhanVien, ngayChamCong, caLam) VALUES (@ma, @ngay, @ca)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@ma", ma);
                    insertCmd.Parameters.AddWithValue("@ngay", ngay);
                    insertCmd.Parameters.AddWithValue("@ca", ca);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ClearForm();
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

        private void button5_Click(object sender, EventArgs e)
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string searchSql = @"
                SELECT MaNhanVien, ngayChamCong,
                       MAX(caLam = 1) AS Ca1,
                       MAX(caLam = 2) AS Ca2,
                       MAX(caLam = 3) AS Ca3
                FROM tt_chamcong
                WHERE MaNhanVien LIKE @ma
                GROUP BY MaNhanVien, ngayChamCong
                ORDER BY ngayChamCong DESC";
                    MySqlCommand cmd = new MySqlCommand(searchSql, conn);
                    cmd.Parameters.AddWithValue("@ma", "%" + txt_tk.Text.Trim() + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (table.Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_manv.Text = row.Cells["MaNhanVien"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngayChamCong"].Value);
                checkBox1.Checked = Convert.ToBoolean(row.Cells["Ca1"].Value);
                checkBox2.Checked = Convert.ToBoolean(row.Cells["Ca2"].Value);
                checkBox3.Checked = Convert.ToBoolean(row.Cells["Ca3"].Value);
            }
        }

        private void btn_lmmoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }
    }
}
