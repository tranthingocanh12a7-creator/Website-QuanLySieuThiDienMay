using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace QuanLySieuThiDienMay
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=sieuthidienmay;password=;";
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT chucVu, maNhanVien FROM tt_nhanvien WHERE tenDangNhap = @user AND matKhau = @pass";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string chucVu = reader["chucVu"].ToString();
                        string maNhanVien = reader["maNhanVien"].ToString();

                        this.Hide(); // Ẩn form đăng nhập

                        DialogResult result;

                        if (chucVu == "Quản lý")
                        {
                            TrangChu formAdmin = new TrangChu();
                            result = formAdmin.ShowDialog();
                        }
                        else
                        {
                            TrangChu_User formUser = new TrangChu_User(maNhanVien);
                            result = formUser.ShowDialog();
                        }

                        if (result == DialogResult.OK)
                        {
                            // Người dùng chọn "Đăng xuất" → quay lại form đăng nhập
                            this.Show();
                            txtMatKhau.Clear();
                            txtMatKhau.Focus();
                        }
                        else
                        {
                            // Người dùng tắt form (nút X) → thoát toàn bộ chương trình
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatKhau.Clear();
                        txtMatKhau.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                txtTenDangNhap.Focus();
            }
        }
    }
}
