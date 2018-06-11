using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Magnet
{
    class NetHelp
    {
        public class WebClientEx : WebClient
        {
            public int Timeout { get; set; }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                request.Timeout = Timeout;
                return request;
            }
        }

        public static string WebClientGet(string gethost)
        {
            WebClientEx webClient = new WebClientEx
            {
                Timeout = 3000
            };

            byte[] result = webClient.DownloadData(gethost);

            return Encoding.UTF8.GetString(result);
        }
    }
}
