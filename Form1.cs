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
    public partial class Form1 : Form
    {
        public static string host = "http://testred.ru";
        public static string login = "";
        public static string password = "";
        public Form1(string login, string password)
        {
            InitializeComponent();
            RM_2._0_old.Form1.login = login;
            RM_2._0_old.Form1.password = password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var redmine = new RedmineManager(host, login, password);
            //NameValueCollection parameters = new NameValueCollection();
            //IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);

            //using (StreamWriter sw = new StreamWriter(@"Проекты.txt", false, Encoding.Default, 10))
            //{
            //    foreach (var issue in allProjects)
            //    {
            //        Debug.WriteLine(issue.Name + " " + issue.Id);
            //        sw.Write(issue.Name + ";" + issue.Id);
            //        sw.Write("\n");
            //    }


            //    sw.Write(DateTime.Now.ToString());
            //}
            //Menu m = new Menu();


        }
    }
}
