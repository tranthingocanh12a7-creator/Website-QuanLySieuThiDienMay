namespace do_an
{
    partial class QLThongTinNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btn_tk = new Button();
            txt_tk = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txt_cv = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tx_mk = new TextBox();
            txt_tendn = new TextBox();
            txt_ten = new TextBox();
            txt_sdt = new TextBox();
            txt_ma = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_xoa = new Button();
            btn_thoat = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            btn_lmmoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Location = new Point(51, 462);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1027, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_tk
            // 
            btn_tk.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_tk.Location = new Point(324, 47);
            btn_tk.Margin = new Padding(4, 3, 4, 3);
            btn_tk.Name = "btn_tk";
            btn_tk.Size = new Size(164, 33);
            btn_tk.TabIndex = 18;
            btn_tk.Text = "Tìm kiếm theo mã";
            btn_tk.UseVisualStyleBackColor = true;
            btn_tk.Click += btn_tk_Click;
            // 
            // txt_tk
            // 
            txt_tk.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            txt_tk.Location = new Point(507, 47);
            txt_tk.Margin = new Padding(4, 3, 4, 3);
            txt_tk.Name = "txt_tk";
            txt_tk.Size = new Size(308, 27);
            txt_tk.TabIndex = 19;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(260, -3);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(629, 47);
            label7.TabIndex = 20;
            label7.Tag = "";
            label7.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_cv);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(tx_mk);
            groupBox1.Controls.Add(txt_tendn);
            groupBox1.Controls.Add(txt_ten);
            groupBox1.Controls.Add(txt_sdt);
            groupBox1.Controls.Add(txt_ma);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(51, 159);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1027, 278);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_cv
            // 
            txt_cv.Location = new Point(148, 172);
            txt_cv.Margin = new Padding(4, 3, 4, 3);
            txt_cv.Name = "txt_cv";
            txt_cv.Size = new Size(308, 30);
            txt_cv.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(58, 172);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 38;
            label8.Text = "Chức vụ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 229);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(308, 30);
            dateTimePicker1.TabIndex = 37;
            // 
            // tx_mk
            // 
            tx_mk.Location = new Point(648, 158);
            tx_mk.Margin = new Padding(4, 3, 4, 3);
            tx_mk.Name = "tx_mk";
            tx_mk.Size = new Size(308, 30);
            tx_mk.TabIndex = 36;
            // 
            // txt_tendn
            // 
            txt_tendn.Location = new Point(648, 100);
            txt_tendn.Margin = new Padding(4, 3, 4, 3);
            txt_tendn.Name = "txt_tendn";
            txt_tendn.Size = new Size(308, 30);
            txt_tendn.TabIndex = 35;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(148, 97);
            txt_ten.Margin = new Padding(4, 3, 4, 3);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(308, 30);
            txt_ten.TabIndex = 34;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(648, 38);
            txt_sdt.Margin = new Padding(4, 3, 4, 3);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(308, 30);
            txt_sdt.TabIndex = 33;
            // 
            // txt_ma
            // 
            txt_ma.Location = new Point(148, 43);
            txt_ma.Margin = new Padding(4, 3, 4, 3);
            txt_ma.Name = "txt_ma";
            txt_ma.Size = new Size(308, 30);
            txt_ma.TabIndex = 32;
            txt_ma.Leave += txt_ma_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(516, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 31;
            label6.Text = "MK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(516, 105);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 30;
            label5.Text = "Ten Dang Nhap";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(516, 43);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 29;
            label4.Text = "Sdt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(58, 239);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 28;
            label3.Text = "Ngay Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(58, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 27;
            label2.Text = "Ho Ten";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 26;
            label1.Text = "Ma nv";
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.Khaki;
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_xoa.Location = new Point(482, 104);
            btn_xoa.Margin = new Padding(4, 3, 4, 3);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(118, 33);
            btn_xoa.TabIndex = 21;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_thoat.Location = new Point(960, 104);
            btn_thoat.Margin = new Padding(4, 3, 4, 3);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(118, 33);
            btn_thoat.TabIndex = 20;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.PeachPuff;
            btn_sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Location = new Point(260, 104);
            btn_sua.Margin = new Padding(4, 3, 4, 3);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(118, 33);
            btn_sua.TabIndex = 19;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.LightYellow;
            btn_them.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_them.Location = new Point(51, 104);
            btn_them.Margin = new Padding(4, 3, 4, 3);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(118, 33);
            btn_them.TabIndex = 18;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_lmmoi
            // 
            btn_lmmoi.BackColor = Color.FromArgb(255, 255, 192);
            btn_lmmoi.Location = new Point(736, 103);
            btn_lmmoi.Name = "btn_lmmoi";
            btn_lmmoi.Size = new Size(124, 34);
            btn_lmmoi.TabIndex = 22;
            btn_lmmoi.Text = "Làm mới";
            btn_lmmoi.UseVisualStyleBackColor = false;
            btn_lmmoi.Click += btn_lmmoi_Click;
            // 
            // QLThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 238, 255);
            ClientSize = new Size(1215, 699);
            Controls.Add(btn_lmmoi);
            Controls.Add(btn_xoa);
            Controls.Add(btn_thoat);
            Controls.Add(groupBox1);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(label7);
            Controls.Add(txt_tk);
            Controls.Add(btn_tk);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QLThongTinNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_tk;
        private TextBox txt_tk;
        private Label label7;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox tx_mk;
        private TextBox txt_tendn;
        private TextBox txt_ten;
        private TextBox txt_sdt;
        private TextBox txt_ma;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_xoa;
        private Button btn_thoat;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_cv;
        private Label label8;
        private Button btn_lmmoi;
    }
}
