using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class SearchItem
    {
        public int ID { get; set; }
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Category { get; set; }

        public ICollection<ListingOffer> ListingOffer { get; set; }
    }
}
