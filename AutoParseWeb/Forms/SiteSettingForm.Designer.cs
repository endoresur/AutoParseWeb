
namespace AutoParseWeb.Forms
{
    partial class SiteSettingForm
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
            this.tbClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddndClose = new System.Windows.Forms.Button();
            this.bTryParse = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numEndPage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numStartPage = new System.Windows.Forms.NumericUpDown();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDeleteSite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(15, 158);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(193, 20);
            this.tbClass.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Строка с классом:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Удостоверьтесь в правильности введенных данных:";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(418, 341);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(172, 23);
            this.bCancel.TabIndex = 38;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bAddndClose
            // 
            this.bAddndClose.Enabled = false;
            this.bAddndClose.Location = new System.Drawing.Point(240, 341);
            this.bAddndClose.Name = "bAddndClose";
            this.bAddndClose.Size = new System.Drawing.Size(172, 23);
            this.bAddndClose.TabIndex = 37;
            this.bAddndClose.Text = "Добавить изменения и выйти";
            this.bAddndClose.UseVisualStyleBackColor = true;
            this.bAddndClose.Click += new System.EventHandler(this.bAddndClose_Click);
            // 
            // bTryParse
            // 
            this.bTryParse.Location = new System.Drawing.Point(240, 26);
            this.bTryParse.Name = "bTryParse";
            this.bTryParse.Size = new System.Drawing.Size(120, 26);
            this.bTryParse.TabIndex = 36;
            this.bTryParse.Text = "Проверить парсинг";
            this.bTryParse.UseVisualStyleBackColor = true;
            this.bTryParse.Click += new System.EventHandler(this.bTryParse_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(240, 58);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(350, 277);
            this.listBox.TabIndex = 35;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel.Location = new System.Drawing.Point(15, 213);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(193, 115);
            this.panel.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Конечная страница:";
            // 
            // numEndPage
            // 
            this.numEndPage.Location = new System.Drawing.Point(15, 308);
            this.numEndPage.Name = "numEndPage";
            this.numEndPage.Size = new System.Drawing.Size(59, 20);
            this.numEndPage.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Начальная страница:";
            // 
            // numStartPage
            // 
            this.numStartPage.Location = new System.Drawing.Point(15, 269);
            this.numStartPage.Name = "numStartPage";
            this.numStartPage.Size = new System.Drawing.Size(59, 20);
            this.numStartPage.TabIndex = 30;
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(15, 230);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(193, 20);
            this.tbPage.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Тэг страницы:";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(15, 190);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(170, 17);
            this.checkBox.TabIndex = 27;
            this.checkBox.Text = "Дополнительные настройки";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(15, 118);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(193, 20);
            this.tbTag.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Строка с тэгом:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(15, 66);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(193, 20);
            this.tbURL.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "URL сайта:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 20);
            this.tbName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название сайта:";
            // 
            // bDeleteSite
            // 
            this.bDeleteSite.Location = new System.Drawing.Point(15, 341);
            this.bDeleteSite.Name = "bDeleteSite";
            this.bDeleteSite.Size = new System.Drawing.Size(172, 23);
            this.bDeleteSite.TabIndex = 42;
            this.bDeleteSite.Text = "Удалить сайт и закрыть";
            this.bDeleteSite.UseVisualStyleBackColor = true;
            this.bDeleteSite.Click += new System.EventHandler(this.bDeleteSite_Click);
            // 
            // SiteSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 376);
            this.Controls.Add(this.bDeleteSite);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAddndClose);
            this.Controls.Add(this.bTryParse);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numEndPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numStartPage);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(621, 387);
            this.Name = "SiteSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SiteSettingForm";
            this.Load += new System.EventHandler(this.SiteSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddndClose;
        private System.Windows.Forms.Button bTryParse;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numEndPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStartPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDeleteSite;
    }
}