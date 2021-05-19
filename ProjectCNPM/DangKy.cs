using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class DangKy : Form
    {
        cla_crud crud = new cla_crud();
        DangNhap dnUser;
        private int gioiTinh = 0;
        private int quyenTC = 0;

        public DangKy()
        {
            InitializeComponent();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            Boolean check = crud.ExceData("INSERT INTO Taikhoan (tenDangNhap, matKhau, hoTen, gioiTinh, quyenTruyCap) VALUES (N'" + txtAcc.Text + "', N'" + txtPass.Text + "', N'" + txtHoTen.Text + "', N'" + gioiTinh + "', '" + quyenTC + "')");
            if (check == true)
            {
                MessageBox.Show("Đăng Ký Thành Công");
            }
            else
            {
                lbShowError.Text = "Tài Khoản Bị Trùng. Hãy Đặt Tên Tài Khoản Mới";
                txtAcc.Text = "";
                txtPass.Text = "";
                txtHoTen.Text = "";
                txtAcc.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ trở lại trang đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dnUser = new DangNhap();
                dnUser.Show();
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

        private void RadNam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = 0;
        }

        private void RadNu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = 1;
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.cmb.GetItemText(this.cmb.SelectedItem);

            if (item == "Giáo Viên")
            {
                quyenTC = 0;
            }
            else
            {
                quyenTC = 1;
            }
        }
    }
}
