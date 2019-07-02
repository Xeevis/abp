using System.Net;
using System.Net.Http;

namespace Volo.Abp.Cli.Http
{
    public class CliHttpClientHandler : HttpClientHandler
    {
        public CliHttpClientHandler()
        {
            // Throws System.PlatformNotSupportedException: Operation is not supported on this platform.
            // Proxy = WebRequest.GetSystemWebProxy();
            DefaultProxyCredentials = CredentialCache.DefaultCredentials;
        }
    }
}
