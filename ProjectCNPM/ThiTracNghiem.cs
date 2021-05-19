using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class ThiTracNghiem : Form
    {
        cla_crud crud = new cla_crud();
        FrmMain frm;
        ChiTietDiem ctd;
        private string dapAnDung = null;
        private string maCauHoi;
        public string hoTen;
        public string gioiTinh;
        private float diemThi = 0;
        private int lanThi = 1;
        public int denTTN = 0;

        public ThiTracNghiem()
        {
            InitializeComponent();
        }

        private void ThiTracNghiem_Load(object sender, EventArgs e)
        {
            LoadDataDgv();
            crud.ExceData("DELETE FROM Dapan");
            txtTen.Text = hoTen;
            txtGioiTinh.Text = gioiTinh;
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoitam");
            DataTable dt2 = crud.ReadData("SELECT * FROM Monhoc");
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataRow row2 in dt2.Rows)
                {
                    if (row["maMonHoc"].ToString() == row2["maMonHoc"].ToString())
                    {
                        txtMon.Text = row2["tenMonHoc"].ToString();
                    }
                }
            }
            if (denTTN == 0)
            {
                crud.ExceData("DELETE FROM Chitietdiem");
            }
        }

        //Load Data De Thi
        private void LoadDataDgv()
        {
            DataTable dt = crud.ReadData("SELECT maCauHoi FROM Cauhoitam");
            dgv.DataSource = dt;
        }

        //Kiem tra dap an
        private void RadA_CheckedChanged(object sender, EventArgs e)
        {
            if (radA.Checked == true)
            {
                dapAnDung = "A";
            }
            crud.ExceData("INSERT INTO Dapan (maDapAn, dapAnDung) VALUES (N'" + maCauHoi + "',N'" + dapAnDung + "')");
            crud.ExceData("UPDATE Dapan SET dapAnDung=N'" + dapAnDung + "' WHERE maDapAn=N'" + maCauHoi + "'");
        }

        private void RadB_CheckedChanged(object sender, EventArgs e)
        {
            if (radB.Checked == true)
            {
                dapAnDung = "B";
            }
            crud.ExceData("INSERT INTO Dapan (maDapAn, dapAnDung) VALUES (N'" + maCauHoi + "',N'" + dapAnDung + "')");
            crud.ExceData("UPDATE Dapan SET dapAnDung=N'" + dapAnDung + "' WHERE maDapAn=N'" + maCauHoi + "'");
        }

        private void RadC_CheckedChanged(object sender, EventArgs e)
        {
            if (radC.Checked == true)
            {
                dapAnDung = "C";
            }
            crud.ExceData("INSERT INTO Dapan (maDapAn, dapAnDung) VALUES (N'" + maCauHoi + "',N'" + dapAnDung + "')");
            crud.ExceData("UPDATE Dapan SET dapAnDung=N'" + dapAnDung + "' WHERE maDapAn=N'" + maCauHoi + "'");
        }

        private void RadD_CheckedChanged(object sender, EventArgs e)
        {
            if (radD.Checked == true)
            {
                dapAnDung = "D";
            }
            crud.ExceData("INSERT INTO Dapan (maDapAn, dapAnDung) VALUES (N'" + maCauHoi + "',N'" + dapAnDung + "')");
            crud.ExceData("UPDATE Dapan SET dapAnDung=N'" + dapAnDung + "' WHERE maDapAn=N'" + maCauHoi + "'");
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Reset gia tri radio button va dapAnDung (khong luu gia tri cho lan click sau)
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
            dapAnDung = null;
            //Hien thi gia tri len textbox
            int i;
            i = dgv.CurrentRow.Index;
            maCauHoi = dgv.Rows[i].Cells[0].Value.ToString();
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoitam");
            foreach (DataRow row in dt.Rows)
            {
                if (maCauHoi == row["maCauHoi"].ToString())
                {
                    txtCauHoi.Text = row["cauHoi"].ToString();
                    txtDapAnA.Text = row["dapAnA"].ToString();
                    txtDapAnB.Text = row["dapAnB"].ToString();
                    txtDapAnC.Text = row["dapAnC"].ToString();
                    txtDapAnD.Text = row["dapAnD"].ToString();
                }
            }

            DataTable dt2 = crud.ReadData("SELECT * FROM Dapan");
            if (dt2 != null)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    if (maCauHoi == row["maDapAn"].ToString())
                    {
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
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int diem = 0;
            float count = 0;
            DataTable dt = crud.ReadData("SELECT maCauHoi, dapAnDung FROM Cauhoitam");
            DataTable dt2 = crud.ReadData("SELECT maDapAn, dapAnDung FROM Dapan");
            foreach (DataRow row in dt.Rows)
            {
                foreach(DataRow row2 in dt2.Rows)
                {
                    if (row["maCauHoi"].ToString() == row2["maDapAn"].ToString())
                    {
                        if (row["dapAnDung"].ToString() == row2["dapAnDung"].ToString())
                        {
                            diem++;
                        }
                    }
                    count++;
                }
            }
            diemThi = diem * (10 / count);
            crud.ExceData("INSERT INTO Chitietdiem(maDiem, soDiem) VALUES (N'Điểm Lần " + lanThi.ToString() + "', '" + diemThi.ToString() + "')");
            lanThi++;
            MessageBox.Show("Số Điểm Của Bạn Là " + diemThi + "");
        }

        private void ToolMDT_Click(object sender, EventArgs e)
        {
            lanThi = 1;
            crud.ExceData("DELETE FROM Chitietdiem");
            try
            {
                // mở file excel
                var package = new ExcelPackage(new FileInfo("DeThi.xlsx"));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                // duyệt tuần tự từ dòng thứ 3 đến dòng cuối cùng của file
                for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        crud.ExceData("INSERT INTO Cauhoitam(maCauHoi, maMonHoc, cauHoi, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung, doKho) VALUES (N'" + workSheet.Cells[i, 1].Value.ToString() + "',N'" + workSheet.Cells[i, 2].Value.ToString() + "',N'" + workSheet.Cells[i, 3].Value.ToString() + "',N'" + workSheet.Cells[i, 4].Value.ToString() + "', N'" + workSheet.Cells[i, 5].Value.ToString() + "',N'" + workSheet.Cells[i, 6].Value.ToString() + "', N'" + workSheet.Cells[i, 7].Value.ToString() + "', N'" + workSheet.Cells[i, 8].Value.ToString() + "',N'" + workSheet.Cells[i, 9].Value.ToString() + "')");
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }

            LoadDataDgv();
        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
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

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy Làm Mới Đề Thi Trước Khi Mở Đề. " +
                "File Đề Phải Là Định Dạng Excel, Tên File Phải Được Đặt Là: 'DeThi'.");
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xem chi tiết điểm không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                ctd = new ChiTietDiem();
                ctd.hoTen = hoTen;
                ctd.gioiTinh = gioiTinh;
                ctd.Show();
            }

        }
    }
}
