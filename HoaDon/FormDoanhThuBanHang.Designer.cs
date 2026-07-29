namespace DOAN1
{
    partial class FormDoanhThuBanHang
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
            dgvDoanhthu = new DataGridView();
            dtptu = new DateTimePicker();
            dtpden = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            cbmanv = new ComboBox();
            btnTailai = new Button();
            lbTongDoanhThu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhthu).BeginInit();
            SuspendLayout();
            // 
            // dgvDoanhthu
            // 
            dgvDoanhthu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhthu.Location = new Point(44, 125);
            dgvDoanhthu.Name = "dgvDoanhthu";
            dgvDoanhthu.RowHeadersWidth = 51;
            dgvDoanhthu.Size = new Size(1080, 428);
            dgvDoanhthu.TabIndex = 0;
            // 
            // dtptu
            // 
            dtptu.Location = new Point(170, 31);
            dtptu.Name = "dtptu";
            dtptu.Size = new Size(250, 27);
            dtptu.TabIndex = 2;
            // 
            // dtpden
            // 
            dtpden.Location = new Point(536, 31);
            dtpden.Name = "dtpden";
            dtpden.Size = new Size(250, 27);
            dtpden.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(536, 72);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 4;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 5;
            label1.Text = "Từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(458, 33);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 6;
            label2.Text = "đến";
            // 
            // cbmanv
            // 
            cbmanv.FormattingEnabled = true;
            cbmanv.Location = new Point(170, 73);
            cbmanv.Name = "cbmanv";
            cbmanv.Size = new Size(250, 28);
            cbmanv.TabIndex = 7;
            // 
            // btnTailai
            // 
            btnTailai.BackColor = Color.Tomato;
            btnTailai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTailai.ForeColor = SystemColors.ControlLightLight;
            btnTailai.Location = new Point(924, 31);
            btnTailai.Name = "btnTailai";
            btnTailai.Size = new Size(123, 68);
            btnTailai.TabIndex = 8;
            btnTailai.Text = "Tải lại ";
            btnTailai.UseVisualStyleBackColor = false;
            btnTailai.Click += btnTailai_Click;
            // 
            // lbTongDoanhThu
            // 
            lbTongDoanhThu.AutoSize = true;
            lbTongDoanhThu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTongDoanhThu.Location = new Point(873, 580);
            lbTongDoanhThu.Name = "lbTongDoanhThu";
            lbTongDoanhThu.Size = new Size(63, 25);
            lbTongDoanhThu.TabIndex = 1;
            lbTongDoanhThu.Text = "label1";
            lbTongDoanhThu.Click += lbTongDoanhThu_Click;
            // 
            // FormDoanhThuBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1176, 627);
            Controls.Add(btnTailai);
            Controls.Add(cbmanv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dtpden);
            Controls.Add(dtptu);
            Controls.Add(lbTongDoanhThu);
            Controls.Add(dgvDoanhthu);
            Name = "FormDoanhThuBanHang";
            Text = "FormDoanhThu";
            Load += FormDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoanhthu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoanhthu;
        private DateTimePicker dtptu;
        private DateTimePicker dtpden;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox cbmanv;
        private Button btnTailai;
        private Label lbTongDoanhThu;
    }
}