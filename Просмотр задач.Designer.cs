
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
            this.SuspendLayout();
            // 
            // redmineWebClient1
            // 
            //this.redmineWebClient1.AllowReadStreamBuffering = false;
            //this.redmineWebClient1.AllowWriteStreamBuffering = false;
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
            this.labelPriority.Location = new System.Drawing.Point(424, 9);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(80, 17);
            this.labelPriority.TabIndex = 14;
            this.labelPriority.Text = "Приоритет";
            // 
            // ComboBoxPriority
            // 
            this.ComboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPriority.FormattingEnabled = true;
            this.ComboBoxPriority.Location = new System.Drawing.Point(428, 34);
            this.ComboBoxPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxPriority.Name = "ComboBoxPriority";
            this.ComboBoxPriority.Size = new System.Drawing.Size(197, 24);
            this.ComboBoxPriority.TabIndex = 15;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(217, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 17);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Статус";
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Location = new System.Drawing.Point(221, 34);
            this.ComboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(197, 24);
            this.ComboBoxStatus.TabIndex = 13;
            // 
            // labelTracker
            // 
            this.labelTracker.AutoSize = true;
            this.labelTracker.Location = new System.Drawing.Point(12, 9);
            this.labelTracker.Name = "labelTracker";
            this.labelTracker.Size = new System.Drawing.Size(56, 17);
            this.labelTracker.TabIndex = 10;
            this.labelTracker.Text = "Трекер";
            // 
            // ComboBoxTracker
            // 
            this.ComboBoxTracker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTracker.FormattingEnabled = true;
            this.ComboBoxTracker.Location = new System.Drawing.Point(16, 34);
            this.ComboBoxTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxTracker.Name = "ComboBoxTracker";
            this.ComboBoxTracker.Size = new System.Drawing.Size(197, 24);
            this.ComboBoxTracker.TabIndex = 11;
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(15, 91);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(611, 22);
            this.tema.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Тема";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Описание";
            // 
            // opisanie
            // 
            this.opisanie.Location = new System.Drawing.Point(16, 138);
            this.opisanie.Multiline = true;
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(611, 81);
            this.opisanie.TabIndex = 18;
            // 
            // DateDue
            // 
            this.DateDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDue.Location = new System.Drawing.Point(145, 248);
            this.DateDue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateDue.Name = "DateDue";
            this.DateDue.Size = new System.Drawing.Size(123, 22);
            this.DateDue.TabIndex = 21;
            this.DateDue.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // DateStart
            // 
            this.DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateStart.Enabled = false;
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart.Location = new System.Drawing.Point(12, 248);
            this.DateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(125, 22);
            this.DateStart.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Начата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Выполнение";
            // 
            // timeZN
            // 
            this.timeZN.AutoSize = true;
            this.timeZN.Location = new System.Drawing.Point(579, 248);
            this.timeZN.Name = "timeZN";
            this.timeZN.Size = new System.Drawing.Size(44, 17);
            this.timeZN.TabIndex = 23;
            this.timeZN.Text = "00.00";
            // 
            // Просмотр_задач
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 515);
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
    }
}