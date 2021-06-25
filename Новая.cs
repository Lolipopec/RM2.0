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
//using Redmine.Client.Languages;
//using Redmine.Client.Properties;
namespace RM_2._0_old
{
    public partial class Новая : Form
    {
        public static string host = "http://testred.ru";
        public static string login = "";
        public static string password = "";
        public int projectId=0;
        public Новая(string login, string password)
        {
            InitializeComponent();
            RM_2._0_old.Новая.login = login;
            RM_2._0_old.Новая.password = password;
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
            var redmine = new RedmineManager(host, login, password);
            var parameters = new NameValueCollection();
            IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
            if (comboBoxПроекты.SelectedItem.ToString().Contains("ЕСА") == true)
            {
            }
            if (comboBoxПроекты.SelectedItem.ToString().Contains("ЦСС") == true)
            {
                panelЦСС.Visible = true;
                panelЕСА.Visible = false;
            }
        }

        private void buttonСоздатьЗадачуЦСС_Click(object sender, EventArgs e)
        {
            try 
            {
                var redmine = new RedmineManager(host, login, password);
                var parameters = new NameValueCollection();
                IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
                foreach (var c in redmine.GetTotalObjectList<Project>(parameters))
                {
                    if (comboBoxПроекты.SelectedItem.ToString() == c.Name)
                    {
                        projectId = c.Id;
                        break;
                    }
                }
                User user = redmine.GetCurrentUser();
                //IssueCustomField customField = new IssueCustomField();
                //customField.Id = 1;
                //customField.Multiple = true;
                CustomField customField = new CustomField { Id=1,Multiple=true};
                Issue redminetask = new Issue()
                {
                    AssignedTo = new IdentifiableName() { Id = user.Id }, // Кому отправить
                    Author = new IdentifiableName() { Id = user.Id },     // Автор задачи 
                    Subject = "ЛРП " + textBoxНомерЦСС.Text + " " + comboBoxМодульЦСС.Text + " " + textBoxОписание.Text, // Название задачи
                    Description = textBoxВыполненныеДействияЦСС.Text,     // Описание задачи
                    Project = new IdentifiableName { Id = projectId },      // Проект
                    CreatedOn = DateTime.Now,                         // Дата создание
                    DueDate = DateTime.Now,                          // Дата окончания
                    Tracker = new IdentifiableName { Id = 4 },        // Трекер
                    Status = new IdentifiableName { Id = 5 },         // Статус. По умолчанию NEW
                    Priority = new IdentifiableName { Id = 2 },       // Приоритет. По умолчанию Normal
                    //CustomFields = 
                };
                Issue savedIssue = redmine.CreateObject(redminetask);
                MessageBox.Show("Созданна задача: " + savedIssue.Id);
            }
            catch (Exception c)
            { MessageBox.Show(c.Message); }
        }
    }
}
