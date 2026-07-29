namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormNhapXuatKho
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
            btnQuayLai = new Button();
            label4 = new Label();
            lblTongSoLuongNhap = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLocDuLieu = new Button();
            dgvNhapXuat = new DataGridView();
            label1 = new Label();
            cbLoaiNX = new ComboBox();
            btnIn = new Button();
            btnTaiLai = new Button();
            dtpDen = new DateTimePicker();
            label5 = new Label();
            dtpTu = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            lblTongSoLuongXuat = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            cbSanpham = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).BeginInit();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.Tomato;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuayLai.ForeColor = SystemColors.ControlLightLight;
            btnQuayLai.Location = new Point(655, 232);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 40);
            btnQuayLai.TabIndex = 22;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(49, 558);
            label4.Name = "label4";
            label4.Size = new Size(181, 23);
            label4.TabIndex = 21;
            label4.Text = "Tổng số lượng nhap: ";
            // 
            // lblTongSoLuongNhap
            // 
            lblTongSoLuongNhap.AutoSize = true;
            lblTongSoLuongNhap.Location = new Point(242, 561);
            lblTongSoLuongNhap.Name = "lblTongSoLuongNhap";
            lblTongSoLuongNhap.Size = new Size(153, 20);
            lblTongSoLuongNhap.TabIndex = 19;
            lblTongSoLuongNhap.Text = "lblTongSoLuongNhap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(-60, 121);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 18;
            label3.Text = "Đến";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(-60, 67);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 16;
            label2.Text = "Từ";
            // 
            // btnLocDuLieu
            // 
            btnLocDuLieu.BackColor = Color.Tomato;
            btnLocDuLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLocDuLieu.ForeColor = SystemColors.ControlLightLight;
            btnLocDuLieu.Location = new Point(282, 232);
            btnLocDuLieu.Name = "btnLocDuLieu";
            btnLocDuLieu.Size = new Size(94, 40);
            btnLocDuLieu.TabIndex = 15;
            btnLocDuLieu.Text = "Lọc dữ liệu";
            btnLocDuLieu.UseVisualStyleBackColor = false;
            btnLocDuLieu.Click += btnLocDuLieu_Click;
            // 
            // dgvNhapXuat
            // 
            dgvNhapXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapXuat.Location = new Point(47, 292);
            dgvNhapXuat.Name = "dgvNhapXuat";
            dgvNhapXuat.RowHeadersWidth = 51;
            dgvNhapXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapXuat.Size = new Size(920, 239);
            dgvNhapXuat.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 25);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 13;
            label1.Text = "NHẬP / XUẤT KHO";
            // 
            // cbLoaiNX
            // 
            cbLoaiNX.FormattingEnabled = true;
            cbLoaiNX.Location = new Point(407, 179);
            cbLoaiNX.Name = "cbLoaiNX";
            cbLoaiNX.Size = new Size(105, 28);
            cbLoaiNX.TabIndex = 23;
            cbLoaiNX.Text = "Loại";
            cbLoaiNX.SelectedIndexChanged += cbLoaiNX_SelectedIndexChanged;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Tomato;
            btnIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIn.ForeColor = SystemColors.ControlLightLight;
            btnIn.Location = new Point(407, 232);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 40);
            btnIn.TabIndex = 40;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.Tomato;
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiLai.ForeColor = SystemColors.ControlLightLight;
            btnTaiLai.Location = new Point(532, 232);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 40);
            btnTaiLai.TabIndex = 39;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // dtpDen
            // 
            dtpDen.Location = new Point(407, 130);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(250, 27);
            dtpDen.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(328, 137);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 43;
            label5.Text = "Đến";
            // 
            // dtpTu
            // 
            dtpTu.Location = new Point(407, 78);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(250, 27);
            dtpTu.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(328, 83);
            label6.Name = "label6";
            label6.Size = new Size(31, 23);
            label6.TabIndex = 41;
            label6.Text = "Từ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(426, 555);
            label7.Name = "label7";
            label7.Size = new Size(176, 23);
            label7.TabIndex = 46;
            label7.Text = "Tổng số lượng xuat: ";
            // 
            // lblTongSoLuongXuat
            // 
            lblTongSoLuongXuat.AutoSize = true;
            lblTongSoLuongXuat.Location = new Point(643, 558);
            lblTongSoLuongXuat.Name = "lblTongSoLuongXuat";
            lblTongSoLuongXuat.Size = new Size(147, 20);
            lblTongSoLuongXuat.TabIndex = 45;
            lblTongSoLuongXuat.Text = "lblTongSoLuongXuat";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // cbSanpham
            // 
            cbSanpham.FormattingEnabled = true;
            cbSanpham.Location = new Point(552, 179);
            cbSanpham.Name = "cbSanpham";
            cbSanpham.Size = new Size(105, 28);
            cbSanpham.TabIndex = 47;
            cbSanpham.Text = "Sản phẩm";
            cbSanpham.SelectedIndexChanged += cbSanpham_SelectedIndexChanged;
            // 
            // FormNhapXuatKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1001, 603);
            Controls.Add(cbSanpham);
            Controls.Add(label7);
            Controls.Add(lblTongSoLuongXuat);
            Controls.Add(dtpDen);
            Controls.Add(label5);
            Controls.Add(dtpTu);
            Controls.Add(label6);
            Controls.Add(btnIn);
            Controls.Add(btnTaiLai);
            Controls.Add(cbLoaiNX);
            Controls.Add(btnQuayLai);
            Controls.Add(label4);
            Controls.Add(lblTongSoLuongNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLocDuLieu);
            Controls.Add(dgvNhapXuat);
            Controls.Add(label1);
            Name = "FormNhapXuatKho";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNhapXuatKho";
            Load += FormNhapXuatKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Label label4;
        private Label lblTongSoLuongNhap;
        private Label label3;
        private Label label2;
        private Button btnLocDuLieu;
        private DataGridView dgvNhapXuat;
        private Label label1;
        private ComboBox cbLoaiNX;
        private Button btnIn;
        private Button btnTaiLai;
        private DateTimePicker dtpDen;
        private Label label5;
        private DateTimePicker dtpTu;
        private Label label6;
        private Label label7;
        private Label lblTongSoLuongXuat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ComboBox cbSanpham;
    }
}