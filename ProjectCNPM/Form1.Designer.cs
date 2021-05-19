namespace ProjectCNPM
{
    partial class FrmMain
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
            this.btnDK = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.grbSysLogin = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTTin = new System.Windows.Forms.Button();
            this.btnHDan = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.grbSysLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDK
            // 
            this.btnDK.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.Location = new System.Drawing.Point(77, 63);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(167, 46);
            this.btnDK.TabIndex = 1;
            this.btnDK.Text = "Đăng Ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(440, 63);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(172, 46);
            this.btnDN.TabIndex = 2;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // grbSysLogin
            // 
            this.grbSysLogin.Controls.Add(this.btnDN);
            this.grbSysLogin.Controls.Add(this.btnDK);
            this.grbSysLogin.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSysLogin.Location = new System.Drawing.Point(54, 107);
            this.grbSysLogin.Name = "grbSysLogin";
            this.grbSysLogin.Size = new System.Drawing.Size(681, 163);
            this.grbSysLogin.TabIndex = 3;
            this.grbSysLogin.TabStop = false;
            this.grbSysLogin.Text = "Hệ Thống Đăng Nhập";
            this.grbSysLogin.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTTin);
            this.groupBox2.Controls.Add(this.btnHDan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hỗ trợ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(518, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnTTin
            // 
            this.btnTTin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTin.Location = new System.Drawing.Point(295, 38);
            this.btnTTin.Name = "btnTTin";
            this.btnTTin.Size = new System.Drawing.Size(104, 38);
            this.btnTTin.TabIndex = 1;
            this.btnTTin.Text = "Thông tin";
            this.btnTTin.UseVisualStyleBackColor = true;
            this.btnTTin.Click += new System.EventHandler(this.BtnTTin_Click);
            // 
            // btnHDan
            // 
            this.btnHDan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDan.Location = new System.Drawing.Point(77, 38);
            this.btnHDan.Name = "btnHDan";
            this.btnHDan.Size = new System.Drawing.Size(106, 38);
            this.btnHDan.TabIndex = 0;
            this.btnHDan.Text = "Hướng dẫn";
            this.btnHDan.UseVisualStyleBackColor = true;
            this.btnHDan.Click += new System.EventHandler(this.BtnHDan_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(142, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(542, 38);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Phần Mềm Quản Lý Thi Trắc Nghiệm";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 455);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbSysLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Phần mềm quản lý thi trắc nghiệm";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grbSysLogin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.GroupBox grbSysLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTTin;
        private System.Windows.Forms.Button btnHDan;
        private System.Windows.Forms.Label lbTitle;
    }
}

