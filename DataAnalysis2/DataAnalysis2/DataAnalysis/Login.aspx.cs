using DataAnalysis.Models;
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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_TextBox.Text) == false)
            {
                if (string.IsNullOrEmpty(password_TextBox.Text) == false)
                {
                    MySql_Functions functions = new MySql_Functions();

                    List<User_Details> user_list = functions.login(email_TextBox.Text, password_TextBox.Text);
                    if (user_list != null)
                    {
                        User_Details user = new User_Details();
                        user = user_list[0];

                        if (user.Role == 1)
                        {
                            Session["User_ID"] = user.ID;
                            Response.Redirect("Admin.aspx");
                            //MessageBox.Show("Welcome Admin!");
                        }
                        else if (user.Role == 2)
                        {
                            Session["User_ID"] = user.ID;
                            Response.Redirect("Student.aspx");
                            //MessageBox.Show("Welcome Student!");
                        }
                        else if (user.Role == -1)
                        {
                            MessageBox.Show("Check Email and Password!");
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("An error occured, contact the IT!");
                    }
                }
                else
                {
                    MessageBox.Show("PLease Fill Password!");
                }
            }
            else
            {
                MessageBox.Show("PLease Fill Email!");
            }
        }
    }
}