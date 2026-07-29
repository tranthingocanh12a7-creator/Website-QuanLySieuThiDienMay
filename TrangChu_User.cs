using chamcong;
using DoAn1;
using DOAN1;
using QuanLySieuThiDienMay.Database;
using QuanLySieuThiDienMay.HoaDon;

namespace QuanLySieuThiDienMay
{
    public partial class TrangChu_User : Form
    {
        string maNhanVien;
        public TrangChu_User(String _maNhanVien)
        {
            InitializeComponent();
            maNhanVien = _maNhanVien;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chamCongtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NVchamcong BaoCao = new NVchamcong(maNhanVien);
                BaoCao.Show(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }

        private void Menu_QLHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                FormBanHang_User BaoCao = new FormBanHang_User();
                BaoCao.Show(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham_User BaoCao = new SanPham_User();
                BaoCao.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }
    }
}
