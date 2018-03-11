using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNTest
{
    public partial class UcRaDeThi : UserControl
    {
        public UcRaDeThi()
        {
            InitializeComponent();
        }

        private void btnRaDeThiTronTungCau_Click(object sender, EventArgs e)
        {
            new FormRaDeThi().Show();
            this.ParentForm.Hide();
        }

        private void btnRaDeThiTronTuFile_Click(object sender, EventArgs e)
        {
            new FormRaDeThi().Show();
            this.ParentForm.Hide();
        }
    }
}
