using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;

namespace RM_2._0_old
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            LoginTXT.Focus();
            LoginTXT.Text = "user1";
            PasswordTXT.Text = "12345678";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Login");
                var host = "http://testred.ru";
                var login = LoginTXT.Text;
                var password = PasswordTXT.Text;
                var a = new RedmineManager(host, login, password);
                User currentUser = a.GetCurrentUser();
                //Debug.WriteLine("Current user: {0}.", currentUser.Id);
                Menu f  = new Menu(login, password);
                f.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }
        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
    }
}
