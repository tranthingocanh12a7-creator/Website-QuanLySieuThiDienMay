namespace DoAn1
{
    partial class NhapXuatKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// this.Load += new System.EventHandler(this.NhapXuatKho_Load);

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
            label6 = new Label();
            btnTao = new Button();
            btnSua = new Button();
            btnXoaChiTietHD = new Button();
            groupBox3 = new GroupBox();
            dgvChiTiet = new DataGridView();
            groupBox2 = new GroupBox();
            txtsoLuongTon = new NumericUpDown();
            txtTenSanPham = new TextBox();
            label1 = new Label();
            cboSP = new ComboBox();
            label5 = new Label();
            btnThemChiTietHD = new Button();
            txtdonGia = new TextBox();
            label9 = new Label();
            label8 = new Label();
            comboBox4 = new ComboBox();
            groupBox1 = new GroupBox();
            cbloaiHoaDon = new ComboBox();
            lblloaiHoaDon = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpNgayLap = new DateTimePicker();
            cboNhanVien = new ComboBox();
            txtMaPhieu = new TextBox();
            textBox3 = new TextBox();
            lblTongTienSanPham = new Label();
            lblTonKho = new Label();
            label7 = new Label();
            label10 = new Label();
            btnLichSu = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtsoLuongTon).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(427, 31);
            label6.Name = "label6";
            label6.Size = new Size(371, 31);
            label6.TabIndex = 36;
            label6.Text = "TẠO HÓA ĐƠN NHẬP XUẤT KHO";
            // 
            // btnTao
            // 
            btnTao.Location = new Point(339, 627);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(84, 28);
            btnTao.TabIndex = 44;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(491, 627);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 28);
            btnSua.TabIndex = 43;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoaChiTietHD
            // 
            btnXoaChiTietHD.Location = new Point(661, 627);
            btnXoaChiTietHD.Name = "btnXoaChiTietHD";
            btnXoaChiTietHD.Size = new Size(84, 28);
            btnXoaChiTietHD.TabIndex = 42;
            btnXoaChiTietHD.Text = "Xóa";
            btnXoaChiTietHD.UseVisualStyleBackColor = true;
            btnXoaChiTietHD.Click += btnXoaChiTietHD_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvChiTiet);
            groupBox3.Location = new Point(27, 336);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1127, 231);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(44, 47);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 31;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(1083, 179);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtsoLuongTon);
            groupBox2.Controls.Add(txtTenSanPham);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboSP);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnThemChiTietHD);
            groupBox2.Controls.Add(txtdonGia);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(22, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1142, 87);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // txtsoLuongTon
            // 
            txtsoLuongTon.Location = new Point(657, 28);
            txtsoLuongTon.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtsoLuongTon.Name = "txtsoLuongTon";
            txtsoLuongTon.Size = new Size(92, 27);
            txtsoLuongTon.TabIndex = 11;
            txtsoLuongTon.ValueChanged += txtsoLuongTon_ValueChanged;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(330, 27);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new Size(194, 27);
            txtTenSanPham.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 28;
            label1.Text = "Tên sản phẩm";
            // 
            // cboSP
            // 
            cboSP.FormattingEnabled = true;
            cboSP.Location = new Point(104, 26);
            cboSP.Name = "cboSP";
            cboSP.Size = new Size(94, 28);
            cboSP.TabIndex = 27;
            cboSP.SelectedIndexChanged += cboSP_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 29);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 12;
            label5.Text = "Mã SP:";
            // 
            // btnThemChiTietHD
            // 
            btnThemChiTietHD.Location = new Point(1048, 29);
            btnThemChiTietHD.Name = "btnThemChiTietHD";
            btnThemChiTietHD.Size = new Size(84, 28);
            btnThemChiTietHD.TabIndex = 25;
            btnThemChiTietHD.Text = "Thêm";
            btnThemChiTietHD.UseVisualStyleBackColor = true;
            btnThemChiTietHD.Click += btnThemChiTietHD_Click;
            // 
            // txtdonGia
            // 
            txtdonGia.Location = new Point(870, 29);
            txtdonGia.Name = "txtdonGia";
            txtdonGia.ReadOnly = true;
            txtdonGia.Size = new Size(172, 27);
            txtdonGia.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(786, 33);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 23;
            label9.Text = "Đơn giá:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 33);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 18;
            label8.Text = "Số lượng :";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(808, 268);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(112, 28);
            comboBox4.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbloaiHoaDon);
            groupBox1.Controls.Add(lblloaiHoaDon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Location = new Point(22, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1148, 103);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Xuất kho";
            // 
            // cbloaiHoaDon
            // 
            cbloaiHoaDon.FormattingEnabled = true;
            cbloaiHoaDon.Items.AddRange(new object[] { "Nhập", "Xuất" });
            cbloaiHoaDon.Location = new Point(344, 30);
            cbloaiHoaDon.Name = "cbloaiHoaDon";
            cbloaiHoaDon.Size = new Size(112, 28);
            cbloaiHoaDon.TabIndex = 10;
            cbloaiHoaDon.SelectedValueChanged += cbloaiHoaDon_SelectedValueChanged;
            // 
            // lblloaiHoaDon
            // 
            lblloaiHoaDon.AutoSize = true;
            lblloaiHoaDon.Location = new Point(235, 33);
            lblloaiHoaDon.Name = "lblloaiHoaDon";
            lblloaiHoaDon.Size = new Size(103, 20);
            lblloaiHoaDon.TabIndex = 9;
            lblloaiHoaDon.Text = "Loại hóa đơn: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 33);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(786, 33);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 33);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã Hóa đơn:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Location = new Point(864, 30);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(278, 27);
            dtpNgayLap.TabIndex = 5;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Items.AddRange(new object[] { "Trần Thị Ngọc Ánh", "Lê Thị Thủy Ngân", "Vũ Thị Giang", "Nguyễn Linh Chi", "Lê Thị Ánh Linh" });
            cboNhanVien.Location = new Point(570, 30);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(184, 28);
            cboNhanVien.TabIndex = 4;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(122, 30);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(90, 27);
            txtMaPhieu.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 27);
            textBox3.TabIndex = 39;
            // 
            // lblTongTienSanPham
            // 
            lblTongTienSanPham.AutoSize = true;
            lblTongTienSanPham.Location = new Point(1024, 313);
            lblTongTienSanPham.Name = "lblTongTienSanPham";
            lblTongTienSanPham.Size = new Size(0, 20);
            lblTongTienSanPham.TabIndex = 30;
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Location = new Point(661, 313);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(0, 20);
            lblTonKho.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(586, 313);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 45;
            label7.Text = "Tồn kho: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(878, 313);
            label10.Name = "label10";
            label10.Size = new Size(140, 20);
            label10.TabIndex = 46;
            label10.Text = "Tổng tiền sản phẩm";
            // 
            // btnLichSu
            // 
            btnLichSu.Location = new Point(836, 627);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(84, 28);
            btnLichSu.TabIndex = 47;
            btnLichSu.Text = "Lịch sử";
            btnLichSu.UseVisualStyleBackColor = true;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // NhapXuatKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 688);
            Controls.Add(btnLichSu);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(lblTonKho);
            Controls.Add(lblTongTienSanPham);
            Controls.Add(label6);
            Controls.Add(btnTao);
            Controls.Add(btnSua);
            Controls.Add(btnXoaChiTietHD);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(comboBox4);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Name = "NhapXuatKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XuatKho";
            Load += NhapXuatKho_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtsoLuongTon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnTao;
        private Button btnSua;
        private Button btnXoaChiTietHD;
        private GroupBox groupBox3;
        private DataGridView dgvChiTiet;
        private GroupBox groupBox2;
        private ComboBox cboSP;
        private Label label5;
        private Button btnThemChiTietHD;
        private TextBox txtdonGia;
        private Label label9;
        private Label label8;
        private ComboBox comboBox4;
        private GroupBox groupBox1;
        private ComboBox cbloaiHoaDon;
        private Label lblloaiHoaDon;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayLap;
        private ComboBox cboNhanVien;
        private TextBox textBox3;
        private TextBox txtMaPhieu;
        private TextBox txtTenSanPham;
        private Label label1;
        private Label lblTongTienSanPham;
        private NumericUpDown txtsoLuongTon;
        private Label lblTonKho;
        private Label label7;
        private Label label10;
        private Button btnLichSu;
    }
}