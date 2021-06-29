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
using System.Linq;
using System.Collections;
//using Redmine.Client.Languages;
//using Redmine.Client.Properties;
namespace RM_2._0_old
{
    public partial class Новая : Form
    {
        //public static string host = "http://testred.ru";
        public static string host = "http://192.168.100.74/";
        public static string login = "vlasov_pa";
        public static string password = "9Ai3dxUL";
        //public static string login = "";
        //public static string password = "";
        public int projectId=0;
        class ClientCustomField
        {
            public String Name { get; set; }
            public String Value { get; set; }
        };
        public Новая(string login, string password)
        {
            InitializeComponent();
            //RM_2._0_old.Новая.login = login;
            //RM_2._0_old.Новая.password = password;
            login = "vlasov_pa";
            password = "9Ai3dxUL";
            var redmine = new RedmineManager(host, login, password);
            var parameters = new NameValueCollection();
            IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
            foreach (var c in allProjects.Distinct())
            {
                comboBoxПроекты.Items.Add(c.Name);
            }
            comboBoxКаналЦСС.Items.Add("Форум");
            comboBoxМодульЦСС.Items.Add("TRS Manager");
        }
        private void comboBoxПроекты_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var redmine = new RedmineManager(host, login, password);
            //var parameters = new NameValueCollection();
            //IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
            //if (comboBoxПроекты.SelectedItem.ToString().Contains("ЕСА") == true)
            //{
            //    panelЦСС.Visible = false;
            //    panelЕСА.Visible = true;
            //}
            //if (comboBoxПроекты.SelectedItem.ToString().Contains("ЦСС") == true)
            //{
            //    panelЦСС.Visible = true;
            //    panelЕСА.Visible = false;
            //}
            //NameValueCollection parameterref2 = new NameValueCollection();
            //parameterref2.Add("issue_id", "107668");
            //parameterref2.Add("project_id", "56");
            //RedmineManager manager = new RedmineManager(host, login, password);
            //int i = 0;
            //foreach (var issue in manager.GetTotalObjectList<Issue>(parameterref2))
            //{
            //    Debug.WriteLine(issue.Tracker);
            //}

        }

        private void buttonСоздатьЗадачуЦСС_Click(object sender, EventArgs e)
        {
            try 
            {
                var redmine = new RedmineManager(host, login, password);
                redmine.ImpersonateUser = login;
                var parameters = new NameValueCollection();
                IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
                foreach (var c1 in redmine.GetTotalObjectList<Project>(parameters))
                {
                    if (comboBoxПроекты.SelectedItem.ToString() == c1.Name)
                    {
                        projectId = c1.Id;
                        Debug.WriteLine(c1.Id);
                        break;
                    }
                }
                
                User user = redmine.GetCurrentUser();
                IssueCustomField cf = new IssueCustomField();
                IList<IssueCustomField> c = new List<IssueCustomField>();
                CustomFieldValue cfv = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv = new List<CustomFieldValue>();
                cfv.Info = "ЕСМА. Центр"; 
                Lcfv.Add(cfv);
                cf.Id = 6;
                cf.Values = Lcfv;
                c.Add(cf);
                Issue redminetask = new Issue()
                {
                    AssignedTo = new IdentifiableName() { Id = user.Id }, // Кому отправить
                    Author = new IdentifiableName() { Id = user.Id },     // Автор задачи 
                    Subject = "ЛРП " + textBoxНомерЦСС.Text + " " + comboBoxМодульЦСС.Text + " " + textBoxОписание.Text, // Название задачи
                    Description = textBoxВыполненныеДействияЦСС.Text,     // Описание задачи
                    Project = new IdentifiableName { Id = projectId },      // Проект
                    CreatedOn = DateTime.Now,                         // Дата создание
                    DueDate = DateTime.Now,                          // Дата окончания
                    Tracker = new IdentifiableName { Id = 9 },        // Трекер
                    Status = new IdentifiableName { Id = 1 },         // Статус. По умолчанию NEW
                    Priority = new IdentifiableName { Id = 1 },       // Приоритет. По умолчанию Normal
                    //CustomFields = c,                                 // Кастомные поля (вставляем лист с заполнением кастомных полей)
                    IsPrivate = false,                                //Параметр приватности
                };
                Issue savedIssue = redmine.CreateObject(redminetask);
                MessageBox.Show("Созданна задача: " + savedIssue.Id);
                //var manager = new RedmineManager(host, login, password);
                //manager.ImpersonateUser = login;
                //var issue = manager.GetObject<Issue>("35", null);
                //issue.IsPrivate = false;
                //issue.SpentHours = 2;
                //manager.UpdateObject("35", issue);
                //var updatedIssue = manager.GetObject<Issue> ("35", null);
                //MessageBox.Show("Updated issue:" +updatedIssue.Id);
            }
            catch (Exception c)
            { MessageBox.Show(c.Message); }
        }

        private void Новая_Load(object sender, EventArgs e)
        {

        }

        private void buttonСоздатьЗадачуЕСА_Click(object sender, EventArgs e)
        {

        }
    }
}
