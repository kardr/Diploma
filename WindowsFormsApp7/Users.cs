using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    class Users
    {
        static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Diploma;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        public int Authorization(string login, string password)
        {
            int k = 0;
            conn.Open();
            string d = "SELECT * FROM Users WHERE login = '"+login+"' and password='"+password+"'";
            SqlCommand command = new SqlCommand(d, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                k = Convert.ToInt32(reader.GetValue(0));
            }
            conn.Close();
            return k;
        }

        public void Registration(string surname, string firstname, string patronymic, string login, string password)
        {
            conn.Open();
            string d = "SELECT * FROM Users_id WHERE [key] = 'user_count'";
            SqlCommand command = new SqlCommand(d, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int count_id = Convert.ToInt32(reader.GetValue(0)) + 1;
            conn.Close();
            conn.Open();
            string z = "INSERT INTO Users([id],[Surname],[Firstname],[Patronymic],[login],[password])" +
                " VALUES ("+count_id+",'"+surname+"','"+firstname+ "','"+patronymic+ "','"+login+ "','"+password+"')";
            SqlCommand command2 = new SqlCommand(z, conn);
            command2.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            string s = "UPDATE Users_id SET count = '"+count_id+"' WHERE [key] = 'user_count' ";
            SqlCommand command3 = new SqlCommand(s, conn);
            command3.ExecuteNonQuery();
            conn.Close();
        }
    }
}
