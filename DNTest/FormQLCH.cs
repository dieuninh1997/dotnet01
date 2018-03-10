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
        // private List<Question> lstDsXuatCauHoi = new List<Question>();
        private SortedSet<Question> lstDsXuatCauHoi = new SortedSet<Question>();
        private static Question tmpAdd;
        private static Question tmpDel;
        private static int indexTmpDel = -1;


        public FormQLCH()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            BindDataDsXuatCauHoi();
            rtxtNoiDungCauHoi.Text = "";
            dgvDsXuatCauHoi.Enabled = false;
            ///  lstDsXuatCauHoi.Clear();
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
            Clear();
            if (cmbFaculty.SelectedValue.ToString() != "DNTest.Entity.Faculty")
            {
                BindDataSubject("", " facultyID = " + cmbFaculty.SelectedValue.ToString(), " ");
            }

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
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
            Clear();
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
            dgvDsXuatCauHoi.Enabled = true;
            int row = e.RowIndex;
            showItem(dgvDsCauHoi, row, ref tmpAdd);

        }

        private void showItem(DataGridView dgv, int row, ref Question tmp)
        {
            string question = "";
            if (row < 0) return;
            string _qid = dgv.Rows[row].Cells["id"].Value.ToString();
            string subjectId = dgv.Rows[row].Cells["subjectID"].Value.ToString();
            string topicId = dgv.Rows[row].Cells["topicID"].Value.ToString();
            string levelId = dgv.Rows[row].Cells["levelID"].Value.ToString();
            string typeId = dgv.Rows[row].Cells["typeID"].Value.ToString();
            string content = dgv.Rows[row].Cells["content"].Value.ToString();
            string createDate = dgv.Rows[row].Cells["createDate"].Value.ToString();

            tmp = new Question(_qid, topicId, subjectId, levelId, content, createDate, typeId);

            //    MessageBox.Show("tmp=" + tmp);

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

        private void showSimpleQuestionInRichTextBox(Question q)
        {
            string question = "";
            List<SubQuestion> lstSub = subQuestionBUS.SubQuestion_GetByTop("", " questionID = " + q.Id, "");

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
            if (tmpDel != null)
            {
              //  MessageBox.Show("size=" + lstDsXuatCauHoi.Count + "  tmpDel =" + tmpDel.Id);
                if (indexTmpDel >= 0)
                {
                    lstDsXuatCauHoi.Remove(tmpDel);
                    //lstDsXuatCauHoi.RemoveAt(indexTmpDel);
                  //  MessageBox.Show("del success size=" + lstDsXuatCauHoi.Count);
                    DataTable tb = new DataTable();
                    tb = Common.ConvertListToDataTable(lstDsXuatCauHoi);
                    dgvDsXuatCauHoi.DataSource = tb;
                }
            }
            lbSelectNum.Text = lstDsXuatCauHoi.Count + " Câu";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tmpAdd != null)
            {

                lstDsXuatCauHoi.Add(tmpAdd);
                DataTable tb = new DataTable();
                tb = Common.ConvertListToDataTable(lstDsXuatCauHoi);
                dgvDsXuatCauHoi.DataSource = tb;
            }
            lbSelectNum.Text = lstDsXuatCauHoi.Count + " Câu";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Question i in lst)
                lstDsXuatCauHoi.Add(i);
            MessageBox.Show("Size=" + lstDsXuatCauHoi.Count);
            if (lstDsXuatCauHoi.Count > 0)
            {
                DataTable tb = new DataTable();
                tb = Common.ConvertListToDataTable(lstDsXuatCauHoi);
                dgvDsXuatCauHoi.DataSource = tb;
                lbSelectNum.Text = lstDsXuatCauHoi.Count + " Câu";
            }
        }

        private void pcXoaHet_Click(object sender, EventArgs e)
        {
            lstDsXuatCauHoi.Clear();
        }

        private void dgvDsXuatCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            foreach (var item in lstDsXuatCauHoi)
            {
                if (item.Id.Equals(lstDsXuatCauHoi.ElementAt(row).Id))
                {
                    tmpDel = new Question(item.Id, item.TopicID, item.SubjectID, item.LevelID, item.Content, item.CreateDate, item.TypeID);
                    indexTmpDel = row;
                    showSimpleQuestionInRichTextBox(item);
                    break;
                }
            }
            // MessageBox.Show("size=" + lstDsXuatCauHoi.Count + " tmp=" + lstDsXuatCauHoi.ElementAt(row).Id);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //xuat ra file word
        }
    }
}
