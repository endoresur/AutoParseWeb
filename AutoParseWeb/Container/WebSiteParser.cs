using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AutoParseWeb.Core;

namespace AutoParseWeb.Container
{
    [Serializable]
    class WebSiteParser : IParser
    {
        public string TagName { get; set; }
        public string ContainerName { get; set; }

        public WebSiteParser(string tagName, string containerName)
        {
            TagName = tagName;
            ContainerName = containerName;
        }

        public string[] Parse(IHtmlDocument document)
        {
            // для хранения данных
            List<string> lines = new List<string>();

            // получаем данные
            IEnumerable<IElement> items = default;
            if (!String.IsNullOrEmpty(TagName) && !String.IsNullOrEmpty(ContainerName))
            {
                items = document.All.Where(m => m.LocalName == TagName && m.ClassList.Contains(ContainerName));
            }
            else if (!String.IsNullOrEmpty(TagName))
            {
                items = document.All.Where(m => m.LocalName == TagName);
            }
            else if(!String.IsNullOrEmpty(ContainerName))
            {
                items = document.All.Where(m => m.ClassList.Contains(ContainerName));
            }

            foreach (var item in items)
                // добавляем данные в коллекцию
                lines.Add(item.TextContent);

            return lines.ToArray();
        }  
    }
}
