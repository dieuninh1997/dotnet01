namespace DNTest
{
    partial class UcRaDeThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRaDeThi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRaDeThiTronTuFile = new System.Windows.Forms.Button();
            this.btnRaDeThiTronTungCau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnRaDeThiTronTuFile);
            this.panel1.Controls.Add(this.btnRaDeThiTronTungCau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(199, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 391);
            this.panel1.TabIndex = 1;
            // 
            // btnRaDeThiTronTuFile
            // 
            this.btnRaDeThiTronTuFile.Enabled = false;
            this.btnRaDeThiTronTuFile.Location = new System.Drawing.Point(87, 147);
            this.btnRaDeThiTronTuFile.Name = "btnRaDeThiTronTuFile";
            this.btnRaDeThiTronTuFile.Size = new System.Drawing.Size(167, 51);
            this.btnRaDeThiTronTuFile.TabIndex = 2;
            this.btnRaDeThiTronTuFile.Text = "Trộn từ file";
            this.btnRaDeThiTronTuFile.UseVisualStyleBackColor = true;
            this.btnRaDeThiTronTuFile.Click += new System.EventHandler(this.btnRaDeThiTronTuFile_Click);
            // 
            // btnRaDeThiTronTungCau
            // 
            this.btnRaDeThiTronTungCau.Location = new System.Drawing.Point(87, 73);
            this.btnRaDeThiTronTungCau.Name = "btnRaDeThiTronTungCau";
            this.btnRaDeThiTronTungCau.Size = new System.Drawing.Size(167, 51);
            this.btnRaDeThiTronTungCau.TabIndex = 1;
            this.btnRaDeThiTronTungCau.Text = "Trộn từng câu";
            this.btnRaDeThiTronTungCau.UseVisualStyleBackColor = true;
            this.btnRaDeThiTronTungCau.Click += new System.EventHandler(this.btnRaDeThiTronTungCau_Click);
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
            this.label1.Size = new System.Drawing.Size(352, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Các chức năng ra đề thi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcRaDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcRaDeThi";
            this.Size = new System.Drawing.Size(776, 431);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRaDeThiTronTuFile;
        private System.Windows.Forms.Button btnRaDeThiTronTungCau;
        private System.Windows.Forms.Label label1;
    }
}
