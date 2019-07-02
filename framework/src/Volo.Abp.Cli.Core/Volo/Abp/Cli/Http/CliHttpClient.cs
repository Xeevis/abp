using System;
using System.IO;
using System.Net.Http;
using System.Text;

namespace Volo.Abp.Cli.Http
{
    public class CliHttpClient
    {
        public HttpClient Client { get; private set; }

        public CliHttpClient(HttpClient httpClient)
        {
            httpClient.Timeout = TimeSpan.FromSeconds(30);
            AddAuthentication(httpClient);
            Client = httpClient;
        }

        private static void AddAuthentication(HttpClient client)
        {
            if (File.Exists(CliPaths.AccessToken))
            {
                var accessToken = File.ReadAllText(CliPaths.AccessToken, Encoding.UTF8);
                if (!accessToken.IsNullOrEmpty())
                {
                    client.SetBearerToken(accessToken);
                }
            }
        }
    }
}
