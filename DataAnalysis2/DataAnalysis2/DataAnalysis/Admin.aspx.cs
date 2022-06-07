using DataAnalysis.Models;
using DataAnalysis.MySql;
using System;
using System.Collections;
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
            if (!IsPostBack == false)
            {
                EmailHiddenField.Value = DropDownList1.SelectedValue.ToString();
                GradeHiddenField.Value = DropDownList2.SelectedValue.ToString();
            }

            if (!IsPostBack == true)
            {
                ArrayList students = new ArrayList();
                MySql_Functions functions = new MySql_Functions();
                students = functions.getAllStudents();

                for (int i = 0; i < students.Count; i++)
                {
                    Students s = new Students();
                    s = (Students)students[i];

                    DropDownList1.Items.Add(s.Email);
                }
            }
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextbox.Text) == false)
            {
                if (string.IsNullOrEmpty(PasswordTextbox.Text) == false)
                {
                    MySql_Functions functions = new MySql_Functions();
                    int student = functions.insert_new_student(EmailTextbox.Text, PasswordTextbox.Text);

                    if (student == 1)
                    {
                        MessageBox.Show("Insert Succes!");
                    }
                    else
                    {
                        MessageBox.Show("An error occured, contact the IT!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Password!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Email!");
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextbox.Text) == false)
            {
                if (string.IsNullOrEmpty(PasswordTextbox.Text) == false)
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
                else
                {
                    MessageBox.Show("Please Fill Password!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Email!");
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextbox.Text) == false)
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
            else
            {
                MessageBox.Show("Please Fill Email!");
            }
        }

        protected void AddGradeButton_Click(object sender, EventArgs e)
        {
            string email = EmailHiddenField.Value;
            int grade_weight_id = int.Parse(GradeHiddenField.Value);
            string class_name = ClassNameTextBox.Text;

            MySql_Functions functions = new MySql_Functions();
            int student_id = functions.get_student_ID(email);

            int insert_id = functions.insert_grade_per_student(student_id, class_name, grade_weight_id);

            if(insert_id == 1)
            {
                MessageBox.Show("Grade Added Succesfully!");
            }
            else
            {
                MessageBox.Show("An Erro Occured, please contact the IT!");
            }

        }
    }
}