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
    public partial class FormTronDeThi : Form
    {
        QuizBUS quizBUS = new QuizBUS();
        AnswerBUS answerBUS = new AnswerBUS();
        QuestionBUS questionBUS = new QuestionBUS();
        SubQuestionBUS subQuestionBUS = new SubQuestionBUS();
        SortedDictionary<string, Question> ds = Common.lstDsCauHoiTrongDeThi;
        SortedSet<Question> dsCH = Common.lstDsCauHoiDaChon;
      
        public FormTronDeThi()
        {
            InitializeComponent();
        }


        private void FormTronDeThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormRaDeThi().Show();
        }

        private void FormTronDeThi_Load(object sender, EventArgs e)
        {
            BindDataDsCauHoiDaChon();
            nudSoDeCanTao.Value = 1;
            Random ran = new Random();
            int so = ran.Next(1, 1000);
            nudMaDe.Minimum = 1;
            nudMaDe.Maximum = 1000;
            nudMaDe.Value = so;
            BindDataCmbMaDe();
        }

        private void BindDataDsCauHoiDaChon()
        {
            // MessageBox.Show("size=" + dsCH.Count);
            var source = new BindingSource();
            source.DataSource = dsCH;
            dgvDsCauHoiDaChon.DataSource = source;

            dgvDsCauHoiDaChon.Columns["id"].HeaderText = "Mã câu hỏi";
            dgvDsCauHoiDaChon.Columns["id"].Visible = true;

            dgvDsCauHoiDaChon.Columns["typeID"].HeaderText = "Dạng câu hỏi";
            dgvDsCauHoiDaChon.Columns["typeID"].Visible = false;

            dgvDsCauHoiDaChon.Columns["subjectID"].HeaderText = "Mã môn học";
            dgvDsCauHoiDaChon.Columns["subjectID"].Visible = false;

            dgvDsCauHoiDaChon.Columns["topicID"].HeaderText = "Mã chuyên để";
            dgvDsCauHoiDaChon.Columns["topicID"].Visible = false;

            dgvDsCauHoiDaChon.Columns["levelID"].HeaderText = "Mã mức độ";
            dgvDsCauHoiDaChon.Columns["levelID"].Visible = false;

            dgvDsCauHoiDaChon.Columns["content"].HeaderText = "Nội dung";
            dgvDsCauHoiDaChon.Columns["content"].Visible = true;

            dgvDsCauHoiDaChon.Columns["createDate"].HeaderText = "Ngày tạo";
            dgvDsCauHoiDaChon.Columns["createDate"].Visible = false;

            var colDiem = new DataGridViewTextBoxColumn();
            colDiem.HeaderText = "Điểm";
            colDiem.Name = "Diem";
            dgvDsCauHoiDaChon.Columns.AddRange(new DataGridViewColumn[] { colDiem });



        }

        private void dgvDsCauHoiDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            //   indexDgvCH = row;
            //   BindDataSubQuestion("", " questionID=" + dgvDsCauHoi.Rows[row].Cells["id"].Value.ToString(), "");
            showItem(dgvDsCauHoiDaChon, row);

        }
        private void showItem(DataGridView dgv, int row)
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

            if (typeId.Equals("2"))
            {
                question += " " + content + "\r\n";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRaDeThi().Show();
        }

        private void ckbNhapDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNhapDiem.Checked)
            {
                dgvDsCauHoiDaChon.Columns[7].ReadOnly = true;
            }
            else
            {
                dgvDsCauHoiDaChon.Columns[7].ReadOnly = false;
            }
        }

        private void btnChiaDeu_Click(object sender, EventArgs e)
        {
            double val = Int16.Parse(txtThangDiem.Text) / ((dsCH.Count) * 1.0);
            //       MessageBox.Show("Diem=" + Math.Round(val, 2));

            for (int i = 0; i < dsCH.Count; i++)
            {
                dgvDsCauHoiDaChon.Rows[i].Cells[7].Value = val.ToString("0.00");
                dgvDsCauHoiDaChon.UpdateCellValue(7, i);
            }

        }
        private void showSimpleQuestionInRichTextBox(Question q)
        {
            string question = "";
            if (q.TypeID.Equals("2"))
            {
                question += " " + q.Content + "\r\n";
            }

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
            if (ckbXemDsXuat.Checked)
            {
                rtxtNoiDungCauHoi.Text = "";
                foreach (var item in dsCH)
                {
                    showSimpleQuestionInRichTextBox(item);
                }

            }
            else
            {
                rtxtNoiDungCauHoi.Text = "";
            }
        }

        private void btnTronDe_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTieuDe.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiêu đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nudThoiGianThi.Value.ToString().Equals("0"))
            {
                MessageBox.Show("Bạn chưa chọn thời gian thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string time_thi = nudThoiGianThi.Value.ToString();
            string title_de = txtTieuDe.Text;
            int soDe = int.Parse(nudSoDeCanTao.Value.ToString());
            SortedSet<string> dsDeThi = createExam(soDe);
            Quiz quiz = new Quiz();
            quiz.SubjectID = Common.subjectID_raDeThi;
            quiz.QuestionList = dsDeThi.ElementAt(0);
            quiz.QuizName = title_de;
            quiz.QuestionCount = dsCH.Count.ToString();
            quiz.CreateDate = DateTime.Now.ToString();
            quiz.Time = time_thi;
            int quizID = -1;
            int success = 0;
            if ((quizID = quizBUS.Quiz_Insert(quiz)) > 0)
            {
                MessageBox.Show("Insert De Thi Thanh Cong");
                success++;
            }
            else
                MessageBox.Show("Insert De Thi Fail");
            if (success > 0)
            {
                for (int i = 0; i < soDe; i++)
                {
                    if (dsDeThi.ElementAt(i) != null)
                    {
                        //   MessageBox.Show("dsDeThi=" + dsDeThi.ElementAt(i));
                        ckbXemDsXuat.Checked = true;
                        rtxtNoiDungCauHoi.Text = "";
                        rtxtNoiDungCauHoi.Text += viewQuiz(dsDeThi.ElementAt(i));
                        int maDe = int.Parse(nudMaDe.Value.ToString());
                        string path = "MaDe" + (maDe + i) + ".docx";
                        string userComputer = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last(); ;
                        string save_doc_path = "C:\\Users\\" + userComputer + "\\Desktop\\" + path;
                        writeToDoc(save_doc_path);
                    }
                }
                MessageBox.Show("Tạo đề thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        private string viewQuiz(string ds)
        {
            string content = "";
            string[] singleQuestion = ds.Split(';');
            int questionNumber = 0;
            foreach (string item in singleQuestion)
            {
                SubQuestion sq = subQuestionBUS.SubQuestion_GetByTop("", "questionID = '" + item.Trim() + "'", "").ElementAt(0);
                content += "Question " + (++questionNumber) + ". " + sq.Content + "\r\n";
                List<Answer> lst = answerBUS.Answer_GetByTop("", " subQuestionID = '" + sq.Id + "'", "");
                for (int i = 0; i < lst.Count; ++i)
                {
                    Answer a = lst.ElementAt(i);
                    if (bool.Parse(a.IsCorrect))
                    {
                        content += (char)(65 + i) + ". " + a.Answers + " *\r\n";
                    }
                    else
                    {
                        content += (char)(65 + i) + ". " + a.Answers + "\r\n";
                    }
                }
                content += "\r\n";
            }
            return content;

        }

        private void writeToDoc(string path)
        {
            //   MessageBox.Show("MaDe=" + path);
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            object filename = path;
            doc.Content.Text += rtxtNoiDungCauHoi.Text;
            //  app.Visible = true;    //Optional
            doc.SaveAs2(ref filename);
            doc.Close(ref missing, ref missing, ref missing);
            doc = null;
            app.Quit(ref missing, ref missing, ref missing);
            app = null;

        }


        private SortedSet<string> createExam(int n)
        {
            SortedSet<string> arr = new SortedSet<string>();
            int i = n;
            while (n > 0 && arr.Count < i)
            {
                //copy to List
                List<Question> lstCH = new List<Question>();
                foreach (Question q in dsCH)
                {
                    lstCH.Add(q);
                }

                string questionList = "";
                Random rd = new Random();
                int rdVal = -1;
                while (lstCH.Count > 0)
                {
                    rdVal = rd.Next(0, lstCH.Count - 1);//can tren
                    if (questionList == "")
                    {
                        questionList += lstCH.ElementAt(rdVal).Id;
                    }
                    else
                    {
                        questionList += ";" + lstCH.ElementAt(rdVal).Id;
                    }
                    lstCH.RemoveAt(rdVal);
                }
                //     MessageBox.Show("quesList=" + questionList);
                if(arr.Add(questionList))
                {
                    MessageBox.Show("size=" + arr.Count);
                }
                n--;
            }
            return arr;
        }


        private void nudSoDeCanTao_ValueChanged(object sender, EventArgs e)
        {
            BindDataCmbMaDe();
        }

        private void BindDataCmbMaDe()
        {
            Dictionary<string, string> val = new Dictionary<string, string>();

            int so = int.Parse(nudMaDe.Value.ToString());

            for (int i = 0; i < nudSoDeCanTao.Value; i++)
            {
                int k = so + i;
                val.Add(k.ToString(), k.ToString());
            }
            cmbMaDe.DataSource = new BindingSource(val, null);
            cmbMaDe.DisplayMember = "Value";
            cmbMaDe.ValueMember = "Key";
        }

        private void nudMaDe_ValueChanged(object sender, EventArgs e)
        {
            BindDataCmbMaDe();
        }
    }
}
