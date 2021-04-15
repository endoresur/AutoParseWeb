using AutoParseWeb.Core;

namespace AutoParseWeb.Container
{
    class WebSiteSettings : ISettings
    {
        public WebSiteSettings(string url) : this(url, null, 1, 1)
        { }

        public WebSiteSettings(string url, string pageDesignation, int startPage, int endPage)
        {            
            URL = url;
            PageDesignation = pageDesignation;
            StartPage = startPage;
            EndPage = endPage;
        }


        public string URL { get; set; }
        public string PageDesignation { get; set; }
        public int StartPage { get; set; }        
        public int EndPage { get; set; }
        
    }
}
