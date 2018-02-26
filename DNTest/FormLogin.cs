using DNTest.BUS;
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
    public partial class FormLogin : Form
    {
        LoginBUS login = new LoginBUS();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            if(login.Get_LoginBUS(User, Pass) == 1)
            {
                this.Visible = false;
                FormHome frm = new FormHome();
                frm.ShowDialog();
            }
            else lbloi.Text = "Bạn nhập sai tên hoăc mật khẩu"; 
        }
    }
}
