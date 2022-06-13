using DataAnalysis.Models;
using DataAnalysis.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataAnalysis
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySql_Functions mySql_Functions = new MySql_Functions();
            mySql_Functions.show_grades_per_student(int.Parse(Session["User_ID"].ToString()), GridView1);
            mySql_Functions.show_cgpa_per_student(int.Parse(Session["User_ID"].ToString()), cgpa_label);
        }
        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}