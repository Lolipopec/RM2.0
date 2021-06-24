using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System.Diagnostics;
using System.IO;
using System.Text;
//using Redmine.Client.Languages;
//using Redmine.Client.Properties;
namespace RM_2._0_old
{
    public partial class Новая : Form
    {
        public static string host = "http://testred.ru";
        public static string login = "";
        public static string password = "";
        public Новая(string login, string password)
        {
            InitializeComponent();
            RM_2._0_old.Новая.login = login;
            RM_2._0_old.Новая.password = password;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
