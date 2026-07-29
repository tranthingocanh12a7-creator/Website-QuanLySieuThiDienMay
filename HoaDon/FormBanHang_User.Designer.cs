namespace QuanLySieuThiDienMay.HoaDon
{
    partial class FormBanHang_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang_User));
            toolStrip1 = new ToolStrip();
            tsLichsubanhang = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            btnThoat = new Button();
            label1 = new Label();
            btnHuy = new Button();
            btnXoaSanPham = new Button();
            btnTaoHoaDon = new Button();
            dgvThongTinSanPham = new DataGridView();
            grbThongTinSanPham = new GroupBox();
            txtTonKho = new TextBox();
            nudsoluong = new NumericUpDown();
            txtTenSanpham = new TextBox();
            txtDonGia = new TextBox();
            btnThemSanPham = new Button();
            cbMasanpham = new ComboBox();
            grbThongtinchung = new GroupBox();
            cbManv = new ComboBox();
            btnThemKhachHang = new Button();
            lblTongThanhTien = new Label();
            dtpNgayTao = new DateTimePicker();
            cbmakhachhang = new ComboBox();
            txtMaHd = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).BeginInit();
            grbThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).BeginInit();
            grbThongtinchung.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsLichsubanhang, toolStripSeparator1, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(1150, 27);
            toolStrip1.TabIndex = 20;
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Tomato;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(743, 558);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 43);
            btnThoat.TabIndex = 29;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(484, 59);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 22;
            label1.Text = "HÓA ĐƠN";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Tomato;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(627, 557);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 43);
            btnHuy.TabIndex = 28;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = Color.Tomato;
            btnXoaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaSanPham.ForeColor = SystemColors.ControlLightLight;
            btnXoaSanPham.Location = new Point(482, 557);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(139, 44);
            btnXoaSanPham.TabIndex = 26;
            btnXoaSanPham.Text = "Xóa sản phẩm";
            btnXoaSanPham.UseVisualStyleBackColor = false;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.BackColor = Color.Tomato;
            btnTaoHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaoHoaDon.ForeColor = SystemColors.ControlLightLight;
            btnTaoHoaDon.Location = new Point(212, 557);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(263, 43);
            btnTaoHoaDon.TabIndex = 25;
            btnTaoHoaDon.Text = "Thanh toán";
            btnTaoHoaDon.UseVisualStyleBackColor = false;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // dgvThongTinSanPham
            // 
            dgvThongTinSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinSanPham.Location = new Point(9, 316);
            dgvThongTinSanPham.Name = "dgvThongTinSanPham";
            dgvThongTinSanPham.RowHeadersWidth = 51;
            dgvThongTinSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongTinSanPham.Size = new Size(1108, 209);
            dgvThongTinSanPham.TabIndex = 24;
            dgvThongTinSanPham.CellContentClick += dgvThongTinSanPham_CellContentClick;
            dgvThongTinSanPham.CellEndEdit += dgvThongTinSanPham_CellEndEdit;
            dgvThongTinSanPham.CellValueChanged += dgvThongTinSanPham_CellValueChanged;
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
            grbThongTinSanPham.Location = new Point(9, 210);
            grbThongTinSanPham.Name = "grbThongTinSanPham";
            grbThongTinSanPham.Size = new Size(1108, 71);
            grbThongTinSanPham.TabIndex = 23;
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
            // grbThongtinchung
            // 
            grbThongtinchung.BackColor = Color.PaleTurquoise;
            grbThongtinchung.Controls.Add(cbManv);
            grbThongtinchung.Controls.Add(btnThemKhachHang);
            grbThongtinchung.Controls.Add(lblTongThanhTien);
            grbThongtinchung.Controls.Add(dtpNgayTao);
            grbThongtinchung.Controls.Add(cbmakhachhang);
            grbThongtinchung.Controls.Add(txtMaHd);
            grbThongtinchung.Location = new Point(9, 112);
            grbThongtinchung.Name = "grbThongtinchung";
            grbThongtinchung.Size = new Size(1108, 71);
            grbThongtinchung.TabIndex = 21;
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
            // 
            // lblTongThanhTien
            // 
            lblTongThanhTien.AutoSize = true;
            lblTongThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongThanhTien.Location = new Point(794, 35);
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
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // FormBanHang_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 655);
            Controls.Add(btnThoat);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnXoaSanPham);
            Controls.Add(btnTaoHoaDon);
            Controls.Add(dgvThongTinSanPham);
            Controls.Add(grbThongTinSanPham);
            Controls.Add(grbThongtinchung);
            Controls.Add(toolStrip1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormBanHang_User";
            Text = "FormBanHang_User";
            Load += FormBanHang_User_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).EndInit();
            grbThongTinSanPham.ResumeLayout(false);
            grbThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).EndInit();
            grbThongtinchung.ResumeLayout(false);
            grbThongtinchung.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton tsLichsubanhang;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private Button btnThoat;
        private Label label1;
        private Button btnHuy;
        private Button btnXoaSanPham;
        private Button btnTaoHoaDon;
        private DataGridView dgvThongTinSanPham;
        private GroupBox grbThongTinSanPham;
        private TextBox txtTonKho;
        private NumericUpDown nudsoluong;
        private TextBox txtTenSanpham;
        private TextBox txtDonGia;
        private Button btnThemSanPham;
        private ComboBox cbMasanpham;
        private GroupBox grbThongtinchung;
        private ComboBox cbManv;
        private Button btnThemKhachHang;
        private Label lblTongThanhTien;
        private DateTimePicker dtpNgayTao;
        private ComboBox cbmakhachhang;
        private TextBox txtMaHd;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}