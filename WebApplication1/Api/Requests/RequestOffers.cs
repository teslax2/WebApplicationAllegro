using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Api.Requests
{
      //    -H 'Accept: application/vnd.allegro.public.v1+json' \
      //    -H 'content-type: application/vnd.allegro.public.v1+json' \
      //    -H 'Authorization: Bearer {token}' \
    public class RequestOffers : Request
    {
        private string requestUrl;
        public override string RequestUrl => requestUrl;
        public override object Payload => null;

        public RequestOffers(string url, string token, string phrase = "", string seller = "", string category = "", string offset = "", string sort = "") : base(url)
        {
            if (string.IsNullOrEmpty(phrase) && string.IsNullOrEmpty(seller) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(offset) && string.IsNullOrEmpty(sort))
                throw new ArgumentException();

            requestUrl = Endpoints.GetOffers(phrase, seller, category, offset, sort);
            RequestType = RestSharp.Method.GET;
            HeaderParameters.Add(new KeyValuePair<string, string>("Accept", "application/vnd.allegro.public.v1+json"));
            HeaderParameters.Add(new KeyValuePair<string, string>("content-type", "application/vnd.allegro.public.v1+json"));
            HeaderParameters.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {token}"));
        }
    }
}
