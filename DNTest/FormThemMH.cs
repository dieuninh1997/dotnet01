using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNTest.BUS;
using DNTest.Entity;

namespace DNTest
{
    public partial class FormThemMH : Form
    {
        private SubjectBUS obj = new SubjectBUS();
        private FacultyBUS faculty = new FacultyBUS();
        public FormThemMH()
        {
            InitializeComponent();
        }
        private void BindDataFaculty(String t = "", String w = "", String o = "")
        {
            cmbFaculty.DataSource = faculty.Faculty_GetByTop(t, w, o);
            cmbFaculty.DisplayMember = "facultyName";
            cmbFaculty.ValueMember = "id";
        }
        private bool ValidField()
        {
            return txtTenMH.Text.Equals(String.Empty) ? true : false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Subject Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Subject subject = new Subject(txtTenMH.Text, cmbFaculty.SelectedValue.ToString());
          //  MessageBox.Show("Ten MH " + subject.SubjectName + " Ma khoa " + subject.FacultyID, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (obj.Subject_Insert(subject))
            {
                MessageBox.Show("Thêm môn học thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm môn học thất bại!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void FormThemMH_Load(object sender, EventArgs e)
        {
            BindDataFaculty("", "", "");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
