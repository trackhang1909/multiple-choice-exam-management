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
    public partial class CachTaoDe : Form
    {
        SoanDeThi sdt;
        FrmMain frm;
        SoanCauHoi sch;
        ThemMonHoc tmh;
        SoanDeThiNgauNhien sdtnn;
        NganHangDe nhd;
        DangNhap dn;

        public CachTaoDe()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang soạn đề thi ngẫu nhiên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                sdtnn = new SoanDeThiNgauNhien();
                sdtnn.Show();
            }
        }

        //Chuyen den trang soan cau hoi
        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ chuyển đến trang soạn đề thi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                sdt = new SoanDeThi();
                sdt.Show();
            }
        }

        //Tro lai frmMain
        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn trở lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dn = new DangNhap();
                dn.Show();
            }
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn soạn câu hỏi mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                sch = new SoanCauHoi();
                sch.Show();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm môn học mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                tmh = new ThemMonHoc();
                tmh.Show();
            }
        }

        private void ToolStripLabel5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn vào ngân hàng đề", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                nhd = new NganHangDe();
                nhd.Show();
            }
        }
    }
}
