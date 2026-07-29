namespace DoAn1
{
    partial class SanPham_User
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
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            lblDanhSach = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            xuấtKhoToolStripMenuItem = new ToolStripMenuItem();
            btnTimKiem = new Button();
            txtmaSP = new TextBox();
            label2 = new Label();
            btnHienThi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(286, 50);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(748, 370);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(43, 159);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(216, 20);
            lblDanhSach.TabIndex = 18;
            lblDanhSach.Text = "Danh sách sản phẩm trong kho:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, xuấtKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(833, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // xuấtKhoToolStripMenuItem
            // 
            xuấtKhoToolStripMenuItem.Name = "xuấtKhoToolStripMenuItem";
            xuấtKhoToolStripMenuItem.Size = new Size(123, 24);
            xuấtKhoToolStripMenuItem.Text = "Nhập/Xuất kho";
            xuấtKhoToolStripMenuItem.Click += xuấtKhoToolStripMenuItem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(555, 116);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(84, 28);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtmaSP
            // 
            txtmaSP.Location = new Point(263, 117);
            txtmaSP.Name = "txtmaSP";
            txtmaSP.Size = new Size(239, 27);
            txtmaSP.TabIndex = 19;
            txtmaSP.TextChanged += txtmaSP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 117);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 20;
            label2.Text = "Tìm kiếm theo mã:";
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(663, 116);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(84, 28);
            btnHienThi.TabIndex = 21;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // SanPham_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 577);
            Controls.Add(btnHienThi);
            Controls.Add(label2);
            Controls.Add(txtmaSP);
            Controls.Add(lblDanhSach);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SanPham_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ KHO";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private Label lblDanhSach;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem xuấtKhoToolStripMenuItem;
        private Button btnTimKiem;
        private TextBox txtmaSP;
        private Label label2;
        private Button btnHienThi;
    }
}
