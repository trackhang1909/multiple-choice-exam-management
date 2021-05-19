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
    public partial class DoiThongTin : Form
    {
        DangNhap dnUser;
        cla_crud crud = new cla_crud();
        private int gioiTinh = 0;
        private int quyenTC = 0;

        public DoiThongTin()
        {
            InitializeComponent();
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

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            Boolean check = crud.ExceData("UPDATE Taikhoan SET matKhau=N'" + txtPass.Text + "', hoTen=N'" + txtHoTen.Text + "', gioiTinh='" + gioiTinh + "', quyenTruyCap='" + quyenTC + "' WHERE tenDangNhap='" + txtAcc.Text + "'");
            if (check == true)
            {
                MessageBox.Show("Thay Đổi Thông Tin Thành Công");
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Không Đúng");
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

        private void TxtAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadNam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = 0;
        }

        private void RadNu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = 1;
        }

        private void RadGV_CheckedChanged(object sender, EventArgs e)
        {
            quyenTC = 0;
        }

        private void RadSV_CheckedChanged(object sender, EventArgs e)
        {
            quyenTC = 1;
        }
    }
}
