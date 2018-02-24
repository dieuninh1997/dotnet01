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
    public partial class UcQuanLyDuLieu : UserControl
    {
        public UcQuanLyDuLieu()
        {
            InitializeComponent();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            new FormQLMH().Show();
            this.ParentForm.Hide();
        }

        private void btnQLCD_Click(object sender, EventArgs e)
        {
            new FormQLCD().Show();
            this.ParentForm.Hide();
        }

        private void btnQLCH_Click(object sender, EventArgs e)
        {
            new FormQLCH().Show();
            this.ParentForm.Hide();
        }
    }
}
