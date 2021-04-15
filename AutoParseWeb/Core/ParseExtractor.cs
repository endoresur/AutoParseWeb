using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoParseWeb.Core
{
    class ParseExtractor
    {
        IParser parser;
        ISettings settings;
        HtmlLoader loader;


        public ParseExtractor()
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
            if (parser == null || settings == null)
            {
                IsRun = false;
                return;
            }

            for (int i = settings.StartPage; i <= settings.EndPage; i++)
            {
                if (IsRun)
                {
                    string source = await loader.GetHtmlCode(i);
                    HtmlParser htmlParser = new HtmlParser();
                    IHtmlDocument document = await htmlParser.ParseDocumentAsync(source);
                    Data.AddRange(parser.Parse(document));
                    NewData?.Invoke(this, Data.ToArray());
                }
            }
            Complited?.Invoke(this);
            IsRun = false;
        }

    }
}
