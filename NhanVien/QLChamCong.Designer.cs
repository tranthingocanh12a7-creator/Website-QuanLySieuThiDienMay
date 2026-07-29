namespace chamcong
{
    partial class QLChamCong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            txt_tk = new TextBox();
            label4 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txt_manv = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            btn_lmmoi = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            btn_thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1052, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            button5.Location = new Point(636, 591);
            button5.Name = "button5";
            button5.Size = new Size(171, 29);
            button5.TabIndex = 13;
            button5.Text = "Tìm kiếm theo mã nv";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_tk
            // 
            txt_tk.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            txt_tk.Location = new Point(835, 592);
            txt_tk.Name = "txt_tk";
            txt_tk.Size = new Size(246, 27);
            txt_tk.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(221, 238, 255);
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(359, 44);
            label4.Name = "label4";
            label4.Size = new Size(393, 31);
            label4.TabIndex = 18;
            label4.Text = "QUẢN LÝ CHẤM CÔNG NHÂN VIÊN";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.IpAddress;
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txt_manv);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Cursor = Cursors.Cross;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 351);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chấm công";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox3.Location = new Point(215, 307);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(59, 24);
            checkBox3.TabIndex = 25;
            checkBox3.Text = "ca 3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox2.Location = new Point(215, 260);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 24);
            checkBox2.TabIndex = 24;
            checkBox2.Text = "ca 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(215, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 24);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "ca 1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_manv
            // 
            txt_manv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_manv.Location = new Point(215, 39);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(246, 27);
            txt_manv.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(63, 260);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 21;
            label3.Text = "Ca Lam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(63, 136);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 20;
            label2.Text = "Ngay cham cong";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(63, 46);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 19;
            label1.Text = "Ma NV";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(215, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_lmmoi);
            groupBox2.Controls.Add(btn_xoa);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(636, 331);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 212);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btn_lmmoi
            // 
            btn_lmmoi.Location = new Point(291, 138);
            btn_lmmoi.Name = "btn_lmmoi";
            btn_lmmoi.Size = new Size(94, 29);
            btn_lmmoi.TabIndex = 16;
            btn_lmmoi.Text = "Làm mới ";
            btn_lmmoi.UseVisualStyleBackColor = true;
            btn_lmmoi.Click += btn_lmmoi_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.PaleGoldenrod;
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_xoa.Location = new Point(77, 139);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 15;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.LemonChiffon;
            btn_sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_sua.Location = new Point(291, 47);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.MistyRose;
            btn_them.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_them.ForeColor = Color.Black;
            btn_them.Location = new Point(77, 47);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 13;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_thoat.Location = new Point(987, 657);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 16;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // QLChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 238, 255);
            ClientSize = new Size(1154, 707);
            Controls.Add(btn_thoat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txt_tk);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            Name = "QLChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý chấm công";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button5;
        private TextBox txt_tk;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox txt_manv;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Button btn_lmmoi;
    }
}
