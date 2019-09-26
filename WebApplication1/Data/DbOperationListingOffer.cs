using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbOperationListingOffer : IDbOperations
    {
        private WebApplication1Context _context;

        public DbOperationListingOffer(WebApplication1Context context)
        {
            _context = context;
        }

        public int Add<T>(T items)
        {
            var itemsToAdd = new List<Model.ListingOffer>();
            if (items is ApiModel.ListingResponseOffers listingOffer)
            {
                foreach (var item in listingOffer.Promoted)
                {
                    var images = item.Images.Select(p => new Model.OfferImages() { Url = p.Url }).ToList();
                    itemsToAdd.Add(new Model.ListingOffer()
                    {
                        Category = item.Category.Id,
                        DeliveryCost = 11.2,//double.Parse(item.Delivery.LowestPrice.Amount),
                        Name = item.Name,
                        SellerID = item.Seller.Id,
                        Price = 123.2,//double.Parse(item.SellingMode.Price.Amount),
                        Stock = item.Stock.Available.Value,
                        SellingMode = item.SellingMode.Format.ToString(),
                        Images = images
                    });
                }
            }
            _context.ListingOffer.AddRange(itemsToAdd);
            var rows = _context.SaveChanges();
            return rows;
        }
    }
}
