namespace DOAN1
{
    partial class FormThemKhachHang
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
            txtMakh = new TextBox();
            btnLuu = new Button();
            txtTenkh = new TextBox();
            label2 = new Label();
            txtSodt = new TextBox();
            label3 = new Label();
            btnHuy = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 100);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // txtMakh
            // 
            txtMakh.Location = new Point(293, 100);
            txtMakh.Name = "txtMakh";
            txtMakh.ReadOnly = true;
            txtMakh.Size = new Size(125, 27);
            txtMakh.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Tomato;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = SystemColors.ControlLightLight;
            btnLuu.Location = new Point(172, 279);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTenkh
            // 
            txtTenkh.Location = new Point(293, 155);
            txtTenkh.Name = "txtTenkh";
            txtTenkh.Size = new Size(125, 27);
            txtTenkh.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 155);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // txtSodt
            // 
            txtSodt.Location = new Point(293, 203);
            txtSodt.Name = "txtSodt";
            txtSodt.Size = new Size(125, 27);
            txtSodt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 203);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 5;
            label3.Text = "Số điện thoại";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Tomato;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(293, 279);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(178, 46);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 8;
            label4.Text = "THÊM KHÁCH HÀNG";
            // 
            // FormThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(600, 377);
            Controls.Add(label4);
            Controls.Add(btnHuy);
            Controls.Add(txtSodt);
            Controls.Add(label3);
            Controls.Add(txtTenkh);
            Controls.Add(label2);
            Controls.Add(btnLuu);
            Controls.Add(txtMakh);
            Controls.Add(label1);
            Name = "FormThemKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormThemKhachHang";
            Load += FormThemKhachHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMakh;
        private Button btnLuu;
        private TextBox txtTenkh;
        private Label label2;
        private TextBox txtSodt;
        private Label label3;
        private Button btnHuy;
        private Label label4;
    }
}