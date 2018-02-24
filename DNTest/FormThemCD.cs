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
    public partial class FormThemCD : Form
    {
        private SubjectBUS subject = new SubjectBUS();
        private TopicBUS topic = new TopicBUS();

        public FormThemCD()
        {
            InitializeComponent();
        }

        private void BindDataSubject(String t = "", String w = "", String o = "")
        {
            cmbSubject.DataSource = subject.Subject_GetByTop(t, w, o);
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "id";
        }
        private bool ValidField()
        {
            return txtTenCD.Text.Equals(String.Empty) ? true : false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Xin hãy điền đầy đủ tên chuyên đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Topic obj = new Topic(txtTenCD.Text, cmbSubject.SelectedValue.ToString());

            if (topic.Topic_Insert(obj))
            {
                MessageBox.Show("Thêm chuyên đề thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm chuyên đề thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void FormThemCD_Load(object sender, EventArgs e)
        {
            BindDataSubject("", "", "");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
