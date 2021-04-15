using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            sitesList.AddSite("Habr", new WebSiteSettings("https://habr.com/ru/all"), new WebSiteParser("a", "post__title_link"));

            /*
            containers = new List<WebSiteDataContainer>();            

            container = new WebSiteDataContainer("Habr");
            container.GetParseInfo("a", "post__title_link");
            container.GetSettings("https://habr.com/ru/all", "page", 1, 2); 
            containers.Add(container);

            container2 = new WebSiteDataContainer("Лента ру");
            //container2.GetParseInfo("a", "mg-card__link");
            //container2.GetSettings("https://yandex.ru/news/?utm_source=main_stripe_big");


            //container2.GetParseInfo("span", "cell-list__item-desc");
            //container2.GetSettings("https://ria.ru");

            //container2.GetParseInfo("span", "news-preview__title");
            //container2.GetSettings("https://tass.ru");

            container2.GetParseInfo("div", "mw-parser-output");
            container2.GetSettings("https://ru.wikipedia.org/w/index.php?search=%D0%98%D0%BD%D0%BA%D0%B0%D0%BF%D1%81%D1%83%D0%BB%D1%8F%D1%86%D0%B8%D1%8F%20(%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5)&title=%D0%A1%D0%BB%D1%83%D0%B6%D0%B5%D0%B1%D0%BD%D0%B0%D1%8F%3A%D0%9F%D0%BE%D0%B8%D1%81%D0%BA&ns0=1");

            containers.Add(container2);
            */

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
            var site = sitesList.WebSites[comboBox.SelectedIndex];

            extractor.Parser = site.Parser;
            extractor.Settings = site.Settings;
            
            extractor.StartParsing();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            //extractor.StopParsing();
        }
    }
}
