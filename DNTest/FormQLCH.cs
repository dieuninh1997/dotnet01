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
        QuestionBUS question = new QuestionBUS();
        static int level = 0;
        static int type = 0;

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
            var lst = question.Question_GetByTop(t, w, o);
            dgvDsCauHoi.DataSource = lst;
            txtSoLuong.Text = lst.Count.ToString();
                
        }

        private void FormQLCH_Load(object sender, EventArgs e)
        {
            cmbFaculty.DataSource = null;
            cmbSubject.DataSource = null;
            cmbTopic.DataSource = null;

            BindDataFaculty();
            BindDataSubject();
            BindDataTopic();
            //  BindDataQuestion(); => load all

            //load base cmbTopic
            if (cmbTopic.SelectedValue.ToString() != "DNTest.Entity.Topic")
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");

            rbAllLevel.Checked = true;
            rbAllType.Checked = true;

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

        private void ckbHienThiTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienThiTatCa.Checked)
            {
                BindDataQuestion();
            }else
            {
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");
            }
        }

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTopic.SelectedValue.ToString() != "DNTest.Entity.Topic")
            BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");
        }

        private void rbDe_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDe.Checked)
            {
                level = 1;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() +" and levelID = "+level, "");
            }
        }

        private void rbTrungBinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrungBinh.Checked)
            {
                level = 2;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = "+level, "");
            }
        }

        private void rbKho_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKho.Checked)
            {
                level = 3;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = "+level, "");
            }
        }

        private void rbAllLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllLevel.Checked)
            {
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");
                level = 0;    
            }
        }

        private void rbAllType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllLevel.Checked)
            {
                type = 0;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");
            }
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKho.Checked)
            {
                type = 1;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = "+level +" and typeID = "+type, "");
            }
        }

        private void rbMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMultiple.Checked)
            {
                type = 2;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = " + level + " and typeID = " + type, "");
            }
        }

        private void FormQLCH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormHome().Show();
        }
    }
}
