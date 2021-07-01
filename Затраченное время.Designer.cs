
namespace RM_2._0_old
{
    partial class Затрченное_время
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
            this.DataGridViewTimeEntries = new System.Windows.Forms.DataGridView();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пользователь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Комментарий = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Часы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.labelДата = new System.Windows.Forms.Label();
            this.textBoxЗатраченноеВремя = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelДействияЕСА = new System.Windows.Forms.Label();
            this.textBoxВыполненныеДействия = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntries)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewTimeEntries
            // 
            this.DataGridViewTimeEntries.AllowUserToAddRows = false;
            this.DataGridViewTimeEntries.AllowUserToDeleteRows = false;
            this.DataGridViewTimeEntries.AllowUserToResizeRows = false;
            this.DataGridViewTimeEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewTimeEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTimeEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Дата,
            this.Пользователь,
            this.Комментарий,
            this.Часы});
            this.DataGridViewTimeEntries.Location = new System.Drawing.Point(16, 33);
            this.DataGridViewTimeEntries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewTimeEntries.MultiSelect = false;
            this.DataGridViewTimeEntries.Name = "DataGridViewTimeEntries";
            this.DataGridViewTimeEntries.ReadOnly = true;
            this.DataGridViewTimeEntries.RowHeadersWidth = 51;
            this.DataGridViewTimeEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTimeEntries.Size = new System.Drawing.Size(729, 258);
            this.DataGridViewTimeEntries.TabIndex = 53;
            // 
            // Дата
            // 
            this.Дата.FillWeight = 72.98312F;
            this.Дата.HeaderText = "Дата";
            this.Дата.MinimumWidth = 6;
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            // 
            // Пользователь
            // 
            this.Пользователь.FillWeight = 133.0516F;
            this.Пользователь.HeaderText = "Пользователь";
            this.Пользователь.MinimumWidth = 6;
            this.Пользователь.Name = "Пользователь";
            this.Пользователь.ReadOnly = true;
            // 
            // Комментарий
            // 
            this.Комментарий.FillWeight = 133.0516F;
            this.Комментарий.HeaderText = "Комментарий";
            this.Комментарий.MinimumWidth = 6;
            this.Комментарий.Name = "Комментарий";
            this.Комментарий.ReadOnly = true;
            // 
            // Часы
            // 
            this.Часы.FillWeight = 60.91371F;
            this.Часы.HeaderText = "Часы";
            this.Часы.MinimumWidth = 6;
            this.Часы.Name = "Часы";
            this.Часы.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 28);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Затр. время";
            // 
            // labelДата
            // 
            this.labelДата.AutoSize = true;
            this.labelДата.Location = new System.Drawing.Point(284, 303);
            this.labelДата.Name = "labelДата";
            this.labelДата.Size = new System.Drawing.Size(42, 17);
            this.labelДата.TabIndex = 62;
            this.labelДата.Text = "Дата";
            // 
            // textBoxЗатраченноеВремя
            // 
            this.textBoxЗатраченноеВремя.Location = new System.Drawing.Point(476, 321);
            this.textBoxЗатраченноеВремя.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxЗатраченноеВремя.Name = "textBoxЗатраченноеВремя";
            this.textBoxЗатраченноеВремя.Size = new System.Drawing.Size(132, 22);
            this.textBoxЗатраченноеВремя.TabIndex = 61;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(288, 322);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker.TabIndex = 58;
            // 
            // labelДействияЕСА
            // 
            this.labelДействияЕСА.AutoSize = true;
            this.labelДействияЕСА.Location = new System.Drawing.Point(15, 303);
            this.labelДействияЕСА.Name = "labelДействияЕСА";
            this.labelДействияЕСА.Size = new System.Drawing.Size(166, 17);
            this.labelДействияЕСА.TabIndex = 60;
            this.labelДействияЕСА.Text = "Выполненные действия";
            // 
            // textBoxВыполненныеДействия
            // 
            this.textBoxВыполненныеДействия.Location = new System.Drawing.Point(16, 322);
            this.textBoxВыполненныеДействия.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxВыполненныеДействия.Multiline = true;
            this.textBoxВыполненныеДействия.Name = "textBoxВыполненныеДействия";
            this.textBoxВыполненныеДействия.Size = new System.Drawing.Size(263, 24);
            this.textBoxВыполненныеДействия.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 64;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Затрченное_время
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelДата);
            this.Controls.Add(this.textBoxЗатраченноеВремя);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelДействияЕСА);
            this.Controls.Add(this.textBoxВыполненныеДействия);
            this.Controls.Add(this.DataGridViewTimeEntries);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Затрченное_время";
            this.Text = "Затрченное_время";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntries)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewTimeEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пользователь;
        private System.Windows.Forms.DataGridViewTextBoxColumn Комментарий;
        private System.Windows.Forms.DataGridViewTextBoxColumn Часы;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelДата;
        private System.Windows.Forms.TextBox textBoxЗатраченноеВремя;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelДействияЕСА;
        private System.Windows.Forms.TextBox textBoxВыполненныеДействия;
        private System.Windows.Forms.Button button1;
    }
}