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
        private int projectId = 0;
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

            RedmineManager redmine = new RedmineManager(host, login, password);
            NameValueCollection parameters = new NameValueCollection();
            IList<Project> allProjects = redmine.GetTotalObjectList<Project>(parameters);
            foreach (var c in allProjects)
            {
                comboBox1.Items.Add(c.Name);
            }
            NameValueCollection parameter = new NameValueCollection();
            parameter.Add("STATUS_ID", "*");
            parameter.Add("ASSIGNED_TO_ID", "*");
            parameter.Add("PROJECT_ID", "*");
            RedmineManager manager = new RedmineManager(host, login, password);
            int i = 0;
            foreach (var issue in manager.GetTotalObjectList<Issue>(parameters))
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                //XmlReader reader =  ;
                //issue.ReadXml();
                i++;
            }
            var s = redminetask;



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


        public void Fill()
        {

        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Update(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
