namespace QuanLySieuThiDienMay
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            menuStrip1 = new MenuStrip();
            tsmMenu = new ToolStripMenuItem();
            Menu_tt_NhanVien = new ToolStripMenuItem();
            quảnLýChấmCôngToolStripMenuItem1 = new ToolStripMenuItem();
            Menu_QL_HoaDon = new ToolStripMenuItem();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            thốngKêVàBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnDangXuat = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmMenu, Menu_QL_HoaDon, quảnLýKhoToolStripMenuItem, thốngKêVàBáoCáoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(831, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            tsmMenu.DropDownItems.AddRange(new ToolStripItem[] { Menu_tt_NhanVien, quảnLýChấmCôngToolStripMenuItem1 });
            tsmMenu.Name = "tsmMenu";
            tsmMenu.Size = new Size(140, 24);
            tsmMenu.Text = "Quản lý nhân viên";
            // 
            // Menu_tt_NhanVien
            // 
            Menu_tt_NhanVien.Name = "Menu_tt_NhanVien";
            Menu_tt_NhanVien.Size = new Size(222, 26);
            Menu_tt_NhanVien.Text = "Thông tin nhân viên";
            Menu_tt_NhanVien.Click += Menu_tt_NhanVien_Click;
            // 
            // quảnLýChấmCôngToolStripMenuItem1
            // 
            quảnLýChấmCôngToolStripMenuItem1.Name = "quảnLýChấmCôngToolStripMenuItem1";
            quảnLýChấmCôngToolStripMenuItem1.Size = new Size(222, 26);
            quảnLýChấmCôngToolStripMenuItem1.Text = "Quản lý chấm công";
            quảnLýChấmCôngToolStripMenuItem1.Click += Menu_QL_ChamCong;
            // 
            // Menu_QL_HoaDon
            // 
            Menu_QL_HoaDon.Name = "Menu_QL_HoaDon";
            Menu_QL_HoaDon.Size = new Size(132, 24);
            Menu_QL_HoaDon.Text = "Quản lý hóa đơn";
            Menu_QL_HoaDon.Click += Menu_QL_HoaDon_Click;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(101, 24);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            quảnLýKhoToolStripMenuItem.Click += quảnLýKhoToolStripMenuItem_Click;
            // 
            // thốngKêVàBáoCáoToolStripMenuItem
            // 
            thốngKêVàBáoCáoToolStripMenuItem.Name = "thốngKêVàBáoCáoToolStripMenuItem";
            thốngKêVàBáoCáoToolStripMenuItem.Size = new Size(161, 24);
            thốngKêVàBáoCáoToolStripMenuItem.Text = "Thống kê và báo cáo";
            thốngKêVàBáoCáoToolStripMenuItem.Click += thốngKêVàBáoCáoToolStripMenuItem_Click;
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
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 569);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu";
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
        private ToolStripMenuItem tsmMenu;
        private ToolStripMenuItem Menu_tt_NhanVien;
        private ToolStripMenuItem quảnLýChấmCôngToolStripMenuItem1;
        private ToolStripMenuItem Menu_QL_HoaDon;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStripMenuItem thốngKêVàBáoCáoToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDangXuat;
    }
}
