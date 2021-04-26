using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AutoParseWeb.Container
{
    [Serializable]
    class WebSitesList
    {
        static WebSitesList instance;
        List<WebSiteDataContainer> containers;
        BinaryFormatter formatter;

        private WebSitesList()
        {
            containers = new List<WebSiteDataContainer>();
            formatter = new BinaryFormatter();
            RecoverData();
        }

        public static WebSitesList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WebSitesList();                    
                }
                return instance;
            }
        }

        public WebSiteDataContainer[] WebSites { get { return containers.ToArray(); } }
        
        public bool AddSite(string name, string url, string tagName, string containerName, string pageDesignation, int startPage, int endPage)
        {
            return AddSite(name, new WebSiteSettings(url, pageDesignation, startPage, endPage), new WebSiteParser(tagName, containerName));
        }

        public bool AddSite(string name, string url, string tagName, string containerName)
        {
            return AddSite(name, url, tagName, containerName, null, 1, 1);
        }        

        public bool AddSite(string name, WebSiteSettings settings, WebSiteParser parser)
        {
            var site = new WebSiteDataContainer(name);
            if (site.SetSettings(settings) && site.SetParseInfo(parser) && !Contains(name))
            {
                containers.Add(site);
                return true;
            }
            return false;
        }        

        public void SaveData()
        {
            using (var file = new FileStream("sites.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, containers);
            }
        }

        public void RecoverData()
        {
            using (var file = new FileStream("sites.bin", FileMode.Open))
            {
                containers = formatter.Deserialize(file) as List<WebSiteDataContainer>;
            }
        }

        public bool DeleteSite(WebSiteDataContainer container)
        {
            return containers.Remove(container);
        }

        public bool OverwriteSiteData(int index, WebSiteDataContainer container)
        {
            if (containers.Count < index)
            {
                return false;
            }
            else
            {
                containers[index] = container;
                return true;
            }
        }

        private bool Contains(string name)
        {
            foreach(var element in containers)
            {
                if (element.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
