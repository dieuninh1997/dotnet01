using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNTest.Entity;
using DNTest.BUS;

namespace DNTest
{
    public partial class FormRaDeThi : Form
    {

        FacultyBUS facultyBUS = new FacultyBUS();
        SubjectBUS subjectBUS = new SubjectBUS();
        TopicBUS topicBUS = new TopicBUS();
        QuestionBUS questionBUS = new QuestionBUS();
        AnswerBUS answerBUS = new AnswerBUS();
        SubQuestionBUS subQuestionBUS = new SubQuestionBUS();

        private List<Question> lstQues = new List<Question>();
        private SortedSet<Question> lstDsCauHoiDaChon = new SortedSet<Question>();
        private static Question tmpAdd;
        private static Question tmpDel;
        private static Question tmp;
        private static int indexTmpDel = -1;
        private static int indexDgvCH = -1;
        private static int indexDgvCHP = -1;



        public FormRaDeThi()
        {
            InitializeComponent();
        }

        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            //TODO: tại bảng vẫn hiện đủ các cột => mong muốn chỉ hiện cột id, content
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
        private void BindDataFaculty(String t = "", String w = "", String o = "")
        {
            List<Faculty> lst = new FacultyBUS().Faculty_GetByTop(t, w, o);
            lst.Insert(0, new Faculty("0", "Select an option"));
            cmbFaculty.DataSource = lst;
            cmbFaculty.DisplayMember = "facultyName";
            cmbFaculty.ValueMember = "id";
            cmbFaculty.SelectedIndex = 0;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            foreach (Question i in lstDsCauHoiDaChon)
            {
                Common.lstDsCauHoiDaChon.Add(i);
            }
            this.Hide();
            new FormTronDeThi().Show();
        }

        private void FormRaDeThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormHome().Show();
        }

        private void FormRaDeThi_Load(object sender, EventArgs e)
        {
            cmbFaculty.DataSource = null;
            cmbSubject.DataSource = null;
            cmbTopic.DataSource = null;

            BindDataFaculty();
            BindDataSubject();
            BindDataTopic();

            rbNone.Checked = true;
        }

        private void BindDataDsXuatCauHoi()
        {
            var source = new BindingSource();
            source.DataSource = lstDsCauHoiDaChon;
            dgvDsCauHoi.DataSource = source;
            lbSelectNum.Text = lstDsCauHoiDaChon.Count.ToString();

        }
        private void Clear()
        {
            BindDataDsXuatCauHoi();
            rtxtNoiDungCauHoi.Text = "";
            dgvDsCauHoiDaChon.Enabled = false;
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

        private void BindDataSubQuestion(String t = "", String w = "", String o = "")
        {
            var lstSubQues= subQuestionBUS.SubQuestion_GetByTop(t, w, o);
            dgvDsCauHoiPhu.DataSource = lstSubQues;
            lbSoCauHoiPhu.Text = lstSubQues.Count.ToString()+" Cau";

            dgvDsCauHoiPhu.Columns["id"].HeaderText = "Mã câu hỏi";
            dgvDsCauHoiPhu.Columns["id"].Visible = true;

            dgvDsCauHoiPhu.Columns["questionID"].HeaderText = "Mã câu hỏi";
            dgvDsCauHoiPhu.Columns["questionID"].Visible = true;

            dgvDsCauHoiPhu.Columns["content"].HeaderText = "Nội dung";
            dgvDsCauHoiPhu.Columns["content"].Visible = true;

        }



        private void BindDataQuestion(String t = "", String w = "", String o = "")
        {
            lstQues = questionBUS.Question_GetByTop(t, w, o);
            dgvDsCauHoi.DataSource = lstQues;
            txtSoLuong.Text = lstQues.Count.ToString();

            dgvDsCauHoi.Columns["id"].HeaderText = "Mã câu hỏi";
            dgvDsCauHoi.Columns["id"].Visible=true;

            dgvDsCauHoi.Columns["typeID"].HeaderText = "Dạng câu hỏi";
            dgvDsCauHoi.Columns["typeID"].Visible = false;

            dgvDsCauHoi.Columns["subjectID"].HeaderText = "Mã môn học";
            dgvDsCauHoi.Columns["subjectID"].Visible = false;

            dgvDsCauHoi.Columns["topicID"].HeaderText = "Mã chuyên để";
            dgvDsCauHoi.Columns["topicID"].Visible = false;

            dgvDsCauHoi.Columns["levelID"].HeaderText = "Mã mức độ";
            dgvDsCauHoi.Columns["levelID"].Visible = false;

            dgvDsCauHoi.Columns["content"].HeaderText = "Nội dung";
            dgvDsCauHoi.Columns["content"].Visible = true;

            dgvDsCauHoi.Columns["createDate"].HeaderText = "Ngày tạo";
            dgvDsCauHoi.Columns["createDate"].Visible = false;





        }

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            if (cmbTopic.SelectedValue.ToString() != "DNTest.Entity.Topic")
                BindDataQuestion("", " topicID = " + cmbTopic.SelectedValue.ToString(), "");

        }
        private void showItem(DataGridView dgv, int row)
        {
            string sub_question = "";
            if (row < 0) return;
            string _qid = dgv.Rows[row].Cells["id"].Value.ToString();
            string questionId = dgv.Rows[row].Cells["questionID"].Value.ToString();
            string content = dgv.Rows[row].Cells["content"].Value.ToString();

      //      tmp = new SubQuestion(_qid, topicId, subjectId, levelId, content, createDate, typeId);

        
            List<SubQuestion> lstSub = subQuestionBUS.SubQuestion_GetByTop("", " id = " + _qid, "");

            foreach (SubQuestion sq in lstSub)
            {
                sub_question += "Question: " + sq.Content + "\r\n";
                List<Answer> lst = answerBUS.Answer_GetByTop("", " subQuestionID = " + sq.Id, "");
                for (int i = 0; i < lst.Count; i++)
                {
                    Answer ans = lst.ElementAt(i);
                    if (bool.Parse(ans.IsCorrect))
                    {
                        sub_question += "    " + (char)(65 + i) + ". " + ans.Answers + " *\r\n";
                    }
                    else
                    {
                        sub_question += "    " + (char)(65 + i) + ". " + ans.Answers + "\r\n";

                    }
                }
                sub_question += "\r\n";
            }
            rtxtNoiDungCauHoi.Text = sub_question;

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

        private void dgvDsCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDsCauHoiDaChon.Enabled = true;
            rtxtNoiDungCauHoi.Enabled = true;
            int row = e.RowIndex;
            indexDgvCH = row;
            BindDataSubQuestion("", " questionID=" + dgvDsCauHoi.Rows[row].Cells["id"].Value.ToString(), "");
            showItem(dgvDsCauHoi, row, ref tmpAdd);

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
            rtxtNoiDungCauHoi.Text += question;
        }

