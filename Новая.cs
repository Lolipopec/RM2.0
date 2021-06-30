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
        public static string host = "http://testred.ru";
        //public static string host = "http://192.168.100.74/";
        public static string login = "";
        public static string password = "";
        public int projectId=0;
        class ClientCustomField
        {
            public String Name { get; set; }
            public String Value { get; set; }
        };
        public Новая(string login, string password)
        {
            InitializeComponent();
           
            //login = "vlasov_pa";
            //password = "9Ai3dxUL";
            login = "user1";
            password = "12345678";
             RM_2._0_old.Новая.login = login;
            RM_2._0_old.Новая.password = password;
            var redmine = new RedmineManager(host, login, password);
            var parameters = new NameValueCollection();
            IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
            foreach (var c in allProjects.Distinct())
            {
                comboBoxПроекты.Items.Add(c.Name);
            }
            comboBoxМодульЦСС.Items.Add("TRS Manager");
        }
        private void comboBoxПроекты_SelectedIndexChanged(object sender, EventArgs e)
        {
            var redmine = new RedmineManager(host, login, password);
            var parameters = new NameValueCollection();
            int projectId = 0;
            foreach (var c in redmine.GetTotalObjectList<Project>(parameters))
            {
                if (comboBoxПроекты.SelectedItem.ToString() == c.Name)
                {
                    projectId = c.Id;
                    break;
                }
                else
                    projectId = 0;
            }
            if (comboBoxПроекты.SelectedItem.ToString().Contains("ЕСА") == true)
            {
                panelЦСС.Visible = false;
                panelЕСА.Visible = true;

            }
            if (comboBoxПроекты.SelectedItem.ToString().Contains("ЦСС") == true)
            {
                panelЦСС.Visible = true;
                panelЕСА.Visible = false;

                parameters.Add("project_id", projectId.ToString());
                var allProjects = redmine.GetTotalObjectList<CustomField>(parameters);
                foreach (var c in allProjects)
                {
                        Debug.WriteLine(c.Id);
                        Debug.WriteLine(c.Name);
                        foreach (var ccc in c.PossibleValues)
                        {
                            Debug.WriteLine(ccc.Value);
                        }
                }
            }
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
                        break;
                    }
                }
                
                User user = redmine.GetCurrentUser();
                IList<IssueCustomField> c = new List<IssueCustomField>();
                IssueCustomField cf = new IssueCustomField();
                CustomFieldValue cfv = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv = new List<CustomFieldValue>();
                IssueCustomField cf2 = new IssueCustomField();
                CustomFieldValue cfv2 = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv2 = new List<CustomFieldValue>();
                IssueCustomField cf3 = new IssueCustomField();
                CustomFieldValue cfv3 = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv3 = new List<CustomFieldValue>();
                cfv2.Info = "ЦСС";
                cfv.Info = "ЕСМА. Центр";
                cfv3.Info = user.Id.ToString(); 
                Lcfv.Add(cfv);
                Lcfv2.Add(cfv2);
                Lcfv3.Add(cfv3);
                cf.Id = 6;
                cf2.Id = 7;
                cf3.Id = 8;
                cf.Values = Lcfv;
                cf2.Values = Lcfv2;
                cf3.Values = Lcfv3;
                c.Add(cf);
                c.Add(cf2);
                c.Add(cf3);
                Issue redminetask = new Issue()
                {
                    AssignedTo = new IdentifiableName() { Id = user.Id }, // Кому отправить
                    Author = new IdentifiableName() { Id = user.Id },     // Автор задачи 
                    Subject = "ЛРП " + textBoxНомерЦСС.Text + " " + comboBoxМодульЦСС.Text, // Название задачи
                    Description = textBoxОписание.Text,     // Описание задачи
                    Project = new IdentifiableName { Id = projectId },      // Проект
                    CreatedOn = DateTime.Now,                         // Дата создание
                    DueDate = DateTime.Now,                          // Дата окончания
                    Tracker = new IdentifiableName { Id = 4 },        // Трекер
                    Status = new IdentifiableName { Id = 3 },         // Статус. По умолчанию NEW
                    Priority = new IdentifiableName { Id = 1 },       // Приоритет. По умолчанию Normal
                    CustomFields = c,                                 // Кастомные поля (вставляем лист с заполнением кастомных полей)
                    IsPrivate = false,                                //Параметр приватности
                    Category = new IdentifiableName { Id = 1 },
                };
                Issue savedIssue = redmine.CreateObject(redminetask);
                MessageBox.Show("Созданна задача: " + savedIssue.Id);
                //var manager = new RedmineManager(host, login, password);
                //manager.ImpersonateUser = login;
                //var issue = manager.GetObject<Issue>(savedIssue.Id.ToString(), null);
                //issue.IsPrivate = ;
                //User user1 = manager.GetCurrentUser();
                //issue.Author = new IdentifiableName() { Id = user1.Id };
                //manager.UpdateObject(savedIssue.Id.ToString(), issue);
                //var updatedIssue = manager.GetObject<Issue>(savedIssue.Id.ToString(), null);
                //MessageBox.Show("Updated issue:" + updatedIssue.Id);
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
