using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace WebApplication1.Api.Requests
{
    public abstract class Request
    {
        public string Url { get; set; }
        public abstract string RequestUrl { get; }
        public abstract object Payload { get; }
        public List<KeyValuePair<string, string>> HeaderParameters { get; set; } = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, string>> QueryParameters { get; set; } = new List<KeyValuePair<string, string>>();
        public bool ShowContentInLog { get; set; }
        public Method RequestType { get; set; }

        public Request(string url)
        {
            Url = url;
        }
    }
}
