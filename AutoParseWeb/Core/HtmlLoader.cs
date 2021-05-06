using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace AutoParseWeb.Core
{
    class HtmlLoader
    {
        HttpClient _client;
        string _url;
        bool _isMultipage;

        public HtmlLoader(ISettings settings)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", "C# App");
            _url = settings.URL + "/"; 
            if (settings.PageDesignation != null)
            {
                _url += settings.PageDesignation;
                _isMultipage = true;
            }
        }

        public async Task<string> GetHtmlCode(int page)
        {
            string pageUrl = _url;
            if (_isMultipage)
            {
                pageUrl += page.ToString();
            }

            HttpResponseMessage httpResponse = await _client.GetAsync(pageUrl);
            string data = default;

            if (httpResponse != null && httpResponse.StatusCode == HttpStatusCode.OK)
            {
                data = await httpResponse.Content.ReadAsStringAsync();
            }

            return data;
        }

    }
}


