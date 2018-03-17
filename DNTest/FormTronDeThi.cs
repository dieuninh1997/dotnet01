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
        AnswerBUS answerBUS = new AnswerBUS();
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

        }

        private void BindDataDsCauHoiDaChon()
        {
            MessageBox.Show("size=" + dsCH.Count);
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
            MessageBox.Show("Diem=" + Math.Round(val,2));

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
    }
}
