using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MoonlayStore.Helper
{
    public class AmazonApiHelper
    {
        private const string uri = "https://amazon-products1.p.rapidapi.com";

        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "amazon-products1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "b412aa893amsh634b8080df979e3p112030jsnb2f25e40922f");
            return client;
        }
    }
}
