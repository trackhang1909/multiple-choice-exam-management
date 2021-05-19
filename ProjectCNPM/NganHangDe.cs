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
    public partial class NganHangDe : Form
    {
        cla_crud crud = new cla_crud();
        CachTaoDe ctd;
        SoanDeThi sdt;
        SoanDeThiNgauNhien sdtnn;
        FrmMain frm;
        public int denNHD = 0;

        public NganHangDe()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataDgv()
        {
            DataTable dt = crud.ReadData("SELECT * FROM Cauhoi");
            dgv.DataSource = dt;
        }

        private void NganHangDe_Load(object sender, EventArgs e)
        {
            LoadDataDgv();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn trở lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                if (denNHD == 1)
                {
                    sdtnn = new SoanDeThiNgauNhien();
                    sdtnn.Show();
                }
                else if (denNHD == 2)
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
    }
}
