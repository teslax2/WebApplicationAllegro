namespace WebApplication1.Model
{
    public class OfferImages
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public int ListingOfferID { get; set; }

        public ListingOffer ListingOffer { get; set; }
    }
}