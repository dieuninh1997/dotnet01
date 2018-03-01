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
using System.Text.RegularExpressions;

namespace DNTest
{
    public partial class FormCNCH : Form
    {
        private QuestionBUS questionBUS = new QuestionBUS();
        private SubQuestionBUS subQuestionBUS = new SubQuestionBUS();
        private AnswerBUS answerBUS = new AnswerBUS();

        private List<SimpleQuestion> lstSimple = new List<SimpleQuestion>();
        private List<MultiQuestion> lstMulti = new List<MultiQuestion>();

        public FormCNCH()
        {
            InitializeComponent();
        }

        private void FormCNCH_Load(object sender, EventArgs e)
        {
            rtxtFileNoiDung.Text = "";
            BindCmbFileTopic();
            BindCmbFileSubject();
            BindCmbFileFaculty();
            rbFileAll.Checked = true;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlOpen = new OpenFileDialog();
            fdlOpen.InitialDirectory = "/";
            fdlOpen.Title = "Select file";
            fdlOpen.CheckFileExists = true;
            fdlOpen.CheckPathExists = true;
            fdlOpen.Filter = "Word document(*.doc/*.docx)|*.doc*";
            fdlOpen.RestoreDirectory = true;
            fdlOpen.ReadOnlyChecked = true;
            if (fdlOpen.ShowDialog() == DialogResult.OK)
            {
                GetData(fdlOpen.FileName);
            }
        }

        private void BindCmbFileSubject(string t="", string w="", string o="")
        {

            List<Subject> lst = new SubjectBUS().Subject_GetByTop(t, w, o);
            lst.Insert(0, new Subject("0", "Select an option"));
            cmbFileSubject.DataSource = lst;
            cmbFileSubject.DisplayMember = "subjectName";
            cmbFileSubject.ValueMember = "Id";
            cmbFileSubject.SelectedIndex = 0;

        }
        private void BindCmbFileFaculty(string t = "", string w = "", string o = "")
        {

            List<Faculty> lst = new FacultyBUS().Faculty_GetByTop(t, w, o);
            lst.Insert(0, new Faculty("0", "Select an option"));
            cmbFileFaculty.DataSource = lst;
            cmbFileFaculty.DisplayMember = "facultyName";
            cmbFileFaculty.ValueMember = "Id";
            cmbFileFaculty.SelectedIndex = 0;

        }

        private void BindCmbFileTopic(string t = "", string w = "", string o = "")
        {

            List<Topic> lst = new TopicBUS().Topic_GetByTop(t, w, o);
            lst.Insert(0, new Topic("0", "Select an option"));
            cmbFileTopic.DataSource = lst;
            cmbFileTopic.DisplayMember = "topicName";
            cmbFileTopic.ValueMember = "Id";
            cmbFileTopic.SelectedIndex = 0;

        }

