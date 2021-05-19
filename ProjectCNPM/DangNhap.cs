using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class DangNhap : Form
    {
        ThiTracNghiem ttn;
        FrmMain frm;
        DangKy dkUser;
        DoiThongTin dttUser;
        CachTaoDe ctd;
        cla_crud crud = new cla_crud();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;
            DataTable dt = crud.ReadData("SELECT * FROM Taikhoan");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tenDangNhap"].ToString() == txtAcc.Text && row["matKhau"].ToString() == txtPass.Text && int.Parse(row["quyenTruyCap"].ToString()) == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.Hide();
                            ttn = new ThiTracNghiem();
                            if (int.Parse(row["gioiTinh"].ToString()) == 0)
                            {
                                ttn.hoTen = row["hoTen"].ToString();
                                ttn.gioiTinh = "Nam";
                            }
                            else
                            {
                                ttn.hoTen = row["hoTen"].ToString();
                                ttn.gioiTinh = "Nữ";
                            }
                            ttn.Show();
                        }
                        count++;
                    }
                    if (row["tenDangNhap"].ToString() == txtAcc.Text && row["matKhau"].ToString() == txtPass.Text && int.Parse(row["quyenTruyCap"].ToString()) == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.Hide();
                            ctd = new CachTaoDe();
                            ctd.Show();
                        }
                        count++;
                    }
                }
                if (count == 0)
                {
                    lbShowError.Text = "Tài khoản hoặc Mật khẩu không đúng";
                    txtAcc.Text = "";
                    txtPass.Text = "";
                    txtAcc.Focus();
                }
            }
            else
            {
                lbShowError.Text = "Tài khoản hoặc Mật khẩu không đúng";
                txtAcc.Text = "";
                txtPass.Text = "";
                txtAcc.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang đăng ký", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dkUser = new DangKy();
                dkUser.Show();
            }
        }

        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnDTT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang đổi thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dttUser = new DoiThongTin();
                dttUser.Show();
            }
        }
    }
}
