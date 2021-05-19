using System;
using System.Windows.Forms;
using AutoParseWeb.Container;
using AutoParseWeb.Core;

namespace AutoParseWeb.Forms
{
    public partial class SiteSettingForm : Form
    {
        int _selected;
        WebSitesList _list;
        WebSiteDataContainer _container;


        public SiteSettingForm(int selected)
        {
            this._selected = selected;
            InitializeComponent();
            _list = WebSitesList.Instance;
        }

        private void SiteSettingForm_Load(object sender, EventArgs e)
        {
            FillFields(_list.WebSites[_selected]);



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
            if (_list.DeleteSite(_list.WebSites[_selected]))
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
            if (String.IsNullOrEmpty(tbName.Text) && String.IsNullOrEmpty(tbURL.Text) &&
                (String.IsNullOrEmpty(tbTag.Text) || String.IsNullOrEmpty(tbClass.Text)))
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля!");
                return;
            }

            _container = new WebSiteDataContainer(tbName.Text);            
            if (string.IsNullOrEmpty(tbPage.Text))
            {
                _container.SetSettings(new WebSiteSettings(tbURL.Text));
            }
            else
            {
                _container.SetSettings(new WebSiteSettings(tbURL.Text, tbPage.Text, (int)numStartPage.Value, (int)numEndPage.Value));
            }
            _container.SetParseInfo(tbTag.Text, tbClass.Text);
            ParseExtractor extractor = new ParseExtractor(_container);
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
            if (_list.OverwriteSiteData(_selected, _container))
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
