namespace DNTest
{
    partial class FormQLCD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLCD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbHienThiTatCa = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvChuyenDe = new System.Windows.Forms.DataGridView();
            this.subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMH = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDe)).BeginInit();
            this.gbMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.gbMH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 497);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.ckbHienThiTatCa);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.dgvChuyenDe);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 479);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các chuyên đề";
            // 
            // ckbHienThiTatCa
            // 
            this.ckbHienThiTatCa.AutoSize = true;
            this.ckbHienThiTatCa.Location = new System.Drawing.Point(521, 11);
            this.ckbHienThiTatCa.Name = "ckbHienThiTatCa";
            this.ckbHienThiTatCa.Size = new System.Drawing.Size(92, 17);
            this.ckbHienThiTatCa.TabIndex = 8;
            this.ckbHienThiTatCa.Text = "Hiển thị tất cả";
            this.ckbHienThiTatCa.UseVisualStyleBackColor = true;
            this.ckbHienThiTatCa.CheckedChanged += new System.EventHandler(this.ckbHienThiTatCa_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(6, 418);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 55);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(463, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(305, 418);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 55);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(153, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvChuyenDe
            // 
            this.dgvChuyenDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenDe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvChuyenDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectID,
            this.id,
            this.topicName});
            this.dgvChuyenDe.Location = new System.Drawing.Point(6, 34);
            this.dgvChuyenDe.Name = "dgvChuyenDe";
            this.dgvChuyenDe.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvChuyenDe.Size = new System.Drawing.Size(607, 378);
            this.dgvChuyenDe.TabIndex = 1;
            this.dgvChuyenDe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenDe_CellClick);
            // 
            // subjectID
            // 
            this.subjectID.DataPropertyName = "subjectID";
            this.subjectID.HeaderText = "Mã môn học";
            this.subjectID.Name = "subjectID";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã chuyên đề";
            this.id.Name = "id";
            // 
            // topicName
            // 
            this.topicName.DataPropertyName = "topicName";
            this.topicName.HeaderText = "Tên chuyên đề";
            this.topicName.Name = "topicName";
            // 
            // gbMH
            // 
            this.gbMH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbMH.Controls.Add(this.dgvMonHoc);
            this.gbMH.Location = new System.Drawing.Point(12, 12);
            this.gbMH.Name = "gbMH";
            this.gbMH.Size = new System.Drawing.Size(279, 479);
            this.gbMH.TabIndex = 0;
            this.gbMH.TabStop = false;
            this.gbMH.Text = "Danh sách môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subjectName,
            this.faculty_id});
            this.dgvMonHoc.Location = new System.Drawing.Point(6, 34);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvMonHoc.Size = new System.Drawing.Size(267, 439);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "id";
            this.subject_id.HeaderText = "Mã môn học";
            this.subject_id.Name = "subject_id";
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "Tên môn học";
            this.subjectName.Name = "subjectName";
            // 
            // faculty_id
            // 
            this.faculty_id.DataPropertyName = "facultyID";
            this.faculty_id.HeaderText = "Mã khoa";
            this.faculty_id.Name = "faculty_id";
            this.faculty_id.Visible = false;
            // 
            // FormQLCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chuyên đề";
            this.Load += new System.EventHandler(this.FormQLCD_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDe)).EndInit();
            this.gbMH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvChuyenDe;
        private System.Windows.Forms.GroupBox gbMH;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicName;
        private System.Windows.Forms.CheckBox ckbHienThiTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_id;
    }
}