namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormDoanhThu
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
            btnThongKe = new Button();
            dgvDoanhThu = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label3 = new Label();
            lblTongDoanhThu = new Label();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            btnQuayLai = new Button();
            btnIn = new Button();
            btnTaiLai = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Tomato;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ControlLightLight;
            btnThongKe.Location = new Point(636, 113);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 36);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(48, 223);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.Size = new Size(920, 239);
            dgvDoanhThu.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 34);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 3;
            label1.Text = "DOANH THU ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(203, 117);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 6;
            label2.Text = "Từ";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(282, 112);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(203, 171);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 8;
            label3.Text = "Đến";
            label3.Click += label3_Click;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(214, 487);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(127, 20);
            lblTongDoanhThu.TabIndex = 9;
            lblTongDoanhThu.Text = "lblTongDoanhThu";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(282, 164);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(48, 487);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 11;
            label4.Text = "Tổng doanh thu: ";
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.Tomato;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuayLai.ForeColor = SystemColors.ControlLightLight;
            btnQuayLai.Location = new Point(750, 113);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 36);
            btnQuayLai.TabIndex = 12;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Tomato;
            btnIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIn.ForeColor = SystemColors.ControlLightLight;
            btnIn.Location = new Point(636, 155);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 36);
            btnIn.TabIndex = 20;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.Tomato;
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiLai.ForeColor = SystemColors.ControlLightLight;
            btnTaiLai.Location = new Point(750, 155);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 36);
            btnTaiLai.TabIndex = 19;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FormDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1002, 557);
            Controls.Add(btnIn);
            Controls.Add(btnTaiLai);
            Controls.Add(btnQuayLai);
            Controls.Add(label4);
            Controls.Add(dtpDenNgay);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(label3);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(btnThongKe);
            Controls.Add(dgvDoanhThu);
            Controls.Add(label1);
            Name = "FormDoanhThu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDoanhThu";
            Load += FormDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThongKe;
        private DataGridView dgvDoanhThu;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private Label label3;
        private Label lblTongDoanhThu;
        private DateTimePicker dtpDenNgay;
        private Label label4;
        private Button btnQuayLai;
        private Button btnIn;
        private Button btnTaiLai;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}