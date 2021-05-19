using System;
using System.Windows.Forms;
using AutoParseWeb.Core;
using AutoParseWeb.Container;

namespace AutoParseWeb.Forms
{
    public partial class AddSiteForm : Form
    {
        ParseExtractor _extractor;
        WebSiteParser _parser;
        WebSiteSettings _settings;

        public AddSiteForm()
        {
            InitializeComponent();
        }

        private void AddSiteForm_Load(object sender, EventArgs e)
        {
            bCancel.Click += (s, a) => { Close(); };
            
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
            if (checkBox.Checked)
            {
                if (String.IsNullOrEmpty(tbPage.Text) || numStartPage.Value < 0 ||
                numEndPage.Value < 0 || numStartPage.Value > numEndPage.Value)
                {
                    MessageBox.Show("Дополнительные настройки заполнены некорректно!");
                }
                else
                {
                    _settings = new WebSiteSettings(tbURL.Text, tbPage.Text, (int)numStartPage.Value, (int)numEndPage.Value);
                }
            }
            else
            {
                _settings = new WebSiteSettings(tbURL.Text);
            }           

            string tagName = tbTag.Text, containerName = tbClass.Text;            
            _parser = new WebSiteParser(tagName, containerName);            

            _extractor = new ParseExtractor(_parser, _settings);
            _extractor.StartParsing();
            _extractor.NewData += OutputData;            
        }

        private void OutputData(object o, string[] lines)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(lines);
            bAddndClose.Enabled = true;
        }

        private void bAddndClose_Click(object sender, EventArgs e)
        {
            var list = WebSitesList.Instance;
            if (list.AddSite(tbName.Text, _settings, _parser))
            {                
                Close();
            }
            else
            {
                bAddndClose.Enabled = false;
                MessageBox.Show("!!!");
                return;
            }
        }
    }
}
