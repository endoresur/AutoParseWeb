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
        ParseExtractor extractor;
        WebSitesList sitesList;


        public MainForm()
        {
            InitializeComponent();                        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sitesList = WebSitesList.Instance;
            RefreshItems();
            extractor = new ParseExtractor();            
            extractor.NewData += OutputData;
            extractor.Complited += (o) => bSave.Enabled = true;
        }

        public void RefreshItems()
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(sitesList.WebSites);
            comboBox.SelectedItem = comboBox.Items[0];
        }

        private void OutputData(object o, string[] lines) 
        { 
            listBox.Items.AddRange(lines);            
        }

        private void bStart_Click(object sender, EventArgs e) 
        {
            listBox.Items.Clear();
            extractor.Data.Clear();
            var site = sitesList.WebSites[comboBox.SelectedIndex];

            extractor.Parser = site.Parser;
            extractor.Settings = site.Settings;
            
            extractor.StartParsing();            
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
                            foreach (var line in extractor.Data)
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
