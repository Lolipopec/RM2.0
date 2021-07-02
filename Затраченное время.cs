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
            foreach (var issue in CurTimeEntr)
            {
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
            CurTimeEntry.SpentOn = DateTime.Now;
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
                NameValueCollection parameter = new NameValueCollection();
                RedmineManager manager = new RedmineManager(host, login, password);
                parameter.Add("issue_id", id);
                decimal H = decimal.Parse(DataGridViewTimeEntries[3, DataGridViewTimeEntries.CurrentCell.RowIndex].Value.ToString());
                User user = manager.GetCurrentUser();
                manager.ImpersonateUser = login;
                //Debug.WriteLine(user.FirstName);
                parameter.Add("comments", DataGridViewTimeEntries[2, DataGridViewTimeEntries.CurrentCell.RowIndex].Value.ToString());
                parameter.Add("hours", DataGridViewTimeEntries[3, DataGridViewTimeEntries.CurrentCell.RowIndex].Value.ToString().Replace(",", "."));
                parameter.Add("user_id", user.Id.ToString());
                //parameter.Add("created_on", DataGridViewTimeEntries[1, DataGridViewTimeEntries.CurrentCell.RowIndex].Value.ToString());
                Debug.WriteLine(id.ToString());
                var CurTimeEntr = manager.GetTotalObjectList<TimeEntry>(parameter);
                int CTEid = 0;
                CurTimeEntry = new TimeEntry();
                foreach (var issue in CurTimeEntr)
                {
                    CurTimeEntry = issue;
                    Debug.WriteLine(issue.Hours);
                }
                Debug.WriteLine(CurTimeEntry.Id);
                var CurTimeEntr2 = new TimeEntry();

                CurTimeEntry.SpentOn = DateTime.Parse(dateTimePicker.Value.ToString("yyyy-MM-dd"));
                CurTimeEntry.Hours = 1;
                CurTimeEntry.Id = 44;
                CurTimeEntry.Comments = textBoxВыполненныеДействия.Text;
                CurTimeEntr2.Comments = textBoxВыполненныеДействия.Text;
                CurTimeEntry.Issue = new IdentifiableName() { Id = 112 };
                CurTimeEntry.User = new IdentifiableName() { Id = user.Id };
                CurTimeEntry.Activity = new IdentifiableName() { Id = 10 };

               // manager.UpdateObject(CurTimeEntry.Id.ToString(), CurTimeEntr2);

                manager.UpdateObject(CurTimeEntry.Id.ToString(), CurTimeEntry);
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


        }
    }
}
