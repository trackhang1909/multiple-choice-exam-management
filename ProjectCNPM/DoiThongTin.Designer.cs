namespace ProjectCNPM
{
    partial class DoiThongTin
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.lbShowError = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbAcc = new System.Windows.Forms.Label();
            this.lbSysLogin = new System.Windows.Forms.Label();
            this.radSV = new System.Windows.Forms.RadioButton();
            this.radGV = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(363, 169);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(269, 30);
            this.txtHoTen.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Họ Và Tên";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(363, 390);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(104, 33);
            this.btnDangKy.TabIndex = 50;
            this.btnDangKy.Text = "Thay Đổi";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(486, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 34);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(363, 121);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(269, 30);
            this.txtPass.TabIndex = 48;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtAcc
            // 
            this.txtAcc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcc.Location = new System.Drawing.Point(363, 72);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(269, 30);
            this.txtAcc.TabIndex = 47;
            this.txtAcc.TextChanged += new System.EventHandler(this.TxtAcc_TextChanged);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPass.Location = new System.Drawing.Point(363, 318);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(144, 26);
            this.cbShowPass.TabIndex = 46;
            this.cbShowPass.Text = "Hiện mật khẩu";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.CbShowPass_CheckedChanged);
            // 
            // lbShowError
            // 
            this.lbShowError.AutoSize = true;
            this.lbShowError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowError.ForeColor = System.Drawing.Color.Red;
            this.lbShowError.Location = new System.Drawing.Point(359, 356);
            this.lbShowError.Name = "lbShowError";
            this.lbShowError.Size = new System.Drawing.Size(0, 22);
            this.lbShowError.TabIndex = 45;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(186, 124);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(87, 22);
            this.lbPass.TabIndex = 44;
            this.lbPass.Text = "Mật Khẩu";
            // 
            // lbAcc
            // 
            this.lbAcc.AutoSize = true;
            this.lbAcc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcc.Location = new System.Drawing.Point(186, 78);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(93, 22);
            this.lbAcc.TabIndex = 43;
            this.lbAcc.Text = "Tài Khoản";
            // 
            // lbSysLogin
            // 
            this.lbSysLogin.AutoSize = true;
            this.lbSysLogin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSysLogin.Location = new System.Drawing.Point(242, 21);
            this.lbSysLogin.Name = "lbSysLogin";
            this.lbSysLogin.Size = new System.Drawing.Size(339, 29);
            this.lbSysLogin.TabIndex = 42;
            this.lbSysLogin.Text = "Hệ Thống Thay Đổi Thông Tin";
            // 
            // radSV
            // 
            this.radSV.AutoSize = true;
            this.radSV.Location = new System.Drawing.Point(525, 268);
            this.radSV.Name = "radSV";
            this.radSV.Size = new System.Drawing.Size(107, 26);
            this.radSV.TabIndex = 59;
            this.radSV.TabStop = true;
            this.radSV.Text = "Sinh Viên";
            this.radSV.UseVisualStyleBackColor = true;
            this.radSV.CheckedChanged += new System.EventHandler(this.RadSV_CheckedChanged);
            // 
            // radGV
            // 
            this.radGV.AutoSize = true;
            this.radGV.Location = new System.Drawing.Point(363, 268);
            this.radGV.Name = "radGV";
            this.radGV.Size = new System.Drawing.Size(111, 26);
            this.radGV.TabIndex = 58;
            this.radGV.TabStop = true;
            this.radGV.Text = "Giáo Viên";
            this.radGV.UseVisualStyleBackColor = true;
            this.radGV.CheckedChanged += new System.EventHandler(this.RadGV_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quyền Truy Cập";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(525, 221);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 26);
            this.radNu.TabIndex = 56;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.RadNu_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(363, 221);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(68, 26);
            this.radNam.TabIndex = 55;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.RadNam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Giới Tính";
            // 
            // DoiThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 455);
            this.Controls.Add(this.radSV);
            this.Controls.Add(this.radGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.lbShowError);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbAcc);
            this.Controls.Add(this.lbSysLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DoiThongTin";
            this.Text = "DoiThongTin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Label lbShowError;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbAcc;
        private System.Windows.Forms.Label lbSysLogin;
        private System.Windows.Forms.RadioButton radSV;
        private System.Windows.Forms.RadioButton radGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label2;
    }
}