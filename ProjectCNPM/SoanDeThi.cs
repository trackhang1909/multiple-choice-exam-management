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
    public partial class SoanDeThi : Form
    {
        FrmMain frm;
        ThemMonHoc tmh;
        cla_crud crud = new cla_crud();
        SoanCauHoi sch;
        NganHangDe nhd;
        CachTaoDe cdt;
        Excel excel;
        private string maMonHoc;
        private string dapAnDung = null;

        public SoanDeThi()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                frm = new FrmMain();
                frm.Show();
            }
        }

        private void Label9_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm môn học mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                tmh = new ThemMonHoc();
                tmh.denTMH = 2;
                tmh.Show();
            }
        }

        private void SoanDeThi_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataDgvNHD();
            LoadDataDgvDT();
        }

        //Load Data Ngan Hang De
        private void LoadDataDgvNHD()
        {
            DataTable dt = crud.ReadData("SELECT maCauHoi, maMonHoc FROM Cauhoi");
            dgvNHD.DataSource = dt;
        }

        //Load Data De Thi
        private void LoadDataDgvDT()
        {
            DataTable dt = crud.ReadData("SELECT maCauHoi, maMonHoc FROM Cauhoitam");
            dgvDT.DataSource = dt;
        }

        //Them ten mon hoc vao combobox
        private void LoadData()
        {
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

        //Gan maMonHoc = maMonHoc trong db khi chon tenMonHoc
        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.cmb.GetItemText(this.cmb.SelectedItem);

            DataTable dt = crud.ReadData("SELECT * FROM Monhoc");
            foreach (DataRow row in dt.Rows)
            {
                if (item == row["tenMonHoc"].ToString())
                {
                    maMonHoc = row["maMonHoc"].ToString();
                }
            }

        }

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

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            int maMonKoTrung = 0;
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoitam");
            foreach (DataRow row in dt.Rows)
            {
                if (maMonHoc != row["maMonHoc"].ToString())
                {
                    maMonKoTrung++;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm câu hỏi mới vào đề thi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (txtCauHoi.Text == "")
                {
                    MessageBox.Show("Hãy Thêm Câu Hỏi");
                }
                else if (maMonKoTrung != 0)
                {
                    MessageBox.Show("Hãy Chọn Cùng Môn Học");
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
                    Boolean check = crud.ExceData("INSERT INTO Cauhoitam (maCauHoi, maMonHoc, cauHoi, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung, doKho) VALUES (N'" + txtMaCauHoi.Text + "',N'" + maMonHoc + "', N'" + txtCauHoi.Text + "',N'" + txtDapAnA.Text + "', N'" + txtDapAnB.Text + "', N'" + txtDapAnC.Text + "', N'" + txtDapAnD.Text + "', N'" + dapAnDung + "', N'" + cmb2.Text + "')");
                    if (check == true)
                    {
                        MessageBox.Show("Thêm Câu Hỏi Thành Công !");
                        LoadDataDgvDT();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Câu Hỏi Thất Bại !");
                    }
                }
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Xem chi tiet ngan hang de
        private void ToolStripLabel1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn vào ngân hàng đề", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                nhd = new NganHangDe();
                nhd.denNHD = 2;
                nhd.Show();
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtDapAnA_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvNHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNHD.CurrentRow.Index;
            txtMaCauHoi.Text = dgvNHD.Rows[i].Cells[0].Value.ToString();
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoi");
            foreach (DataRow row in dt.Rows)
            {
                if (txtMaCauHoi.Text == row["maCauHoi"].ToString())
                {
                    txtCauHoi.Text = row["cauHoi"].ToString();
                    txtDapAnA.Text = row["dapAnA"].ToString();
                    txtDapAnB.Text = row["dapAnB"].ToString();
                    txtDapAnC.Text = row["dapAnC"].ToString();
                    txtDapAnD.Text = row["dapAnD"].ToString();
                    if (row["dapAnDung"].ToString() == "A")
                    {
                        radA.Checked = true;
                    }
                    if (row["dapAnDung"].ToString() == "B")
                    {
                        radB.Checked = true;
                    }
                    if (row["dapAnDung"].ToString() == "C")
                    {
                        radC.Checked = true;
                    }
                    if (row["dapAnDung"].ToString() == "D")
                    {
                        radD.Checked = true;
                    }
                    cmb2.Text = row["doKho"].ToString();
                    DataTable dt2 = crud.ReadData("SELECT * FROM Monhoc");
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        if (dgvNHD.Rows[i].Cells[1].Value.ToString() == row2["maMonHoc"].ToString())
                        {
                            cmb.Text = row2["tenMonHoc"].ToString();
                        }
                    }
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

        private void ToolStripLabel4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn soạn câu hỏi mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                sch = new SoanCauHoi();
                sch.denSCH = 2;
                sch.Show();
            }
        }

        //Lam moi du lieu
        private void ToolStripLabel5_Click(object sender, EventArgs e)
        {
            txtMaCauHoi.Text = "";
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

        //Lam moi Cauhoitam
        private void ToolStripLabel6_Click(object sender, EventArgs e)
        {
            Boolean check = crud.ExceData("DELETE FROM Cauhoitam");
            if (check == true)
            {
                LoadDataDgvDT();
            }
            else
            {
                MessageBox.Show("Lỗi !");
            }
        }

        //Cap nhat cau hoi
        private void ToolSuaCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật câu hỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("UPDATE Cauhoitam SET maMonHoc=N'" + maMonHoc + "',cauHoi=N'" + txtCauHoi.Text + "',dapAnA=N'" + txtDapAnA.Text + "',dapAnB=N'" + txtDapAnB.Text + "',dapAnC=N'" + txtDapAnC.Text + "',dapAnD=N'" + txtDapAnD.Text + "',dapAnDung=N'" + dapAnDung + "',doKho=N'" + cmb2.Text + "' WHERE maCauHoi=N'" + txtMaCauHoi.Text + "'");
                if (check == true)
                {
                    MessageBox.Show("Cập Nhật Câu Hỏi Thành Công !");
                    LoadDataDgvDT();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Câu Hỏi Thất Bại !");
                }
            }
        }

        private void DgvDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDT.CurrentRow.Index;
            txtMaCauHoi.Text = dgvDT.Rows[i].Cells[0].Value.ToString();
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoitam");
            foreach (DataRow row in dt.Rows)
            {
                if (txtMaCauHoi.Text == row["maCauHoi"].ToString())
                {
                    txtCauHoi.Text = row["cauHoi"].ToString();
                    txtDapAnA.Text = row["dapAnA"].ToString();
                    txtDapAnB.Text = row["dapAnB"].ToString();
                    txtDapAnC.Text = row["dapAnC"].ToString();
                    txtDapAnD.Text = row["dapAnD"].ToString();
                    if (row["dapAnDung"].ToString() == "A")
                    {
                        radA.Checked = true;
                    }
                    if (row["dapAnDung"].ToString() == "B")
                    {
                        radB.Checked = true;
                    }
                    if (row["dapAnDung"].ToString() == "C")
                    {
                        radC.Checked = true;
                    }
                    if (row["dapAnDung"].ToString() == "D")
                    {
                        radD.Checked = true;
                    }
                    cmb2.Text = row["doKho"].ToString();
                    DataTable dt2 = crud.ReadData("SELECT * FROM Monhoc");
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        if (dgvDT.Rows[i].Cells[1].Value.ToString() == row2["maMonHoc"].ToString())
                        {
                            cmb.Text = row2["tenMonHoc"].ToString();
                        }
                    }
                }
            }
        }

        //Xoa cau hoi
        private void ToolXoaCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa câu hỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("DELETE FROM Cauhoitam WHERE maCauHoi= '" + txtMaCauHoi.Text + "'");
                if (check == true)
                {
                    MessageBox.Show("Xóa Câu Hỏi Thành Công !");
                    LoadDataDgvDT();
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
                cdt = new CachTaoDe();
                cdt.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tạo file excel", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                excel = new Excel();
                excel.denExcel = 1;
                excel.Show();
            }
        }
    }
}
