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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_2._0_old
{
    public partial class Menu : Form
    {
        #region Что-то возможно важное
        public class Filter : ICloneable
        {
            public int TrackerId = 0;
            public int StatusId = 0;
            public int PriorityId = 0;
            public string Subject = "";
            public int AssignedToId = 0;
            public int VersionId = 0;
            public int CategoryId = 0;

            #region ICloneable Members

            public object Clone()
            {
                return new Filter { TrackerId = TrackerId, StatusId = StatusId, PriorityId = PriorityId, Subject = Subject, AssignedToId = AssignedToId, VersionId = VersionId, CategoryId = CategoryId };
            }

            #endregion
        }

        #endregion
        #region Переменные

        RedmineManager redmine;
        NameValueCollection parameters;
        private int projectId = 0;
        private int statusId = 0;
        private int priorID = 0;
        public static string host = "http://testred.ru";
        public static string login = "";
        //  IList<Project> allProjects;
        public static string password = "";
        #endregion


        //   private Dictionary<int, Project> Projects;
        public Menu(string l, string p)
        {
            InitializeComponent();
            RM_2._0_old.Menu.login = l;
            RM_2._0_old.Menu.password = p;

            redmine = new RedmineManager(host, login, password);
            parameters = new NameValueCollection();
            Fill();
            userToolStripMenuItem.Text = l;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        /// <summary>
        /// определение id 
        /// </summary>
        /// <returns></returns>
        public void idsearch()
        {
            parameters = new NameValueCollection();
            //для проектов
            foreach (var c in redmine.GetTotalObjectList<Project>(parameters))
            {
                if (comboProject.SelectedItem.ToString() == c.Name)
                {
                    projectId = c.Id;
                    break;
                }
                else
                    projectId = 0;
            }
            //для статусов
            foreach (var c in redmine.GetTotalObjectList<IssueStatus>(parameters))
            {
                if (comboStatus.SelectedItem.ToString() == c.Name)
                {
                    statusId = c.Id;
                    break;
                }
                else
                    statusId = 0;
            }
            //для приоритета
            foreach (var c in redmine.GetTotalObjectList<IssuePriority>(parameters))
            {
                if (comboPrior.SelectedItem.ToString() == c.Name)
                {
                    priorID = c.Id;
                    break;
                }
                else
                    priorID = 0;
            }
            RefReshFill();
        }

        /// <summary>
        /// наполнение формы
        /// </summary>
        public void Fill()
        {
            //Наполнение проектов
            IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
            foreach (var c in allProjects.Distinct())
            {
                comboProject.Items.Add(c.Name);
            }
            //наполнение сатусов
            foreach (var c in redmine.GetTotalObjectList<IssueStatus>(parameters))
            {
                comboStatus.Items.Add(c.Name);
            }
            //наполнение приоритетов
            foreach (var c in redmine.GetTotalObjectList<IssuePriority>(parameters))
            {
                comboPrior.Items.Add(c.Name);
            }

            //наполнение datagrid
            NameValueCollection parameter = new NameValueCollection();
            parameter.Add("status_id", "open");
            parameter.Add("assigned_to_id", "me");
            parameter.Add("project", "*");
            RedmineManager manager = new RedmineManager(host, login, password);
            int i = 0;

            foreach (var issue in manager.GetTotalObjectList<Issue>(parameters))
            {
                //Debug.WriteLine(issue.CustomFields.);
                //foreach (var c in issue.CustomFields.Distinct())
                //{
                //    Debug.WriteLine(c.Id+" "+c.Name+" "+c.Multiple);
                //}
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                i++;
            }
        }
        Issue redminetask = new Issue()
        {
            AssignedTo = new IdentifiableName() { Id = 1 }, // Кому отправить
            Author = new IdentifiableName() { Id = 1 },     // Автор задачи 
            Subject = "ТЕСТ",                                 // Название задачи
            Description = "Описание для тестовой задачи",     // Описание задачи
            Project = new IdentifiableName { Id = 1 },      // Проект
            CreatedOn = DateTime.Now,                         // Дата создание
            DueDate = DateTime.Now,                          // Дата окончания
            Tracker = new IdentifiableName { Id = 1 },        // Трекер
            Status = new IdentifiableName { Id = 1 },         // Статус. По умолчанию NEW
            Priority = new IdentifiableName { Id = 4 },       // Приоритет. По умолчанию Normal
            EstimatedHours = (float?)1.0,                     // Оценка времени
            Watchers = new List<Watcher>() { new Watcher { Id = 2 } }, // Наблюдатели
        };
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// combobox проектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            idsearch();
        }
        private void comboPrior_SelectedIndexChanged(object sender, EventArgs e)
        {
            idsearch();
        }
        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            idsearch();
        }
        private void выйтиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация f = new Авторизация();
            f.Show();
        }
        private void RefReshFill()
        {
            dataGridView1.Rows.Clear();
            //наполнение datagrid
            NameValueCollection parameterref1 = new NameValueCollection();
            if (statusId == 0)
                parameterref1.Add("status_id", "*");
            else
                parameterref1.Add("status_id", statusId.ToString());
            if (priorID == 0)
                parameterref1.Add("priority", "*");
            else
                parameterref1.Add("priority_id", priorID.ToString());
            if (projectId == 0)
                parameterref1.Add("project", "*");
            else
                parameterref1.Add("project_id", projectId.ToString());
            RedmineManager manager = new RedmineManager(host, login, password);
            int i = 0;
            foreach (var issue in manager.GetTotalObjectList<Issue>(parameterref1))
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                i++;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowTXT.Text = DateTime.Now.ToLongTimeString();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Новая новая = new Новая(login, password);
            новая.Show();
            this.Hide();
        }
    }
}