        private void ckbXemDsXuat_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbXemDsXuat.Checked)
            {
                rtxtNoiDungCauHoi.Text = "";
                foreach (var item in lstDsCauHoiDaChon)
                {
                    showSimpleQuestionInRichTextBox(item);
                }

            }
            else
            {
                rtxtNoiDungCauHoi.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (indexDgvCH == -1)
            {
                MessageBox.Show("Bạn đã chưa chọn câu hỏi trong danh sách!");
                return;
            }
            else
            {
                if (tmpAdd != null)
                {

                    bool rs = lstDsCauHoiDaChon.Add(tmpAdd);
                    if (!rs)
                    {
                        MessageBox.Show("Câu hỏi này đã được thêm vào danh sách xuất!");
                        return;
                    }
                    DataTable tb = new DataTable();
                    tb = Common.ConverSortedtListToDataTable(lstDsCauHoiDaChon);
                    dgvDsCauHoiDaChon.DataSource = tb;
                }
                lbSelectNum.Text = lstDsCauHoiDaChon.Count + " Câu";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (indexTmpDel == -1)
            {
                MessageBox.Show("Bạn đã chưa chọn câu hỏi trong danh sách!");
                return;
            }
            else
            {
                if (tmpDel != null)
                {
                    if (indexTmpDel >= 0)
                    {
                        lstDsCauHoiDaChon.Remove(tmpDel);
                        DataTable tb = new DataTable();
                        tb = Common.ConverSortedtListToDataTable(lstDsCauHoiDaChon);
                        dgvDsCauHoiDaChon.DataSource = tb;
                    }
                }
                lbSelectNum.Text = lstDsCauHoiDaChon.Count + " Câu";

            }
        }

        private void dgvDsCauHoiDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            showItem(dgvDsCauHoi, row, ref tmpAdd);
           foreach (var item in lstDsCauHoiDaChon)
            {
                if (item.Id.Equals(lstDsCauHoiDaChon.ElementAt(row).Id))
                {
                    tmpDel = new Question(item.Id, item.TopicID, item.SubjectID, item.LevelID, item.Content, item.CreateDate, item.TypeID);
                    indexTmpDel = row;
                    break;
                }
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            lstDsCauHoiDaChon.Clear();
            DataTable tb = new DataTable();
            tb = Common.ConverSortedtListToDataTable(lstDsCauHoiDaChon);
            dgvDsCauHoiDaChon.DataSource = tb;
            lbSelectNum.Text = lstDsCauHoiDaChon.Count + " Câu";
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNone.Checked)
                Common.permuteStyle = "0";
            else
                Common.permuteStyle = "-1";
        }

        private void rbHoanViAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHoanViAll.Checked)
                Common.permuteStyle = "1";
            else
                Common.permuteStyle = "-1";
        }

        private void dgvDsCauHoiPhu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            indexDgvCHP = row;
            showItem(dgvDsCauHoiPhu, row);

        }
    }
}
