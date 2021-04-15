using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AutoParseWeb.Core;

namespace AutoParseWeb.Container
{
    class WebSiteParser : IParser
    {
        public string TagName { get; set; }
        public string ContainerName { get; set; }

        public WebSiteParser(string tagName, string containerName)
        {
            // TODO: проверка входных данных

            TagName = tagName;
            ContainerName = containerName;
        }

        public string[] Parse(IHtmlDocument document)
        {
            List<string> lines = new List<string>();            

            IEnumerable<IElement> items = document.All.Where(m => m.LocalName == TagName && m.ClassList.Contains(ContainerName));

            foreach (var item in items)
                lines.Add(item.TextContent);

            return lines.ToArray();
        }  
    }
}
