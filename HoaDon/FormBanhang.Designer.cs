namespace DOAN1
{
    partial class FormBanhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanhang));
            grbThongtinchung = new GroupBox();
            cbManv = new ComboBox();
            btnThemKhachHang = new Button();
            lblTongThanhTien = new Label();
            dtpNgayTao = new DateTimePicker();
            cbmakhachhang = new ComboBox();
            txtMaHd = new TextBox();
            btnThemSanPham = new Button();
            grbThongTinSanPham = new GroupBox();
            txtTonKho = new TextBox();
            nudsoluong = new NumericUpDown();
            txtTenSanpham = new TextBox();
            txtDonGia = new TextBox();
            cbMasanpham = new ComboBox();
            dgvThongTinSanPham = new DataGridView();
            btnTaoHoaDon = new Button();
            btnXoaSanPham = new Button();
            toolStrip1 = new ToolStrip();
            tsLichsubanhang = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsDoanhthu = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnHuy = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label1 = new Label();
            btnThoat = new Button();
            grbThongtinchung.SuspendLayout();
            grbThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbThongtinchung
            // 
            grbThongtinchung.BackColor = Color.PaleTurquoise;
            grbThongtinchung.Controls.Add(cbManv);
            grbThongtinchung.Controls.Add(btnThemKhachHang);
            grbThongtinchung.Controls.Add(lblTongThanhTien);
            grbThongtinchung.Controls.Add(dtpNgayTao);
            grbThongtinchung.Controls.Add(cbmakhachhang);
            grbThongtinchung.Controls.Add(txtMaHd);
            grbThongtinchung.Location = new Point(32, 95);
            grbThongtinchung.Name = "grbThongtinchung";
            grbThongtinchung.Size = new Size(1108, 71);
            grbThongtinchung.TabIndex = 0;
            grbThongtinchung.TabStop = false;
            grbThongtinchung.Text = "Thông tin chung";
            // 
            // cbManv
            // 
            cbManv.FormattingEnabled = true;
            cbManv.Location = new Point(138, 25);
            cbManv.Name = "cbManv";
            cbManv.Size = new Size(96, 28);
            cbManv.TabIndex = 6;
            cbManv.SelectedIndexChanged += cbManv_SelectedIndexChanged;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackgroundImage = (Image)resources.GetObject("btnThemKhachHang.BackgroundImage");
            btnThemKhachHang.BackgroundImageLayout = ImageLayout.Stretch;
            btnThemKhachHang.Location = new Point(393, 23);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(39, 36);
            btnThemKhachHang.TabIndex = 5;
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // lblTongThanhTien
            // 
            lblTongThanhTien.AutoSize = true;
            lblTongThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongThanhTien.Location = new Point(793, 34);
            lblTongThanhTien.Name = "lblTongThanhTien";
            lblTongThanhTien.Size = new Size(121, 20);
            lblTongThanhTien.TabIndex = 4;
            lblTongThanhTien.Text = "Tổng thành tiền";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Enabled = false;
            dtpNgayTao.Location = new Point(473, 26);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(250, 27);
            dtpNgayTao.TabIndex = 2;
            // 
            // cbmakhachhang
            // 
            cbmakhachhang.FormattingEnabled = true;
            cbmakhachhang.Location = new Point(266, 25);
            cbmakhachhang.Name = "cbmakhachhang";
            cbmakhachhang.Size = new Size(96, 28);
            cbmakhachhang.TabIndex = 1;
            // 
            // txtMaHd
            // 
            txtMaHd.Location = new Point(19, 26);
            txtMaHd.Name = "txtMaHd";
            txtMaHd.PlaceholderText = "Ma hoa don";
            txtMaHd.ReadOnly = true;
            txtMaHd.Size = new Size(84, 27);
            txtMaHd.TabIndex = 0;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.BackColor = Color.Tomato;
            btnThemSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemSanPham.ForeColor = SystemColors.ControlLightLight;
            btnThemSanPham.Location = new Point(793, 21);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(263, 32);
            btnThemSanPham.TabIndex = 3;
            btnThemSanPham.Text = "Them san pham ";
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // grbThongTinSanPham
            // 
            grbThongTinSanPham.BackColor = Color.PaleTurquoise;
            grbThongTinSanPham.Controls.Add(txtTonKho);
            grbThongTinSanPham.Controls.Add(nudsoluong);
            grbThongTinSanPham.Controls.Add(txtTenSanpham);
            grbThongTinSanPham.Controls.Add(txtDonGia);
            grbThongTinSanPham.Controls.Add(btnThemSanPham);
            grbThongTinSanPham.Controls.Add(cbMasanpham);
            grbThongTinSanPham.Location = new Point(32, 172);
            grbThongTinSanPham.Name = "grbThongTinSanPham";
            grbThongTinSanPham.Size = new Size(1108, 71);
            grbThongTinSanPham.TabIndex = 7;
            grbThongTinSanPham.TabStop = false;
            grbThongTinSanPham.Text = "Thông tin sản phẩm";
            // 
            // txtTonKho
            // 
            txtTonKho.Location = new Point(475, 28);
            txtTonKho.Name = "txtTonKho";
            txtTonKho.PlaceholderText = "Tồn kho";
            txtTonKho.ReadOnly = true;
            txtTonKho.Size = new Size(115, 27);
            txtTonKho.TabIndex = 8;
            // 
            // nudsoluong
            // 
            nudsoluong.Location = new Point(624, 27);
            nudsoluong.Name = "nudsoluong";
            nudsoluong.Size = new Size(101, 27);
            nudsoluong.TabIndex = 7;
            nudsoluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtTenSanpham
            // 
            txtTenSanpham.Location = new Point(138, 28);
            txtTenSanpham.Name = "txtTenSanpham";
            txtTenSanpham.PlaceholderText = "Ten san pham";
            txtTenSanpham.ReadOnly = true;
            txtTenSanpham.Size = new Size(144, 27);
            txtTenSanpham.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(316, 25);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Don gia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(116, 27);
            txtDonGia.TabIndex = 0;
            // 
            // cbMasanpham
            // 
            cbMasanpham.FormattingEnabled = true;
            cbMasanpham.Location = new Point(19, 27);
            cbMasanpham.Name = "cbMasanpham";
            cbMasanpham.Size = new Size(96, 28);
            cbMasanpham.TabIndex = 1;
            cbMasanpham.SelectedIndexChanged += cbMasanpham_SelectedIndexChanged;
            cbMasanpham.KeyDown += cbMasanpham_KeyDown;
            cbMasanpham.Leave += cbMasanpham_Leave;
            // 
            // dgvThongTinSanPham
            // 
            dgvThongTinSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinSanPham.Location = new Point(32, 264);
            dgvThongTinSanPham.Name = "dgvThongTinSanPham";
            dgvThongTinSanPham.RowHeadersWidth = 51;
            dgvThongTinSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongTinSanPham.Size = new Size(1108, 209);
            dgvThongTinSanPham.TabIndex = 8;
            dgvThongTinSanPham.CellContentClick += dgvThongTinSanPham_CellContentClick;
            dgvThongTinSanPham.CellEndEdit += dgvThongTinSanPham_CellEndEdit;
            dgvThongTinSanPham.CellValueChanged += dgvThongTinSanPham_CellValueChanged;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.BackColor = Color.Tomato;
            btnTaoHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaoHoaDon.ForeColor = SystemColors.ControlLightLight;
            btnTaoHoaDon.Location = new Point(235, 505);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(263, 43);
            btnTaoHoaDon.TabIndex = 9;
            btnTaoHoaDon.Text = "Thanh toán";
            btnTaoHoaDon.UseVisualStyleBackColor = false;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = Color.Tomato;
            btnXoaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaSanPham.ForeColor = SystemColors.ControlLightLight;
            btnXoaSanPham.Location = new Point(505, 505);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(139, 44);
            btnXoaSanPham.TabIndex = 10;
            btnXoaSanPham.Text = "Xóa sản phẩm";
            btnXoaSanPham.UseVisualStyleBackColor = false;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsLichsubanhang, toolStripSeparator1, tsDoanhthu, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1187, 27);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsLichsubanhang
            // 
            tsLichsubanhang.ImageTransparentColor = Color.Magenta;
            tsLichsubanhang.Name = "tsLichsubanhang";
            tsLichsubanhang.Size = new Size(143, 24);
            tsLichsubanhang.Text = "Lịch sử tạo hóa đơn";
            tsLichsubanhang.Click += tsLichsubanhang_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsDoanhthu
            // 
            tsDoanhthu.ImageTransparentColor = Color.Magenta;
            tsDoanhthu.Name = "tsDoanhthu";
            tsDoanhthu.Size = new Size(82, 24);
            tsDoanhthu.Text = "Doanh thu";
            tsDoanhthu.Click += tsDoanhthu_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Tomato;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(650, 505);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 43);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 57);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 7;
            label1.Text = "HÓA ĐƠN";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Tomato;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(766, 506);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 43);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += button1_Click;
            // 
            // FormBanhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 596);
            Controls.Add(btnThoat);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(toolStrip1);
            Controls.Add(btnXoaSanPham);
            Controls.Add(btnTaoHoaDon);
            Controls.Add(dgvThongTinSanPham);
            Controls.Add(grbThongTinSanPham);
            Controls.Add(grbThongtinchung);
            Name = "FormBanhang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBanhang";
            Load += FormBanhang_Load;
            grbThongtinchung.ResumeLayout(false);
            grbThongtinchung.PerformLayout();
            grbThongTinSanPham.ResumeLayout(false);
            grbThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongtinchung;
        private Button btnThemKhachHang;
        private Label lblTongThanhTien;
        private DateTimePicker dtpNgayTao;
        private ComboBox cbmakhachhang;
        private TextBox txtMaHd;
        private Button btnThemSanPham;
        private GroupBox grbThongTinSanPham;
        private NumericUpDown nudsoluong;
        private TextBox txtTenSanpham;
        private TextBox txtDonGia;
        private ComboBox cbMasanpham;
        private DataGridView dgvThongTinSanPham;
        private Button btnTaoHoaDon;
        private TextBox txtTonKho;
        private ComboBox cbManv;
        private Button btnXoaSanPham;
        private ToolStrip toolStrip1;
        private ToolStripButton tsLichsubanhang;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsDoanhthu;
        private ToolStripSeparator toolStripSeparator2;
        private Button btnHuy;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private Button btnThoat;
    }
}