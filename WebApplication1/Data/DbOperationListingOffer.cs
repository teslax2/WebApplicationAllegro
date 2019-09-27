using System;
using System.Collections.Generic;
using System.Globalization;
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
            if (items is ApiModel.ListingResponseOffers listingOffer)
            {
                var itemsToAdd = GetOffers(listingOffer);
                _context.ListingOffer.AddRange(itemsToAdd);
                var rows = _context.SaveChanges();
                return rows;
            }
            return 0;
        }

        public int AddOrUpdate<T>(T items)
        {
            if (items is ApiModel.ListingResponseOffers listingOffer)
            {
                var itemsToAdd = GetOffers(listingOffer);
                foreach (var item in itemsToAdd)
                {
                    if (_context.ListingOffer.Any(p => p.ID == item.ID))
                        _context.Update(item);
                    else
                        _context.Add(item);
                }
                var rows = _context.SaveChanges();
                return rows;
            }
            return 0;
        }

        private List<Model.ListingOffer> GetOffers(ApiModel.ListingResponseOffers listingOffer)
        {
            var itemsToAdd = new List<Model.ListingOffer>();
                foreach (var item in listingOffer.Promoted)
                {
                    var images = item.Images.Select(p => new Model.OfferImages() { Url = p.Url }).ToList();
                    itemsToAdd.Add(new Model.ListingOffer()
                    {
                        ID = item.Id,
                        Category = item.Category.Id,
                        DeliveryCost = double.Parse(item.Delivery.LowestPrice.Amount,CultureInfo.InvariantCulture),
                        Name = item.Name,
                        SellerID = item.Seller.Id,
                        Price = double.Parse(item.SellingMode.Price.Amount, CultureInfo.InvariantCulture),
                        Stock = item.Stock.Available.Value,
                        SellingMode = item.SellingMode.Format.ToString(),
                        Images = images
                    });
                }
            return itemsToAdd;
        }
    }
}
