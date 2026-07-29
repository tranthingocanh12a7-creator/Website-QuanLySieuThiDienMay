using chamcong;
using do_an;
using DoAn1;
using DOAN1;
using DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo;

namespace QuanLySieuThiDienMay
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
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

        private void Menu_tt_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                QLThongTinNhanVien BaoCao = new QLThongTinNhanVien();
                BaoCao.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }

        private void Menu_QL_ChamCong(object sender, EventArgs e)
        {
            try
            {
                QLChamCong BaoCao = new QLChamCong();
                BaoCao.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }

        private void Menu_QL_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                FormBanhang BaoCao = new FormBanhang();
                BaoCao.Show(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
                this.Show(); // Đảm bảo form chính luôn hiển thị lại nếu có lỗi
            }
        }

        private void thốngKêVàBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormThongKe BaoCao = new FormThongKe();
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
                SanPham BaoCao = new SanPham();
                BaoCao.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }

        private void thôngYinNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinKoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
