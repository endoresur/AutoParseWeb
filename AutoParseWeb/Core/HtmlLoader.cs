using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace AutoParseWeb.Core
{
    class HtmlLoader
    {
        HttpClient client;
        string url;
        bool isMultipage;

        public HtmlLoader(ISettings settings)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# App");
            url = settings.URL + "/"; 
            if (settings.PageDesignation != null)
            {
                url += settings.PageDesignation;
                isMultipage = true;
            }
        }

        public async Task<string> GetHtmlCode(int page)
        {
            string pageUrl = url;
            if (isMultipage)
            {
                pageUrl += page.ToString();
            }

            HttpResponseMessage httpResponse = await client.GetAsync(pageUrl);
            string data = default;

            if (httpResponse != null && httpResponse.StatusCode == HttpStatusCode.OK)
            {
                data = await httpResponse.Content.ReadAsStringAsync();
            }

            return data;
        }

    }
}


