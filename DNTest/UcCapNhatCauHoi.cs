﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNTest
{
    public partial class UcCapNhatCauHoi : UserControl
    {
        public UcCapNhatCauHoi()
        {
            InitializeComponent();
        }

        private void btnCapNhatTuFile_Click(object sender, EventArgs e)
        {
            
            new FormCNCH(1).Show();
           
            this.ParentForm.Hide();
        }
    }
}
