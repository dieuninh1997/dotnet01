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
    public partial class FormTronDeThi : Form
    {
        public FormTronDeThi()
        {
            InitializeComponent();
        }


        private void FormTronDeThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormRaDeThi().Show();
        }

        private void FormTronDeThi_Load(object sender, EventArgs e)
        {

        }
    }
}
