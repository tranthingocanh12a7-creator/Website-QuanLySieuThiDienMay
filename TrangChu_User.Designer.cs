namespace QuanLySieuThiDienMay
{
    partial class TrangChu_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu_User));
            menuStrip1 = new MenuStrip();
            chamCongtoolStripMenuItem = new ToolStripMenuItem();
            Menu_QLHoaDon = new ToolStripMenuItem();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnDangXuat = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chamCongtoolStripMenuItem, Menu_QLHoaDon, quảnLýKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(831, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chamCongtoolStripMenuItem
            // 
            chamCongtoolStripMenuItem.Name = "chamCongtoolStripMenuItem";
            chamCongtoolStripMenuItem.Size = new Size(98, 24);
            chamCongtoolStripMenuItem.Text = "Chấm công";
            chamCongtoolStripMenuItem.Click += chamCongtoolStripMenuItem_Click;
            // 
            // Menu_QLHoaDon
            // 
            Menu_QLHoaDon.Name = "Menu_QLHoaDon";
            Menu_QLHoaDon.Size = new Size(132, 24);
            Menu_QLHoaDon.Text = "Quản lý hóa đơn";
            Menu_QLHoaDon.Click += Menu_QLHoaDon_Click;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(101, 24);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            quảnLýKhoToolStripMenuItem.Click += quảnLýKhoToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDangXuat });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(30, 541);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDangXuat
            // 
            btnDangXuat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageTransparentColor = Color.Magenta;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(27, 24);
            btnDangXuat.Text = "toolStripButton1";
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // TrangChu_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 569);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu_QLHoaDon;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDangXuat;
        private ToolStripMenuItem chamCongtoolStripMenuItem;
    }
}
