using System;

namespace AutoParseWeb.Container
{
    [Serializable]
    class WebSiteDataContainer
    {
        public WebSiteSettings Settings { get; set; }
        public WebSiteParser Parser { get; set; }

        public string Name { get; set; }

        public WebSiteDataContainer(string name)
        {
            Name = name;
        }
                
        public bool SetSettings(string url, string pageDesignation, int startPage, int endPage)
        {
            return SetSettings(new WebSiteSettings(url, pageDesignation, startPage, endPage));            
        }

        public bool SetSettings(WebSiteSettings settings)
        {
            if (Settings == null)
            {
                Settings = settings;
                return true;
            }
            return false;
        }

        public bool SetParseInfo(string tagName, string containerName)
        {
            return SetParseInfo(new WebSiteParser(tagName, containerName));
        }

        public bool SetParseInfo(WebSiteParser parser)
        {
            if (Parser == null)
            {
                Parser = parser;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }



    }
}
