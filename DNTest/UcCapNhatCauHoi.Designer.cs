﻿namespace DNTest
{
    partial class UcCapNhatCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCapNhatCauHoi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCapNhatTuFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCapNhatTuFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(199, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 391);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(84, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cập nhật từng câu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatTuFile
            // 
            this.btnCapNhatTuFile.Location = new System.Drawing.Point(84, 45);
            this.btnCapNhatTuFile.Name = "btnCapNhatTuFile";
            this.btnCapNhatTuFile.Size = new System.Drawing.Size(167, 51);
            this.btnCapNhatTuFile.TabIndex = 1;
            this.btnCapNhatTuFile.Text = "Cập nhật từ file";
            this.btnCapNhatTuFile.UseVisualStyleBackColor = true;
            this.btnCapNhatTuFile.Click += new System.EventHandler(this.btnCapNhatTuFile_Click);
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
            this.label1.Size = new System.Drawing.Size(341, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Các chức năng cập nhật";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcCapNhatCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcCapNhatCauHoi";
            this.Size = new System.Drawing.Size(776, 431);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCapNhatTuFile;
        private System.Windows.Forms.Label label1;
    }
}
