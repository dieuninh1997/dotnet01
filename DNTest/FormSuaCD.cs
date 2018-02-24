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
    public partial class FormSuaCD : Form
    {
        private SubjectBUS subject = new SubjectBUS();
        private TopicBUS topic = new TopicBUS();

        public FormSuaCD()
        {
            InitializeComponent();
        }
        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            cmbSubject.DataSource = subject.Subject_GetByTop(t, w, o);
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "id";
            cmbSubject.SelectedValue = Common.topic_subjectID;
        }
        private bool ValidField()
        {
            return txtTenCD.Text.Equals(String.Empty) ? true : false;
        }

        private void FormSuaCD_Load(object sender, EventArgs e)
        {
            BindDataSubject("", "", "");
            txtTenCD.Focus();
            txtTenCD.Text = Common.topicName;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Xin hãy điền đầy đủ tên chuyên đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Topic obj = new Topic(Common.topicID, txtTenCD.Text, cmbSubject.SelectedValue.ToString());

            if (topic.Topic_Update(obj))
            {
                MessageBox.Show("Sửa chuyên đề thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa chuyên đề thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
