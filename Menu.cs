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
        public static string password = "";
        public bool mezad = false;
        public string us = "";
        public User currentUser;
        #endregion
        public Menu(string l, string p)
        {
            try
            {
                InitializeComponent();
                this.Text = "Меню (" + l + ")";
                RM_2._0_old.Menu.login = l;
                RM_2._0_old.Menu.password = p;
                redmine = new RedmineManager(host, login, password);
                parameters = new NameValueCollection();
                Fill();
                userToolStripMenuItem.Text = l;
                timer1.Interval = 1000;
                timer1.Enabled = true;
                timer2.Interval = 60000;
                timer2.Enabled = true;
                dateTimePicker1.Value = DateTime.Now;
                SearchBtn.Enabled = false;
                SearchTxt.Enabled = false;
                domainUpDown1.Wrap = true;
                checkForME.Checked = true;
                ttime();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        /// <summary>
        /// определение id 
        /// </summary>
        /// <returns></returns>
        public void idsearch()
        {
            try
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
            catch { MessageBox.Show("Ошибка"); }
        }
        /// <summary>
        /// наполнение формы
        /// </summary>
        public void Fill()
        {
            try
            {
                currentUser = redmine.GetCurrentUser();
                ttime();
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

                parameter.Add("assigned_to_id", currentUser.Id.ToString());
                RedmineManager manager = new RedmineManager(host, login, password);
                int i = 0;
                foreach (var issue in manager.GetTotalObjectList<Issue>(parameter))
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                    dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                    dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                    dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                    i++;
                }
            }
            catch { MessageBox.Show("Ошибка"); }
        }
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
            try
            {
                idsearch();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void comboPrior_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idsearch();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idsearch();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void выйтиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Авторизация f = new Авторизация();
                f.Show();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void RefReshFill()
        {
            try
            {
                ttime();




                dataGridView1.Rows.Clear();
                //наполнение datagrid
                NameValueCollection parameterref1 = new NameValueCollection();
                if (mezad == true)
                {
                    parameterref1.Add("assigned_to_id", currentUser.Id.ToString());

                }
                if (statusId == 0)
                    parameterref1.Add("status_id", "open");
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
            catch { MessageBox.Show("Ошибка"); }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeNowTXT.Text = DateTime.Now.ToLongTimeString();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Новая новая = new Новая(login, password);
                новая.Show();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                SearchTxt.Enabled = true;
                SearchBtn.Enabled = true;
                SearchBtn.Text = "Поиск";
                if (domainUpDown1.SelectedIndex == 2)
                {
                    SearchTxt.Enabled = false;
                    SearchBtn.Text = "Выгрузить";
                }
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        /// <summary>
        /// дополнительный поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //id = 0 - номер задачи; 1 - номер ЛРП фыв
                dataGridView1.Rows.Clear();
                if (domainUpDown1.SelectedIndex == 0)
                {

                    try
                    {
                        NameValueCollection parameterref2 = new NameValueCollection();
                        parameterref2.Add("issue_id", SearchTxt.Text);
                        RedmineManager manager = new RedmineManager(host, login, password);
                        int i = 0;
                        foreach (var issue in manager.GetTotalObjectList<Issue>(parameterref2))
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                            dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                            dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                            dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                            i++;
                        }
                    }
                    catch
                    {

                    }
                }
                else if (domainUpDown1.SelectedIndex == 1)
                {
                    //тут нужен двойной поиск (1 - в теме, 2 - в описании)

                    try
                    {
                        NameValueCollection parameterref2 = new NameValueCollection();
                        RedmineManager manager = new RedmineManager(host, login, password);
                        parameterref2.Add("subject", "~" + SearchTxt.Text);
                        var Search = manager.GetTotalObjectList<Issue>(parameterref2);

                        int i = 0;
                        foreach (var issue in Search)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                            dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                            dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                            dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                            i++;
                        }
                        if (dataGridView1.RowCount > 0)
                        {
                            return;
                        }
                        else
                        {
                            NameValueCollection parameterref3 = new NameValueCollection();
                            RedmineManager manager1 = new RedmineManager(host, login, password);
                            parameterref3.Add("description", "~" + SearchTxt.Text);
                            var Search2 = manager1.GetTotalObjectList<Issue>(parameterref3);

                            i = 0;
                            foreach (var issue in Search2)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                                dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                                dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                                dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                                i++;
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                else if (domainUpDown1.SelectedIndex == 2)
                {
                    try
                    {
                        RedmineManager manager = new RedmineManager(host, login, password);
                        NameValueCollection pr = new NameValueCollection();
                        pr.Add("login", login);
                        User uss = manager.GetCurrentUser();
                        NameValueCollection parameterref2 = new NameValueCollection(); // для поиска по теме
                        NameValueCollection parameterref3 = new NameValueCollection(); // для поиска по описанию
                        parameterref2.Add("subject", "~" + "Затраченное время " + uss.FirstName); //параметр по теме*
                        parameterref3.Add("description", "~" + "Затраченное время"); // параметр по описанию*
                        parameterref3.Add("start_date", DateTime.Now.Year.ToString("yyyy-MM-dd")); //параметр по дате*
                        var Search = manager.GetTotalObjectList<Issue>(parameterref2);
                        var Search2 = manager.GetTotalObjectList<Issue>(parameterref3);

                        int i = 0;
                        foreach (var issue in Search)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                            dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                            dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                            dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                            i++;
                        }

                        foreach (var issue in Search2)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                            dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                            dataGridView1.Rows[i].Cells[2].Value = issue.Status.Name;
                            dataGridView1.Rows[i].Cells[3].Value = issue.Priority.Name;
                            i++;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Search = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                Просмотр_задач ch = new Просмотр_задач(Search, login, password);
                ch.Show();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void checkForME_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                mezad = !mezad;
                RefReshFill();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void TimeNowTXT_Click(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                ttime();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        public void ttime()
        {
            try
            {
                textBox1.Text = "0";
                decimal tim = 0;
                RedmineManager manager = new RedmineManager(host, login, password);
                NameValueCollection param = new NameValueCollection();
                param.Add("spent_on", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                param.Add("user_id", currentUser.Id.ToString());
                var oftime = manager.GetTotalObjectList<TimeEntry>(param);
                foreach (var c in oftime)
                {
                    tim += c.Hours;
                }
                textBox1.Text = tim.ToString();
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Resources\Модули.txt");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Новая n = new Новая(login, password);
            n.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ttime();
        }
    }
}
