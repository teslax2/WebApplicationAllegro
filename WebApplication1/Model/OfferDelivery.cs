namespace WebApplication1.Model
{
    public class OfferDelivery
    {
        public int ID { get; set; }
        public bool? AvailableForFree { get; set; }
        public int LowestPriceID { get; set; }

        public OfferLowestPrice LowestPrice { get; set; }
    }
}