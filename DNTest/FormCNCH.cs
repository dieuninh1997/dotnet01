﻿using System;
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
        private SubjectBUS subjectBUS = new SubjectBUS();

        private List<SimpleQuestion> lstSimple = new List<SimpleQuestion>();
        private List<MultiQuestion> lstMulti = new List<MultiQuestion>();

        private static string levelQuestion = "0";
        private Question _question;
        public FormCNCH(Question q)
        {
            this._question = q;
            //  MessageBox.Show("id = " + _question.Id + " content= " + _question.Content);
            InitializeComponent();
        }

        public FormCNCH()
        {
            InitializeComponent();
        }
        public FormCNCH(int tabIndex)
        {
            InitializeComponent();
            tabCNFile.SelectedTab = tabCNTF_Container;
         
        }
        private void FormCNCH_Load(object sender, EventArgs e)
        {
            rtxtFileNoiDung.Text = "";
            rbFileAll.Checked = true;
            BindCmbFileTopic();
            BindCmbFileSubject();
            BindCmbFileFaculty();
            //
            BindCmbTopic();
            BindCmbSubject();
            BindCmbFaculty();
            //
            LoadQuestionToEdit();
        }

        private void LoadQuestionToEdit()
        {
            if (_question != null)
            {
                var subject = subjectBUS.Subject_GetByTop("", " id = " + _question.SubjectID, "");
                cmbKhoa.SelectedValue = subject.ElementAt(0).FacultyID;
                cmbMon.SelectedValue = _question.SubjectID;
                cmbChuDe.SelectedValue = _question.TopicID;
                if (_question.LevelID.Equals("1"))
                {
                    rbDe.Checked = true;
                }
                else if (_question.LevelID.Equals("2"))
                {
                    rbTB.Checked = true;
                }
                else if (_question.LevelID.Equals("3"))
                {
                    rbKho.Checked = true;
                }

                if (_question.TypeID.Equals("1"))
                {
                    rbCauDon.Checked = true;

                    var subQues = subQuestionBUS.SubQuestion_GetByTop("", " questionID = " + _question.Id, "");
                    var answers = answerBUS.Answer_GetByTop("", " subQuestionID = " + subQues.ElementAt(0).Id, "");
                    rtxtDA1.Text = answers.ElementAt(0).Answers;
                    rtxtDA2.Text = answers.ElementAt(1).Answers;
                    rtxtDA3.Text = answers.ElementAt(2).Answers;
                    rtxtDA4.Text = answers.ElementAt(3).Answers;


                    if (bool.Parse(answers.ElementAt(0).IsCorrect))
                    {
                        rbDA1.Checked = true;
                    }
                    else if (bool.Parse(answers.ElementAt(1).IsCorrect))
                    {
                        rbDA2.Checked = true;
                    }
                    else if (bool.Parse(answers.ElementAt(2).IsCorrect))
                    {
                        rbDA3.Checked = true;
                    }
                    else if (bool.Parse(answers.ElementAt(3).IsCorrect))
                    {
                        rbDA4.Checked = true;
                    }





                }
                else if (_question.TypeID.Equals("2"))
                {
                    rbCauChum.Checked = true;
                }

                rtxtNoiDungCauHoi.Text = _question.Content;


            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlOpen = new OpenFileDialog();
            fdlOpen.InitialDirectory = "/";
            fdlOpen.Title = "Select file";
            fdlOpen.CheckFileExists = true;
            fdlOpen.CheckPathExists = true;
            fdlOpen.Filter = "Word document(*.doc/*.docx)|*.doc*| RichTextFile |*.rtf";
            fdlOpen.RestoreDirectory = true;
            fdlOpen.ReadOnlyChecked = true;
            if (fdlOpen.ShowDialog() == DialogResult.OK)
            {
                GetData(fdlOpen.FileName);
            }
        }

        private void BindCmbFileSubject(string t = "", string w = "", string o = "")
        {

            List<Subject> lst = new SubjectBUS().Subject_GetByTop(t, w, o);
            lst.Insert(0, new Subject("0", "Select an option"));
            cmbFileSubject.DataSource = lst;
            cmbFileSubject.DisplayMember = "subjectName";
            cmbFileSubject.ValueMember = "Id";
            cmbFileSubject.SelectedIndex = 0;

        }

        private void BindCmbSubject(string t = "", string w = "", string o = "")
        {

            List<Subject> lst = new SubjectBUS().Subject_GetByTop(t, w, o);
            lst.Insert(0, new Subject("0", "Select an option"));
            cmbMon.DataSource = lst;
            cmbMon.DisplayMember = "subjectName";
            cmbMon.ValueMember = "Id";
            cmbMon.SelectedIndex = 0;

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

        private void BindCmbFaculty(string t = "", string w = "", string o = "")
        {

            List<Faculty> lst = new FacultyBUS().Faculty_GetByTop(t, w, o);
            lst.Insert(0, new Faculty("0", "Select an option"));
            cmbKhoa.DataSource = lst;
            cmbKhoa.DisplayMember = "facultyName";
            cmbKhoa.ValueMember = "Id";
            cmbKhoa.SelectedIndex = 0;

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

        private void BindCmbTopic(string t = "", string w = "", string o = "")
        {

            List<Topic> lst = new TopicBUS().Topic_GetByTop(t, w, o);
            lst.Insert(0, new Topic("0", "Select an option"));
            cmbChuDe.DataSource = lst;
            cmbChuDe.DisplayMember = "topicName";
            cmbChuDe.ValueMember = "Id";
            cmbChuDe.SelectedIndex = 0;

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
                    //int no_multi_ques = 0;
                    do
                    {
                        temp = docs.Paragraphs[++i].Range.Text;
                        if (temp.Trim() == "") break;

                        qMul.content += temp + "\r\n";
                        //lọc công thức toán
                        /*
                             temp = docs.Paragraphs[++i].Range.Text;
                             if (LocCongThucToan(temp, i, no_multi_ques))
                             {
                                MessageBox.Show("Chen anh answ " + i);
                             }
                             */

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
                        //lọc công thức toán học
                        /*  if(LocCongThucToan(temp,i))
                          {
                              MessageBox.Show("Chen anh ");
                          }*/
                        qItem.question = temp;
                    }
                    else
                    {
                        List<string> answer = new List<string>();
                        qItem.correctAnswer = -1;
                        // int no_ans = 0;
                        while (temp != string.Empty)
                        {

                            //lọc công thức toán học
                            /* no_ans++;

                             if (LocCongThucToan(temp, i, no_ans))
                             {
                                 MessageBox.Show("Chen anh answ "+i);
                             }*/
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
        }

        private bool LocCongThucToan(string temp, int i, int no = 0)
        {
            int start = temp.IndexOf("[sct]");
            int end = temp.IndexOf("[ect]");
            MessageBox.Show("temp=" + temp + ", s=" + start + ", e=" + end);

            if (start >= 0 && start < temp.Length && end > 0 && end < temp.Length)
            {
                string text = temp.Substring(start + 5, end - 5 - start + 1);
                string userComputer = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last(); ;
                MessageBox.Show("Computer Name =" + userComputer);
                string save_img_path = "C:\\Users\\" + userComputer + "\\Desktop\\DNTest_Image\\Subject" + cmbFileSubject.SelectedValue.ToString() + "_Topic" + cmbFileTopic.SelectedValue.ToString() + "_" + i + "_" + no + ".png";

                Common.DrawText(text, text.Length + 100, save_img_path);
                MessageBox.Show("Saved success");
                return true;
            }
            return false;

        }

        private void FormCNCH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormHome().Show();
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

            if (levelQuestion.Trim().Equals("0"))
            {
                MessageBox.Show("Bạn chưa chọn mức độ kiến thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int success = 0, questionId = -1, subQuestionId = -1;
            //   MessageBox.Show("lstSimple = " + lstSimple.Count);
            foreach (SimpleQuestion sq in lstSimple)
            {
                questionId = questionBUS.Question_Insert(new Question(null, cmbFileTopic.SelectedValue.ToString(), cmbFileSubject.SelectedValue.ToString(), levelQuestion, sq.question, null, "1"));
                //  MessageBox.Show("QuestionID = " + questionId);
                if (questionId > 0)
                {
                    subQuestionId = subQuestionBUS.SubQuestion_Insert(new SubQuestion(null, questionId.ToString(), sq.question));
                    //     MessageBox.Show("SubQuestionID = " + subQuestionId);
                    if (subQuestionId > 0)
                    {
                        int count = sq.answer.Count;
                        //         MessageBox.Show("count = " + count);

                        for (int i = 0; i < sq.answer.Count; i++)
                        {
                            // MessageBox.Show("i = " + i);
                            if (sq.correctAnswer == i)
                            {

                                if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "1")))
                                {
                                    count--;
                                }
                            }
                            else
                            {
                                if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "0")))
                                {
                                    count--;
                                }
                            }
                            // MessageBox.Show("count = " + count);

                        }

                        //    MessageBox.Show("out count = " + count);
                        if (count != 0)
                        {
                            MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật 1");
                            return;
                        }
                    }
                    success++;
                }
            }
            //   MessageBox.Show("2 lstMulti = " + lstMulti.Count);
            foreach (MultiQuestion mq in lstMulti)
            {
                if ((questionId = questionBUS.Question_Insert(new Question(null, cmbFileTopic.SelectedValue.ToString(), cmbFileSubject.SelectedValue.ToString(), levelQuestion, mq.content, null, "2"))) > 0)
                {
                    //  MessageBox.Show("2 lstQues = " + mq.lstQuestion.Count);
                    foreach (SimpleQuestion sq in mq.lstQuestion)
                    {
                        int count = sq.answer.Count;
                        //   MessageBox.Show("2 count = " + count);
                        if ((subQuestionId = subQuestionBUS.SubQuestion_Insert(new SubQuestion(null, questionId.ToString(), sq.question))) > 0)
                        {
                            for (int i = 0; i < sq.answer.Count; i++)
                            {
                                if (sq.correctAnswer == i)
                                {
                                    if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "1")))
                                        count--;

                                }
                                else
                                {
                                    if (answerBUS.Answer_Insert(new Answer(null, subQuestionId.ToString(), sq.answer.ElementAt(i), "0")))
                                        count--;
                                }
                                //   MessageBox.Show("2 tru count = " + count);
                            }

                        }
                        //  MessageBox.Show("2 out count = " + count);
                        if (count != 0)
                        {
                            MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật 2");
                            return;
                        }
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

        private void rbFileDe_CheckedChanged(object sender, EventArgs e)
        {
            levelQuestion = "1";
        }

        private void rbFileTrungBinh_CheckedChanged(object sender, EventArgs e)
        {
            levelQuestion = "2";
        }

        private void rbFileKho_CheckedChanged(object sender, EventArgs e)
        {
            levelQuestion = "3";
        }

        private void rbFileAll_CheckedChanged(object sender, EventArgs e)
        {
            levelQuestion = "0";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
