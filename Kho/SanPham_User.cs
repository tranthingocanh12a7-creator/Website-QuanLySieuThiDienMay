using DoAn1.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DoAn1
{
    public partial class SanPham_User : Form
    {
        DBContext db = new DBContext();
        public SanPham_User()
        {
            InitializeComponent();
            LoadData();
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
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            LoadData();
        }
        private void ClearTextBoxes()
        {
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap formNCC = new NhaCungCap();
            formNCC.Show();
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
