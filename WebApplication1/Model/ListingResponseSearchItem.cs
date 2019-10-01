using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ApiModel;

namespace WebApplication1.Model
{
    public class ListingResponseSearchItem
    {
        public ListingResponse ListingResponse { get; set; }
        public SearchItem SearchItem { get; set; }
    }
}
