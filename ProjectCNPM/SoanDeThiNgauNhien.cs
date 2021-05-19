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
    public partial class SoanDeThiNgauNhien : Form
    {
        ThemMonHoc tmh;
        CachTaoDe ctd;
        FrmMain frm;
        SoanCauHoi sch;
        NganHangDe nhd;
        Excel excel;
        cla_crud crud = new cla_crud();
        private string maMonHoc;
        private string dapAnDung = null;

        public SoanDeThiNgauNhien()
        {
            InitializeComponent();
        }

        //Load Data Grid View
        private void LoadDataDgv()
        {
            DataTable dt2 = crud.ReadData("SELECT * FROM Cauhoitam");
            dgv.DataSource = dt2;
        }

        //Them mon hoc moi
        private void TsThemMonHoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm môn học mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                tmh = new ThemMonHoc();
                tmh.denTMH = 1;
                tmh.Show();
            }
        }

        private void ToolSuaCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật câu hỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("UPDATE Cauhoitam SET maMonHoc=N'" + maMonHoc + "',cauHoi=N'" + txtCauHoi.Text + "',dapAnA=N'" + txtDapAnA.Text + "',dapAnB=N'" + txtDapAnB.Text + "',dapAnC=N'" + txtDapAnC.Text + "',dapAnD=N'" + txtDapAnD.Text + "',dapAnDung=N'" + dapAnDung + "',doKho=N'" + cmb2.Text + "' WHERE maCauHoi=N'" + txtMaCauHoi.Text + "'");
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

        private void SoanDeThiNgauNhien_Load(object sender, EventArgs e)
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

        private void ToolXoaCH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa câu hỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Boolean check = crud.ExceData("DELETE FROM Cauhoitam WHERE maCauHoi= '" + txtMaCauHoi.Text + "'");
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

        private void ToolThemCH_Click(object sender, EventArgs e)
        {
            int maMonKoTrung = 0;
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoitam");
            foreach (DataRow row in dt.Rows)
            {
                if (txtMaMonHoc.Text != row["maMonHoc"].ToString())
                {
                    maMonKoTrung++;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm câu hỏi mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        LoadDataDgv();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Câu Hỏi Thất Bại !");
                    }
                }
            }
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn trở lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                ctd = new CachTaoDe();
                ctd.Show();
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

        //Lam moi Cauhoitam
        private void ToolStripLabel6_Click(object sender, EventArgs e)
        {
            Boolean check = crud.ExceData("DELETE FROM Cauhoitam");
            if (check == true)
            {
                LoadDataDgv();
            }
            else
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private void ToolStripLabel4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn soạn câu hỏi mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                sch = new SoanCauHoi();
                sch.denSCH = 1;
                sch.Show();
            }
        }

        private void ToolStripLabel5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn vào ngân hàng đề", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                nhd = new NganHangDe();
                nhd.denNHD = 1;
                nhd.Show();
            }
        }

        private void BtnTaoDeThi_Click(object sender, EventArgs e)
        {
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoi");
            int tongCauDe = dt.Select("doKho = 'Dễ' AND maMonHoc = '" + txtMaMonHoc.Text + "'").Length;
            int tongCauTB = dt.Select("doKho = 'Trung Bình' AND maMonHoc = '" + txtMaMonHoc.Text + "'").Length;
            int tongCauKho = dt.Select("doKho = 'Khó' AND maMonHoc = '" + txtMaMonHoc.Text + "'").Length;

            //Yeu cau chon mon hoc khi tao de thi
            if (cmb.Text == "")
            {
                MessageBox.Show("Bạn Hãy Chọn Môn Học");
            }
            else 
            {
                //Kiem tra table co rong khong
                DataTable dt2 = crud.ReadData("SELECT * FROM Cauhoitam");

                if (dt2.Rows.Count != 0)
                {
                    MessageBox.Show("Bạn Hãy Làm Mới Đề Thi");
                }
                else
                {
                    //=============================================================================================
                    //Xu ly cau hoi de
                    int soCauDeNhap = 0;
                    int countDe = 0;
                    //=============================================================================================
                    //Xu ly cau hoi trung binh
                    int soCauTBNhap = 0;
                    int countTB = 0;
                    //=============================================================================================
                    //Xu ly cau hoi kho
                    int soCauKhoNhap = 0;
                    int countKho = 0;

                    //Yeu cau nhap so cau hoi de 
                    if (txtCauHoiDe.Text == "")
                    {
                        MessageBox.Show("Bạn Hãy Nhập Số Câu Hỏi Dễ");
                    }
                    //Yeu cau nhap so cau hoi tb
                    else if (txtCauHoiTB.Text == "")
                    {
                        MessageBox.Show("Bạn Hãy Nhập Số Câu Hỏi Trung Bình");
                    }
                    //Yeu cau nhap so cau hoi kho
                    else if (txtCauHoiKho.Text == "")
                    {
                        MessageBox.Show("Bạn Hãy Nhập Số Câu Hỏi Khó");
                    }
                    else
                    {
                        //Gan gia tri so cau hoi de nhap vao
                        soCauDeNhap = int.Parse(txtCauHoiDe.Text);
                        //Gan gia tri so cau hoi tb nhap vao
                        soCauTBNhap = int.Parse(txtCauHoiTB.Text);
                        //Gan gia tri so cau hoi kho nhap vao
                        soCauKhoNhap = int.Parse(txtCauHoiKho.Text);

                        //So sanh voi cau hoi trong ngan hang de
                        if (soCauDeNhap > tongCauDe)
                        {
                            MessageBox.Show("Ngân Hàng Đề Không Đủ Số Câu Hỏi Dễ");
                        }
                        else if (soCauTBNhap > tongCauTB)
                        {
                            MessageBox.Show("Ngân Hàng Đề Không Đủ Số Câu Hỏi Trung Bình");
                        }
                        else if (soCauKhoNhap > tongCauKho)
                        {
                            MessageBox.Show("Ngân Hàng Đề Không Đủ Số Câu Hỏi Khó");
                        }
                        else
                        {
                            //Tao cau hoi de
                            while (countDe < soCauDeNhap)
                            {
                                Random rd = new Random();
                                int rdDe = rd.Next(0, dt.Rows.Count);

                                if (dt.Rows[rdDe]["maMonHoc"].ToString() == txtMaMonHoc.Text && dt.Rows[rdDe]["doKho"].ToString() == "Dễ")
                                {
                                    Boolean check = crud.ExceData("INSERT INTO Cauhoitam (maCauHoi, maMonHoc, cauHoi, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung, doKho) VALUES (N'" + dt.Rows[rdDe]["maCauHoi"].ToString() + "',N'" + dt.Rows[rdDe]["maMonHoc"].ToString() + "', N'" + dt.Rows[rdDe]["cauHoi"].ToString() + "',N'" + dt.Rows[rdDe]["dapAnA"].ToString() + "', N'" + dt.Rows[rdDe]["dapAnB"].ToString() + "', N'" + dt.Rows[rdDe]["dapAnC"].ToString() + "', N'" + dt.Rows[rdDe]["dapAnD"].ToString() + "', N'" + dt.Rows[rdDe]["dapAnDung"].ToString() + "', N'" + dt.Rows[rdDe]["doKho"].ToString() + "')");
                                    if (check == true)
                                    {
                                        LoadDataDgv();
                                        countDe++;
                                    }
                                }
                            }
                            //Tao cau hoi tb
                            while (countTB < soCauTBNhap)
                            {
                                Random rd = new Random();
                                int rdTB = rd.Next(0, dt.Rows.Count);

                                if (dt.Rows[rdTB]["maMonHoc"].ToString() == txtMaMonHoc.Text && dt.Rows[rdTB]["doKho"].ToString() == "Trung Bình")
                                {
                                    Boolean check = crud.ExceData("INSERT INTO Cauhoitam (maCauHoi, maMonHoc, cauHoi, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung, doKho) VALUES (N'" + dt.Rows[rdTB]["maCauHoi"].ToString() + "',N'" + dt.Rows[rdTB]["maMonHoc"].ToString() + "', N'" + dt.Rows[rdTB]["cauHoi"].ToString() + "',N'" + dt.Rows[rdTB]["dapAnA"].ToString() + "', N'" + dt.Rows[rdTB]["dapAnB"].ToString() + "', N'" + dt.Rows[rdTB]["dapAnC"].ToString() + "', N'" + dt.Rows[rdTB]["dapAnD"].ToString() + "', N'" + dt.Rows[rdTB]["dapAnDung"].ToString() + "', N'" + dt.Rows[rdTB]["doKho"].ToString() + "')");
                                    if (check == true)
                                    {
                                        LoadDataDgv();
                                        countTB++;
                                    }
                                }
                            }
                            //Tao cau hoi kho
                            while (countKho < soCauKhoNhap)
                            {
                                Random rd = new Random();
                                int rdKho = rd.Next(0, dt.Rows.Count);

                                if (dt.Rows[rdKho]["maMonHoc"].ToString() == txtMaMonHoc.Text && dt.Rows[rdKho]["doKho"].ToString() == "Khó")
                                {
                                    Boolean check = crud.ExceData("INSERT INTO Cauhoitam (maCauHoi, maMonHoc, cauHoi, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung, doKho) VALUES (N'" + dt.Rows[rdKho]["maCauHoi"].ToString() + "',N'" + dt.Rows[rdKho]["maMonHoc"].ToString() + "', N'" + dt.Rows[rdKho]["cauHoi"].ToString() + "',N'" + dt.Rows[rdKho]["dapAnA"].ToString() + "', N'" + dt.Rows[rdKho]["dapAnB"].ToString() + "', N'" + dt.Rows[rdKho]["dapAnC"].ToString() + "', N'" + dt.Rows[rdKho]["dapAnD"].ToString() + "', N'" + dt.Rows[rdKho]["dapAnDung"].ToString() + "', N'" + dt.Rows[rdKho]["doKho"].ToString() + "')");
                                    if (check == true)
                                    {
                                        LoadDataDgv();
                                        countKho++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void TxtMaCauHoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tạo file excel", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                excel = new Excel();
                excel.denExcel = 0;
                excel.Show();
            }
        }
    }
}
