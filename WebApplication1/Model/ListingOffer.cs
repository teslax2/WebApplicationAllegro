using System.Collections.Generic;

namespace WebApplication1.Model
{
    public class ListingOffer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SellerID { get; set; }
        public int PromotionID { get; set; }
        public int DeliveryID { get; set; }
        public int SellingModeID { get; set; }
        public int StockID { get; set; }
        public int VendorID { get; set; }
        public string Category { get; set; }
        public int PublicationID { get; set; }

        public OfferSeller Seller { get; set; }
        public OfferPromotion Promotion { get; set; }
        public OfferDelivery Delivery { get; set; }
        public ICollection<OfferImages> Images { get; set; }
        public OfferSellingMode SellingMode { get; set; }
        public OfferStock Stock { get; set; }
        public OfferVendor Vendor { get; set; }
    }
}