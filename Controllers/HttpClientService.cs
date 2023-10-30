using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Controllers
{
    public class HttpClientService
    {
        public HttpClient CreateHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler();

            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

            HttpClient httpClient = new HttpClient(handler);
            return httpClient;
        }
    }
}
