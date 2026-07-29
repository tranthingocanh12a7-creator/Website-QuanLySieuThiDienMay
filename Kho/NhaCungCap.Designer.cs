namespace DoAn1
{
    partial class NhaCungCap
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
            btnLamMoi = new Button();
            label2 = new Label();
            txtmaNhacc = new TextBox();
            lblDanhSach = new Label();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtDiaChi = new TextBox();
            lbldiaChiNhaCC = new Label();
            txttenNhaCC = new TextBox();
            lbltenNhaCC = new Label();
            txtmaNhCC = new TextBox();
            lbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(753, 323);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 76;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 139);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 75;
            label2.Text = "Tìm kiếm theo mã:";
            // 
            // txtmaNhacc
            // 
            txtmaNhacc.Location = new Point(357, 139);
            txtmaNhacc.Name = "txtmaNhacc";
            txtmaNhacc.Size = new Size(268, 29);
            txtmaNhacc.TabIndex = 74;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(139, 370);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(207, 21);
            lblDanhSach.TabIndex = 73;
            lblDanhSach.Text = "Danh sách các nhà cung cấp:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(684, 138);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 72;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(559, 323);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 71;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(381, 323);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 70;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(202, 323);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 69;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(139, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(783, 252);
            dataGridView1.TabIndex = 68;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(702, 200);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(210, 29);
            txtSDT.TabIndex = 67;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(560, 203);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(104, 21);
            lblSDT.TabIndex = 66;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(702, 248);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(210, 29);
            txtDiaChi.TabIndex = 65;
            // 
            // lbldiaChiNhaCC
            // 
            lbldiaChiNhaCC.AutoSize = true;
            lbldiaChiNhaCC.Location = new Point(560, 248);
            lbldiaChiNhaCC.Name = "lbldiaChiNhaCC";
            lbldiaChiNhaCC.Size = new Size(60, 21);
            lbldiaChiNhaCC.TabIndex = 64;
            lbldiaChiNhaCC.Text = "Địa chỉ:";
            // 
            // txttenNhaCC
            // 
            txttenNhaCC.Location = new Point(295, 245);
            txttenNhaCC.Name = "txttenNhaCC";
            txttenNhaCC.Size = new Size(210, 29);
            txttenNhaCC.TabIndex = 63;
            // 
            // lbltenNhaCC
            // 
            lbltenNhaCC.AutoSize = true;
            lbltenNhaCC.Location = new Point(158, 245);
            lbltenNhaCC.Name = "lbltenNhaCC";
            lbltenNhaCC.Size = new Size(132, 21);
            lbltenNhaCC.TabIndex = 62;
            lbltenNhaCC.Text = "Tên nhà cung cấp:";
            // 
            // txtmaNhCC
            // 
            txtmaNhCC.Location = new Point(295, 200);
            txtmaNhCC.Name = "txtmaNhCC";
            txtmaNhCC.Size = new Size(210, 29);
            txtmaNhCC.TabIndex = 61;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(158, 200);
            lbl.Name = "lbl";
            lbl.Size = new Size(131, 21);
            lbl.TabIndex = 60;
            lbl.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 69);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 59;
            label1.Text = "NHÀ CUNG CẤP";
            // 
            // NhaCungCap
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 729);
            Controls.Add(btnLamMoi);
            Controls.Add(label2);
            Controls.Add(txtmaNhacc);
            Controls.Add(lblDanhSach);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(lbldiaChiNhaCC);
            Controls.Add(txttenNhaCC);
            Controls.Add(lbltenNhaCC);
            Controls.Add(txtmaNhCC);
            Controls.Add(lbl);
            Controls.Add(label1);
            Name = "NhaCungCap";
            Text = "NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLamMoi;
        private Label label2;
        private TextBox txtmaNhacc;
        private Label lblDanhSach;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private TextBox txtSDT;
        private Label lblSDT;
        private TextBox txtDiaChi;
        private Label lbldiaChiNhaCC;
        private TextBox txttenNhaCC;
        private Label lbltenNhaCC;
        private TextBox txtmaNhCC;
        private Label lbl;
        private Label label1;
    }
}