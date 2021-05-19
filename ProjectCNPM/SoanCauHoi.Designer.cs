namespace ProjectCNPM
{
    partial class SoanCauHoi
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
            this.gbLamMoi = new System.Windows.Forms.GroupBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolThemCH = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSuaCH = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolXoaCH = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsThemMonHoc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDapAnD = new System.Windows.Forms.TextBox();
            this.txtDapAnC = new System.Windows.Forms.TextBox();
            this.txtDapAnB = new System.Windows.Forms.TextBox();
            this.txtDapAnA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbLamMoi.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLamMoi
            // 
            this.gbLamMoi.Controls.Add(this.cmb);
            this.gbLamMoi.Controls.Add(this.label8);
            this.gbLamMoi.Controls.Add(this.txtMaMonHoc);
            this.gbLamMoi.Controls.Add(this.label1);
            this.gbLamMoi.Controls.Add(this.cmb2);
            this.gbLamMoi.Controls.Add(this.label10);
            this.gbLamMoi.Controls.Add(this.toolStrip1);
            this.gbLamMoi.Controls.Add(this.radD);
            this.gbLamMoi.Controls.Add(this.radC);
            this.gbLamMoi.Controls.Add(this.radB);
            this.gbLamMoi.Controls.Add(this.radA);
            this.gbLamMoi.Controls.Add(this.label7);
            this.gbLamMoi.Controls.Add(this.label6);
            this.gbLamMoi.Controls.Add(this.label5);
            this.gbLamMoi.Controls.Add(this.label4);
            this.gbLamMoi.Controls.Add(this.txtDapAnD);
            this.gbLamMoi.Controls.Add(this.txtDapAnC);
            this.gbLamMoi.Controls.Add(this.txtDapAnB);
            this.gbLamMoi.Controls.Add(this.txtDapAnA);
            this.gbLamMoi.Controls.Add(this.label3);
            this.gbLamMoi.Controls.Add(this.txtCauHoi);
            this.gbLamMoi.Controls.Add(this.txtMaCauHoi);
            this.gbLamMoi.Controls.Add(this.label2);
            this.gbLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLamMoi.Location = new System.Drawing.Point(33, 27);
            this.gbLamMoi.Name = "gbLamMoi";
            this.gbLamMoi.Size = new System.Drawing.Size(1227, 276);
            this.gbLamMoi.TabIndex = 5;
            this.gbLamMoi.TabStop = false;
            this.gbLamMoi.Text = "Quản Lý Câu Hỏi";
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(166, 93);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(195, 30);
            this.cmb.TabIndex = 25;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tên Môn Học:";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(466, 47);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(119, 30);
            this.txtMaMonHoc.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Môn Học:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmb2
            // 
            this.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(466, 96);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(119, 30);
            this.cmb2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Độ Khó:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThemCH,
            this.toolStripSeparator1,
            this.toolSuaCH,
            this.toolStripSeparator2,
            this.toolXoaCH,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.tsThemMonHoc,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 248);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1221, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolThemCH
            // 
            this.toolThemCH.Name = "toolThemCH";
            this.toolThemCH.Size = new System.Drawing.Size(46, 22);
            this.toolThemCH.Text = "Thêm";
            this.toolThemCH.Click += new System.EventHandler(this.ToolThemCH_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSuaCH
            // 
            this.toolSuaCH.Name = "toolSuaCH";
            this.toolSuaCH.Size = new System.Drawing.Size(68, 22);
            this.toolSuaCH.Text = "Cập nhật";
            this.toolSuaCH.Click += new System.EventHandler(this.ToolSuaCH_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolXoaCH
            // 
            this.toolXoaCH.Name = "toolXoaCH";
            this.toolXoaCH.Size = new System.Drawing.Size(35, 22);
            this.toolXoaCH.Text = "Xóa";
            this.toolXoaCH.Click += new System.EventHandler(this.ToolXoaCH_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel1.Text = "Làm mới";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsThemMonHoc
            // 
            this.tsThemMonHoc.Name = "tsThemMonHoc";
            this.tsThemMonHoc.Size = new System.Drawing.Size(111, 22);
            this.tsThemMonHoc.Text = "Thêm Môn Học";
            this.tsThemMonHoc.Click += new System.EventHandler(this.TsThemMonHoc_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "Trở lại";
            this.toolStripLabel2.Click += new System.EventHandler(this.ToolStripLabel2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel3.Text = "Thoát";
            this.toolStripLabel3.Click += new System.EventHandler(this.ToolStripLabel3_Click);
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(722, 201);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(17, 16);
            this.radD.TabIndex = 16;
            this.radD.TabStop = true;
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.RadD_CheckedChanged);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(722, 151);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(17, 16);
            this.radC.TabIndex = 15;
            this.radC.TabStop = true;
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.RadC_CheckedChanged);
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(722, 102);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(17, 16);
            this.radB.TabIndex = 14;
            this.radB.TabStop = true;
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.RadB_CheckedChanged);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(722, 53);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(17, 16);
            this.radA.TabIndex = 13;
            this.radA.TabStop = true;
            this.radA.UseVisualStyleBackColor = true;
            this.radA.CheckedChanged += new System.EventHandler(this.RadA_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đáp Án D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đáp Án C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đáp Án B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đáp Án A";
            // 
            // txtDapAnD
            // 
            this.txtDapAnD.Location = new System.Drawing.Point(745, 195);
            this.txtDapAnD.Name = "txtDapAnD";
            this.txtDapAnD.Size = new System.Drawing.Size(443, 30);
            this.txtDapAnD.TabIndex = 8;
            // 
            // txtDapAnC
            // 
            this.txtDapAnC.Location = new System.Drawing.Point(745, 145);
            this.txtDapAnC.Name = "txtDapAnC";
            this.txtDapAnC.Size = new System.Drawing.Size(443, 30);
            this.txtDapAnC.TabIndex = 7;
            // 
            // txtDapAnB
            // 
            this.txtDapAnB.Location = new System.Drawing.Point(745, 96);
            this.txtDapAnB.Name = "txtDapAnB";
            this.txtDapAnB.Size = new System.Drawing.Size(443, 30);
            this.txtDapAnB.TabIndex = 6;
            this.txtDapAnB.TextChanged += new System.EventHandler(this.TxtDapAnB_TextChanged);
            // 
            // txtDapAnA
            // 
            this.txtDapAnA.Location = new System.Drawing.Point(745, 47);
            this.txtDapAnA.Name = "txtDapAnA";
            this.txtDapAnA.Size = new System.Drawing.Size(443, 30);
            this.txtDapAnA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Câu Hỏi:";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(166, 145);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(419, 80);
            this.txtCauHoi.TabIndex = 3;
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(166, 47);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(152, 30);
            this.txtMaCauHoi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Câu Hỏi:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(33, 309);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1227, 416);
            this.dgv.TabIndex = 6;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // SoanCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 754);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbLamMoi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SoanCauHoi";
            this.Load += new System.EventHandler(this.NganHangDe_Load);
            this.gbLamMoi.ResumeLayout(false);
            this.gbLamMoi.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLamMoi;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolThemCH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolSuaCH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolXoaCH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDapAnD;
        private System.Windows.Forms.TextBox txtDapAnC;
        private System.Windows.Forms.TextBox txtDapAnB;
        private System.Windows.Forms.TextBox txtDapAnA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsThemMonHoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}