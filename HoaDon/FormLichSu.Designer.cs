namespace DOAN1
{
    partial class FormLichSu
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
            dgvLichsu = new DataGridView();
            label1 = new Label();
            txtTukhoa = new TextBox();
            dtpTu = new DateTimePicker();
            dtpDen = new DateTimePicker();
            btnTimkiem = new Button();
            label2 = new Label();
            label3 = new Label();
            btnTailai = new Button();
            label4 = new Label();
            dgvChitiethd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichsu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChitiethd).BeginInit();
            SuspendLayout();
            // 
            // dgvLichsu
            // 
            dgvLichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichsu.Location = new Point(101, 216);
            dgvLichsu.Name = "dgvLichsu";
            dgvLichsu.RowHeadersWidth = 51;
            dgvLichsu.Size = new Size(928, 254);
            dgvLichsu.TabIndex = 0;
            dgvLichsu.CellClick += dgvLichsu_CellClick;
            dgvLichsu.CellContentClick += dgvLichsu_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(448, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 1;
            label1.Text = "LỊCH SỬ ĐƠN HÀNG";
            // 
            // txtTukhoa
            // 
            txtTukhoa.Location = new Point(303, 92);
            txtTukhoa.Name = "txtTukhoa";
            txtTukhoa.PlaceholderText = "Nhập thông tin tìm kiếm";
            txtTukhoa.Size = new Size(241, 27);
            txtTukhoa.TabIndex = 2;
            // 
            // dtpTu
            // 
            dtpTu.Location = new Point(303, 143);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(241, 27);
            dtpTu.TabIndex = 3;
            // 
            // dtpDen
            // 
            dtpDen.Location = new Point(615, 145);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(243, 27);
            dtpDen.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackColor = Color.Tomato;
            btnTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimkiem.ForeColor = SystemColors.ControlLightLight;
            btnTimkiem.Location = new Point(901, 85);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(87, 34);
            btnTimkiem.TabIndex = 5;
            btnTimkiem.Text = "TÌM KIẾM";
            btnTimkiem.UseVisualStyleBackColor = false;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(151, 150);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 7;
            label2.Text = "Từ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(564, 152);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 8;
            label3.Text = "đến";
            // 
            // btnTailai
            // 
            btnTailai.BackColor = Color.Tomato;
            btnTailai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTailai.ForeColor = SystemColors.ControlLightLight;
            btnTailai.Location = new Point(901, 136);
            btnTailai.Name = "btnTailai";
            btnTailai.Size = new Size(87, 34);
            btnTailai.TabIndex = 9;
            btnTailai.Text = "TẢI LẠI";
            btnTailai.UseVisualStyleBackColor = false;
            btnTailai.Click += btnTailai_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(151, 99);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 10;
            label4.Text = "Nhập mã Tìm Kiếm";
            // 
            // dgvChitiethd
            // 
            dgvChitiethd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChitiethd.Location = new Point(101, 520);
            dgvChitiethd.Name = "dgvChitiethd";
            dgvChitiethd.RowHeadersWidth = 51;
            dgvChitiethd.Size = new Size(928, 245);
            dgvChitiethd.TabIndex = 11;
            dgvChitiethd.CellContentClick += dgvChitiethd_CellContentClick;
            // 
            // FormLichSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1191, 782);
            Controls.Add(dgvChitiethd);
            Controls.Add(label4);
            Controls.Add(btnTailai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnTimkiem);
            Controls.Add(dtpDen);
            Controls.Add(dtpTu);
            Controls.Add(txtTukhoa);
            Controls.Add(label1);
            Controls.Add(dgvLichsu);
            Name = "FormLichSu";
            Text = "FormLichSu";
            Load += FormLichSu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichsu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChitiethd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLichsu;
        private Label label1;
        private TextBox txtTukhoa;
        private DateTimePicker dtpTu;
        private DateTimePicker dtpDen;
        private Button btnTimkiem;
        private Label label2;
        private Label label3;
        private Button btnTailai;
        private Label label4;
        private DataGridView dgvChitiethd;
    }
}