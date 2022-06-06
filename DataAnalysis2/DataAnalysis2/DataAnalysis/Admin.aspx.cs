using DataAnalysis.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DataAnalysis
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            MySql_Functions functions = new MySql_Functions();
            int student = functions.insert_new_student(EmailTextbox.Text, PasswordTextbox.Text);

            if(student == 1)
            {
                MessageBox.Show("Insert Succes!");
            }
            else
            {
                MessageBox.Show("An error occured, contact the IT!");
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            MySql_Functions functions = new MySql_Functions();
            int student = functions.update_student(EmailTextbox.Text, PasswordTextbox.Text);

            if (student == 1)
            {
                MessageBox.Show("Update Succes!");
            }
            else
            {
                MessageBox.Show("An error occured, contact the IT!");
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            MySql_Functions functions = new MySql_Functions();
            int student = functions.delete_student(EmailTextbox.Text);

            if (student == 1)
            {
                MessageBox.Show("Delete Succes!");
            }
            else
            {
                MessageBox.Show("An error occured, contact the IT!");
            }
        }
    }
}