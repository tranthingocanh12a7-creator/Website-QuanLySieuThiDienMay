namespace DoAn1
{
    partial class TaoHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoHoaDon));
            lblTongTien = new Label();
            dgvChiTiet = new DataGridView();
            lblNhanVien = new Label();
            lblNgayLap = new Label();
            lblTieuDe = new Label();
            lblloaiHoaDon = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnIn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(784, 566);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(90, 23);
            lblTongTien.TabIndex = 12;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(68, 203);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 31;
            dgvChiTiet.Size = new Size(971, 295);
            dgvChiTiet.TabIndex = 11;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(420, 150);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(84, 21);
            lblNhanVien.TabIndex = 9;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(420, 117);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(75, 21);
            lblNgayLap.TabIndex = 8;
            lblNgayLap.Text = "Ngày lập:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(391, 40);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(319, 31);
            lblTieuDe.TabIndex = 7;
            lblTieuDe.Text = "HÓA ĐƠN NHẬP XUẤT KHO";
            // 
            // lblloaiHoaDon
            // 
            lblloaiHoaDon.AutoSize = true;
            lblloaiHoaDon.Location = new Point(420, 84);
            lblloaiHoaDon.Name = "lblloaiHoaDon";
            lblloaiHoaDon.Size = new Size(104, 21);
            lblloaiHoaDon.TabIndex = 13;
            lblloaiHoaDon.Text = "Loại hóa đơn:";
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
            // btnIn
            // 
            btnIn.Location = new Point(233, 563);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 29);
            btnIn.TabIndex = 14;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // TaoHoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 628);
            Controls.Add(btnIn);
            Controls.Add(lblloaiHoaDon);
            Controls.Add(lblTongTien);
            Controls.Add(dgvChiTiet);
            Controls.Add(lblNhanVien);
            Controls.Add(lblNgayLap);
            Controls.Add(lblTieuDe);
            Name = "TaoHoaDon";
            Text = "InHoaDonXuat";
            Load += TaoHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTongTien;
        private DataGridView dgvChiTiet;
        private Label lblNhanVien;
        private Label lblNgayLap;
        private Label lblTieuDe;
        private Label lblloaiHoaDon;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnIn;
    }
}