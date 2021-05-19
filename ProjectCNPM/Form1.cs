using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCNPM
{
    public partial class FrmMain : Form
    {
        DangKy dk;
        DangNhap dnUser;
        ThongTin tt;
        HuongDan hd;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            dk = new DangKy();
            dk.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnTTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            tt = new ThongTin();
            tt.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            dnUser = new DangNhap();
            dnUser.Show();
        }

        private void BtnHDan_Click(object sender, EventArgs e)
        {
            this.Hide();
            hd = new HuongDan();
            hd.Show();
        }
    }
}
