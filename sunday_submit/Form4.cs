using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sunday_submit
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_employeeid.Text = string.Empty;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
