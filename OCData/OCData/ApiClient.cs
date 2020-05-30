using System;
using System.Net;
using System.Net.Http;


namespace OCData
{
    public static class ApiClient
    {
        private static readonly string ApiUrl = "https://api.opencorporates.com/v0.4/companies/";

        private static HttpClient HttpClient { get; set; }

        static ApiClient()
        {
            HttpClient = new HttpClient();
        }

        /// <summary>
        /// Obtain list of companies matching name, using access token
        /// if available
        /// </summary>
        /// <param name="name"></param>
        /// <param name="apiToken"></param>
        /// <returns></returns>
        public static string GetCompanies(string name, string apiToken = null)
        {
            var nameEnc = WebUtility.UrlEncode(name);
            var url = ApiUrl + $"search?q={nameEnc}";
            if (apiToken != null)
            {
                url = url + @"&api_token={apiToken}";
            }
            var resp = HttpClient.GetAsync(url).Result;

            return resp.Content.ReadAsStringAsync().Result;
        }
    }
}
