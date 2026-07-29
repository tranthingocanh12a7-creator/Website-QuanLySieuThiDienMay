namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormBaoCaoBanHang
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
            label1 = new Label();
            dgvBanHang = new DataGridView();
            btnTaiLai = new Button();
            btnQuayLai = new Button();
            label2 = new Label();
            lblTongSoLuong = new Label();
            lblTongTien = new Label();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnIn = new Button();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            btnThongKe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBanHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 38);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 0;
            label1.Text = "BÁO CÁO BÁN HÀNG ";
            // 
            // dgvBanHang
            // 
            dgvBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanHang.Location = new Point(122, 215);
            dgvBanHang.Name = "dgvBanHang";
            dgvBanHang.RowHeadersWidth = 51;
            dgvBanHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBanHang.Size = new Size(877, 239);
            dgvBanHang.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.Tomato;
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiLai.ForeColor = SystemColors.ControlLightLight;
            btnTaiLai.Location = new Point(634, 140);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(90, 38);
            btnTaiLai.TabIndex = 2;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.Tomato;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuayLai.ForeColor = SystemColors.ControlLightLight;
            btnQuayLai.Location = new Point(756, 140);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(90, 38);
            btnQuayLai.TabIndex = 13;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(122, 479);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 14;
            label2.Text = "Tổng số lượng";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.AutoSize = true;
            lblTongSoLuong.Location = new Point(254, 479);
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(117, 20);
            lblTongSoLuong.TabIndex = 15;
            lblTongSoLuong.Text = "lblTongSoLuong";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(853, 488);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(87, 20);
            lblTongTien.TabIndex = 17;
            lblTongTien.Text = "lblTongTien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(732, 488);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 16;
            label4.Text = "Tổng tiền";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Tomato;
            btnIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIn.ForeColor = SystemColors.ControlLightLight;
            btnIn.Location = new Point(756, 92);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(90, 38);
            btnIn.TabIndex = 18;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(330, 98);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(246, 27);
            dtpTuNgay.TabIndex = 19;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(330, 144);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(246, 27);
            dtpDenNgay.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(277, 105);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 21;
            label3.Text = "Từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(277, 149);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 22;
            label5.Text = "đến";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Tomato;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ControlLightLight;
            btnThongKe.Location = new Point(634, 92);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(90, 38);
            btnThongKe.TabIndex = 23;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // FormBaoCaoBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1147, 686);
            Controls.Add(btnThongKe);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnIn);
            Controls.Add(lblTongTien);
            Controls.Add(label4);
            Controls.Add(lblTongSoLuong);
            Controls.Add(label2);
            Controls.Add(btnQuayLai);
            Controls.Add(btnTaiLai);
            Controls.Add(dgvBanHang);
            Controls.Add(label1);
            Name = "FormBaoCaoBanHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormBaoCaoBanHang";
            Load += FormBaoCaoBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBanHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBanHang;
        private Button btnTaiLai;
        private Button btnQuayLai;
        private Label label2;
        private Label lblTongSoLuong;
        private Label lblTongTien;
        private Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnIn;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label label3;
        private Label label5;
        private Button btnThongKe;
    }
}