using System;
using System.IO;
using System.Windows.Forms;
using AutoParseWeb.Container;
using AutoParseWeb.Core;
using AutoParseWeb.Forms;


namespace AutoParseWeb
{
    public partial class MainForm : Form
    {        
        ParseExtractor _extractor;
        WebSitesList _sitesList;

        public MainForm()
        {
            InitializeComponent();                        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _sitesList = WebSitesList.Instance;
            RefreshItems();
            _extractor = new ParseExtractor();            
            _extractor.NewData += OutputData;
            _extractor.Complited += (o) => bSave.Enabled = true;
        }

        public void RefreshItems()
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(_sitesList.WebSites);
            comboBox.SelectedItem = comboBox.Items[0];
        }

        private void OutputData(object o, string[] lines) 
        { 
            listBox.Items.AddRange(lines);            
        }

        private void bStart_Click(object sender, EventArgs e) 
        {
            listBox.Items.Clear();
            _extractor.Data.Clear();
            var site = _sitesList.WebSites[comboBox.SelectedIndex];

            _extractor.Parser = site.Parser;
            _extractor.Settings = site.Settings;
            
            _extractor.StartParsing();            
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            //sitesList.SaveData();
            //extractor.StopParsing();
            Close();
        }

        private void bAddSite_Click(object sender, EventArgs e)
        {
            new AddSiteForm().ShowDialog();
            RefreshItems();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = dialog.SelectedPath + "\\result.txt";
                        using (var stream = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                        {
                            foreach (var line in _extractor.Data)
                            {
                                stream.WriteLine(line);
                            }
                        }
                        MessageBox.Show("Данные успешно сохранены.");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            new SiteSettingForm(comboBox.SelectedIndex).ShowDialog();
            RefreshItems();
        }
    }
}
