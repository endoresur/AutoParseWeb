using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParseWeb.Container
{
    class WebSitesList
    {
        static WebSitesList instance;
        static List<WebSiteDataContainer> containers;

        private WebSitesList()
        { }

        public static WebSitesList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WebSitesList();
                    containers = new List<WebSiteDataContainer>();
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

        public bool DeleteSite(WebSiteDataContainer container)
        {
            return containers.Remove(container);
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
