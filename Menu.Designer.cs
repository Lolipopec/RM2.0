
namespace RM_2._0_old
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.What = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelProject = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPrior = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchDop = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeNowTXT = new System.Windows.Forms.Label();
            this.checkForME = new System.Windows.Forms.CheckBox();
            this.списатьОстатокВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SearchDop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.What,
            this.Status,
            this.Prior});
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nom.FillWeight = 20F;
            this.nom.Frozen = true;
            this.nom.HeaderText = "№";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 51;
            // 
            // What
            // 
            this.What.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.What.HeaderText = "Тема";
            this.What.MinimumWidth = 6;
            this.What.Name = "What";
            this.What.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.FillWeight = 40F;
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 82;
            // 
            // Prior
            // 
            this.Prior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Prior.FillWeight = 40F;
            this.Prior.HeaderText = "Приоритет";
            this.Prior.MinimumWidth = 6;
            this.Prior.Name = "Prior";
            this.Prior.ReadOnly = true;
            this.Prior.Width = 109;
            // 
            // comboProject
            // 
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Items.AddRange(new object[] {
            "Все проекты"});
            this.comboProject.Location = new System.Drawing.Point(204, 54);
            this.comboProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(261, 24);
            this.comboProject.TabIndex = 2;
            this.comboProject.Text = "Все проекты";
            this.comboProject.SelectedIndexChanged += new System.EventHandler(this.comboProject_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 24, 23, 33, 46, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяToolStripMenuItem,
            this.списатьОстатокВремениToolStripMenuItem,
            this.userToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(812, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяToolStripMenuItem
            // 
            this.новаяToolStripMenuItem.Name = "новаяToolStripMenuItem";
            this.новаяToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.новаяToolStripMenuItem.Text = "Новая";
            this.новаяToolStripMenuItem.Click += new System.EventHandler(this.новаяToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Margin = new System.Windows.Forms.Padding(260, 0, 0, 0);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(31, 24);
            this.userToolStripMenuItem.Text = "1";
            this.userToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click_1);
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(204, 33);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(56, 17);
            this.labelProject.TabIndex = 5;
            this.labelProject.Text = "Проект";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Все статусы"});
            this.comboStatus.Location = new System.Drawing.Point(12, 101);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(168, 24);
            this.comboStatus.TabIndex = 6;
            this.comboStatus.Text = "Все статусы";
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Статус";
            // 
            // comboPrior
            // 
            this.comboPrior.FormattingEnabled = true;
            this.comboPrior.Items.AddRange(new object[] {
            "Все приоритеты"});
            this.comboPrior.Location = new System.Drawing.Point(12, 54);
            this.comboPrior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPrior.Name = "comboPrior";
            this.comboPrior.Size = new System.Drawing.Size(168, 24);
            this.comboPrior.TabIndex = 6;
            this.comboPrior.Text = "Все приоритеты";
            this.comboPrior.SelectedIndexChanged += new System.EventHandler(this.comboPrior_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Приоритет";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 372);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Остаток времени";
            // 
            // SearchDop
            // 
            this.SearchDop.Controls.Add(this.SearchBtn);
            this.SearchDop.Controls.Add(this.domainUpDown1);
            this.SearchDop.Controls.Add(this.label5);
            this.SearchDop.Controls.Add(this.SearchTxt);
            this.SearchDop.Controls.Add(this.label4);
            this.SearchDop.Location = new System.Drawing.Point(577, 129);
            this.SearchDop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchDop.Name = "SearchDop";
            this.SearchDop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchDop.Size = new System.Drawing.Size(224, 151);
            this.SearchDop.TabIndex = 10;
            this.SearchDop.TabStop = false;
            this.SearchDop.Text = "Дополнительный поиск";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(9, 125);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(209, 23);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Номер задачи RM");
            this.domainUpDown1.Items.Add("Поиск по номеру ЛРП");
            this.domainUpDown1.Items.Add("Задачи по списанию времени");
            this.domainUpDown1.Location = new System.Drawing.Point(9, 50);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(209, 22);
            this.domainUpDown1.TabIndex = 12;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Значение поиска";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(9, 98);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(209, 22);
            this.SearchTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поиск по";
            // 
            // TimeNowTXT
            // 
            this.TimeNowTXT.AutoSize = true;
            this.TimeNowTXT.BackColor = System.Drawing.Color.Transparent;
            this.TimeNowTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeNowTXT.Location = new System.Drawing.Point(723, 36);
            this.TimeNowTXT.Name = "TimeNowTXT";
            this.TimeNowTXT.Size = new System.Drawing.Size(73, 20);
            this.TimeNowTXT.TabIndex = 11;
            this.TimeNowTXT.Text = "00:00:00";
            this.TimeNowTXT.Click += new System.EventHandler(this.TimeNowTXT_Click);
            // 
            // checkForME
            // 
            this.checkForME.AutoSize = true;
            this.checkForME.Location = new System.Drawing.Point(207, 101);
            this.checkForME.Name = "checkForME";
            this.checkForME.Size = new System.Drawing.Size(135, 21);
            this.checkForME.TabIndex = 12;
            this.checkForME.Text = "Задачки на мне";
            this.checkForME.UseVisualStyleBackColor = true;
            this.checkForME.CheckedChanged += new System.EventHandler(this.checkForME_CheckedChanged);
            // 
            // списатьОстатокВремениToolStripMenuItem
            // 
            this.списатьОстатокВремениToolStripMenuItem.Margin = new System.Windows.Forms.Padding(215, 0, 0, 0);
            this.списатьОстатокВремениToolStripMenuItem.Name = "списатьОстатокВремениToolStripMenuItem";
            this.списатьОстатокВремениToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 399);
            this.Controls.Add(this.checkForME);
            this.Controls.Add(this.TimeNowTXT);
            this.Controls.Add(this.SearchDop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPrior);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboProject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(830, 446);
            this.MinimumSize = new System.Drawing.Size(830, 446);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchDop.ResumeLayout(false);
            this.SearchDop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn What;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prior;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPrior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox SearchDop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Label TimeNowTXT;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.CheckBox checkForME;
        private System.Windows.Forms.ToolStripMenuItem списатьОстатокВремениToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
    }
}