namespace DNTest
{
    partial class FormQLCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLCH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtNoiDungCauHoi = new System.Windows.Forms.RichTextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDsXuatCauHoi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSelectNum = new System.Windows.Forms.Label();
            this.pcXoaHet = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckbHienThiTatCa = new System.Windows.Forms.CheckBox();
            this.dgvDsCauHoi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDangCauHoi = new System.Windows.Forms.GroupBox();
            this.rbAllType = new System.Windows.Forms.RadioButton();
            this.rbMultiple = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.gbMucDoKienThuc = new System.Windows.Forms.GroupBox();
            this.rbAllLevel = new System.Windows.Forms.RadioButton();
            this.rbKho = new System.Windows.Forms.RadioButton();
            this.rbTrungBinh = new System.Windows.Forms.RadioButton();
            this.rbDe = new System.Windows.Forms.RadioButton();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsXuatCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcXoaHet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCauHoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbDangCauHoi.SuspendLayout();
            this.gbMucDoKienThuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtxtNoiDungCauHoi);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 606);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nội dung câu hỏi và câu trả lời";
            // 
            // rtxtNoiDungCauHoi
            // 
            this.rtxtNoiDungCauHoi.Enabled = false;
            this.rtxtNoiDungCauHoi.Location = new System.Drawing.Point(267, 269);
            this.rtxtNoiDungCauHoi.Name = "rtxtNoiDungCauHoi";
            this.rtxtNoiDungCauHoi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtxtNoiDungCauHoi.Size = new System.Drawing.Size(848, 325);
            this.rtxtNoiDungCauHoi.TabIndex = 15;
            this.rtxtNoiDungCauHoi.Text = "";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.Image")));
            this.btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAll.Location = new System.Drawing.Point(675, 147);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(34, 30);
            this.btnSelectAll.TabIndex = 14;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(675, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(675, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.dgvDsXuatCauHoi);
            this.groupBox5.Controls.Add(this.lbSelectNum);
            this.groupBox5.Controls.Add(this.pcXoaHet);
            this.groupBox5.Location = new System.Drawing.Point(715, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(403, 226);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Câu hỏi muốn xuất ra";
            // 
            // dgvDsXuatCauHoi
            // 
            this.dgvDsXuatCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsXuatCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsXuatCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvDsXuatCauHoi.Location = new System.Drawing.Point(3, 35);
            this.dgvDsXuatCauHoi.Name = "dgvDsXuatCauHoi";
            this.dgvDsXuatCauHoi.Size = new System.Drawing.Size(396, 162);
            this.dgvDsXuatCauHoi.TabIndex = 2;
            this.dgvDsXuatCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsXuatCauHoi_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã câu hỏi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "typeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dạng câu hỏi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "subjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã môn học";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "topicID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã chuyên đề";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "levelID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã mức độ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "content";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nội dung";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngày tạo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // lbSelectNum
            // 
            this.lbSelectNum.AutoSize = true;
            this.lbSelectNum.Location = new System.Drawing.Point(179, 204);
            this.lbSelectNum.Name = "lbSelectNum";
            this.lbSelectNum.Size = new System.Drawing.Size(35, 13);
            this.lbSelectNum.TabIndex = 5;
            this.lbSelectNum.Text = "0 Câu";
            // 
            // pcXoaHet
            // 
            this.pcXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("pcXoaHet.Image")));
            this.pcXoaHet.Location = new System.Drawing.Point(373, 5);
            this.pcXoaHet.Name = "pcXoaHet";
            this.pcXoaHet.Size = new System.Drawing.Size(24, 24);
            this.pcXoaHet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcXoaHet.TabIndex = 1;
            this.pcXoaHet.TabStop = false;
            this.pcXoaHet.Click += new System.EventHandler(this.pcXoaHet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.ckbHienThiTatCa);
            this.groupBox4.Controls.Add(this.dgvDsCauHoi);
            this.groupBox4.Location = new System.Drawing.Point(265, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 226);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách câu hỏi";
            // 
            // ckbHienThiTatCa
            // 
            this.ckbHienThiTatCa.AutoSize = true;
            this.ckbHienThiTatCa.Location = new System.Drawing.Point(306, 5);
            this.ckbHienThiTatCa.Name = "ckbHienThiTatCa";
            this.ckbHienThiTatCa.Size = new System.Drawing.Size(92, 17);
            this.ckbHienThiTatCa.TabIndex = 1;
            this.ckbHienThiTatCa.Text = "Hiển thị tất cả";
            this.ckbHienThiTatCa.UseVisualStyleBackColor = true;
            this.ckbHienThiTatCa.CheckedChanged += new System.EventHandler(this.ckbHienThiTatCa_CheckedChanged);
            // 
            // dgvDsCauHoi
            // 
            this.dgvDsCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.typeID,
            this.subjectID,
            this.topicID,
            this.levelID,
            this.content,
            this.createDate});
            this.dgvDsCauHoi.Location = new System.Drawing.Point(4, 32);
            this.dgvDsCauHoi.Name = "dgvDsCauHoi";
            this.dgvDsCauHoi.Size = new System.Drawing.Size(396, 162);
            this.dgvDsCauHoi.TabIndex = 0;
            this.dgvDsCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsCauHoi_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã câu hỏi";
            this.id.Name = "id";
            // 
            // typeID
            // 
            this.typeID.DataPropertyName = "typeID";
            this.typeID.HeaderText = "Dạng câu hỏi";
            this.typeID.Name = "typeID";
            this.typeID.Visible = false;
            // 
            // subjectID
            // 
            this.subjectID.DataPropertyName = "subjectID";
            this.subjectID.HeaderText = "Mã môn học";
            this.subjectID.Name = "subjectID";
            this.subjectID.Visible = false;
            // 
            // topicID
            // 
            this.topicID.DataPropertyName = "topicID";
            this.topicID.HeaderText = "Mã chuyên đề";
            this.topicID.Name = "topicID";
            this.topicID.Visible = false;
            // 
            // levelID
            // 
            this.levelID.DataPropertyName = "levelID";
            this.levelID.HeaderText = "Mã mức độ";
            this.levelID.Name = "levelID";
            this.levelID.Visible = false;
            // 
            // content
            // 
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "Nội dung";
            this.content.Name = "content";
            // 
            // createDate
            // 
            this.createDate.DataPropertyName = "createDate";
            this.createDate.HeaderText = "Ngày tạo";
            this.createDate.Name = "createDate";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnThemCauHoi);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gbDangCauHoi);
            this.groupBox1.Controls.Add(this.gbMucDoKienThuc);
            this.groupBox1.Controls.Add(this.cmbTopic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFaculty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCauHoi.Image")));
            this.btnThemCauHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCauHoi.Location = new System.Drawing.Point(18, 384);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(211, 46);
            this.btnThemCauHoi.TabIndex = 12;
            this.btnThemCauHoi.Text = "Thêm câu hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(18, 488);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(211, 43);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Xuất tài liệu ôn tập";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(18, 436);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa câu hỏi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(168, 330);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(61, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số câu hỏi trong chuyên đề: ";
            // 
            // gbDangCauHoi
            // 
            this.gbDangCauHoi.BackColor = System.Drawing.Color.SteelBlue;
            this.gbDangCauHoi.Controls.Add(this.rbAllType);
            this.gbDangCauHoi.Controls.Add(this.rbMultiple);
            this.gbDangCauHoi.Controls.Add(this.rbSingle);
            this.gbDangCauHoi.Location = new System.Drawing.Point(20, 241);
            this.gbDangCauHoi.Name = "gbDangCauHoi";
            this.gbDangCauHoi.Size = new System.Drawing.Size(209, 73);
            this.gbDangCauHoi.TabIndex = 7;
            this.gbDangCauHoi.TabStop = false;
            this.gbDangCauHoi.Text = "Dạng câu hỏi";
            // 
            // rbAllType
            // 
            this.rbAllType.AutoSize = true;
            this.rbAllType.Location = new System.Drawing.Point(12, 23);
            this.rbAllType.Name = "rbAllType";
            this.rbAllType.Size = new System.Drawing.Size(56, 17);
            this.rbAllType.TabIndex = 2;
            this.rbAllType.TabStop = true;
            this.rbAllType.Text = "Tất cả";
            this.rbAllType.UseVisualStyleBackColor = true;
            this.rbAllType.CheckedChanged += new System.EventHandler(this.rbAllType_CheckedChanged);
            // 
            // rbMultiple
            // 
            this.rbMultiple.AutoSize = true;
            this.rbMultiple.Location = new System.Drawing.Point(84, 50);
            this.rbMultiple.Name = "rbMultiple";
            this.rbMultiple.Size = new System.Drawing.Size(73, 17);
            this.rbMultiple.TabIndex = 1;
            this.rbMultiple.TabStop = true;
            this.rbMultiple.Text = "Câu chùm";
            this.rbMultiple.UseVisualStyleBackColor = true;
            this.rbMultiple.CheckedChanged += new System.EventHandler(this.rbMultiple_CheckedChanged);
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(12, 50);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(66, 17);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Câu đơn";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.CheckedChanged += new System.EventHandler(this.rbSingle_CheckedChanged);
            // 
            // gbMucDoKienThuc
            // 
            this.gbMucDoKienThuc.BackColor = System.Drawing.Color.SteelBlue;
            this.gbMucDoKienThuc.Controls.Add(this.rbAllLevel);
            this.gbMucDoKienThuc.Controls.Add(this.rbKho);
            this.gbMucDoKienThuc.Controls.Add(this.rbTrungBinh);
            this.gbMucDoKienThuc.Controls.Add(this.rbDe);
            this.gbMucDoKienThuc.Location = new System.Drawing.Point(18, 148);
            this.gbMucDoKienThuc.Name = "gbMucDoKienThuc";
            this.gbMucDoKienThuc.Size = new System.Drawing.Size(209, 78);
            this.gbMucDoKienThuc.TabIndex = 6;
            this.gbMucDoKienThuc.TabStop = false;
            this.gbMucDoKienThuc.Text = "Mức độ kiến thức";
            // 
            // rbAllLevel
            // 
            this.rbAllLevel.AutoSize = true;
            this.rbAllLevel.Location = new System.Drawing.Point(14, 24);
            this.rbAllLevel.Name = "rbAllLevel";
            this.rbAllLevel.Size = new System.Drawing.Size(56, 17);
            this.rbAllLevel.TabIndex = 3;
            this.rbAllLevel.TabStop = true;
            this.rbAllLevel.Text = "Tất cả";
            this.rbAllLevel.UseVisualStyleBackColor = true;
            this.rbAllLevel.CheckedChanged += new System.EventHandler(this.rbAllLevel_CheckedChanged);
            // 
            // rbKho
            // 
            this.rbKho.AutoSize = true;
            this.rbKho.Location = new System.Drawing.Point(154, 52);
            this.rbKho.Name = "rbKho";
            this.rbKho.Size = new System.Drawing.Size(44, 17);
            this.rbKho.TabIndex = 2;
            this.rbKho.TabStop = true;
            this.rbKho.Text = "Khó";
            this.rbKho.UseVisualStyleBackColor = true;
            this.rbKho.CheckedChanged += new System.EventHandler(this.rbKho_CheckedChanged);
            // 
            // rbTrungBinh
            // 
            this.rbTrungBinh.AutoSize = true;
            this.rbTrungBinh.Location = new System.Drawing.Point(72, 52);
            this.rbTrungBinh.Name = "rbTrungBinh";
            this.rbTrungBinh.Size = new System.Drawing.Size(76, 17);
            this.rbTrungBinh.TabIndex = 1;
            this.rbTrungBinh.TabStop = true;
            this.rbTrungBinh.Text = "Trung bình";
            this.rbTrungBinh.UseVisualStyleBackColor = true;
            this.rbTrungBinh.CheckedChanged += new System.EventHandler(this.rbTrungBinh_CheckedChanged);
            // 
            // rbDe
            // 
            this.rbDe.AutoSize = true;
            this.rbDe.Location = new System.Drawing.Point(14, 52);
            this.rbDe.Name = "rbDe";
            this.rbDe.Size = new System.Drawing.Size(39, 17);
            this.rbDe.TabIndex = 0;
            this.rbDe.TabStop = true;
            this.rbDe.Text = "Dễ";
            this.rbDe.UseVisualStyleBackColor = true;
            this.rbDe.CheckedChanged += new System.EventHandler(this.rbDe_CheckedChanged);
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(18, 112);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(209, 21);
            this.cmbTopic.TabIndex = 5;
            this.cmbTopic.SelectedIndexChanged += new System.EventHandler(this.cmbTopic_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyên đề kiến thức";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(18, 72);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(209, 21);
            this.cmbSubject.TabIndex = 3;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn môn học";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(18, 32);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(209, 21);
            this.cmbFaculty.TabIndex = 1;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn khoa:";
            // 
            // FormQLCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 606);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý câu hỏi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQLCH_FormClosed);
            this.Load += new System.EventHandler(this.FormQLCH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsXuatCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcXoaHet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCauHoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDangCauHoi.ResumeLayout(false);
            this.gbDangCauHoi.PerformLayout();
            this.gbMucDoKienThuc.ResumeLayout(false);
            this.gbMucDoKienThuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtNoiDungCauHoi;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbSelectNum;
        private System.Windows.Forms.PictureBox pcXoaHet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDsCauHoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDangCauHoi;
        private System.Windows.Forms.RadioButton rbMultiple;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.GroupBox gbMucDoKienThuc;
        private System.Windows.Forms.RadioButton rbKho;
        private System.Windows.Forms.RadioButton rbTrungBinh;
        private System.Windows.Forms.RadioButton rbDe;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbHienThiTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.RadioButton rbAllType;
        private System.Windows.Forms.RadioButton rbAllLevel;
        private System.Windows.Forms.DataGridView dgvDsXuatCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}