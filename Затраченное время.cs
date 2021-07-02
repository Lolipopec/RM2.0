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
    public partial class Затрченное_время : Form
    {
        public string id;
        public string login = "";
        int[] mas = new int[0];
        public TimeEntry CurTimeEntry { get; set; }
        public string password = "";
        public string host = "http://testred.ru";
        Menu m;
        public Затрченное_время(string id, string log, string pass)
        {
            InitializeComponent();
            this.id = id;
            this.login = log;
            this.password = pass;
            fill();
            m = new Menu(login, password);
            DataGridViewTimeEntries.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

        }
        public void fill()
        {
            DataGridViewTimeEntries.Rows.Clear();
            NameValueCollection parameter = new NameValueCollection();
            RedmineManager manager = new RedmineManager(host, login, password);
            parameter.Add("issue_id", id);
            Debug.WriteLine(id);
            var CurTimeEntr = manager.GetTotalObjectList<TimeEntry>(parameter);
            int i = 0;
            string firstn = "";
            int tabIdx;
            foreach (var issue in CurTimeEntr)
            {
                Array.Resize(ref mas, mas.Length + 1);
                mas[i] = issue.Id;
                Debug.WriteLine("issue.Id" + issue.Id);
                DataGridViewTimeEntries.Rows.Add();
                DataGridViewTimeEntries.Rows[i].Cells[0].Value = Convert.ToDateTime(issue.SpentOn).ToShortDateString();
                DataGridViewTimeEntries.Rows[i].Cells[1].Value = issue.User.Name;
                DataGridViewTimeEntries.Rows[i].Cells[2].Value = issue.Comments;
                DataGridViewTimeEntries.Rows[i].Cells[3].Value = issue.Hours;
                i++;
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameValueCollection parameter = new NameValueCollection();
            parameter.Add("issue_id", id);
            RedmineManager manager = new RedmineManager(host, login, password);
            User user = manager.GetCurrentUser();
            CurTimeEntry = new TimeEntry();
            CurTimeEntry.Issue = new IdentifiableName() { Id = Convert.ToInt32(id) };
            CurTimeEntry.SpentOn = dateTimePicker.Value;
            CurTimeEntry.User = new IdentifiableName() { Id = user.Id };
            CurTimeEntry.Hours = decimal.Parse(textBoxЗатраченноеВремя.Text);
            CurTimeEntry.Comments = textBoxВыполненныеДействия.Text;
            manager.CreateObject(CurTimeEntry);
            fill();
            m.ttime();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Visible = false;
                RedmineManager manager = new RedmineManager(host, login, password);
                NameValueCollection parameter = new NameValueCollection();
                var CurTimeEntr = manager.GetObject<TimeEntry>(mas[DataGridViewTimeEntries.CurrentCell.RowIndex].ToString(), parameter);
                try
                {
                    manager.DeleteObject<TimeEntry>(CurTimeEntr.Id.ToString(), null);
                }
                catch (RedmineException rex)
                {
                    MessageBox.Show("Ошибка " + rex.Message);
                }
                CurTimeEntr.SpentOn = dateTimePicker.Value;
                CurTimeEntr.Hours = decimal.Parse(textBoxЗатраченноеВремя.Text);
                CurTimeEntr.Comments = textBoxВыполненныеДействия.Text;
                try
                {
                    manager.CreateObject<TimeEntry>(CurTimeEntr);
                    MessageBox.Show("Уcпешно");
                }
                catch (RedmineException rex)
                {
                    MessageBox.Show("Ошибка " + rex.Message);
                }
                fill();
                m.ttime();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedmineManager manager = new RedmineManager(host, login, password);
            NameValueCollection parameter = new NameValueCollection();
            var CurTimeEntr = manager.GetObject<TimeEntry>(mas[DataGridViewTimeEntries.CurrentCell.RowIndex].ToString(), parameter);
            try
            {
                manager.DeleteObject<TimeEntry>(CurTimeEntr.Id.ToString(), null);
                MessageBox.Show("Уcпешно");
            }
            catch (RedmineException rex)
            {
                MessageBox.Show("Ошибка " + rex.Message);
            }
            fill();
            m.ttime();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
