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

namespace DOAN1
{
    public partial class FormThemKhachHang : Form
    {

        internal string GetMaKhachHangMoi()
        {
            return maKhachHangMoi;
        }

        private void SetMaKhachHangMoi(string value)
        {
            maKhachHangMoi = value;
        }

        string connectionString = "server=localhost;uid=root;pwd=;database=sieuthidienmay;";
        private string maKhachHangMoi;

        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {
            SetMaKhachHangMoi(TaoMaKhachHangTuDong());
            txtMakh.Text = GetMaKhachHangMoi().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenkh.Text.Trim();
            string sdt = txtSodt.Text.Trim();

            if (tenKH == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tt_khachhang (maKhachHang, tenKhachHang, soDienThoaiKH) VALUES (@maKH, @tenKH, @sdt)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maKH", GetMaKhachHangMoi());
                cmd.Parameters.AddWithValue("@tenKH", tenKH);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã thêm khách hàng mới!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private string TaoMaKhachHangTuDong()
        {
            string maMoi = "KH001";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maKhachHang FROM tt_khachhang ORDER BY maKhachHang DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string maCu = result.ToString(); // KH005
                    int so = int.Parse(maCu.Substring(2));
                    so++;
                    maMoi = "KH" + so.ToString("D3");
                }
            }
            return maMoi;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
