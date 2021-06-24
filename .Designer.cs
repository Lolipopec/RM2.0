
namespace RM_2._0_old
{
    partial class Новая
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxПроекты = new System.Windows.Forms.ComboBox();
            this.labelProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxПроекты
            // 
            this.comboBoxПроекты.FormattingEnabled = true;
            this.comboBoxПроекты.Location = new System.Drawing.Point(12, 26);
            this.comboBoxПроекты.Name = "comboBoxПроекты";
            this.comboBoxПроекты.Size = new System.Drawing.Size(121, 21);
            this.comboBoxПроекты.TabIndex = 1;
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(11, 9);
            this.labelProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(44, 13);
            this.labelProject.TabIndex = 6;
            this.labelProject.Text = "Проект";
            // 
            // Новая
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 343);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.comboBoxПроекты);
            this.Controls.Add(this.button1);
            this.Name = "Новая";
            this.Text = "Новая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxПроекты;
        private System.Windows.Forms.Label labelProject;
    }
}

