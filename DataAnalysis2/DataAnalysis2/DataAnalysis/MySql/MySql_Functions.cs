using DataAnalysis.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace DataAnalysis.MySql
{
    public class MySql_Functions
    {
        public string connectoin_string = Connection_String.connectoin_string;

        public int login(string email, string pass)
        {
            string query = "SELECT Roli FROM users where Email = '" + email + "' and Pass = '" + pass + "';";

            MySqlConnection conn = new MySqlConnection(connectoin_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    return int.Parse(dr[0].ToString());
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
    }
}