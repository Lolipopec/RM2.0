using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_2._0_old
{
    public partial class Просмотр_задач : Form
    {
        #region Переменные
        public static string host = "http://testred.ru";
        public  string login = "";
        public TimeEntry CurTimeEntry { get; set; }
        public  string password = "";
        public static string id;
        private Просмотр_задач DataCache = null;
        NameValueCollection parameters;
        #endregion

        public Просмотр_задач(string st,string login,string pass)
        {
            InitializeComponent();
            id = st;
            this.login = login;
            this.password = pass;
            fill();
        }


        public void fill()
        {
            RedmineManager redmine = new RedmineManager(host, login, password);
            //Наполнение трекеров (не работает)
            foreach (var c in redmine.GetTotalObjectList<Tracker>(parameters))
            {
                ComboBoxTracker.Items.Add(c.Name);
            }
            //наполнение сатусов
            foreach (var c in redmine.GetTotalObjectList<IssueStatus>(parameters))
            {
                ComboBoxStatus.Items.Add(c.Name);
            }
            //наполнение приоритетов
            foreach (var c in redmine.GetTotalObjectList<IssuePriority>(parameters))
            {
                ComboBoxPriority.Items.Add(c.Name);
            }
            
            NameValueCollection parameter = new NameValueCollection();
            RedmineManager manager = new RedmineManager(host, login, password);
            parameter.Add("issue_id", id);
            var Search = manager.GetTotalObjectList<Issue>(parameter);
            var CurTimeEntr = manager.GetTotalObjectList<TimeEntry>(parameter);
            foreach (var issue in Search)
            {

                this.Text = "Просмотр и редактирование задачи №" + issue.Id;
                tema.Text = issue.Subject;
                ComboBoxStatus.Text = issue.Status.Name;
                ComboBoxPriority.Text = issue.Priority.Name;
                ComboBoxTracker.Text = issue.Tracker.Name;
                DateStart.Value = issue.StartDate.Value;
                opisanie.Text = issue.Description;
                
                    try
                {
                    DateDue.Value = issue.DueDate.Value;
                }
                catch
                {
                    DateDue.Value = DateTime.Now.AddDays(1);
                }
            }
            decimal ZN = 0;
            foreach (var issue in CurTimeEntr)
            {
                ZN+= issue.Hours;
            }
            timeZN.Text = "Затраченное время " + " " + ZN.ToString() + " ч.";
        }


        private void Просмотр_задач_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxTracker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void timeZN_Click(object sender, EventArgs e)
        {
            try
            {
                Затрченное_время dlg = new Затрченное_время(id,login,password);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
