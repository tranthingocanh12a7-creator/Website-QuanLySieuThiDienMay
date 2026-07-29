namespace DoAn1
{
    partial class SanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblmaSanPham = new Label();
            txtmaSanPham = new TextBox();
            txttenSanPham = new TextBox();
            lbltenSanPham = new Label();
            txtdonGiaBan = new TextBox();
            lbldonGiaBan = new Label();
            txtdonGiaNhap = new TextBox();
            lbldonGiaNhap = new Label();
            txtsoLuongTon = new TextBox();
            lblsoLuongTon = new Label();
            txtmaNhaCC = new TextBox();
            lblmaNhaCC = new Label();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            lblDanhSach = new Label();
            txtmaSP = new TextBox();
            label2 = new Label();
            btnHienThi = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            xuấtKhoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(286, 50);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblmaSanPham
            // 
            lblmaSanPham.AutoSize = true;
            lblmaSanPham.Location = new Point(44, 168);
            lblmaSanPham.Name = "lblmaSanPham";
            lblmaSanPham.Size = new Size(101, 20);
            lblmaSanPham.TabIndex = 1;
            lblmaSanPham.Text = "Mã sản phẩm:";
            // 
            // txtmaSanPham
            // 
            txtmaSanPham.Location = new Point(145, 165);
            txtmaSanPham.Name = "txtmaSanPham";
            txtmaSanPham.Size = new Size(187, 27);
            txtmaSanPham.TabIndex = 2;
            // 
            // txttenSanPham
            // 
            txttenSanPham.Location = new Point(145, 208);
            txttenSanPham.Name = "txttenSanPham";
            txttenSanPham.Size = new Size(187, 27);
            txttenSanPham.TabIndex = 4;
            // 
            // lbltenSanPham
            // 
            lbltenSanPham.AutoSize = true;
            lbltenSanPham.Location = new Point(44, 210);
            lbltenSanPham.Name = "lbltenSanPham";
            lbltenSanPham.Size = new Size(103, 20);
            lbltenSanPham.TabIndex = 3;
            lbltenSanPham.Text = "Tên sản phẩm:";
            // 
            // txtdonGiaBan
            // 
            txtdonGiaBan.Location = new Point(145, 255);
            txtdonGiaBan.Name = "txtdonGiaBan";
            txtdonGiaBan.Size = new Size(187, 27);
            txtdonGiaBan.TabIndex = 6;
            // 
            // lbldonGiaBan
            // 
            lbldonGiaBan.AutoSize = true;
            lbldonGiaBan.Location = new Point(44, 258);
            lbldonGiaBan.Name = "lbldonGiaBan";
            lbldonGiaBan.Size = new Size(94, 20);
            lbldonGiaBan.TabIndex = 5;
            lbldonGiaBan.Text = "Đơn giá bán:";
            // 
            // txtdonGiaNhap
            // 
            txtdonGiaNhap.Location = new Point(518, 255);
            txtdonGiaNhap.Name = "txtdonGiaNhap";
            txtdonGiaNhap.Size = new Size(187, 27);
            txtdonGiaNhap.TabIndex = 12;
            // 
            // lbldonGiaNhap
            // 
            lbldonGiaNhap.AutoSize = true;
            lbldonGiaNhap.Location = new Point(377, 261);
            lbldonGiaNhap.Name = "lbldonGiaNhap";
            lbldonGiaNhap.Size = new Size(102, 20);
            lbldonGiaNhap.TabIndex = 11;
            lbldonGiaNhap.Text = "Đơn giá nhập:";
            // 
            // txtsoLuongTon
            // 
            txtsoLuongTon.Location = new Point(518, 208);
            txtsoLuongTon.Name = "txtsoLuongTon";
            txtsoLuongTon.Size = new Size(187, 27);
            txtsoLuongTon.TabIndex = 10;
            // 
            // lblsoLuongTon
            // 
            lblsoLuongTon.AutoSize = true;
            lblsoLuongTon.Location = new Point(377, 213);
            lblsoLuongTon.Name = "lblsoLuongTon";
            lblsoLuongTon.Size = new Size(98, 20);
            lblsoLuongTon.TabIndex = 9;
            lblsoLuongTon.Text = "Số lượng tồn:";
            // 
            // txtmaNhaCC
            // 
            txtmaNhaCC.Location = new Point(518, 165);
            txtmaNhaCC.Name = "txtmaNhaCC";
            txtmaNhaCC.Size = new Size(187, 27);
            txtmaNhaCC.TabIndex = 8;
            // 
            // lblmaNhaCC
            // 
            lblmaNhaCC.AutoSize = true;
            lblmaNhaCC.Location = new Point(377, 170);
            lblmaNhaCC.Name = "lblmaNhaCC";
            lblmaNhaCC.Size = new Size(132, 20);
            lblmaNhaCC.TabIndex = 7;
            lblmaNhaCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(748, 235);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(94, 319);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 28);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(268, 319);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 28);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(452, 319);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 28);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(555, 116);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(84, 28);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(46, 375);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(216, 20);
            lblDanhSach.TabIndex = 18;
            lblDanhSach.Text = "Danh sách sản phẩm trong kho:";
            // 
            // txtmaSP
            // 
            txtmaSP.Location = new Point(263, 117);
            txtmaSP.Name = "txtmaSP";
            txtmaSP.Size = new Size(239, 27);
            txtmaSP.TabIndex = 19;
            txtmaSP.TextChanged += txtmaSP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 117);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 20;
            label2.Text = "Tìm kiếm theo mã:";
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(641, 319);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(84, 28);
            btnHienThi.TabIndex = 21;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, nhàCungCấpToolStripMenuItem, xuấtKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(833, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(114, 24);
            nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            nhàCungCấpToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // xuấtKhoToolStripMenuItem
            // 
            xuấtKhoToolStripMenuItem.Name = "xuấtKhoToolStripMenuItem";
            xuấtKhoToolStripMenuItem.Size = new Size(123, 24);
            xuấtKhoToolStripMenuItem.Text = "Nhập/Xuất kho";
            xuấtKhoToolStripMenuItem.Click += xuấtKhoToolStripMenuItem_Click;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 699);
            Controls.Add(btnHienThi);
            Controls.Add(label2);
            Controls.Add(txtmaSP);
            Controls.Add(lblDanhSach);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtdonGiaNhap);
            Controls.Add(lbldonGiaNhap);
            Controls.Add(txtsoLuongTon);
            Controls.Add(lblsoLuongTon);
            Controls.Add(txtmaNhaCC);
            Controls.Add(lblmaNhaCC);
            Controls.Add(txtdonGiaBan);
            Controls.Add(lbldonGiaBan);
            Controls.Add(txttenSanPham);
            Controls.Add(lbltenSanPham);
            Controls.Add(txtmaSanPham);
            Controls.Add(lblmaSanPham);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ KHO";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Label lblmaSanPham;
        private TextBox txtmaSanPham;
        private TextBox txttenSanPham;
        private Label lbltenSanPham;
        private TextBox txtdonGiaBan;
        private Label lbldonGiaBan;
        private TextBox txtdonGiaNhap;
        private Label lbldonGiaNhap;
        private TextBox txtsoLuongTon;
        private Label lblsoLuongTon;
        private TextBox txtmaNhaCC;
        private Label lblmaNhaCC;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private Label lblDanhSach;
        private TextBox txtmaSP;
        private Label label2;
        private Button btnHienThi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem xuấtKhoToolStripMenuItem;
    }
}
