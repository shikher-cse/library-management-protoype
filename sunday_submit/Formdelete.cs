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
    public partial class Formdelete : Form
    {
        Form4 frm4 = new Form4();
        public Formdelete()
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
            MessageBox.Show("save Pressed ");

           
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UB0HGLO;Initial Catalog=library_management;" +
              "Persist Security Info=True;User ID=admin;Password=login123");
            connect.Open();
            SqlCommand cmd = new SqlCommand("delete from  library_management_table1 where  Employee_ID like '% '" + txt_employeeid +"'%')", connect);

            MessageBox.Show("Data Deleted  Successfully ! ");
           int i = cmd.ExecuteNonQuery();
           if (i != 0)
           {
               MessageBox.Show("Data Deleted  Successfully ! ");
           }
  
           else
           {
               MessageBox.Show("ERROR ! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
