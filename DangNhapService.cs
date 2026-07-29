using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuanLySieuThiDienMay
{
    public class DangNhapService
    {
        private string connStr = "server=localhost;user=root;database=sieuthidienmay;password=;";

        public (bool thanhCong, string chucVu, string maNhanVien) KiemTraDangNhap(string username, string password)
        {
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
                        return (true, reader["chucVu"].ToString(), reader["maNhanVien"].ToString());
                    }
                    else
                        return (false, "", "");
                }
                catch
                {
                    return (false, "", "");
                }
            }
        }

        [TestClass]
        public class DangNhapServiceTests
        {
            [TestMethod]
            public void KiemTraDangNhap_TaiKhoanDung_ThanhCong()
            {
                var service = new DangNhapService();
                var result = service.KiemTraDangNhap("admin", "123");

                Assert.IsTrue(result.thanhCong);
                Assert.AreEqual("Quản lý", result.chucVu);
                Assert.IsFalse(string.IsNullOrEmpty(result.maNhanVien));
            }

            [TestMethod]
            public void KiemTraDangNhap_TaiKhoanSai_ThatBai()
            {
                var service = new DangNhapService();
                var result = service.KiemTraDangNhap("saiuser", "saimk");

                Assert.IsFalse(result.thanhCong);
                Assert.AreEqual("", result.chucVu);
                Assert.AreEqual("", result.maNhanVien);
            }
        }


    }
}
