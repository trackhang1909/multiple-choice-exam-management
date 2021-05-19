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
    public partial class ChiTietDiem : Form
    {
        cla_crud crud = new cla_crud();
        ThiTracNghiem ttn;
        public string hoTen;
        public string gioiTinh;

        public ChiTietDiem()
        {
            InitializeComponent();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChiTietDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = crud.ReadData("SELECT * FROM Chitietdiem");
            dgv.DataSource = dt;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn trở lại không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                ttn = new ThiTracNghiem();
                ttn.denTTN = 1;
                ttn.hoTen = hoTen;
                ttn.gioiTinh = gioiTinh;
                ttn.Show();
            }
        }
    }
}
