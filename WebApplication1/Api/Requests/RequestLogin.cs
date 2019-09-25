using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Api.Requests
{
    public class RequestLogin : Request
    {
        private string _requestUrl;

        public override object Payload { get => null; }
        public override string RequestUrl { get => _requestUrl; }

        public RequestLogin(string url, string requestUrl, string clientId, string secret):base(url)
        {
            RequestType = RestSharp.Method.POST;
            _requestUrl = requestUrl;
            var clientSecret = Encoding.UTF8.GetBytes($"{clientId}:{secret}");
            string encodedHeader = Convert.ToBase64String(clientSecret);
            HeaderParameters.Add(new KeyValuePair<string, string>("Authorization", $"Basic {encodedHeader}"));
        }
    }
}
