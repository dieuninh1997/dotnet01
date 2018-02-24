namespace DNTest
{
    partial class UcQuanLyDuLieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcQuanLyDuLieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLCH = new System.Windows.Forms.Button();
            this.btnQLCD = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnQLCH);
            this.panel1.Controls.Add(this.btnQLCD);
            this.panel1.Controls.Add(this.btnQLMH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(199, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 391);
            this.panel1.TabIndex = 2;
            // 
            // btnQLCH
            // 
            this.btnQLCH.Location = new System.Drawing.Point(84, 181);
            this.btnQLCH.Name = "btnQLCH";
            this.btnQLCH.Size = new System.Drawing.Size(167, 51);
            this.btnQLCH.TabIndex = 3;
            this.btnQLCH.Text = "Quản lý câu hỏi";
            this.btnQLCH.UseVisualStyleBackColor = true;
            this.btnQLCH.Click += new System.EventHandler(this.btnQLCH_Click);
            // 
            // btnQLCD
            // 
            this.btnQLCD.Location = new System.Drawing.Point(84, 115);
            this.btnQLCD.Name = "btnQLCD";
            this.btnQLCD.Size = new System.Drawing.Size(167, 51);
            this.btnQLCD.TabIndex = 2;
            this.btnQLCD.Text = "Quản lý chuyên đề";
            this.btnQLCD.UseVisualStyleBackColor = true;
            this.btnQLCD.Click += new System.EventHandler(this.btnQLCD_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.Location = new System.Drawing.Point(84, 45);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(167, 51);
            this.btnQLMH.TabIndex = 1;
            this.btnQLMH.Text = "Quản lý môn học";
            this.btnQLMH.UseVisualStyleBackColor = true;
            this.btnQLMH.Click += new System.EventHandler(this.btnQLMH_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Các chức năng quản lý ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcQuanLyDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcQuanLyDuLieu";
            this.Size = new System.Drawing.Size(776, 431);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLCH;
        private System.Windows.Forms.Button btnQLCD;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Label label1;
    }
}
