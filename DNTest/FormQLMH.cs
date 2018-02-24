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
    public partial class FormQLMH : Form
    {
        private SubjectBUS subject = new SubjectBUS();
        private FacultyBUS faculty = new FacultyBUS();
        public FormQLMH()
        {
            InitializeComponent();
        }
     
        private void BindDataFaculty(String t = "", String w = "", String o = "")
        {
            dgvFaculty.DataSource = faculty.Faculty_GetByTop(t, w, o);
         
        }

        private void setDgvFaculty()
        {
            dgvFaculty.Columns[0].HeaderText = "Mã khoa";
            dgvFaculty.Columns[0].Visible = false;
            dgvFaculty.Columns[1].HeaderText = "Tên khoa";
            dgvFaculty.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setDgvSubject()
        {
            dgvSubject.Columns[0].HeaderText = "Mã môn học";
            dgvSubject.Columns[0].DataPropertyName = "id";
            dgvSubject.Columns[1].HeaderText = "Tên môn học";
            dgvSubject.Columns[1].DataPropertyName = "subjectName";
            dgvSubject.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubject.Columns[2].HeaderText = "Mã khoa";
            dgvSubject.Columns[0].DataPropertyName = "facultyID";
            dgvSubject.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // dgvSubject.Columns[2].Visible = false;
        }
        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            dgvSubject.DataSource = subject.Subject_GetByTop(t, w, o);
        }

        private void FormQLMH_Load(object sender, EventArgs e)
        {
           
            BindDataSubject("", "", "");
            BindDataFaculty("", "", "");
            setDgvFaculty();
           // setDgvSubject();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormThemMH().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FormSuaMH().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa môn học "+Common.subjectName+"?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                int row = dgvSubject.CurrentRow.Index;
              //  SubjectBUS obj = new SubjectBUS();
                MessageBox.Show(dgvSubject.Rows[row].Cells["id"].Value.ToString(), "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (subject.Subject_Delete(dgvSubject.Rows[row].Cells["id"].Value.ToString()))
                {
                    count++;
                    BindDataSubject("", "", "");
                    MessageBox.Show("Xóa thành công " + count + " môn học.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Xóa môn học thất bại", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvFaculty.CurrentRow.Index;
             //   MessageBox.Show("row", dgvFaculty.Rows[row].Cells[0].Value.ToString()+" " + dgvFaculty.Rows[row].Cells[1].Value.ToString());
                BindDataSubject("", " facultyID = "+dgvFaculty.Rows[row].Cells[0].Value.ToString(), "");
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ckbHienThiTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiTatCa.Checked)
            {
                BindDataSubject("", "", "");
                gbKhoa.Enabled = false;
            }
            else
            {
                gbKhoa.Enabled = true;
                int row = dgvFaculty.CurrentRow.Index;
                BindDataSubject("", " facultyID = " + dgvFaculty.Rows[row].Cells[0].Value.ToString(), "");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindDataSubject("", "", "");
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvSubject.CurrentRow.Index;
               Common.subjectID = dgvSubject.Rows[row].Cells[1].Value.ToString();
               Common.subjectName = dgvSubject.Rows[row].Cells[2].Value.ToString();
                Common.subject_facultyID = dgvSubject.Rows[row].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormQLMH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormHome().Show();
        }
    }
}
