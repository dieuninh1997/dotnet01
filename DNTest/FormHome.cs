using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNTest
{
    public partial class FormHome : Form
    {
        UcCapNhatCauHoi ucCapNhatCauHoi = new UcCapNhatCauHoi();
        UcQuanLyDuLieu ucQLDL = new UcQuanLyDuLieu();
        UcRaDeThi ucRaDeThi = new UcRaDeThi();

        public FormHome()
        {
            InitializeComponent();
            pnContainer.Controls.Add(ucCapNhatCauHoi);
            pnContainer.Controls.Add(ucQLDL);
            pnContainer.Controls.Add(ucRaDeThi);

        }

        private void btnThongTinPM_Click(object sender, EventArgs e)
        {
            new FormInfo().ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new FormHelp().Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormDoiMK().ShowDialog();
        }

        private void tabRaDeThi_Click(object sender, EventArgs e)
        {
            ucRaDeThi.BringToFront();
        }

        private void tabQLDL_Click(object sender, EventArgs e)
        {
            ucQLDL.BringToFront();
        }

        private void tabCNCH_Click(object sender, EventArgs e)
        {
            ucCapNhatCauHoi.BringToFront();
        }
    }
}
