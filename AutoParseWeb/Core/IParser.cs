using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace AutoParseWeb.Core
{
    interface IParser
    {
        string TagName { get; set; }
        string ContainerName { get; set; }
        string[] Parse(IHtmlDocument document);
    }
}
