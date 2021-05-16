using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AutoParseWeb.Container
{
    [Serializable]
    class WebSitesList
    {
        static WebSitesList _instance;
        List<WebSiteDataContainer> _containers;
        BinaryFormatter _formatter;

        private WebSitesList()
        {
            _containers = new List<WebSiteDataContainer>();
            _formatter = new BinaryFormatter();
            RecoverData();
        }

        public static WebSitesList Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WebSitesList();                    
                }
                return _instance;
            }
        }

        public WebSiteDataContainer[] WebSites { get { return _containers.ToArray(); } }
        
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
                _containers.Add(site);
                return true;
            }
            return false;
        }        

        public void SaveData()
        {
            using (var file = new FileStream("sites.bin", FileMode.OpenOrCreate))
            {
                _formatter.Serialize(file, _containers);
            }
        }

        public void RecoverData()
        {
            using (var file = new FileStream("sites.bin", FileMode.Open))
            {
                _containers = _formatter.Deserialize(file) as List<WebSiteDataContainer>;
            }
        }

        public bool DeleteSite(WebSiteDataContainer container)
        {
            return _containers.Remove(container);
        }

        public bool OverwriteSiteData(int index, WebSiteDataContainer container)
        {
            if (_containers.Count < index)
            {
                return false;
            }
            else
            {
                _containers[index] = container;
                return true;
            }
        }

        private bool Contains(string name)
        {
            foreach(var element in _containers)
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
