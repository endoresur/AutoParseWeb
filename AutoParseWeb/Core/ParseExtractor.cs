using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using AutoParseWeb.Container;

namespace AutoParseWeb.Core
{
    class ParseExtractor
    {
        IParser parser;
        ISettings settings;
        HtmlLoader loader;


        public ParseExtractor()
        { }

        public ParseExtractor(IParser parser, ISettings settings)
        {
            Parser = parser;
            Settings = settings;
        }

        public ParseExtractor(WebSiteDataContainer container) : this(container.Parser, container.Settings)
        { }            
        

        public List<string> Data { get; set; } = new List<string>();

        public IParser Parser 
        { 
            get 
            { 
                return parser; 
            } 
            set
            {
                parser = value;
            }
        }

        public bool IsRun { get; set; }
       
        public ISettings Settings
        {
            get { return settings; }
            set
            {
                settings = value;
                loader = new HtmlLoader(value);
            }
        }

        public void StartParsing()
        {
            IsRun = true;
            Extract();
        }

        public void StopParsing()
        {
            IsRun = false;
        }

        public event Action<object> Complited;
        public event Action<object, string[]> NewData;

        private async void Extract()
        {
            if (Parser == null || Settings == null)
            {
                IsRun = false;                
                return;
            }

            for (int i = Settings.StartPage; i <= Settings.EndPage; i++)
            {
                if (IsRun)
                {
                    string source = await loader.GetHtmlCode(i);
                    HtmlParser htmlParser = new HtmlParser();
                    IHtmlDocument document = await htmlParser.ParseDocumentAsync(source);
                    Data.AddRange(Parser.Parse(document));
                    NewData?.Invoke(this, Data.ToArray());
                }
            }
            Complited?.Invoke(this);
            IsRun = false;
        }

    }
}
