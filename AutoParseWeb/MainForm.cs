using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoParseWeb.Container;
using AutoParseWeb.Core;


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
            
            comboBox.Items.AddRange(sitesList.WebSites);
            comboBox.SelectedItem = comboBox.Items[0];            
            
            extractor = new ParseExtractor();            

            //extractor.Complited += StopParsing;
            extractor.NewData += OutputData;
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
            sitesList.SaveData();
            //extractor.StopParsing();
        }
    }
}
