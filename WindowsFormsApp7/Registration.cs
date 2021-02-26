using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string surname = textBox_surname.Text.Trim();
            string firstname = textBox_firstname.Text.Trim();
            string patronymic = textBox_patronymic.Text.Trim();
            string login = textBox_login.Text.Trim();
            string password = textBox_password.Text.Trim();
            string password2 = textBox_password2.Text.Trim();

            if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            {
                Users u = new Users();
                u.Registration(surname, firstname, patronymic, login, password);
                MessageBox.Show("Регестрация прошла успешно!");
                this.Close();
            }
        }
    }
}
