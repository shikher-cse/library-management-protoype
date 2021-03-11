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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UB0HGLO;Initial Catalog=library_management;" +
                "Persist Security Info=True;User ID=admin;Password=login123");
            connect.Open();
            SqlCommand cmd = new SqlCommand("insert  into  library_management_table1(FullName,TeamName,Employee_ID,Department)" +
                "values('" + txt_fullname.Text + "','" + txt_teamname.Text + "','" + txt_employeeid.Text + "', '" + txt_department.Text+ "')", connect);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Data saved ");
            }
            else
            {
                MessageBox.Show("ERROR ! ");

            }    
            txt_department.Text = string.Empty;
            txt_employeeid.Text = string.Empty;
            txt_fullname.Text = string.Empty;
            txt_teamname.Text = string.Empty;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_department.Text = string.Empty;
            txt_employeeid.Text = string.Empty;
            txt_fullname.Text = string.Empty;
            txt_teamname.Text = string.Empty;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
