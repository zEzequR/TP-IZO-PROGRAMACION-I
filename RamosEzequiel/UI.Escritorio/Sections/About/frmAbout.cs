﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Escritorio.Sections.About
{
    public partial class frmAbout : Form
    {
        public frmAbout(string username)
        {
            InitializeComponent();
            statusTxt.Text = username;
        }

        private void closeMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
