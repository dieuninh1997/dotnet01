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
    public partial class FormQLCH : Form
    {
        FacultyBUS faculty = new FacultyBUS();
        SubjectBUS subject = new SubjectBUS();
        TopicBUS topic = new TopicBUS();

        public FormQLCH()
        {
            InitializeComponent();
        }

        private void BindDataFaculty(String t = "", String w = "", String o = "")
        {
            cmbFaculty.DataSource = faculty.Faculty_GetByTop(t, w, o);
            cmbFaculty.DisplayMember = "facultyName";
            cmbFaculty.ValueMember = "id";
            cmbFaculty.SelectedIndex = 0;
        }
        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            cmbSubject.DataSource = subject.Subject_GetByTop(t, w, o);
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "id";
            cmbSubject.SelectedIndex = 0;
        }
        private void BindDataTopic(String t = "", String w = "", String o = "")
        {
            cmbTopic.DataSource = topic.Topic_GetByTop(t, w, o);
            cmbTopic.DisplayMember = "topicName";
            cmbTopic.ValueMember = "id";
            cmbTopic.SelectedIndex = 0;
        }

        private void BindDataQuestion(String t = "", String w = "", String o = "")
        {
           //dgvDsCauHoi.DataSource
        }

        private void FormQLCH_Load(object sender, EventArgs e)
        {
            cmbFaculty.DataSource = null;
            cmbSubject.DataSource = null;
            cmbTopic.DataSource = null;

            BindDataFaculty();
            BindDataSubject();
            BindDataTopic();
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFaculty.SelectedValue.ToString() != "DNTest.Entity.Faculty")
            {
                BindDataSubject("", " facultyID = " + cmbFaculty.SelectedValue.ToString(), " ");
            }
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue.ToString() != "DNTest.Entity.Subject")
            {
                BindDataTopic("", " subjectID = " + cmbSubject.SelectedValue.ToString(), " ");
            }
        }
    }
}
