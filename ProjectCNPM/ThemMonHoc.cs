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
    public partial class ThemMonHoc : Form
    {
        SoanDeThi sdt;
        SoanDeThiNgauNhien sdtnn;
        FrmMain frm;
        cla_crud crud = new cla_crud();
        CachTaoDe ctd;
        public int denTMH = 0;

        public ThemMonHoc()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        private void ToolStripLabel6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn trở lại không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                if (denTMH == 1)
                {
                    sdtnn = new SoanDeThiNgauNhien();
                    sdtnn.Show();
                }
                else if (denTMH == 2)
                {
                    sdt = new SoanDeThi();
                    sdt.Show();
                }
                else
                {
                    ctd = new CachTaoDe();
                    ctd.Show();
                }
            }
        }

        //Them mon hoc moi
        private void ToolThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm môn học mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (txtMaMonHoc.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Mã Môn Học");
                }
                else if (txtTenMonHoc.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Tên Môn Học");
                }
                else
                {
                    Boolean check = crud.ExceData("INSERT INTO Monhoc (maMonHoc, tenMonHoc) VALUES (N'" + txtMaMonHoc.Text + "',N'" + txtTenMonHoc.Text + "') ");
                    if (check == true)
                    {
                        MessageBox.Show("Thêm Môn Học Thành Công !");
                        LoadDataDgv();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Môn Học Thất Bại !");
                    }
                }
            }
        }

        //Load Data GridView
        private void ThemMonHoc_Load(object sender, EventArgs e)
        {
            LoadDataDgv();
        }

        //LoadData tu db, them vao gridview
        private void LoadDataDgv()
        {
            DataTable dt = crud.ReadData("SELECT * FROM Monhoc");
            dgv.DataSource = dt;
        }

        //Cap nhat mon hoc cu
        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật môn học", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("UPDATE Monhoc SET tenMonHoc=N'" + txtTenMonHoc.Text + "' WHERE maMonHoc=N'" + txtMaMonHoc.Text + "'");
                if (check == true)
                {
                    MessageBox.Show("Cập Nhật Môn Học Thành Công !");
                    LoadDataDgv();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Môn Học Thất Bại !");
                }
            }
        }

        //Click dgv -> hien data textbox
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtMaMonHoc.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTenMonHoc.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        //Xoa mon hoc
        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa môn học", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("DELETE FROM Monhoc WHERE maMonHoc= '" + txtMaMonHoc.Text + "'");
                if (check == true)
                {
                    MessageBox.Show("Xóa Môn Học Thành Công !");
                    LoadDataDgv();
                }
                else
                {
                    MessageBox.Show("Xóa Môn Học Thất Bại !");
                }
            }
        }
    }
}
