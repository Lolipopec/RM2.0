﻿
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
            this.DataGridViewTimeEntries.Location = new System.Drawing.Point(12, 27);
            this.DataGridViewTimeEntries.MultiSelect = false;
            this.DataGridViewTimeEntries.Name = "DataGridViewTimeEntries";
            this.DataGridViewTimeEntries.ReadOnly = true;
            this.DataGridViewTimeEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTimeEntries.Size = new System.Drawing.Size(547, 210);
            this.DataGridViewTimeEntries.TabIndex = 53;
            // 
            // Дата
            // 
            this.Дата.FillWeight = 72.98312F;
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            // 
            // Пользователь
            // 
            this.Пользователь.FillWeight = 133.0516F;
            this.Пользователь.HeaderText = "Пользователь";
            this.Пользователь.Name = "Пользователь";
            this.Пользователь.ReadOnly = true;
            // 
            // Комментарий
            // 
            this.Комментарий.FillWeight = 133.0516F;
            this.Комментарий.HeaderText = "Комментарий";
            this.Комментарий.Name = "Комментарий";
            this.Комментарий.ReadOnly = true;
            // 
            // Часы
            // 
            this.Часы.FillWeight = 60.91371F;
            this.Часы.HeaderText = "Часы";
            this.Часы.Name = "Часы";
            this.Часы.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Затр. время";
            // 
            // labelДата
            // 
            this.labelДата.AutoSize = true;
            this.labelДата.Location = new System.Drawing.Point(213, 246);
            this.labelДата.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelДата.Name = "labelДата";
            this.labelДата.Size = new System.Drawing.Size(33, 13);
            this.labelДата.TabIndex = 62;
            this.labelДата.Text = "Дата";
            // 
            // textBoxЗатраченноеВремя
            // 
            this.textBoxЗатраченноеВремя.Location = new System.Drawing.Point(357, 261);
            this.textBoxЗатраченноеВремя.Name = "textBoxЗатраченноеВремя";
            this.textBoxЗатраченноеВремя.Size = new System.Drawing.Size(100, 20);
            this.textBoxЗатраченноеВремя.TabIndex = 61;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(216, 262);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker.TabIndex = 58;
            // 
            // labelДействияЕСА
            // 
            this.labelДействияЕСА.AutoSize = true;
            this.labelДействияЕСА.Location = new System.Drawing.Point(11, 246);
            this.labelДействияЕСА.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelДействияЕСА.Name = "labelДействияЕСА";
            this.labelДействияЕСА.Size = new System.Drawing.Size(128, 13);
            this.labelДействияЕСА.TabIndex = 60;
            this.labelДействияЕСА.Text = "Выполненные действия";
            // 
            // textBoxВыполненныеДействия
            // 
            this.textBoxВыполненныеДействия.Location = new System.Drawing.Point(12, 262);
            this.textBoxВыполненныеДействия.Multiline = true;
            this.textBoxВыполненныеДействия.Name = "textBoxВыполненныеДействия";
            this.textBoxВыполненныеДействия.Size = new System.Drawing.Size(198, 20);
            this.textBoxВыполненныеДействия.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Затрченное_время
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 293);
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