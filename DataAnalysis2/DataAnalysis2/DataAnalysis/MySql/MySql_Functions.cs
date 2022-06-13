using DataAnalysis.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Label = System.Web.UI.WebControls.Label;

namespace DataAnalysis.MySql
{
    public class MySql_Functions
    {
        public string connectoin_string = Connection_String.connectoin_string;

        public List<User_Details> login(string email, string pass)
        {
            string query = "SELECT ID, Roli FROM users where Email = '" + email + "' and Pass = '" + pass + "';";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            List<User_Details> user_list = new List<User_Details>();
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    User_Details user_Details = new User_Details();
                    user_Details.ID = int.Parse(dr[0].ToString());
                    user_Details.Role = int.Parse(dr[1].ToString());

                    user_list.Add(user_Details);

                    conn.Close();
                    return user_list;
                }
                else
                {
                    User_Details user_Details = new User_Details();
                    user_Details.ID = -1;
                    user_Details.Role = -1;

                    user_list.Add(user_Details);

                    conn.Close();
                    return user_list;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                //MessageBox.Show(ex.ToString());
                return user_list;
            }
        }


        public int insert_new_student(string email, string pass)
        {
            string querry = "INSERT INTO users (Email, Pass, Roli) VALUES ('" + email + "', '" + pass + "', 2);";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(querry, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                conn.Close();
                return -1;
            }
        }

        public int update_student(string email, string pass)
        {
            string querry = "UPDATE users SET Pass = '" + pass + "' WHERE Email = '" + email + "';";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(querry, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                conn.Close();
                return -1;
            }
        }

        public int delete_student(string email)
        {
            string querry = "DELETE FROM users WHERE Email = '" + email + "';";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(querry, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                conn.Close();
                return -1;
            }
        }
        public ArrayList getAllStudents()
        {
            ArrayList students = new ArrayList();

            string query = "SELECT ID, Email FROM users where Roli = 2;";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Students s = new Students();
                    s.ID = int.Parse(dr[0].ToString());
                    s.Email = dr[1].ToString();

                    students.Add(s);

                }

                conn.Close();
                return students;
            }
            catch (Exception ex)
            {
                conn.Close();
                //MessageBox.Show(ex.ToString());
                return students;
            }
        }

        public int get_student_ID(string email)
        {
            int student_ID = 0;

            string query = "SELECT ID FROM users where Email = '" + email + "';";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    student_ID = int.Parse(dr[0].ToString());
                }

                conn.Close();
                return student_ID;
            }
            catch (Exception ex)
            {
                conn.Close();
                //MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public int insert_grade_per_student(int student_id, string class_name, int grade_id)
        {
            string querry = "INSERT INTO grades (Student_ID, Class_Name, Grade_ID) VALUES (" + student_id + ", '" + class_name + "', " + grade_id + ");";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(querry, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                conn.Close();
                return -1;
            }
        }

        public int show_grades_per_student(int student_id, GridView gridView)
        {
            string query = "SELECT grades.Class_Name as 'Class Name', grade_types.Name as Grade, grade_types.Weight FROM grade_types INNER JOIN grades on grade_types.ID = grades.Grade_ID WHERE grades.Student_ID = " + student_id + ";";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    gridView.DataSource = dr;
                    gridView.DataBind();
                }

                conn.Close();
                return -1;
            }
            catch (Exception ex)
            {
                conn.Close();
                //MessageBox.Show(ex.ToString());
                return -2;
            }
        }

        public int show_cgpa_per_student(int student_id, Label label)
        {
            string query = "SELECT grade_types.Weight FROM grade_types INNER JOIN grades on grade_types.ID = grades.Grade_ID WHERE grades.Student_ID = " + student_id + ";";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                double total_credits = 0;
                double grades = 0;

                while (dr.Read())
                {
                    total_credits = total_credits + double.Parse(dr[0].ToString());
                    grades++;
                }

                double cgpa = total_credits / grades;
                label.Text = "Your CGPA is: " + cgpa.ToString();


                conn.Close();
                return -1;
            }
            catch (Exception ex)
            {
                conn.Close();
                //MessageBox.Show(ex.ToString());
                return -2;
            }
        }
    }
}