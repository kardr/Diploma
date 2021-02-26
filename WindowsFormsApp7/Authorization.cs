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

namespace WindowsFormsApp7
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
           Registration r = new Registration();
            r.Show();
           
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBox_login.Text;
                string password = textBox_password.Text;
                Users u = new Users();
                int d = u.Authorization(login, password);
                if (d == 0)
                {
                    MessageBox.Show("Логин или пароль неверный.");
                }
                else
                {
                    Program.user_id = d;
                    Diploma f = new Diploma();
                    f.Show();
                    this.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
