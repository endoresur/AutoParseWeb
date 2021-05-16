
namespace AutoParseWeb
{
    partial class MainForm
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.bStart = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.bStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bChange = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bAddSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(30, 43);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(161, 21);
            this.comboBox.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(30, 174);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(161, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Начать парсинг";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(223, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(585, 433);
            this.listBox.TabIndex = 2;
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(30, 422);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(161, 23);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Сохранить и выйти";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите сайт:";
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(30, 214);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(161, 23);
            this.bChange.TabIndex = 5;
            this.bChange.Text = "Настройки сайта";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bSave
            // 
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(30, 253);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(161, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Экспортировать данные";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAddSite
            // 
            this.bAddSite.Location = new System.Drawing.Point(30, 70);
            this.bAddSite.Name = "bAddSite";
            this.bAddSite.Size = new System.Drawing.Size(161, 23);
            this.bAddSite.TabIndex = 7;
            this.bAddSite.Text = "Добавить сайт";
            this.bAddSite.UseVisualStyleBackColor = true;
            this.bAddSite.Click += new System.EventHandler(this.bAddSite_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 463);
            this.Controls.Add(this.bAddSite);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.comboBox);
            this.MinimumSize = new System.Drawing.Size(839, 502);
            this.Name = "MainForm";
            this.Text = "Приложение для парсинга";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAddSite;
    }
}

