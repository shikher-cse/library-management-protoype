﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sunday_submit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btn_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", " http://www.idsil.com");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
