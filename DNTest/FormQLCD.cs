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
    public partial class FormQLCD : Form
    {
        private SubjectBUS subject = new SubjectBUS();
        private TopicBUS topic = new TopicBUS();

        public FormQLCD()
        {
            InitializeComponent();
        }
        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            dgvMonHoc.DataSource = subject.Subject_GetByTop(t, w, o);
     
        }
        private void BindDataTopic(String t = "", String w = "", String o = "")
        {
            dgvChuyenDe.DataSource = topic.Topic_GetByTop(t, w, o);

        }

      
        private void FormQLCD_Load(object sender, EventArgs e)
        {
            BindDataSubject("", "", "");
            BindDataTopic("", "", "");

        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvMonHoc.CurrentRow.Index;
                BindDataTopic("", " subjectID = " + dgvMonHoc.Rows[row].Cells["subject_id"].Value.ToString(), "");
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
                BindDataTopic("", "", "");
                gbMH.Enabled = false;
            }
            else
            {
                gbMH.Enabled = true;
                int row = dgvMonHoc.CurrentRow.Index;
                BindDataTopic("", " subjectID = " + dgvMonHoc.Rows[row].Cells["subject_id"].Value.ToString(), "");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindDataSubject("", "", "");

            if (ckbHienThiTatCa.Checked)
            {
                BindDataTopic("", "", "");
                gbMH.Enabled = false;
            }
            else
            {
                gbMH.Enabled = true;
                int row = dgvMonHoc.CurrentRow.Index;
                BindDataTopic("", " subjectID = " + dgvMonHoc.Rows[row].Cells[0].Value.ToString(), "");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormThemCD().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FormSuaCD().ShowDialog();
        }

        private void dgvChuyenDe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvChuyenDe.CurrentRow.Index;
                Common.topicID = dgvChuyenDe.Rows[row].Cells[1].Value.ToString();
                Common.topicName = dgvChuyenDe.Rows[row].Cells[2].Value.ToString();
                Common.topic_subjectID = dgvChuyenDe.Rows[row].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa chuyên đề " + Common.topicID + "?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                int row = dgvChuyenDe.CurrentRow.Index;
                //  SubjectBUS obj = new SubjectBUS();
                MessageBox.Show(dgvChuyenDe.Rows[row].Cells["id"].Value.ToString(), "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (topic.Topic_Delete(dgvChuyenDe.Rows[row].Cells["id"].Value.ToString()))
                {
                    count++;
                    BindDataTopic("", "", "");
                    MessageBox.Show("Xóa thành công " + count + " chuyên đề.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa chuyên đề thất bại", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
