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
    public partial class FormSuaMH : Form
    {
        private SubjectBUS obj = new SubjectBUS();
        private FacultyBUS faculty = new FacultyBUS();
        private void BindDataFaculty(String t = "", String w = "", String o = "")
        {
            cmbFaculty.DataSource = faculty.Faculty_GetByTop(t, w, o);
            cmbFaculty.DisplayMember = "facultyName";
            cmbFaculty.ValueMember = "id";
            cmbFaculty.SelectedValue = Common.subject_facultyID; 
        }
        private bool ValidField()
        {
            return txtTenMH.Text.Equals(String.Empty) ? true : false;
        }

        public FormSuaMH()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Subject Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Subject subject = new Subject(Common.subjectID, txtTenMH.Text, cmbFaculty.SelectedValue.ToString());
          //  MessageBox.Show("Ten MH " + subject.SubjectName + " Ma khoa " + subject.FacultyID, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (obj.Subject_Update(subject))
            {
                MessageBox.Show("Sửa môn học thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa môn học thất bại!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormSuaMH_Load(object sender, EventArgs e)
        {
            BindDataFaculty("", "", "");
            txtTenMH.Focus();
            txtTenMH.Text = Common.subjectName;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
