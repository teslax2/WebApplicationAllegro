using WebApplication1.ApiModel;

namespace WebApplication1.Model
{
    public class OfferSellingMode
    {
        public int ID { get; set; }
        public string Format { get; set; }
        public int PriceID { get; set; }
        public int OfferFixedPriceID { get; set; }
        public int? Popularity { get; set; }
        public int? BidCount { get; set; }

        public OfferPrice Price { get; set; }
        public OfferFixedPrice FixedPrice { get; set; }
    }
}