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
        public bool flagbutton = false;
        public static string host = "http://testred.ru";
        //public static string host = "http://192.168.100.74/";
        public static string login = "";
        public static string password = "";
        public TimeEntry CurTimeEntry { get; set; }
        public int projectId=0;
        class ClientCustomField
        {
            public String Name { get; set; }
            public String Value { get; set; }
        };
        public Новая(string login, string password)
        {
            try {
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
                comboBoxМодульЦСС.Items.Add("ГТП");
                comboBoxМодульЦСС.Items.Add("Форум ЕСМА");
                comboBoxМодульЦСС.Items.Add("АСИА");
                comboBoxМодульЦСС.Items.Add("Моб.ЕСМА");
                comboBoxМодульЦСС.Items.Add("АГО-5");
                comboBoxМодульЦСС.Items.Add("УРРАН");
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void comboBoxПроекты_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
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
                flagbutton = true;
                comboBoxАктивностьЕСА.Items.Clear();
                comboBoxКаналЕСА.Items.Clear();
                panelЦСС.Visible = false;
                panelЕСА.Visible = true;
                parameters.Add("project_id", projectId.ToString());
                var allProjects = redmine.GetTotalObjectList<CustomField>(parameters);
                foreach (var c in allProjects)
                {
                    if (c.Name == "Источник информации")
                        foreach (var ccc in c.PossibleValues)
                        {
                            comboBoxКаналЕСА.Items.Add(ccc.Value);
                        }
                    if (c.Name == "Активность")
                        foreach (var ccc in c.PossibleValues)
                        {
                            comboBoxАктивностьЕСА.Items.Add(ccc.Value);
                        }
                }
            }
            if (comboBoxПроекты.SelectedItem.ToString().Contains("ЦСС") == true)
            {
                comboBoxКаналЦСС.Items.Clear();
                comboBoxАктивностьЦСС.Items.Clear();
                flagbutton = false;
                panelЦСС.Visible = true;
                panelЕСА.Visible = false;
                parameters.Add("project_id", projectId.ToString());
                var allProjects = redmine.GetTotalObjectList<CustomField>(parameters);
                foreach (var c in allProjects)
                {
                    if (c.Name == "Источник информации")
                        foreach (var ccc in c.PossibleValues)
                        {
                            comboBoxКаналЦСС.Items.Add(ccc.Value);
                        }
                    if (c.Name == "Активность")
                        foreach (var ccc in c.PossibleValues)
                        {
                            comboBoxАктивностьЦСС.Items.Add(ccc.Value);
                        }
                }
            }
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        public void СоздатьЗадачуЦСС()
        {
            try { 
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
                IssueCustomField cf4 = new IssueCustomField();
                CustomFieldValue cfv4 = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv4 = new List<CustomFieldValue>();
                cfv2.Info = comboBoxАктивностьЦСС.Text;
                cfv.Info = "ЕСМА. Центр";
                cfv3.Info = user.Id.ToString();
                cfv4.Info = comboBoxКаналЦСС.Text;
                Lcfv.Add(cfv);
                Lcfv2.Add(cfv2);
                Lcfv3.Add(cfv3);
                Lcfv4.Add(cfv4);
                cf.Id = 6;
                cf2.Id = 7;
                cf3.Id = 8;
                cf4.Id = 9;
                cf.Values = Lcfv;
                cf2.Values = Lcfv2;
                cf3.Values = Lcfv3;
                cf4.Values = Lcfv4;
                c.Add(cf);
                c.Add(cf2);
                c.Add(cf3);
                c.Add(cf4);
                Issue redminetask = new Issue()
                {
                    AssignedTo = new IdentifiableName() { Id = user.Id }, // Кому отправить
                    Author = new IdentifiableName() { Id = user.Id },     // Автор задачи 
                    Subject = "ЛРП " + textBoxНомерЦСС.Text + " " + comboBoxМодульЦСС.Text, // Название задачи
                    Description = textBoxОписание.Text,     // Описание задачи
                    Project = new IdentifiableName { Id = projectId },      // Проект
                    CreatedOn = DateTime.Now,                         // Дата создание
                    DueDate = DateTime.Now,                           // Дата окончания
                    Tracker = new IdentifiableName { Id = 4 },        // Трекер
                    Status = new IdentifiableName { Id = 3 },         // Статус. По умолчанию NEW
                    Priority = new IdentifiableName { Id = 1 },       // Приоритет. По умолчанию Normal
                    CustomFields = c,                                 // Кастомные поля (вставляем лист с заполнением кастомных полей)
                    IsPrivate = false,                                //Параметр приватности
                    Category = new IdentifiableName { Id = 1 },
                };
                Issue savedIssue = redmine.CreateObject(redminetask);
                CurTimeEntry = new TimeEntry();
                CurTimeEntry.Issue = new IdentifiableName() { Id = savedIssue.Id };
                
                CurTimeEntry.SpentOn = DateTime.Parse(dateTimePickerЦСС.Value.ToString("yyyy-MM-dd"));
                CurTimeEntry.User = new IdentifiableName() { Id = user.Id };
                //CurTimeEntry.Activity = new IdentifiableName() { Id = 10 };
                CurTimeEntry.Hours = decimal.Parse(textBoxЗатраченноеВремяЦСС.Text);
                CurTimeEntry.Comments = textBoxВыполненныеДействияЦСС.Text;
                redmine.CreateObject(CurTimeEntry);
                MessageBox.Show("Созданна задача: " + savedIssue.Id + " и списано " + CurTimeEntry.Hours);
                }
            catch (Exception c)
            { MessageBox.Show(c.Message); }
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void Новая_Load(object sender, EventArgs e)
        {

        }

        public void СоздатьЗадачуЕСА()
        {
            try { 
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
                IssueCustomField cf2 = new IssueCustomField();
                CustomFieldValue cfv2 = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv2 = new List<CustomFieldValue>();
                IssueCustomField cf3 = new IssueCustomField();
                CustomFieldValue cfv3 = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv3 = new List<CustomFieldValue>();
                IssueCustomField cf4 = new IssueCustomField();
                CustomFieldValue cfv4 = new CustomFieldValue();
                IList<CustomFieldValue> Lcfv4 = new List<CustomFieldValue>();
                cfv2.Info = comboBoxАктивностьЕСА.Text;
                cfv3.Info = user.Id.ToString();
                cfv4.Info = comboBoxКаналЕСА.Text;
                Lcfv2.Add(cfv2);
                Lcfv3.Add(cfv3);
                Lcfv4.Add(cfv4);
                cf2.Id = 7;
                cf3.Id = 8;
                cf4.Id = 9;
                cf2.Values = Lcfv2;
                cf3.Values = Lcfv3;
                cf4.Values = Lcfv4;
                c.Add(cf2);
                c.Add(cf3);
                c.Add(cf4);
                Issue redminetask = new Issue()
                {
                    AssignedTo = new IdentifiableName() { Id = user.Id }, // Кому отправить
                    Author = new IdentifiableName() { Id = user.Id },     // Автор задачи 
                    Subject = textBoxТема.Text, // Название задачи
                    Description = textBoxОписаниеЕСА.Text,     // Описание задачи
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
                
                CurTimeEntry = new TimeEntry();
                CurTimeEntry.Issue = new IdentifiableName() { Id = savedIssue.Id };
                CurTimeEntry.SpentOn = DateTime.Parse(dateTimePickerЕСА.Value.ToString("yyyy-MM-dd")); ;
                CurTimeEntry.User = new IdentifiableName() { Id = user.Id };
                //CurTimeEntry.Activity = new IdentifiableName() { Id = 10 };
                CurTimeEntry.Hours = decimal.Parse(textBoxЗатраченноеВремяЕСА.Text);
                CurTimeEntry.Comments = textBoxВыполненныеДействияЕСА.Text;
                redmine.CreateObject(CurTimeEntry);
                MessageBox.Show("Созданна задача: " + savedIssue.Id + " и списано "+ CurTimeEntry.Hours);


            }
            catch (Exception c)
            { MessageBox.Show(c.Message); }
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagbutton == false)
                {
                    СоздатьЗадачуЦСС();
                }
                else
                { СоздатьЗадачуЕСА(); }
            }
            catch { MessageBox.Show("Ошибка"); }
        }
    }
}
