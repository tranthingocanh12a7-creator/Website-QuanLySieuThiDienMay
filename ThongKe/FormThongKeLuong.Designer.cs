namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormThongKeLuong
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
            dgvLuongNV = new DataGridView();
            cbThang = new ComboBox();
            btnLoc = new Button();
            cbNam = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTongLuong = new Label();
            btnIn = new Button();
            btnTaiLai = new Button();
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvLuongNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 31);
            label1.TabIndex = 0;
            label1.Text = "LƯƠNG NHÂN VIÊN";
            // 
            // dgvLuongNV
            // 
            dgvLuongNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLuongNV.Location = new Point(124, 208);
            dgvLuongNV.Margin = new Padding(4, 3, 4, 3);
            dgvLuongNV.Name = "dgvLuongNV";
            dgvLuongNV.RowHeadersWidth = 51;
            dgvLuongNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLuongNV.Size = new Size(911, 216);
            dgvLuongNV.TabIndex = 1;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(250, 98);
            cbThang.Margin = new Padding(4, 3, 4, 3);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(188, 31);
            cbThang.TabIndex = 2;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.Tomato;
            btnLoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLoc.ForeColor = SystemColors.ControlLightLight;
            btnLoc.Location = new Point(540, 126);
            btnLoc.Margin = new Padding(4, 3, 4, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(118, 40);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Thống kê";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(250, 160);
            cbNam.Margin = new Padding(4, 3, 4, 3);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(188, 31);
            cbNam.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(124, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 5;
            label2.Text = "THÁNG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(124, 163);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 6;
            label3.Text = "NĂM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(124, 448);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 7;
            label4.Text = "Tổng lương: ";
            // 
            // lblTongLuong
            // 
            lblTongLuong.AutoSize = true;
            lblTongLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTongLuong.Location = new Point(250, 448);
            lblTongLuong.Margin = new Padding(4, 0, 4, 0);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new Size(120, 23);
            lblTongLuong.TabIndex = 8;
            lblTongLuong.Text = "lblTongLuong";
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Tomato;
            btnIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnIn.ForeColor = SystemColors.ControlLightLight;
            btnIn.Location = new Point(693, 126);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 40);
            btnIn.TabIndex = 43;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.Tomato;
            btnTaiLai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTaiLai.ForeColor = SystemColors.ControlLightLight;
            btnTaiLai.Location = new Point(818, 126);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 40);
            btnTaiLai.TabIndex = 42;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(941, 126);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 41;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FormThongKeLuong
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1173, 536);
            Controls.Add(btnIn);
            Controls.Add(btnTaiLai);
            Controls.Add(button1);
            Controls.Add(lblTongLuong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbNam);
            Controls.Add(btnLoc);
            Controls.Add(cbThang);
            Controls.Add(dgvLuongNV);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormThongKeLuong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormThongKeLuong";
            Load += FormThongKeLuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLuongNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLuongNV;
        private ComboBox cbThang;
        private Button btnLoc;
        private ComboBox cbNam;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTongLuong;
        private Button btnIn;
        private Button btnTaiLai;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}