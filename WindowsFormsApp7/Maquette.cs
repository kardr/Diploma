using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    class Maquette
    {
        static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Diploma;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        public void Insert(string name_maquette, string name_file, int user_id)
        {
            conn.Open();
            string d = "SELECT * FROM Users_id WHERE [key] = 'maquette_count'";
            SqlCommand command = new SqlCommand(d, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int count_id = Convert.ToInt32(reader.GetValue(0)) + 1;
            conn.Close();

            conn.Open();
            string z = "INSERT INTO Maquette([id],[Name_maquette],[Name_file], [User_id_fk])" +
                " VALUES ("+count_id+",'"+ name_maquette + "','"+ name_file + "',"+ user_id + ")";
            SqlCommand command2 = new SqlCommand(z, conn);
            command2.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            string s = "UPDATE Users_id SET count = '" + count_id + "' WHERE [key] = 'maquette_count' ";
            SqlCommand command3 = new SqlCommand(s, conn);
            command3.ExecuteNonQuery();
            conn.Close();
        }
    }
}
