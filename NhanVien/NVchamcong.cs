using MySql.Data.MySqlClient;

namespace chamcong
{
    public partial class NVchamcong : Form
    {
        String maNhanVien;
        public NVchamcong(String _maNhanVien)
        {
            InitializeComponent();
            maNhanVien = _maNhanVien;
            txt_manv.Text = maNhanVien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();
            DateTime ngayCham = DateTime.Now;

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool daChamCong = false;

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    if (checkBox1.Checked)
                        daChamCong |= ChamCongCa(conn, maNV, ngayCham, 1);
                    if (checkBox2.Checked)
                        daChamCong |= ChamCongCa(conn, maNV, ngayCham, 2);
                    if (checkBox3.Checked)
                        daChamCong |= ChamCongCa(conn, maNV, ngayCham, 3);

                    if (daChamCong)
                        MessageBox.Show("Chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chưa chọn ca làm hoặc đã chấm công rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ChamCongCa(MySqlConnection conn, string maNV, DateTime ngayCham, int ca)
        {
            // Kiểm tra đã chấm công chưa
            string checkQuery = "SELECT COUNT(*) FROM tt_chamcong WHERE MaNhanVien=@maNV AND DATE(ngayChamCong)=DATE(@ngay) AND caLam=@ca";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@maNV", maNV);
            checkCmd.Parameters.AddWithValue("@ngay", ngayCham);
            checkCmd.Parameters.AddWithValue("@ca", ca);
            int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (exists > 0) return false;

            // Chưa chấm thì thêm
            string insertQuery = "INSERT INTO tt_chamcong (MaNhanVien, ngayChamCong, caLam) VALUES (@maNV, @ngay, @ca)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@maNV", maNV);
            insertCmd.Parameters.AddWithValue("@ngay", ngayCham);
            insertCmd.Parameters.AddWithValue("@ca", ca);
            insertCmd.ExecuteNonQuery();

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NVchamcong_Load(object sender, EventArgs e)
        {
            txt_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            timer1.Interval = 1000;
            timer1.Tick += (s, ev) =>
            {
                txt_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            };
            timer1.Start();
        }
    }
}
