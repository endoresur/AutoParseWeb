
namespace AutoParseWeb.Core
{
    interface ISettings
    {
        string URL { get; set; }

        string PageDesignation { get; set; }

        int StartPage { get; set; }

        int EndPage { get; set; }
    }
}
