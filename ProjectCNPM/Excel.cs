using OfficeOpenXml;
using OfficeOpenXml.Style;
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
    public partial class Excel : Form
    {
        cla_crud crud = new cla_crud();
        CachTaoDe ctd;
        private string tenMonHoc;
        public int denExcel;
        SoanDeThiNgauNhien sdtnn;
        SoanDeThi sdt;

        public Excel()
        {
            InitializeComponent();
        }

        private void TaoDeThi_Load(object sender, EventArgs e)
        {
            LoadDataDgv();
        }

        //Load Data Grid View
        private void LoadDataDgv()
        {
            DataTable dt2 = crud.ReadData("SELECT * FROM Cauhoitam");
            dgv.DataSource = dt2;
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                ctd = new CachTaoDe();
                ctd.Show();
            }
        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn trở lại không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                if (denExcel == 0)
                {
                    sdtnn = new SoanDeThiNgauNhien();
                    sdtnn.Show();
                }
                else
                {
                    sdt = new SoanDeThi();
                    sdt.Show();
                }
            }
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            dialog.ShowDialog();

            filePath = dialog.FileName;


            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    if (txtTacGia.Text == "")
                    {
                        MessageBox.Show("Hãy Nhập Tên Tác Giả");
                    }
                    else if (txtTieuDe.Text == "")
                    {
                        MessageBox.Show("Hãy Nhập Tên Tiêu Đề");
                    }
                    else if (txtSheet.Text == "")
                    {
                        MessageBox.Show("Hãy Nhập Tên Sheet");
                    }
                    else
                    {
                        p.Workbook.Properties.Author = txtTacGia.Text;
                        p.Workbook.Properties.Title = txtTieuDe.Text;
                        p.Workbook.Worksheets.Add(txtSheet.Text + "Sheet");
                    }

                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    ws.Name = txtSheet.Text + "Sheet";
                    ws.Cells.Style.Font.Size = 12;
                    ws.Cells.Style.Font.Name = "Time New Roman";

                    string[] arrColumnHeader = {
                                                "Mã Câu Hỏi",
                                                "Mã Môn Học",
                                                "Câu Hỏi",
                                                "Đáp Án A",
                                                "Đáp Án B",
                                                "Đáp Án C",
                                                "Đáp Án D",
                                                "Đáp Án Đúng",
                                                "Độ Khó"
                    };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    DataTable dt2 = crud.ReadData("SELECT * FROM Monhoc");
                    DataTable dt3 = crud.ReadData("SELECT * FROM Cauhoitam");
                    foreach (DataRow row1 in dt2.Rows)
                    {
                        foreach (DataRow row2 in dt3.Rows)
                        {
                            if (row1["maMonHoc"].ToString() == row2["maMonHoc"].ToString())
                            {
                                tenMonHoc = row1["tenMonHoc"].ToString();
                            }
                        }
                    }

                    ws.Cells[1, 1].Value = "Đề Thi Trắc Nghiệm Môn " + tenMonHoc;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // lấy ra danh sách
                    DataTable dt = crud.ReadData("SELECT * FROM Cauhoitam");

                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (DataRow row in dt.Rows)
                    {
                        // bắt đầu ghi từ cột 1
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = row["maCauHoi"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["maMonHoc"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["cauHoi"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["dapAnA"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["dapAnB"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["dapAnC"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["dapAnD"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["dapAnDung"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row["doKho"].ToString();

                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất Excel Thành Công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
        }
    }
}
