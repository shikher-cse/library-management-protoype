using System;
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
    public partial class Form1 : Form
    {
      
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
        Formdelete frmdelete = new Formdelete();
        Form2 frminfo = new Form2();
        public Form1()
        {
            InitializeComponent();
            hidepanel();
        }
        private  void  hidepanel()
        {
            frm3.Visible = false;
            frm4.Visible = false;

            panel7.Visible = false;
            panel8.Visible = false;

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            frm3.Visible = false;
            frm3.Enabled = false;
            panel7.Visible = true;
            panel8.Visible = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }

     

        private void btn_adddata_Click(object sender, EventArgs e)
        {
            frm3.Visible = true;
            frm3.Enabled = true;
           

        }

        private void btn_editdata_Click(object sender, EventArgs e)
        {
            frm4.Visible = true;
            frm4.Enabled = true;
        }

        private void btn_delete_click(object sender, EventArgs e)
        {
            frmdelete.Visible = true;
            frm3.Visible = false;
            frm4.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {

           
        }

     

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = false;
          


        }

        private void btn_aboutus_Click(object sender, EventArgs e)
        {
            frminfo.Visible = true;
            frmdelete.Visible = false;
            frm3.Visible = false;
            frm4.Visible = false;
        }

        private void gotosite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https:// www.idsil.com");
        }
    }
}
