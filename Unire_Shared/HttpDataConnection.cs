using Android.Widget;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Unire_Shared
{
	public class HttpDataConnection
	{

        private String notificationData;
        private String url;

        public HttpDataConnection(String url)
        {
            this.url = url;
            Task<string> task = HttpConnection(url);
        }

        public async Task<string> HttpConnection(String url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var answer = response.Content.ReadAsStringAsync().Result;
            notificationData = answer;
            return answer;
        }

    }
}

