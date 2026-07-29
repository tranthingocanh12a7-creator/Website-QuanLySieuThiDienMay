namespace chamcong
{
    partial class NVchamcong
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
            components = new System.ComponentModel.Container();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txt_manv = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_ngay = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox3.Location = new Point(217, 326);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(59, 24);
            checkBox3.TabIndex = 33;
            checkBox3.Text = "ca 3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox2.Location = new Point(217, 279);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 24);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "ca 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(217, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 24);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "ca 1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_manv
            // 
            txt_manv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_manv.Location = new Point(217, 58);
            txt_manv.Name = "txt_manv";
            txt_manv.ReadOnly = true;
            txt_manv.Size = new Size(246, 27);
            txt_manv.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(65, 279);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 29;
            label3.Text = "Ca Lam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(65, 155);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 28;
            label2.Text = "Ngay cham cong";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(65, 65);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 27;
            label1.Text = "Ma NV";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_ngay);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_manv);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 400);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_ngay
            // 
            txt_ngay.Enabled = false;
            txt_ngay.Location = new Point(217, 155);
            txt_ngay.Name = "txt_ngay";
            txt_ngay.ReadOnly = true;
            txt_ngay.Size = new Size(246, 27);
            txt_ngay.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(221, 238, 255);
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(297, 21);
            label4.Name = "label4";
            label4.Size = new Size(154, 31);
            label4.TabIndex = 35;
            label4.Text = "CHẤM CÔNG";
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(145, 518);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 36;
            button1.Text = "Chấm công";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(438, 518);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 37;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // NVchamcong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 238, 255);
            ClientSize = new Size(742, 595);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "NVchamcong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NVchamcong";
            Load += NVchamcong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox txt_manv;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox txt_ngay;
        private System.Windows.Forms.Timer timer1;
    }
}