
namespace RM_2._0_old
{
    partial class Просмотр_задач
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Просмотр_задач));
            this.redmineWebClient1 = new Redmine.Net.Api.RedmineWebClient();
            this.labelPriority = new System.Windows.Forms.Label();
            this.ComboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelTracker = new System.Windows.Forms.Label();
            this.ComboBoxTracker = new System.Windows.Forms.ComboBox();
            this.tema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opisanie = new System.Windows.Forms.TextBox();
            this.DateDue = new System.Windows.Forms.DateTimePicker();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeZN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redmineWebClient1
            // 
            this.redmineWebClient1.BaseAddress = "";
            this.redmineWebClient1.CachePolicy = null;
            this.redmineWebClient1.Credentials = null;
            this.redmineWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("redmineWebClient1.Encoding")));
            this.redmineWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("redmineWebClient1.Headers")));
            this.redmineWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("redmineWebClient1.QueryString")));
            this.redmineWebClient1.UseDefaultCredentials = false;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(318, 7);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(61, 13);
            this.labelPriority.TabIndex = 14;
            this.labelPriority.Text = "Приоритет";
            // 
            // ComboBoxPriority
            // 
            this.ComboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPriority.FormattingEnabled = true;
            this.ComboBoxPriority.Location = new System.Drawing.Point(321, 28);
            this.ComboBoxPriority.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxPriority.Name = "ComboBoxPriority";
            this.ComboBoxPriority.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxPriority.TabIndex = 15;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(163, 7);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Статус";
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Location = new System.Drawing.Point(166, 28);
            this.ComboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxStatus.TabIndex = 13;
            // 
            // labelTracker
            // 
            this.labelTracker.AutoSize = true;
            this.labelTracker.Location = new System.Drawing.Point(9, 7);
            this.labelTracker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTracker.Name = "labelTracker";
            this.labelTracker.Size = new System.Drawing.Size(44, 13);
            this.labelTracker.TabIndex = 10;
            this.labelTracker.Text = "Трекер";
            // 
            // ComboBoxTracker
            // 
            this.ComboBoxTracker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTracker.FormattingEnabled = true;
            this.ComboBoxTracker.Location = new System.Drawing.Point(12, 28);
            this.ComboBoxTracker.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTracker.Name = "ComboBoxTracker";
            this.ComboBoxTracker.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxTracker.TabIndex = 11;
            this.ComboBoxTracker.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTracker_SelectedIndexChanged);
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(11, 74);
            this.tema.Margin = new System.Windows.Forms.Padding(2);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(459, 20);
            this.tema.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Тема";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Описание";
            // 
            // opisanie
            // 
            this.opisanie.Location = new System.Drawing.Point(12, 112);
            this.opisanie.Margin = new System.Windows.Forms.Padding(2);
            this.opisanie.Multiline = true;
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(459, 67);
            this.opisanie.TabIndex = 18;
            // 
            // DateDue
            // 
            this.DateDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDue.Location = new System.Drawing.Point(109, 202);
            this.DateDue.Margin = new System.Windows.Forms.Padding(2);
            this.DateDue.Name = "DateDue";
            this.DateDue.Size = new System.Drawing.Size(93, 20);
            this.DateDue.TabIndex = 21;
            this.DateDue.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // DateStart
            // 
            this.DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateStart.Enabled = false;
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart.Location = new System.Drawing.Point(9, 202);
            this.DateStart.Margin = new System.Windows.Forms.Padding(2);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(95, 20);
            this.DateStart.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Начата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Выполнение";
            // 
            // timeZN
            // 
            this.timeZN.AutoSize = true;
            this.timeZN.Location = new System.Drawing.Point(434, 202);
            this.timeZN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeZN.Name = "timeZN";
            this.timeZN.Size = new System.Drawing.Size(34, 13);
            this.timeZN.TabIndex = 23;
            this.timeZN.Text = "00.00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Просмотр_задач
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeZN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateDue);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opisanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.ComboBoxPriority);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.labelTracker);
            this.Controls.Add(this.ComboBoxTracker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Просмотр_задач";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Просмотр_задач_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Redmine.Net.Api.RedmineWebClient redmineWebClient1;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox ComboBoxPriority;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.Label labelTracker;
        private System.Windows.Forms.ComboBox ComboBoxTracker;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opisanie;
        private System.Windows.Forms.DateTimePicker DateDue;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeZN;
        private System.Windows.Forms.Button button1;
    }
}