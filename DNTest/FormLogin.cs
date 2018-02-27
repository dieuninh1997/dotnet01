using DNTest.BUS;
using DNTest.Entity;
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
            string User = txtUser.Text.Trim();
            string Pass = txtPass.Text.Trim();
            Teacher obj = new Teacher();
            DataTable dt = new DataTable();
            dt = login.Get_LoginBUS(User, Pass);
            if (dt.Rows.Count == 1)
            {
                Properties.Settings.Default.Pass = Pass;
                Properties.Settings.Default.ID_User = dt.Rows[0]["id"].ToString();
                 obj.Id =dt.Rows[0]["id"].ToString();
                obj.Name = dt.Rows[0]["name"].ToString();
                obj.User = dt.Rows[0]["username"].ToString();
                obj.Password = dt.Rows[0]["password"].ToString();
                obj.Avatar = dt.Rows[0]["avatar"].ToString();
                Properties.Settings.Default.objTeacher = obj;
              this.Visible = false;
              FormHome frm = new FormHome();
                frm.ShowDialog();
                
                
            }
            else lbloi.Text = "Bạn nhập sai tên hoăc mật khẩu";
           // lbloi.Text = login.Get_LoginBUS(User, Pass).Rows[0]["id"].ToString(); ;
        }
    }
}
