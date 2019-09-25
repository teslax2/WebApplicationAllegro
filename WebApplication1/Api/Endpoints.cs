using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Api
{
    public class Endpoints
    {
        public const string URLAuth = "https://allegro.pl";
        public const string URL = "https://api.allegro.pl";
        public const string Login = "/auth/oauth/token?grant_type=client_credentials";

        public static string GetOffers(string phrase = "", string seller = "", string category = "", string offset = "", string sort = "")
        {
            var sb = new StringBuilder();
            sb.Append("/offers/listing");
            if (!string.IsNullOrEmpty(phrase) || !string.IsNullOrEmpty(seller) || !string.IsNullOrEmpty(category) || !string.IsNullOrEmpty(offset) || !string.IsNullOrEmpty(sort))
                sb.Append("?");
            if (!string.IsNullOrEmpty(phrase))
                sb.Append($"phrase={phrase}");
            if (!string.IsNullOrEmpty(seller))
                sb.Append($"seller.id={seller}");
            if (!string.IsNullOrEmpty(category))
                sb.Append($"category.id={category}");
            if (!string.IsNullOrEmpty(offset))
                sb.Append($"offset={category}");
            if (!string.IsNullOrEmpty(sort))
                sb.Append($"sort={sort}");
            return sb.ToString();
        }
    }
}
