namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormLoiNhuan
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
            label4 = new Label();
            lblTongLoiNhuan = new Label();
            dgvLoiNhuan = new DataGridView();
            label1 = new Label();
            btnIn = new Button();
            btnTaiLai = new Button();
            button1 = new Button();
            dtpDen = new DateTimePicker();
            label3 = new Label();
            dtpTu = new DateTimePicker();
            label2 = new Label();
            btnThongKe = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvLoiNhuan).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(28, 496);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 28;
            label4.Text = "Tổng lợi nhuận: ";
            // 
            // lblTongLoiNhuan
            // 
            lblTongLoiNhuan.AutoSize = true;
            lblTongLoiNhuan.Location = new Point(194, 496);
            lblTongLoiNhuan.Name = "lblTongLoiNhuan";
            lblTongLoiNhuan.Size = new Size(122, 20);
            lblTongLoiNhuan.TabIndex = 27;
            lblTongLoiNhuan.Text = "lblTongLoiNhuan";
            // 
            // dgvLoiNhuan
            // 
            dgvLoiNhuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoiNhuan.Location = new Point(26, 230);
            dgvLoiNhuan.Name = "dgvLoiNhuan";
            dgvLoiNhuan.RowHeadersWidth = 51;
            dgvLoiNhuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoiNhuan.Size = new Size(920, 239);
            dgvLoiNhuan.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 44);
            label1.Name = "label1";
            label1.Size = new Size(273, 31);
            label1.TabIndex = 24;
            label1.Text = "LỢI NHUẬN SẢN PHẨM";
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Tomato;
            btnIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIn.ForeColor = SystemColors.ControlLightLight;
            btnIn.Location = new Point(579, 153);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 36);
            btnIn.TabIndex = 37;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.Tomato;
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiLai.ForeColor = SystemColors.ControlLightLight;
            btnTaiLai.Location = new Point(693, 153);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 36);
            btnTaiLai.TabIndex = 36;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(693, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 35;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtpDen
            // 
            dtpDen.Location = new Point(225, 162);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(250, 27);
            dtpDen.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(146, 169);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 33;
            label3.Text = "Đến";
            // 
            // dtpTu
            // 
            dtpTu.Location = new Point(225, 110);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(250, 27);
            dtpTu.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(146, 115);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 31;
            label2.Text = "Từ";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Tomato;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ControlLightLight;
            btnThongKe.Location = new Point(579, 111);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 36);
            btnThongKe.TabIndex = 30;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FormLoiNhuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(958, 557);
            Controls.Add(btnIn);
            Controls.Add(btnTaiLai);
            Controls.Add(button1);
            Controls.Add(dtpDen);
            Controls.Add(label3);
            Controls.Add(dtpTu);
            Controls.Add(label2);
            Controls.Add(btnThongKe);
            Controls.Add(label4);
            Controls.Add(lblTongLoiNhuan);
            Controls.Add(dgvLoiNhuan);
            Controls.Add(label1);
            Name = "FormLoiNhuan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLoiNhuan";
            Load += FormLoiNhuan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoiNhuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label lblTongLoiNhuan;
        private DataGridView dgvLoiNhuan;
        private Label label1;
        private Button btnIn;
        private Button btnTaiLai;
        private Button button1;
        private DateTimePicker dtpDen;
        private Label label3;
        private DateTimePicker dtpTu;
        private Label label2;
        private Button btnThongKe;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}