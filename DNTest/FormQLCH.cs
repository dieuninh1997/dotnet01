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
        FacultyBUS facultyBUS = new FacultyBUS();
        SubjectBUS subjectBUS = new SubjectBUS();
        TopicBUS topicBUS = new TopicBUS();
        QuestionBUS questionBUS = new QuestionBUS();
        AnswerBUS answerBUS = new AnswerBUS();
        SubQuestionBUS subQuestionBUS = new SubQuestionBUS();


        static int level = 0;
        static int type = 0;
        private List<Question> lst = new List<Question>();
        private List<Question> lstDsXuatCauHoi = new List<Question>();

        private static Question tmp ;


        public FormQLCH()
        {
            InitializeComponent();
        }

        private void BindDataFaculty(String t = "", String w = "", String o = "")
        {
            List<Faculty> lst = new FacultyBUS().Faculty_GetByTop(t, w, o);
            lst.Insert(0, new Faculty("0", "Select an option"));
            cmbFaculty.DataSource = lst;
            cmbFaculty.DisplayMember = "facultyName";
            cmbFaculty.ValueMember = "id";
            cmbFaculty.SelectedIndex = 0;
        }
        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            List<Subject> lst = new SubjectBUS().Subject_GetByTop(t, w, o);
            lst.Insert(0, new Subject("0", "Select an option"));
            cmbSubject.DataSource = lst;
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "id";
            cmbSubject.SelectedIndex = 0;
        }
        private void BindDataTopic(String t = "", String w = "", String o = "")
        {
            List<Topic> lst = new TopicBUS().Topic_GetByTop(t, w, o);
            lst.Insert(0, new Topic("0", "Select an option"));
            cmbTopic.DataSource = lst;
            cmbTopic.DisplayMember = "topicName";
            cmbTopic.ValueMember = "id";
            cmbTopic.SelectedIndex = 0;
        }

        private void BindDataQuestion(String t = "", String w = "", String o = "")
        {
            lst = questionBUS.Question_GetByTop(t, w, o);
            dgvDsCauHoi.DataSource = lst;
            txtSoLuong.Text = lst.Count.ToString();

        }

        private void BindDataDsXuatCauHoi()
        {
            var source = new BindingSource();
            source.DataSource = lstDsXuatCauHoi;
            dgvDsCauHoi.DataSource = source;
            lbSelectNum.Text = lstDsXuatCauHoi.Count.ToString();

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
            txtSoLuong.Text = lst.Count.ToString();

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaculty.SelectedValue.ToString() != "DNTest.Entity.Faculty")
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
            if (ckbHienThiTatCa.Checked)
            {
                BindDataQuestion();
            }
            else
            {
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");
            }
        }

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTopic.SelectedValue.ToString() != "DNTest.Entity.Topic")
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");
        }

        private void rbDe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDe.Checked)
            {
                level = 1;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = " + level, "");
            }
        }

        private void rbTrungBinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrungBinh.Checked)
            {
                level = 2;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = " + level, "");
            }
        }

        private void rbKho_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKho.Checked)
            {
                level = 3;
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = " + level, "");
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
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString() + " and levelID = " + level + " and typeID = " + type, "");
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

        private void dgvDsCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string question = "";
            int row = e.RowIndex;
            if (row < 0) return;
            string _qid = dgvDsCauHoi.Rows[row].Cells["id"].Value.ToString();
            string subjectId= dgvDsCauHoi.Rows[row].Cells["subjectID"].Value.ToString();
            string topicId= dgvDsCauHoi.Rows[row].Cells["topicID"].Value.ToString();
            string levelId= dgvDsCauHoi.Rows[row].Cells["levelID"].Value.ToString();
            string typeId = dgvDsCauHoi.Rows[row].Cells["typeID"].Value.ToString();
            string content= dgvDsCauHoi.Rows[row].Cells["content"].Value.ToString();
            string createDate= dgvDsCauHoi.Rows[row].Cells["createDate"].Value.ToString();

            // tmp = new Question(_qid, topicId, subjectId, levelId, content, createDate, typeId);
           
            MessageBox.Show("tmp=" + tmp);

            //List<Answer> lstAns = new List<Answer>();
            if (content != "")
            {
                if (typeId == "2")
                {
                    question += content + "\r\n";
                    rbMultiple.Checked = true;
                }
                else if (typeId == "1")
                {
                    rbSingle.Checked = true;
                }
                else
                {
                    rbAllType.Checked = true;
                }
            }

            if (levelId == "0")
            {
                rbAllLevel.Checked = true;
            }
            else if (levelId == "1")
            {
                rbDe.Checked = true;
            }
            else if (levelId == "2")
            {
                rbTrungBinh.Checked = true;
            }
            else
            {
                rbKho.Checked = true;
            }

            if (content != "" && typeId == "2")
            {
                question += content + "\r\n";
            }


            List<SubQuestion> lstSub = subQuestionBUS.SubQuestion_GetByTop("", " questionID = " + _qid, "");

            foreach (SubQuestion sq in lstSub)
            {
                question += "Question: " + sq.Content + "\r\n";
                List<Answer> lst = answerBUS.Answer_GetByTop("", " subQuestionID = " + sq.Id, "");
                for (int i = 0; i < lst.Count; i++)
                {
                    Answer ans = lst.ElementAt(i);
                    //  lstAns.Add(ans);
                    if (bool.Parse(ans.IsCorrect))
                    {
                        question += "    " + (char)(65 + i) + ". " + ans.Answers + " *\r\n";
                    }
                    else
                    {
                        question += "    " + (char)(65 + i) + ". " + ans.Answers + "\r\n";

                    }
                }
                question += "\r\n";
            }
            rtxtNoiDungCauHoi.Text = question;

        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            FormCNCH f = new FormCNCH();
            f.ControlBox = false;
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormCNCH f = new FormCNCH();
            f.Text = "Sửa câu hỏi";
            f.ControlBox = false;
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDsXuatCauHoi.Count > 0)
            {
                lstDsXuatCauHoi.Remove(tmp);
                BindDataDsXuatCauHoi();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*if (tmp != null)
            {
              
                lstDsXuatCauHoi.Add(tmp);
                MessageBox.Show("Size=" + lstDsXuatCauHoi.Count+" tmp="+tmp.ToString());
                BindDataDsXuatCauHoi();
            }*/



        }

        private DataGridView copy(DataGridView dgv1,DataGridView dgv2)
        {
            try
            {
               if( dgv2.Columns.Count ==0)
                {
                    foreach(DataGridViewColumn c in dgv1.Columns)
                    {
                        dgv2.Columns.Add(c.Clone() as DataGridViewColumn);
                    }
                }
                DataGridViewRow r = new DataGridViewRow();
                for(int i=0; i<dgv1.Rows.Count; i++)
                {
                    r = (DataGridViewRow) dgv1.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach(DataGridViewCell cell in dgv1.Rows[i].Cells)
                    {
                        r.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv2.Rows.Add(r);

                }
                dgv2.AllowUserToAddRows = false;
                dgv2.Refresh();
            }
            catch (Exception ex)
            {
                
            }
            return dgv2;
        }


        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Question i in lst)
                lstDsXuatCauHoi.Add(i);
            MessageBox.Show("Size=" + lstDsXuatCauHoi.Count);
            if (lstDsXuatCauHoi.Count > 0)
            {

                BindDataDsXuatCauHoi();
            }
        }

        private void pcXoaHet_Click(object sender, EventArgs e)
        {
            lstDsXuatCauHoi.Clear();
        }
    }
}
