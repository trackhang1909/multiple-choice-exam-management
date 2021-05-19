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
    public partial class SoanCauHoi : Form
    {
        cla_crud crud = new cla_crud();
        FrmMain frm;
        ThemMonHoc tmh;
        CachTaoDe ctd;
        SoanDeThi sdt;
        SoanDeThiNgauNhien sdtnn;
        private string maMonHoc;
        private string dapAnDung = null;
        public int denSCH = 0;

        public SoanCauHoi()
        {
            InitializeComponent();
        }

        //Them data vao 2 combobox
        private void NganHangDe_Load(object sender, EventArgs e)
        {
            LoadDataDgv();
            DataTable dt = crud.ReadData("SELECT * FROM Monhoc");
            foreach (DataRow row in dt.Rows)
            {
                cmb.Items.Add(row["tenMonHoc"].ToString());
            }
            //Do kho cau hoi
            cmb2.Items.Add("Dễ");
            cmb2.Items.Add("Trung Bình");
            cmb2.Items.Add("Khó");
        }

        //Load Data Grid View
        private void LoadDataDgv()
        {
            DataTable dt2 = crud.ReadData("SELECT * FROM Cauhoi");
            dgv.DataSource = dt2;
        }

        private void TxtDapAnB_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //Them cau hoi
        private void ToolThemCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm câu hỏi mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (txtCauHoi.Text == "")
                {
                    MessageBox.Show("Hãy Thêm Câu Hỏi");
                }
                else if (txtDapAnA.Text == "" && txtDapAnB.Text == "" && txtDapAnC.Text == "" && txtDapAnD.Text == "")
                {
                    MessageBox.Show("Hãy Thêm Ít Nhất Một Đáp Án");
                }
                else if (txtMaCauHoi.Text == "")
                {
                    MessageBox.Show("Hãy Thêm Mã Câu Hỏi");
                }
                else if (radA.Checked == false && radB.Checked == false && radC.Checked == false && radD.Checked == false)
                {
                    MessageBox.Show("Hãy Thêm Đáp Án Đúng");
                }
                else if (radA.Checked == true && txtDapAnA.Text == "")
                {
                    MessageBox.Show("Hãy Chọn Lại Đáp Án Đúng");
                }
                else if (radB.Checked == true && txtDapAnB.Text == "")
                {
                    MessageBox.Show("Hãy Chọn Lại Đáp Án Đúng");
                }
                else if (radC.Checked == true && txtDapAnC.Text == "")
                {
                    MessageBox.Show("Hãy Chọn Lại Đáp Án Đúng");
                }
                else if (radD.Checked == true && txtDapAnD.Text == "")
                {
                    MessageBox.Show("Hãy Chọn Lại Đáp Án Đúng");
                }
                else if (cmb.Text == "")
                {
                    MessageBox.Show("Hãy Chọn Môn Học");
                }
                else if (cmb2.Text == "")
                {
                    MessageBox.Show("Hãy Chọn Độ Khó Câu Hỏi");
                }
                else
                {
                    Boolean check = crud.ExceData("INSERT INTO Cauhoi (maCauHoi, maMonHoc, cauHoi, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung, doKho) VALUES (N'" + txtMaCauHoi.Text + "',N'" + maMonHoc + "', N'" + txtCauHoi.Text + "',N'" + txtDapAnA.Text + "', N'" + txtDapAnB.Text + "', N'" + txtDapAnC.Text + "', N'" + txtDapAnD.Text + "', N'" + dapAnDung + "', N'" + cmb2.Text + "')");
                    if (check == true)
                    {
                        MessageBox.Show("Thêm Câu Hỏi Thành Công !");
                        LoadDataDgv();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Câu Hỏi Thất Bại !");
                    }
                }
            }
        }

        //Gan maMonHoc = tenMonHoc tuong ung khi thay doi gia tri
        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String var = cmb.Text;
            var item = this.cmb.GetItemText(this.cmb.SelectedItem);

            DataTable dt = crud.ReadData("SELECT * FROM Monhoc");
            foreach (DataRow row in dt.Rows)
            {
                if (item == row["tenMonHoc"].ToString())
                {
                    maMonHoc = row["maMonHoc"].ToString();
                }
            }
            txtMaMonHoc.Text = maMonHoc;
        }

        //Gan gia tri dapAnDung
        private void RadA_CheckedChanged(object sender, EventArgs e)
        {
            if (radA.Checked == true)
            {
                dapAnDung = "A";
            }
        }

        private void RadB_CheckedChanged(object sender, EventArgs e)
        {
            if (radB.Checked == true)
            {
                dapAnDung = "B";
            }
        }

        private void RadC_CheckedChanged(object sender, EventArgs e)
        {
            if (radC.Checked == true)
            {
                dapAnDung = "C";
            }
        }

        private void RadD_CheckedChanged(object sender, EventArgs e)
        {
            if (radD.Checked == true)
            {
                dapAnDung = "D";
            }
        }

        //Click dgv -> hien data textbox
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtMaCauHoi.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtMaMonHoc.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtCauHoi.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtDapAnA.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtDapAnB.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txtDapAnC.Text = dgv.Rows[i].Cells[5].Value.ToString();
            txtDapAnD.Text = dgv.Rows[i].Cells[6].Value.ToString();
            if (dgv.Rows[i].Cells[7].Value.ToString() == "A")
            {
                radA.Checked = true;
            }
            if (dgv.Rows[i].Cells[7].Value.ToString() == "B")
            {
                radB.Checked = true;
            }
            if (dgv.Rows[i].Cells[7].Value.ToString() == "C")
            {
                radC.Checked = true;
            }
            if (dgv.Rows[i].Cells[7].Value.ToString() == "D")
            {
                radD.Checked = true;
            }
            cmb2.Text = dgv.Rows[i].Cells[8].Value.ToString();
            DataTable dt = crud.ReadData("SELECT * FROM Monhoc");
            foreach (DataRow row in dt.Rows)
            {
                if (dgv.Rows[i].Cells[1].Value.ToString() == row["maMonHoc"].ToString())
                {
                    cmb.Text = row["tenMonHoc"].ToString();
                }
            }
        }

        //Reset data
        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            txtMaCauHoi.Text = "";
            txtMaMonHoc.Text = "";
            txtCauHoi.Text = "";
            txtDapAnA.Text = "";
            txtDapAnB.Text = "";
            txtDapAnC.Text = "";
            txtDapAnD.Text = "";
            cmb.Text = "";
            cmb2.Text = "";
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
        }

        //Xoa cau hoi
        private void ToolXoaCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa câu hỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("DELETE FROM Cauhoi WHERE maCauHoi= '" + txtMaCauHoi.Text + "'");
                if (check == true)
                {
                    MessageBox.Show("Xóa Câu Hỏi Thành Công !");
                    LoadDataDgv();
                }
                else
                {
                    MessageBox.Show("Xóa Câu Hỏi Thất Bại !");
                }
            }
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn trở lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                if (denSCH == 1)
                {
                    sdtnn = new SoanDeThiNgauNhien();
                    sdtnn.Show();
                }
                else if (denSCH == 2)
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

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        //Cap nhat cau hoi
        private void ToolSuaCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật câu hỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("UPDATE Cauhoi SET maMonHoc=N'" + maMonHoc + "',cauHoi=N'" + txtCauHoi.Text + "',dapAnA=N'" + txtDapAnA.Text + "',dapAnB=N'" + txtDapAnB.Text + "',dapAnC=N'" + txtDapAnC.Text + "',dapAnD=N'" + txtDapAnD.Text + "',dapAnDung=N'" + dapAnDung + "',doKho=N'" + cmb2.Text + "' WHERE maCauHoi=N'" + txtMaCauHoi.Text + "'");
                if (check == true)
                {
                    MessageBox.Show("Cập Nhật Câu Hỏi Thành Công !");
                    LoadDataDgv();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Câu Hỏi Thất Bại !");
                }
            }
        }

        //Chuyen den ThemMonHoc
        private void TsThemMonHoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm môn học mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                tmh = new ThemMonHoc();
                tmh.Show();
            }
        }
    }
}
