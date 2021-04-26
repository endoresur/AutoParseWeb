using System;
using System.Windows.Forms;
using AutoParseWeb.Container;
using AutoParseWeb.Core;

namespace AutoParseWeb.Forms
{
    public partial class SiteSettingForm : Form
    {
        int selected;
        WebSitesList list;
        WebSiteDataContainer container;


        public SiteSettingForm(int selected)
        {
            this.selected = selected;
            InitializeComponent();
            list = WebSitesList.Instance;
        }

        private void SiteSettingForm_Load(object sender, EventArgs e)
        {
            FillFields(list.WebSites[selected]);



            bCancel.Click += (s, a) => { Close(); };
        }

        private void FillFields(WebSiteDataContainer container)
        {
            tbName.Text = container.Name;
            tbURL.Text = container.Settings.URL;
            tbTag.Text = container.Parser.TagName;
            tbClass.Text = container.Parser.ContainerName;

            if (!string.IsNullOrEmpty(container.Settings.PageDesignation))
            {
                checkBox.Checked = true;
                panel.Visible = false;
                tbPage.Text = container.Settings.PageDesignation;
                numStartPage.Value = container.Settings.StartPage;
                numEndPage.Value = container.Settings.EndPage;
            }
        }
        
        private void bDeleteSite_Click(object sender, EventArgs e)
        {
            if (list.DeleteSite(list.WebSites[selected]))
            {
                MessageBox.Show("Сайт успешно удалён.");
                Close();
            }
            else
            {
                MessageBox.Show("Что-то пошло не так.");
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void bTryParse_Click(object sender, EventArgs e)
        {
            container = new WebSiteDataContainer(tbName.Text);            
            if (string.IsNullOrEmpty(tbPage.Text))
            {
                container.SetSettings(new WebSiteSettings(tbURL.Text));
            }
            else
            {
                container.SetSettings(new WebSiteSettings(tbURL.Text, tbPage.Text, (int)numStartPage.Value, (int)numEndPage.Value));
            }
            container.SetParseInfo(tbTag.Text, tbClass.Text);
            ParseExtractor extractor = new ParseExtractor(container);
            extractor.StartParsing();
            extractor.NewData += OutputData;
        }

        private void OutputData(object o, string[] lines)
        {
            listBox.Items.AddRange(lines);
            bAddndClose.Enabled = true;
        }

        private void bAddndClose_Click(object sender, EventArgs e)
        {
            if (list.OverwriteSiteData(selected, container))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить настройки.");
            }            
        }
    }
}
