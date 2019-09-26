using System.Collections.Generic;

namespace WebApplication1.Model
{
    public class ListingOffer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SellerID { get; set; }
        public double DeliveryCost { get; set; }
        public string SellingMode { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }

        public ICollection<OfferImages> Images { get; set; }
    }
}