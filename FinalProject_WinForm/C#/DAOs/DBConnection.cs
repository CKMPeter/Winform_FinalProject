using FinalProject_WinForm.Properties;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProject_WinForm
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        FormEntry logIn = Program.logIn;
        public void Execute(string sqlStr, string action, SqlParameter[] parameters = null)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                // Add parameters if provided
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public List<User> LoadUser(string sqlStr, string action)
        {
            List<User> list = new List<User>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User tmp = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(5), reader.GetString(4), reader.GetInt32(6));
                    list.Add(tmp);
                }
                reader.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public List<Items> LoadItem(string sqlStr, string action)
        {
            List<Items> Loadlist = new List<Items>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string imagePath = "C:/Users/DELL/OneDrive/Pictures/logo.png";
                    //byte[] imageData = File.ReadAllBytes(imagePath);;
                    //Image image = ByteArrayToImage(imageData);
                    string[] imageList = new string[3];
                    imageList[0] = reader.GetString(4); // Assuming the image data is in column index 4
                    imageList[1] = reader.GetString(5); // Assuming the image data is in column index 5
                    imageList[2] = reader.GetString(6); // Assuming the image data is in column index 6

                    Items tmp = new Items(reader.GetString(0), reader.GetString(2), reader.GetInt32(1), reader.GetInt32(3), reader.GetString(9), imageList, reader.GetInt32(8), reader.GetInt32(7),reader.GetInt32(10), reader.GetInt32(11));
                    Loadlist.Add(tmp);

                }
                reader.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return Loadlist;
            
        }
    }
}