        private void GetData(object path)
        {
            //numOfAnswer++            
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            SimpleQuestion qItem = null;
            // Define an object to pass to the API for missing parameters
            object miss = System.Reflection.Missing.Value;
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs =
                word.Documents.Open(ref path, ref miss, ref readOnly,
                ref miss, ref miss, ref miss, ref miss, ref miss, ref miss,
                ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);

            int flag = 0;
            for (int i = 1; i <= docs.Paragraphs.Count; i++)
            {
                string temp = docs.Paragraphs[i].Range.Text.Trim();
                if (temp.Trim().ToLower().Equals("<multi>"))// multi question
                {
                    MultiQuestion qMul = new MultiQuestion();
                    do
                    {
                        temp = docs.Paragraphs[++i].Range.Text;
                        if (temp.Trim() == "") break;
                        qMul.content += temp + "\r\n";
                    } while (temp != string.Empty);

                    if (temp.Trim() != "")
                    {
                        MessageBox.Show("Lỗi cú pháp tại \"" + qMul.content + "\"...");
                        lstSimple.Clear();
                        lstMulti.Clear();
                        return;
                    }

                    while (!temp.Trim().ToLower().Equals("</multi>"))
                    {
                        temp = docs.Paragraphs[++i].Range.Text.Trim();
                        if (temp != "")
                        {
                            qItem = new SimpleQuestion();
                            qItem.question = temp;
                            qItem.correctAnswer = -1;
                            List<string> answer = new List<string>();
                            do
                            {
                                temp = docs.Paragraphs[++i].Range.Text.Trim();
                                if (temp == string.Empty || temp.ToLower().Equals("</multi>")) break;
                                temp = Regex.Replace(temp, "[a-z1-4](\\.|\\))[ \t]+", "", RegexOptions.IgnoreCase);
                                if (temp.EndsWith("*"))
                                {
                                    qItem.correctAnswer = answer.Count;
                                    temp = temp.Substring(0, temp.Length - 1).Trim();
                                    answer.Add(temp);
                                }
                                else
                                {
                                    answer.Add(temp);
                                }
                            } while (temp != string.Empty);

                            qItem.answer = answer;

                            if (qItem.correctAnswer != -1)
                                qMul.lstQuestion.Add(qItem);
                            else
                            {
                                MessageBox.Show("Câu hỏi \"" + qItem.question + "\" không có câu trả lời đúng");
                                lstSimple.Clear();
                                lstMulti.Clear();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi cú pháp tại " + qMul.content + "\"...");
                            lstSimple.Clear();
                            lstMulti.Clear();
                            return;
                        }
                    }

                    lstMulti.Add(qMul);

                    //hiển thị list câu hỏi lên rtxtFileNoiDung
                    string question = "";
                    question += qMul.content;
                    question += "\n================================================" + "\r\n";
                    foreach (SimpleQuestion sq in qMul.lstQuestion)
                    {
                        question += sq.question + "\r\n";
                        for (int idx = 0; idx < sq.answer.Count; ++idx)
                        {
                            question += (char)(65 + idx) + ". " + sq.answer.ElementAt(idx) + "\r\n";
                        }
                        question += "=> Correct: " + (char)(65 + sq.correctAnswer) + "\r\n\r\n\n";
                    }
                    rtxtFileNoiDung.Text += question;

                    //Ignore blank paragraph
                    i++;
                }
                else if (temp != string.Empty) //simple question
                {
                    if (flag % 2 == 0)
                    {
                        //remove question number like Câu 1, Câu 2,...
                        temp = Regex.Replace(temp, "^[0-9]+\\.[ ]*|^Câu [0-9]+:[ ]*|^Question [0-9]+:[ ]*", "", RegexOptions.IgnoreCase);
                        qItem = new SimpleQuestion();
                        qItem.question = temp;
                    }
                    else
                    {
                        List<string> answer = new List<string>();
                        qItem.correctAnswer = -1;
                        while (temp != string.Empty)
                        {
                            //remove answer key, like A,B,C,D
                            temp = Regex.Replace(temp, "[a-z1-4](\\.|\\))[ \t]+", "", RegexOptions.IgnoreCase);
                            if (temp.EndsWith("*"))
                            {
                                qItem.correctAnswer = answer.Count;
                                temp = temp.Substring(0, temp.Length - 1).Trim();
                                answer.Add(temp);
                            }
                            else
                            {
                                answer.Add(temp);
                            }
                            temp = docs.Paragraphs[++i].Range.Text.Trim();
                        }

                        qItem.answer = answer;

                        if (qItem.correctAnswer != -1)
                        {
                            lstSimple.Add(qItem);

                            //hiển thị lstSimple lên txtFileNoiDung
                            string question = "Question: ";
                            question += qItem.question + "\r\n";
                            for (int idx = 0; idx < qItem.answer.Count; ++idx)
                            {
                                question += (char)(65 + idx) + ". " + qItem.answer.ElementAt(idx) + "\r\n";
                            }
                            question += "=> Correct: " + (char)(65 + qItem.correctAnswer) + "\r\n\n";
                            rtxtFileNoiDung.Text += question;
                        }
                        else
                        {
                            MessageBox.Show("Câu hỏi \"" + qItem.question + "\" không có câu trả lời đúng");
                            lstSimple.Clear();
                            lstMulti.Clear();
                            return;
                        }
                    }
                    flag++;
                }
                else
                {
                    MessageBox.Show("Lỗi cú pháp tại " + lstSimple.ElementAt(lstSimple.Count - 1).question);
                    lstSimple.Clear(); lstMulti.Clear();
                    return;
                }
            }
            docs.Close();
            word.Quit();
           // BindSimpleQuestion(lstSimple);
            //BindMultiQuestion(lstMulti);
        }

        private void FormCNCH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormHome() .Show();
        }

        private void btnFileUpdate_Click(object sender, EventArgs e)
        {
            if (cmbFileSubject.SelectedIndex < 1)
            {
                MessageBox.Show("Bạn chưa chọn môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbFileTopic.SelectedIndex < 1)
            {
                MessageBox.Show("Bạn chưa chọn chuyên đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int success = 0, questionId = -1, subQuestionId = -1;
            foreach (SimpleQuestion sq in lstSimple)
            {
                if ((questionId = questionBUS.Question_Insert(new Question(null, cmbFileTopic.SelectedValue.ToString(), cmbFileSubject.SelectedValue.ToString(),null , null, null))) > 0)
                {
                    if ((subQuestionId = subQuestionBUS.SubQuestion_Insert(new SubQuestion(null, questionId.ToString(), sq.question, "true"))) > 0)
                    {
                        int count = 0;
                        for (int i = 0; i < sq.answer.Count; i++)
                        {
                            if (sq.correctAnswer == i)
                            {
                                if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "true")))
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "false")))
                                {
                                    count++;
                                }
                            }
                        }
                        if (count == sq.answer.Count) success++;
                    }
                }
            }
            foreach (MultiQuestion mq in lstMulti)
            {
                if ((questionId = questionBUS.Question_Insert(new Question(null, cmbFileTopic.SelectedValue.ToString(), cmbFileSubject.SelectedValue.ToString(), null, mq.content, null))) > 0)
                {
                    foreach (SimpleQuestion sq in mq.lstQuestion)
                    {
                        int count = sq.answer.Count;
                        if ((subQuestionId = subQuestionBUS.SubQuestion_Insert(new SubQuestion(null, questionId.ToString(), sq.question, "true"))) > 0)
                        {
                            for (int i = 0; i < sq.answer.Count; ++i)
                            {
                                if (sq.correctAnswer == i)
                                {
                                    if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "true"))) count--;

                                }
                                else
                                {
                                    if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "false"))) count--;
                                }
                            }
                        }
                        if (count != 0) MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật");
                    }
                }
                success++;
            }
            if (MessageBox.Show("Cập nhật thành công " + success + "/" + (lstSimple.Count + lstMulti.Count) + " câu hỏi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbFileFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFileFaculty.SelectedIndex > 0)
                BindCmbFileSubject("", "facultyID = " + cmbFileFaculty.SelectedValue.ToString(), "");
        }

        private void cmbFileSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFileSubject.SelectedIndex > 0)
                BindCmbFileTopic("", "subjectID = " + cmbFileSubject.SelectedValue.ToString(), "");
        }
    }
}
