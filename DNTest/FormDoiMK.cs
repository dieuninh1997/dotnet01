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
    public partial class FormDoiMK : Form
    {
        TeacherBUS objBUS = new TeacherBUS();
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PassWord = txtMatKhauCu.Text;
            string MatKhauMoi = txtMatKhauMoi.Text;
            string MatKhauMoi2 = txtMatKhauMoi2.Text;
            if (string.IsNullOrEmpty(PassWord))
            {
                lbLoi.Text = "Bạn chưa nhập mật khẩu cũ";
            }
            if (string.IsNullOrEmpty(MatKhauMoi))
            {
                lbLoi.Text = "Bạn chưa nhập mật khẩu mới";
            }
            if (string.IsNullOrEmpty(MatKhauMoi2))
            {
                lbLoi.Text = "Giá trị không được để trống";
            }
            if (PassWord.Contains(Properties.Settings.Default.Pass))
            {
                if (MatKhauMoi.Contains(MatKhauMoi2))
                {
                    Teacher obj = new Teacher();
                    obj.Id = Properties.Settings.Default.objTeacher.Id;
                    obj.Name = Properties.Settings.Default.objTeacher.Name;
                    obj.User = Properties.Settings.Default.objTeacher.User;
                    obj.Password = MatKhauMoi;
                    obj.Avatar = Properties.Settings.Default.objTeacher.Avatar;
                    objBUS.Update_Password(obj);
                    lbLoi.Text = "Cập nhật thành công";
                    lbLoi.ForeColor = Color.Green;
                    txtMatKhauCu.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtMatKhauMoi2.Text = "";
                }
            }
            else
            {
                lbLoi.Text = "Bạn nhập sai mật khẩu";
            }
        }
    }
}
